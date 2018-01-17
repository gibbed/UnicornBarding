/* Copyright (c) 2018 Rick (rick 'at' gibbed 'dot' us)
 *
 * This software is provided 'as-is', without any express or implied
 * warranty. In no event will the authors be held liable for any damages
 * arising from the use of this software.
 *
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 *
 * 1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would
 *    be appreciated but is not required.
 *
 * 2. Altered source versions must be plainly marked as such, and must not
 *    be misrepresented as being the original software.
 *
 * 3. This notice may not be removed or altered from any source
 *    distribution.
 */
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Unicorn
{
    public abstract class BaseEmulator<TType> : IMemoryManager, IDisposable
        where TType : BaseEmulator<TType>
    {
        #region Fields
        private readonly IntPtr _Handle;
        private readonly Architecture _Architecture;
        private readonly Mode _Mode;
        private readonly List<Hook> _Hooks;
        private readonly Memory _Memory;
        private bool _IsDisposed;
        #endregion

        protected BaseEmulator(Architecture architecture, Mode mode)
        {
            IntPtr handle;
            CheckSuccess(Native.uc_open(architecture, mode, out handle));
            this._Handle = handle;
            this._Architecture = architecture;
            this._Mode = mode;
            this._Hooks = new List<Hook>();
            this._Memory = new Memory(this);
        }

        ~BaseEmulator()
        {
            this.Dispose(false);
        }

        #region Properties
        protected IntPtr Handle
        {
            get { return this._Handle; }
        }

        public Architecture Architecture
        {
            get { return this._Architecture; }
        }

        public Mode Mode
        {
            get { return this._Mode; }
        }

        public int PageSize
        {
            get
            {
                this.CheckDisposed();
                UIntPtr value;
                CheckSuccess(Native.uc_query(this._Handle, QueryType.PageSize, out value));
                return (int)value.ToUInt32();
            }
        }

        public Memory Memory
        {
            get { return this._Memory; }
        }
        #endregion

        internal Hook AddHook(HookType type, Delegate callback, ulong address, ulong end)
        {
            var pointer = Marshal.GetFunctionPointerForDelegate(callback);
            UIntPtr hookHandle;
            CheckSuccess(Native.uc_hook_add(
                this._Handle,
                out hookHandle,
                type,
                pointer,
                IntPtr.Zero,
                address,
                end));
            var hook = new Hook(hookHandle, callback);
            this._Hooks.Add(hook);
            return hook;
        }

        internal Hook AddHook(int instruction, Delegate callback, ulong address, ulong end)
        {
            this.CheckDisposed();
            var pointer = Marshal.GetFunctionPointerForDelegate(callback);
            UIntPtr hookHandle;
            CheckSuccess(Native.uc_hook_add(
                this._Handle,
                out hookHandle,
                HookType.Instruction,
                pointer,
                IntPtr.Zero,
                address,
                end,
                instruction));
            var hook = new Hook(hookHandle, callback);
            this._Hooks.Add(hook);
            return hook;
        }

        public delegate void CodeHook(TType emulator, ulong address, uint size);

        public Hook AddHook(CodeHookType type, CodeHook callback, ulong address = 1, ulong end = 0)
        {
            if (callback == null)
            {
                throw new ArgumentNullException("callback");
            }

            if ((type & ~CodeHookType.All) != 0)
            {
                throw new ArgumentOutOfRangeException("type", "unsupported code hook type");
            }

            var wrapper = new Native.uc_cb_hookcode_t(
                (uc, a, s, ud) => callback((TType)this, a, s));
            return this.AddHook((HookType)type, wrapper, address, end);
        }

        public delegate bool MemoryEventHook(TType emulator, MemoryType type, ulong address, int size, long value);

        public Hook AddHook(MemoryEventHookType type, MemoryEventHook callback, ulong address = 1, ulong end = 0)
        {
            if (callback == null)
            {
                throw new ArgumentNullException("callback");
            }

            if ((type & ~MemoryEventHookType.All) != 0)
            {
                throw new ArgumentOutOfRangeException("type", "unsupported memory event hook type");
            }

            var wrapper = new Native.uc_cb_eventmem_t(
                (uc, t, a, s, v, ud) => callback((TType)this, t, a, s, v));
            return this.AddHook((HookType)type, wrapper, address, end);
        }

        public void Start(ulong begin, ulong until, ulong timeout = 0)
        {
            CheckSuccess(Native.uc_emu_start(this._Handle, begin, until, timeout, UIntPtr.Zero));
        }

        public void Start(ulong begin, ulong until, ulong timeout, UIntPtr count)
        {
            CheckSuccess(Native.uc_emu_start(this._Handle, begin, until, timeout, count));
        }

        void IMemoryManager.Map(ulong address, int size, Protection protection)
        {
            CheckSuccess(Native.uc_mem_map(this._Handle, address, new UIntPtr((uint)size), protection));
        }

        void IMemoryManager.Unmap(ulong address, int size)
        {
            CheckSuccess(Native.uc_mem_unmap(this._Handle, address, new UIntPtr((uint)size)));
        }

        bool IMemoryManager.UnmapSafe(ulong address, int size)
        {
            return Native.uc_mem_unmap(this._Handle, address, new UIntPtr((uint)size)) == Error.OK;
        }

        void IMemoryManager.Protect(ulong address, int size, Protection protection)
        {
            CheckSuccess(Native.uc_mem_protect(this._Handle, address, new UIntPtr((uint)size), protection));
        }

        void IMemoryManager.Write(ulong address, byte[] buffer, int count)
        {
            CheckSuccess(Native.uc_mem_write(this._Handle, address, buffer, new UIntPtr((uint)count)));
        }

        void IMemoryManager.Read(ulong address, byte[] buffer, int count)
        {
            CheckSuccess(Native.uc_mem_read(this._Handle, address, buffer, new UIntPtr((uint)count)));
        }

        protected static void CheckSuccess(Error error)
        {
            if (error != Error.OK)
            {
                throw new UnicornException(error);
            }
        }

        protected void CheckDisposed()
        {
            if (this._IsDisposed == true)
            {
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (this._IsDisposed == true)
            {
                return;
            }

            if (this._Handle != IntPtr.Zero)
            {
                CheckSuccess(Native.uc_close(this._Handle));
            }

            this._IsDisposed = true;
        }
    }
}

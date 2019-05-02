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
        protected IntPtr Handle { get; private set; }
        public Architecture Architecture { get; private set; }
        public Mode Mode { get; private set; }
        public Memory Memory { get; private set; }

        private readonly List<Hook> _Hooks;
        private bool _IsDisposed;

        protected BaseEmulator(Architecture architecture, Mode mode)
        {
            CheckSuccess(Native.uc_open(architecture, mode, out var handle));
            this.Handle = handle;
            this.Architecture = architecture;
            this.Mode = mode;
            this._Hooks = new List<Hook>();
            this.Memory = new Memory(this);
        }

        ~BaseEmulator()
        {
            this.Dispose(false);
        }

        public int PageSize
        {
            get
            {
                this.CheckDisposed();
                CheckSuccess(Native.uc_query(this.Handle, QueryType.PageSize, out var value));
                return (int)value.ToUInt32();
            }
        }

        internal Hook AddHook(HookType type, Delegate callback, ulong address, ulong end)
        {
            var pointer = Marshal.GetFunctionPointerForDelegate(callback);
            CheckSuccess(Native.uc_hook_add(
                this.Handle,
                out var hookHandle,
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
            CheckSuccess(Native.uc_hook_add(
                this.Handle,
                out var hookHandle,
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
            CheckSuccess(Native.uc_emu_start(this.Handle, begin, until, timeout, UIntPtr.Zero));
        }

        public void Start(ulong begin, ulong until, ulong timeout, UIntPtr count)
        {
            CheckSuccess(Native.uc_emu_start(this.Handle, begin, until, timeout, count));
        }

        void IMemoryManager.Map(ulong address, int size, Protection protection)
        {
            CheckSuccess(Native.uc_mem_map(this.Handle, address, new UIntPtr((uint)size), protection));
        }

        void IMemoryManager.Unmap(ulong address, int size)
        {
            CheckSuccess(Native.uc_mem_unmap(this.Handle, address, new UIntPtr((uint)size)));
        }

        bool IMemoryManager.UnmapSafe(ulong address, int size)
        {
            return Native.uc_mem_unmap(this.Handle, address, new UIntPtr((uint)size)) == Error.OK;
        }

        void IMemoryManager.Protect(ulong address, int size, Protection protection)
        {
            CheckSuccess(Native.uc_mem_protect(this.Handle, address, new UIntPtr((uint)size), protection));
        }

        void IMemoryManager.Write(ulong address, byte[] buffer, int count)
        {
            CheckSuccess(Native.uc_mem_write(this.Handle, address, buffer, new UIntPtr((uint)count)));
        }

        void IMemoryManager.Read(ulong address, byte[] buffer, int count)
        {
            CheckSuccess(Native.uc_mem_read(this.Handle, address, buffer, new UIntPtr((uint)count)));
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

            if (this.Handle != IntPtr.Zero)
            {
                CheckSuccess(Native.uc_close(this.Handle));
            }

            this._IsDisposed = true;
        }
    }
}

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

namespace Unicorn.X86
{
    public abstract class Emulator<TType> : BaseEmulator<TType>, IRegisterTable
        where TType : Emulator<TType>
    {
        protected Emulator(Mode mode)
            : base(Architecture.X86, mode)
        {
        }

        public delegate uint InHook(TType emulator, uint port, int size);

        public Hook AddHook(InHook callback, ulong address = 0, ulong end = 0)
        {
            if (callback == null)
            {
                throw new ArgumentNullException("callback");
            }

            var wrapper = new Native.uc_cb_insn_in_t(
                (uc, p, s, ud) => callback((TType)this, p, s));
            return this.AddHook((int)Instruction.IN, wrapper, address, end);
        }

        public delegate void OutHook(TType emulator, uint port, int size, uint value);

        public Hook AddHook(OutHook callback, ulong address = 0, ulong end = 0)
        {
            if (callback == null)
            {
                throw new ArgumentNullException("callback");
            }

            var wrapper = new Native.uc_cb_insn_out_t(
                (uc, p, s, v, ud) => callback((TType)this, p, s, v));
            return this.AddHook((int)Instruction.OUT, wrapper, address, end);
        }

        public delegate void SyscallHook(TType emulator);

        public Hook AddHook(SyscallHook callback, ulong address = 0, ulong end = 0)
        {
            if (callback == null)
            {
                throw new ArgumentNullException("callback");
            }

            var wrapper = new Native.uc_cb_insn_syscall_t(
                (uc, ud) => callback((TType)this));
            return this.AddHook((int)Instruction.SYSCALL, wrapper, address, end);
        }

        void IRegisterTable.Read(Register register, out byte value)
        {
            ThrowOnDisposed(this);
            ThrowOnError(Native.uc_reg_read(this.Handle, (int)register, out value));
        }

        void IRegisterTable.Read(Register register, out ushort value)
        {
            ThrowOnDisposed(this);
            ThrowOnError(Native.uc_reg_read(this.Handle, (int)register, out value));
        }

        void IRegisterTable.Read(Register register, out uint value)
        {
            ThrowOnDisposed(this);
            ThrowOnError(Native.uc_reg_read(this.Handle, (int)register, out value));
        }

        void IRegisterTable.Read(Register register, out ulong value)
        {
            ThrowOnDisposed(this);
            ThrowOnError(Native.uc_reg_read(this.Handle, (int)register, out value));
        }

        void IRegisterTable.Read(Register register, out FpRegister value)
        {
            ThrowOnDisposed(this);
            ThrowOnError(Native.uc_reg_read(this.Handle, (int)register, out value));
        }

        void IRegisterTable.Read(Register register, out XmmRegister value)
        {
            ThrowOnDisposed(this);
            ThrowOnError(Native.uc_reg_read(this.Handle, (int)register, out value));
        }

        void IRegisterTable.Read(Register register, out YmmRegister value)
        {
            ThrowOnDisposed(this);
            ThrowOnError(Native.uc_reg_read(this.Handle, (int)register, out value));
        }

        void IRegisterTable.Read(Register register, out MmRegister value)
        {
            ThrowOnDisposed(this);
            ThrowOnError(Native.uc_reg_read(this.Handle, (int)register, out value));
        }

        void IRegisterTable.Read(Register register, out MsRegister value)
        {
            ThrowOnDisposed(this);
            ThrowOnError(Native.uc_reg_read(this.Handle, (int)register, out value));
        }

        void IRegisterTable.Write(Register register, ref byte value)
        {
            ThrowOnDisposed(this);
            ThrowOnError(Native.uc_reg_write(this.Handle, (int)register, ref value));
        }

        void IRegisterTable.Write(Register register, ref ushort value)
        {
            ThrowOnDisposed(this);
            ThrowOnError(Native.uc_reg_write(this.Handle, (int)register, ref value));
        }

        void IRegisterTable.Write(Register register, ref uint value)
        {
            ThrowOnDisposed(this);
            ThrowOnError(Native.uc_reg_write(this.Handle, (int)register, ref value));
        }

        void IRegisterTable.Write(Register register, ref ulong value)
        {
            ThrowOnDisposed(this);
            ThrowOnError(Native.uc_reg_write(this.Handle, (int)register, ref value));
        }

        void IRegisterTable.Write(Register register, ref FpRegister value)
        {
            ThrowOnDisposed(this);
            ThrowOnError(Native.uc_reg_write(this.Handle, (int)register, ref value));
        }

        void IRegisterTable.Write(Register register, ref XmmRegister value)
        {
            ThrowOnDisposed(this);
            ThrowOnError(Native.uc_reg_write(this.Handle, (int)register, ref value));
        }

        void IRegisterTable.Write(Register register, ref YmmRegister value)
        {
            ThrowOnDisposed(this);
            ThrowOnError(Native.uc_reg_write(this.Handle, (int)register, ref value));
        }

        void IRegisterTable.Write(Register register, ref MmRegister value)
        {
            ThrowOnDisposed(this);
            ThrowOnError(Native.uc_reg_write(this.Handle, (int)register, ref value));
        }

        void IRegisterTable.Write(Register register, ref MsRegister value)
        {
            ThrowOnDisposed(this);
            ThrowOnError(Native.uc_reg_write(this.Handle, (int)register, ref value));
        }
    }
}

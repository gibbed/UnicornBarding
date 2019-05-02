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
namespace Unicorn.SPARC
{
    public class Emulator : BaseEmulator<Emulator>, IRegisterTable
    {
        public Emulator(Mode mode)
            : base(Architecture.SPARC, mode)
        {
        }

        void IRegisterTable.Read(Register register, out byte value)
        {
            this.CheckDisposed();
            CheckSuccess(Native.uc_reg_read(this.Handle, (int)register, out value));
        }

        void IRegisterTable.Read(Register register, out ushort value)
        {
            this.CheckDisposed();
            CheckSuccess(Native.uc_reg_read(this.Handle, (int)register, out value));
        }

        void IRegisterTable.Read(Register register, out uint value)
        {
            this.CheckDisposed();
            CheckSuccess(Native.uc_reg_read(this.Handle, (int)register, out value));
        }

        void IRegisterTable.Read(Register register, out ulong value)
        {
            this.CheckDisposed();
            CheckSuccess(Native.uc_reg_read(this.Handle, (int)register, out value));
        }

        void IRegisterTable.Write(Register register, ref byte value)
        {
            this.CheckDisposed();
            CheckSuccess(Native.uc_reg_write(this.Handle, (int)register, ref value));
        }

        void IRegisterTable.Write(Register register, ref ushort value)
        {
            this.CheckDisposed();
            CheckSuccess(Native.uc_reg_write(this.Handle, (int)register, ref value));
        }

        void IRegisterTable.Write(Register register, ref uint value)
        {
            this.CheckDisposed();
            CheckSuccess(Native.uc_reg_write(this.Handle, (int)register, ref value));
        }

        void IRegisterTable.Write(Register register, ref ulong value)
        {
            this.CheckDisposed();
            CheckSuccess(Native.uc_reg_write(this.Handle, (int)register, ref value));
        }
    }
}

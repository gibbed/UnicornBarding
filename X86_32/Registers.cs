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
namespace Unicorn.X86_32
{
    public class Registers : X86.Registers
    {
        internal Registers(X86.IRegisterTable emulator)
            : base(emulator)
        {
        }

        public uint CR0
        {
            get
            {
                this.Table.Read(X86.Register.CR0, out uint value);
                return value;
            }

            set { this.Table.Write(X86.Register.CR0, ref value); }
        }

        public uint CR1
        {
            get
            {
                this.Table.Read(X86.Register.CR1, out uint value);
                return value;
            }

            set { this.Table.Write(X86.Register.CR1, ref value); }
        }

        public uint CR2
        {
            get
            {
                this.Table.Read(X86.Register.CR2, out uint value);
                return value;
            }

            set { this.Table.Write(X86.Register.CR2, ref value); }
        }

        public uint CR3
        {
            get
            {
                this.Table.Read(X86.Register.CR3, out uint value);
                return value;
            }

            set { this.Table.Write(X86.Register.CR3, ref value); }
        }

        public uint CR4
        {
            get
            {
                this.Table.Read(X86.Register.CR4, out uint value);
                return value;
            }

            set { this.Table.Write(X86.Register.CR4, ref value); }
        }

        public uint DR0
        {
            get
            {
                this.Table.Read(X86.Register.DR0, out uint value);
                return value;
            }

            set { this.Table.Write(X86.Register.DR0, ref value); }
        }

        public uint DR1
        {
            get
            {
                this.Table.Read(X86.Register.DR1, out uint value);
                return value;
            }

            set { this.Table.Write(X86.Register.DR1, ref value); }
        }

        public uint DR2
        {
            get
            {
                this.Table.Read(X86.Register.DR2, out uint value);
                return value;
            }

            set { this.Table.Write(X86.Register.DR2, ref value); }
        }

        public uint DR3
        {
            get
            {
                this.Table.Read(X86.Register.DR3, out uint value);
                return value;
            }

            set { this.Table.Write(X86.Register.DR3, ref value); }
        }

        public uint DR4
        {
            get
            {
                this.Table.Read(X86.Register.DR4, out uint value);
                return value;
            }

            set { this.Table.Write(X86.Register.DR4, ref value); }
        }

        public uint DR5
        {
            get
            {
                this.Table.Read(X86.Register.DR5, out uint value);
                return value;
            }

            set { this.Table.Write(X86.Register.DR5, ref value); }
        }

        public uint DR6
        {
            get
            {
                this.Table.Read(X86.Register.DR6, out uint value);
                return value;
            }

            set { this.Table.Write(X86.Register.DR6, ref value); }
        }

        public uint DR7
        {
            get
            {
                this.Table.Read(X86.Register.DR7, out uint value);
                return value;
            }

            set { this.Table.Write(X86.Register.DR7, ref value); }
        }
    }
}

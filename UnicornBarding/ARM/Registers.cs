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

namespace Unicorn.ARM
{
    public class Registers
    {
        internal readonly IRegisterTable Table;

        internal Registers(IRegisterTable table)
        {
            this.Table = table ?? throw new ArgumentNullException("table");
        }

        public uint APSR
        {
            get
            {
                this.Table.Read(Register.APSR, out uint value);
                return value;
            }

            set { this.Table.Write(Register.APSR, ref value); }
        }

        public uint CPSR
        {
            get
            {
                this.Table.Read(Register.CPSR, out uint value);
                return value;
            }

            set { this.Table.Write(Register.CPSR, ref value); }
        }

        public uint FPEXC
        {
            get
            {
                this.Table.Read(Register.FPEXC, out uint value);
                return value;
            }

            set { this.Table.Write(Register.FPEXC, ref value); }
        }

        public uint LR
        {
            get
            {
                this.Table.Read(Register.LR, out uint value);
                return value;
            }

            set { this.Table.Write(Register.LR, ref value); }
        }

        public uint PC
        {
            get
            {
                this.Table.Read(Register.PC, out uint value);
                return value;
            }

            set { this.Table.Write(Register.PC, ref value); }
        }

        public uint SP
        {
            get
            {
                this.Table.Read(Register.SP, out uint value);
                return value;
            }

            set { this.Table.Write(Register.SP, ref value); }
        }

        public double D0
        {
            get
            {
                this.Table.Read(Register.D0, out double value);
                return value;
            }

            set { this.Table.Write(Register.D0, ref value); }
        }

        public double D1
        {
            get
            {
                this.Table.Read(Register.D1, out double value);
                return value;
            }

            set { this.Table.Write(Register.D1, ref value); }
        }

        public double D2
        {
            get
            {
                this.Table.Read(Register.D2, out double value);
                return value;
            }

            set { this.Table.Write(Register.D2, ref value); }
        }

        public double D3
        {
            get
            {
                this.Table.Read(Register.D3, out double value);
                return value;
            }

            set { this.Table.Write(Register.D3, ref value); }
        }

        public double D4
        {
            get
            {
                this.Table.Read(Register.D4, out double value);
                return value;
            }

            set { this.Table.Write(Register.D4, ref value); }
        }

        public double D5
        {
            get
            {
                this.Table.Read(Register.D5, out double value);
                return value;
            }

            set { this.Table.Write(Register.D5, ref value); }
        }

        public double D6
        {
            get
            {
                this.Table.Read(Register.D6, out double value);
                return value;
            }

            set { this.Table.Write(Register.D6, ref value); }
        }

        public double D7
        {
            get
            {
                this.Table.Read(Register.D7, out double value);
                return value;
            }

            set { this.Table.Write(Register.D7, ref value); }
        }

        public double D8
        {
            get
            {
                this.Table.Read(Register.D8, out double value);
                return value;
            }

            set { this.Table.Write(Register.D8, ref value); }
        }

        public double D9
        {
            get
            {
                this.Table.Read(Register.D9, out double value);
                return value;
            }

            set { this.Table.Write(Register.D9, ref value); }
        }

        public double D10
        {
            get
            {
                this.Table.Read(Register.D10, out double value);
                return value;
            }

            set { this.Table.Write(Register.D10, ref value); }
        }

        public double D11
        {
            get
            {
                this.Table.Read(Register.D11, out double value);
                return value;
            }

            set { this.Table.Write(Register.D11, ref value); }
        }

        public double D12
        {
            get
            {
                this.Table.Read(Register.D12, out double value);
                return value;
            }

            set { this.Table.Write(Register.D12, ref value); }
        }

        public double D13
        {
            get
            {
                this.Table.Read(Register.D13, out double value);
                return value;
            }

            set { this.Table.Write(Register.D13, ref value); }
        }

        public double D14
        {
            get
            {
                this.Table.Read(Register.D14, out double value);
                return value;
            }

            set { this.Table.Write(Register.D14, ref value); }
        }

        public double D15
        {
            get
            {
                this.Table.Read(Register.D15, out double value);
                return value;
            }

            set { this.Table.Write(Register.D15, ref value); }
        }

        public double D16
        {
            get
            {
                this.Table.Read(Register.D16, out double value);
                return value;
            }

            set { this.Table.Write(Register.D16, ref value); }
        }

        public double D17
        {
            get
            {
                this.Table.Read(Register.D17, out double value);
                return value;
            }

            set { this.Table.Write(Register.D17, ref value); }
        }

        public double D18
        {
            get
            {
                this.Table.Read(Register.D18, out double value);
                return value;
            }

            set { this.Table.Write(Register.D18, ref value); }
        }

        public double D19
        {
            get
            {
                this.Table.Read(Register.D19, out double value);
                return value;
            }

            set { this.Table.Write(Register.D19, ref value); }
        }

        public double D20
        {
            get
            {
                this.Table.Read(Register.D20, out double value);
                return value;
            }

            set { this.Table.Write(Register.D20, ref value); }
        }

        public double D21
        {
            get
            {
                this.Table.Read(Register.D21, out double value);
                return value;
            }

            set { this.Table.Write(Register.D21, ref value); }
        }

        public double D22
        {
            get
            {
                this.Table.Read(Register.D22, out double value);
                return value;
            }

            set { this.Table.Write(Register.D22, ref value); }
        }

        public double D23
        {
            get
            {
                this.Table.Read(Register.D23, out double value);
                return value;
            }

            set { this.Table.Write(Register.D23, ref value); }
        }

        public double D24
        {
            get
            {
                this.Table.Read(Register.D24, out double value);
                return value;
            }

            set { this.Table.Write(Register.D24, ref value); }
        }

        public double D25
        {
            get
            {
                this.Table.Read(Register.D25, out double value);
                return value;
            }

            set { this.Table.Write(Register.D25, ref value); }
        }

        public double D26
        {
            get
            {
                this.Table.Read(Register.D26, out double value);
                return value;
            }

            set { this.Table.Write(Register.D26, ref value); }
        }

        public double D27
        {
            get
            {
                this.Table.Read(Register.D27, out double value);
                return value;
            }

            set { this.Table.Write(Register.D27, ref value); }
        }

        public double D28
        {
            get
            {
                this.Table.Read(Register.D28, out double value);
                return value;
            }

            set { this.Table.Write(Register.D28, ref value); }
        }

        public double D29
        {
            get
            {
                this.Table.Read(Register.D29, out double value);
                return value;
            }

            set { this.Table.Write(Register.D29, ref value); }
        }

        public double D30
        {
            get
            {
                this.Table.Read(Register.D30, out double value);
                return value;
            }

            set { this.Table.Write(Register.D30, ref value); }
        }

        public double D31
        {
            get
            {
                this.Table.Read(Register.D31, out double value);
                return value;
            }

            set { this.Table.Write(Register.D31, ref value); }
        }

        public uint R0
        {
            get
            {
                this.Table.Read(Register.R0, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R0, ref value); }
        }

        public uint R1
        {
            get
            {
                this.Table.Read(Register.R1, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R1, ref value); }
        }

        public uint R2
        {
            get
            {
                this.Table.Read(Register.R2, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R2, ref value); }
        }

        public uint R3
        {
            get
            {
                this.Table.Read(Register.R3, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R3, ref value); }
        }

        public uint R4
        {
            get
            {
                this.Table.Read(Register.R4, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R4, ref value); }
        }

        public uint R5
        {
            get
            {
                this.Table.Read(Register.R5, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R5, ref value); }
        }

        public uint R6
        {
            get
            {
                this.Table.Read(Register.R6, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R6, ref value); }
        }

        public uint R7
        {
            get
            {
                this.Table.Read(Register.R7, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R7, ref value); }
        }

        public uint R8
        {
            get
            {
                this.Table.Read(Register.R8, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R8, ref value); }
        }

        public uint R9
        {
            get
            {
                this.Table.Read(Register.R9, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R9, ref value); }
        }

        public uint R10
        {
            get
            {
                this.Table.Read(Register.R10, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R10, ref value); }
        }

        public uint R11
        {
            get
            {
                this.Table.Read(Register.R11, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R11, ref value); }
        }

        public uint R12
        {
            get
            {
                this.Table.Read(Register.R12, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R12, ref value); }
        }

        public uint C1_C0_2
        {
            get
            {
                this.Table.Read(Register.C1_C0_2, out uint value);
                return value;
            }

            set { this.Table.Write(Register.C1_C0_2, ref value); }
        }

        public uint C13_C0_2
        {
            get
            {
                this.Table.Read(Register.C13_C0_2, out uint value);
                return value;
            }

            set { this.Table.Write(Register.C13_C0_2, ref value); }
        }

        public uint C13_C0_3
        {
            get
            {
                this.Table.Read(Register.C13_C0_3, out uint value);
                return value;
            }

            set { this.Table.Write(Register.C13_C0_3, ref value); }
        }

        public uint R13
        {
            get
            {
                this.Table.Read(Register.R13, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R13, ref value); }
        }

        public uint R14
        {
            get
            {
                this.Table.Read(Register.R14, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R14, ref value); }
        }

        public uint R15
        {
            get
            {
                this.Table.Read(Register.R15, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R15, ref value); }
        }
    }
}

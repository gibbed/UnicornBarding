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
    public class Registers
    {
        internal readonly IRegisterTable Table;

        internal Registers(IRegisterTable table)
        {
            if (table == null)
            {
                throw new ArgumentNullException("table");
            }

            this.Table = table;
        }

        // ReSharper disable InconsistentNaming
        public byte AH
        {
            get
            {
                byte value;
                this.Table.Read(Register.AH, out value);
                return value;
            }

            set { this.Table.Write(Register.AH, ref value); }
        }

        public byte AL
        {
            get
            {
                byte value;
                this.Table.Read(Register.AL, out value);
                return value;
            }

            set { this.Table.Write(Register.AL, ref value); }
        }

        public ushort AX
        {
            get
            {
                ushort value;
                this.Table.Read(Register.AX, out value);
                return value;
            }

            set { this.Table.Write(Register.AX, ref value); }
        }

        public byte BH
        {
            get
            {
                byte value;
                this.Table.Read(Register.BH, out value);
                return value;
            }

            set { this.Table.Write(Register.BH, ref value); }
        }

        public byte BL
        {
            get
            {
                byte value;
                this.Table.Read(Register.BL, out value);
                return value;
            }

            set { this.Table.Write(Register.BL, ref value); }
        }

        public ushort BP
        {
            get
            {
                ushort value;
                this.Table.Read(Register.BP, out value);
                return value;
            }

            set { this.Table.Write(Register.BP, ref value); }
        }

        public byte BPL
        {
            get
            {
                byte value;
                this.Table.Read(Register.BPL, out value);
                return value;
            }

            set { this.Table.Write(Register.BPL, ref value); }
        }

        public ushort BX
        {
            get
            {
                ushort value;
                this.Table.Read(Register.BX, out value);
                return value;
            }

            set { this.Table.Write(Register.BX, ref value); }
        }

        public byte CH
        {
            get
            {
                byte value;
                this.Table.Read(Register.CH, out value);
                return value;
            }

            set { this.Table.Write(Register.CH, ref value); }
        }

        public byte CL
        {
            get
            {
                byte value;
                this.Table.Read(Register.CL, out value);
                return value;
            }

            set { this.Table.Write(Register.CL, ref value); }
        }

        public ushort CS
        {
            get
            {
                ushort value;
                this.Table.Read(Register.CS, out value);
                return value;
            }

            set { this.Table.Write(Register.CS, ref value); }
        }

        public ushort CX
        {
            get
            {
                ushort value;
                this.Table.Read(Register.CX, out value);
                return value;
            }

            set { this.Table.Write(Register.CX, ref value); }
        }

        public byte DH
        {
            get
            {
                byte value;
                this.Table.Read(Register.DH, out value);
                return value;
            }

            set { this.Table.Write(Register.DH, ref value); }
        }

        public ushort DI
        {
            get
            {
                ushort value;
                this.Table.Read(Register.DI, out value);
                return value;
            }

            set { this.Table.Write(Register.DI, ref value); }
        }

        public ushort DIL
        {
            get
            {
                ushort value;
                this.Table.Read(Register.DIL, out value);
                return value;
            }

            set { this.Table.Write(Register.DIL, ref value); }
        }

        public ushort DL
        {
            get
            {
                ushort value;
                this.Table.Read(Register.DL, out value);
                return value;
            }

            set { this.Table.Write(Register.DL, ref value); }
        }

        public ushort DS
        {
            get
            {
                ushort value;
                this.Table.Read(Register.DS, out value);
                return value;
            }

            set { this.Table.Write(Register.DS, ref value); }
        }

        public ushort DX
        {
            get
            {
                ushort value;
                this.Table.Read(Register.DX, out value);
                return value;
            }

            set { this.Table.Write(Register.DX, ref value); }
        }

        public uint EAX
        {
            get
            {
                uint value;
                this.Table.Read(Register.EAX, out value);
                return value;
            }

            set { this.Table.Write(Register.EAX, ref value); }
        }

        public uint EBP
        {
            get
            {
                uint value;
                this.Table.Read(Register.EBP, out value);
                return value;
            }

            set { this.Table.Write(Register.EBP, ref value); }
        }

        public uint EBX
        {
            get
            {
                uint value;
                this.Table.Read(Register.EBX, out value);
                return value;
            }

            set { this.Table.Write(Register.EBX, ref value); }
        }

        public uint ECX
        {
            get
            {
                uint value;
                this.Table.Read(Register.ECX, out value);
                return value;
            }

            set { this.Table.Write(Register.ECX, ref value); }
        }

        public uint EDI
        {
            get
            {
                uint value;
                this.Table.Read(Register.EDI, out value);
                return value;
            }

            set { this.Table.Write(Register.EDI, ref value); }
        }

        public uint EDX
        {
            get
            {
                uint value;
                this.Table.Read(Register.EDX, out value);
                return value;
            }

            set { this.Table.Write(Register.EDX, ref value); }
        }

        public uint EFLAGS
        {
            get
            {
                uint value;
                this.Table.Read(Register.EFLAGS, out value);
                return value;
            }

            set { this.Table.Write(Register.EFLAGS, ref value); }
        }

        public uint EIP
        {
            get
            {
                uint value;
                this.Table.Read(Register.EIP, out value);
                return value;
            }

            set { this.Table.Write(Register.EIP, ref value); }
        }

        public ushort ES
        {
            get
            {
                ushort value;
                this.Table.Read(Register.ES, out value);
                return value;
            }

            set { this.Table.Write(Register.ES, ref value); }
        }

        public uint ESI
        {
            get
            {
                uint value;
                this.Table.Read(Register.ESI, out value);
                return value;
            }

            set { this.Table.Write(Register.ESI, ref value); }
        }

        public uint ESP
        {
            get
            {
                uint value;
                this.Table.Read(Register.ESP, out value);
                return value;
            }

            set { this.Table.Write(Register.ESP, ref value); }
        }

        public ushort FPSW
        {
            get
            {
                ushort value;
                this.Table.Read(Register.FPSW, out value);
                return value;
            }

            set { this.Table.Write(Register.FPSW, ref value); }
        }

        public ushort FS
        {
            get
            {
                ushort value;
                this.Table.Read(Register.FS, out value);
                return value;
            }

            set { this.Table.Write(Register.FS, ref value); }
        }

        public ushort GS
        {
            get
            {
                ushort value;
                this.Table.Read(Register.GS, out value);
                return value;
            }

            set { this.Table.Write(Register.GS, ref value); }
        }

        public ushort IP
        {
            get
            {
                ushort value;
                this.Table.Read(Register.IP, out value);
                return value;
            }

            set { this.Table.Write(Register.IP, ref value); }
        }

        public ulong RAX
        {
            get
            {
                ulong value;
                this.Table.Read(Register.RAX, out value);
                return value;
            }

            set { this.Table.Write(Register.RAX, ref value); }
        }

        public ulong RBP
        {
            get
            {
                ulong value;
                this.Table.Read(Register.RBP, out value);
                return value;
            }

            set { this.Table.Write(Register.RBP, ref value); }
        }

        public ulong RBX
        {
            get
            {
                ulong value;
                this.Table.Read(Register.RBX, out value);
                return value;
            }

            set { this.Table.Write(Register.RBX, ref value); }
        }

        public ulong RCX
        {
            get
            {
                ulong value;
                this.Table.Read(Register.RCX, out value);
                return value;
            }

            set { this.Table.Write(Register.RCX, ref value); }
        }

        public ulong RDI
        {
            get
            {
                ulong value;
                this.Table.Read(Register.RDI, out value);
                return value;
            }

            set { this.Table.Write(Register.RDI, ref value); }
        }

        public ulong RDX
        {
            get
            {
                ulong value;
                this.Table.Read(Register.RDX, out value);
                return value;
            }

            set { this.Table.Write(Register.RDX, ref value); }
        }

        public ulong RIP
        {
            get
            {
                ulong value;
                this.Table.Read(Register.RIP, out value);
                return value;
            }

            set { this.Table.Write(Register.RIP, ref value); }
        }

        public ulong RSI
        {
            get
            {
                ulong value;
                this.Table.Read(Register.RSI, out value);
                return value;
            }

            set { this.Table.Write(Register.RSI, ref value); }
        }

        public ulong RSP
        {
            get
            {
                ulong value;
                this.Table.Read(Register.RSP, out value);
                return value;
            }

            set { this.Table.Write(Register.RSP, ref value); }
        }

        public ushort SI
        {
            get
            {
                ushort value;
                this.Table.Read(Register.SI, out value);
                return value;
            }

            set { this.Table.Write(Register.SI, ref value); }
        }

        public byte SIL
        {
            get
            {
                byte value;
                this.Table.Read(Register.SIL, out value);
                return value;
            }

            set { this.Table.Write(Register.SIL, ref value); }
        }

        public ushort SP
        {
            get
            {
                ushort value;
                this.Table.Read(Register.SP, out value);
                return value;
            }

            set { this.Table.Write(Register.SP, ref value); }
        }

        public byte SPL
        {
            get
            {
                byte value;
                this.Table.Read(Register.SPL, out value);
                return value;
            }

            set { this.Table.Write(Register.SPL, ref value); }
        }

        public ushort SS
        {
            get
            {
                ushort value;
                this.Table.Read(Register.SS, out value);
                return value;
            }

            set { this.Table.Write(Register.SS, ref value); }
        }

        public FpRegister FP0
        {
            get
            {
                FpRegister value;
                this.Table.Read(Register.FP0, out value);
                return value;
            }

            set { this.Table.Write(Register.FP0, ref value); }
        }

        public FpRegister FP1
        {
            get
            {
                FpRegister value;
                this.Table.Read(Register.FP1, out value);
                return value;
            }

            set { this.Table.Write(Register.FP1, ref value); }
        }

        public FpRegister FP2
        {
            get
            {
                FpRegister value;
                this.Table.Read(Register.FP2, out value);
                return value;
            }

            set { this.Table.Write(Register.FP2, ref value); }
        }

        public FpRegister FP3
        {
            get
            {
                FpRegister value;
                this.Table.Read(Register.FP3, out value);
                return value;
            }

            set { this.Table.Write(Register.FP3, ref value); }
        }

        public FpRegister FP4
        {
            get
            {
                FpRegister value;
                this.Table.Read(Register.FP4, out value);
                return value;
            }

            set { this.Table.Write(Register.FP4, ref value); }
        }

        public FpRegister FP5
        {
            get
            {
                FpRegister value;
                this.Table.Read(Register.FP5, out value);
                return value;
            }

            set { this.Table.Write(Register.FP5, ref value); }
        }

        public FpRegister FP6
        {
            get
            {
                FpRegister value;
                this.Table.Read(Register.FP6, out value);
                return value;
            }

            set { this.Table.Write(Register.FP6, ref value); }
        }

        public FpRegister FP7
        {
            get
            {
                FpRegister value;
                this.Table.Read(Register.FP7, out value);
                return value;
            }

            set { this.Table.Write(Register.FP7, ref value); }
        }

        public ulong R8
        {
            get
            {
                ulong value;
                this.Table.Read(Register.R8, out value);
                return value;
            }

            set { this.Table.Write(Register.R8, ref value); }
        }

        public ulong R9
        {
            get
            {
                ulong value;
                this.Table.Read(Register.R9, out value);
                return value;
            }

            set { this.Table.Write(Register.R9, ref value); }
        }

        public ulong R10
        {
            get
            {
                ulong value;
                this.Table.Read(Register.R10, out value);
                return value;
            }

            set { this.Table.Write(Register.R10, ref value); }
        }

        public ulong R11
        {
            get
            {
                ulong value;
                this.Table.Read(Register.R11, out value);
                return value;
            }

            set { this.Table.Write(Register.R11, ref value); }
        }

        public ulong R12
        {
            get
            {
                ulong value;
                this.Table.Read(Register.R12, out value);
                return value;
            }

            set { this.Table.Write(Register.R12, ref value); }
        }

        public ulong R13
        {
            get
            {
                ulong value;
                this.Table.Read(Register.R13, out value);
                return value;
            }

            set { this.Table.Write(Register.R13, ref value); }
        }

        public ulong R14
        {
            get
            {
                ulong value;
                this.Table.Read(Register.R14, out value);
                return value;
            }

            set { this.Table.Write(Register.R14, ref value); }
        }

        public ulong R15
        {
            get
            {
                ulong value;
                this.Table.Read(Register.R15, out value);
                return value;
            }

            set { this.Table.Write(Register.R15, ref value); }
        }

        public XmmRegister XMM0
        {
            get
            {
                XmmRegister value;
                this.Table.Read(Register.XMM0, out value);
                return value;
            }

            set { this.Table.Write(Register.XMM0, ref value); }
        }

        public XmmRegister XMM1
        {
            get
            {
                XmmRegister value;
                this.Table.Read(Register.XMM1, out value);
                return value;
            }

            set { this.Table.Write(Register.XMM1, ref value); }
        }

        public XmmRegister XMM2
        {
            get
            {
                XmmRegister value;
                this.Table.Read(Register.XMM2, out value);
                return value;
            }

            set { this.Table.Write(Register.XMM2, ref value); }
        }

        public XmmRegister XMM3
        {
            get
            {
                XmmRegister value;
                this.Table.Read(Register.XMM3, out value);
                return value;
            }

            set { this.Table.Write(Register.XMM3, ref value); }
        }

        public XmmRegister XMM4
        {
            get
            {
                XmmRegister value;
                this.Table.Read(Register.XMM4, out value);
                return value;
            }

            set { this.Table.Write(Register.XMM4, ref value); }
        }

        public XmmRegister XMM5
        {
            get
            {
                XmmRegister value;
                this.Table.Read(Register.XMM5, out value);
                return value;
            }

            set { this.Table.Write(Register.XMM5, ref value); }
        }

        public XmmRegister XMM6
        {
            get
            {
                XmmRegister value;
                this.Table.Read(Register.XMM6, out value);
                return value;
            }

            set { this.Table.Write(Register.XMM6, ref value); }
        }

        public XmmRegister XMM7
        {
            get
            {
                XmmRegister value;
                this.Table.Read(Register.XMM7, out value);
                return value;
            }

            set { this.Table.Write(Register.XMM7, ref value); }
        }

        public YmmRegister YMM0
        {
            get
            {
                YmmRegister value;
                this.Table.Read(Register.YMM0, out value);
                return value;
            }

            set { this.Table.Write(Register.YMM0, ref value); }
        }

        public YmmRegister YMM1
        {
            get
            {
                YmmRegister value;
                this.Table.Read(Register.YMM1, out value);
                return value;
            }

            set { this.Table.Write(Register.YMM1, ref value); }
        }

        public YmmRegister YMM2
        {
            get
            {
                YmmRegister value;
                this.Table.Read(Register.YMM2, out value);
                return value;
            }

            set { this.Table.Write(Register.YMM2, ref value); }
        }

        public YmmRegister YMM3
        {
            get
            {
                YmmRegister value;
                this.Table.Read(Register.YMM3, out value);
                return value;
            }

            set { this.Table.Write(Register.YMM3, ref value); }
        }

        public YmmRegister YMM4
        {
            get
            {
                YmmRegister value;
                this.Table.Read(Register.YMM4, out value);
                return value;
            }

            set { this.Table.Write(Register.YMM4, ref value); }
        }

        public YmmRegister YMM5
        {
            get
            {
                YmmRegister value;
                this.Table.Read(Register.YMM5, out value);
                return value;
            }

            set { this.Table.Write(Register.YMM5, ref value); }
        }

        public YmmRegister YMM6
        {
            get
            {
                YmmRegister value;
                this.Table.Read(Register.YMM6, out value);
                return value;
            }

            set { this.Table.Write(Register.YMM6, ref value); }
        }

        public YmmRegister YMM7
        {
            get
            {
                YmmRegister value;
                this.Table.Read(Register.YMM7, out value);
                return value;
            }

            set { this.Table.Write(Register.YMM7, ref value); }
        }

        public byte R8B
        {
            get
            {
                byte value;
                this.Table.Read(Register.R8B, out value);
                return value;
            }

            set { this.Table.Write(Register.R8B, ref value); }
        }

        public byte R9B
        {
            get
            {
                byte value;
                this.Table.Read(Register.R9B, out value);
                return value;
            }

            set { this.Table.Write(Register.R9B, ref value); }
        }

        public byte R10B
        {
            get
            {
                byte value;
                this.Table.Read(Register.R10B, out value);
                return value;
            }

            set { this.Table.Write(Register.R10B, ref value); }
        }

        public byte R11B
        {
            get
            {
                byte value;
                this.Table.Read(Register.R11B, out value);
                return value;
            }

            set { this.Table.Write(Register.R11B, ref value); }
        }

        public byte R12B
        {
            get
            {
                byte value;
                this.Table.Read(Register.R12B, out value);
                return value;
            }

            set { this.Table.Write(Register.R12B, ref value); }
        }

        public byte R13B
        {
            get
            {
                byte value;
                this.Table.Read(Register.R13B, out value);
                return value;
            }

            set { this.Table.Write(Register.R13B, ref value); }
        }

        public byte R14B
        {
            get
            {
                byte value;
                this.Table.Read(Register.R14B, out value);
                return value;
            }

            set { this.Table.Write(Register.R14B, ref value); }
        }

        public byte R15B
        {
            get
            {
                byte value;
                this.Table.Read(Register.R15B, out value);
                return value;
            }

            set { this.Table.Write(Register.R15B, ref value); }
        }

        public uint R8D
        {
            get
            {
                uint value;
                this.Table.Read(Register.R8D, out value);
                return value;
            }

            set { this.Table.Write(Register.R8D, ref value); }
        }

        public uint R9D
        {
            get
            {
                uint value;
                this.Table.Read(Register.R9D, out value);
                return value;
            }

            set { this.Table.Write(Register.R9D, ref value); }
        }

        public uint R10D
        {
            get
            {
                uint value;
                this.Table.Read(Register.R10D, out value);
                return value;
            }

            set { this.Table.Write(Register.R10D, ref value); }
        }

        public uint R11D
        {
            get
            {
                uint value;
                this.Table.Read(Register.R11D, out value);
                return value;
            }

            set { this.Table.Write(Register.R11D, ref value); }
        }

        public uint R12D
        {
            get
            {
                uint value;
                this.Table.Read(Register.R12D, out value);
                return value;
            }

            set { this.Table.Write(Register.R12D, ref value); }
        }

        public uint R13D
        {
            get
            {
                uint value;
                this.Table.Read(Register.R13D, out value);
                return value;
            }

            set { this.Table.Write(Register.R13D, ref value); }
        }

        public uint R14D
        {
            get
            {
                uint value;
                this.Table.Read(Register.R14D, out value);
                return value;
            }

            set { this.Table.Write(Register.R14D, ref value); }
        }

        public uint R15D
        {
            get
            {
                uint value;
                this.Table.Read(Register.R15D, out value);
                return value;
            }

            set { this.Table.Write(Register.R15D, ref value); }
        }

        public ushort R8W
        {
            get
            {
                ushort value;
                this.Table.Read(Register.R8W, out value);
                return value;
            }

            set { this.Table.Write(Register.R8W, ref value); }
        }

        public ushort R9W
        {
            get
            {
                ushort value;
                this.Table.Read(Register.R9W, out value);
                return value;
            }

            set { this.Table.Write(Register.R9W, ref value); }
        }

        public ushort R10W
        {
            get
            {
                ushort value;
                this.Table.Read(Register.R10W, out value);
                return value;
            }

            set { this.Table.Write(Register.R10W, ref value); }
        }

        public ushort R11W
        {
            get
            {
                ushort value;
                this.Table.Read(Register.R11W, out value);
                return value;
            }

            set { this.Table.Write(Register.R11W, ref value); }
        }

        public ushort R12W
        {
            get
            {
                ushort value;
                this.Table.Read(Register.R12W, out value);
                return value;
            }

            set { this.Table.Write(Register.R12W, ref value); }
        }

        public ushort R13W
        {
            get
            {
                ushort value;
                this.Table.Read(Register.R13W, out value);
                return value;
            }

            set { this.Table.Write(Register.R13W, ref value); }
        }

        public ushort R14W
        {
            get
            {
                ushort value;
                this.Table.Read(Register.R14W, out value);
                return value;
            }

            set { this.Table.Write(Register.R14W, ref value); }
        }

        public ushort R15W
        {
            get
            {
                ushort value;
                this.Table.Read(Register.R15W, out value);
                return value;
            }

            set { this.Table.Write(Register.R15W, ref value); }
        }

        public MmRegister IDTR
        {
            get
            {
                MmRegister value;
                this.Table.Read(Register.IDTR, out value);
                return value;
            }

            set { this.Table.Write(Register.IDTR, ref value); }
        }

        public MmRegister GDTR
        {
            get
            {
                MmRegister value;
                this.Table.Read(Register.GDTR, out value);
                return value;
            }

            set { this.Table.Write(Register.GDTR, ref value); }
        }

        public MmRegister LDTR
        {
            get
            {
                MmRegister value;
                this.Table.Read(Register.LDTR, out value);
                return value;
            }

            set { this.Table.Write(Register.LDTR, ref value); }
        }

        public MmRegister TR
        {
            get
            {
                MmRegister value;
                this.Table.Read(Register.TR, out value);
                return value;
            }

            set { this.Table.Write(Register.TR, ref value); }
        }

        public ushort FPCW
        {
            get
            {
                ushort value;
                this.Table.Read(Register.FPCW, out value);
                return value;
            }

            set { this.Table.Write(Register.FPCW, ref value); }
        }

        public ushort FPTAG
        {
            get
            {
                ushort value;
                this.Table.Read(Register.FPTAG, out value);
                return value;
            }

            set { this.Table.Write(Register.FPTAG, ref value); }
        }

        public MsRegister MSR
        {
            get
            {
                MsRegister value;
                this.Table.Read(Register.MSR, out value);
                return value;
            }

            set { this.Table.Write(Register.MSR, ref value); }
        }
        // ReSharper restore InconsistentNaming
    }
}

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
            this.Table = table ?? throw new ArgumentNullException("table");
        }

        public byte AH
        {
            get
            {
                this.Table.Read(Register.AH, out byte value);
                return value;
            }

            set { this.Table.Write(Register.AH, ref value); }
        }

        public byte AL
        {
            get
            {
                this.Table.Read(Register.AL, out byte value);
                return value;
            }

            set { this.Table.Write(Register.AL, ref value); }
        }

        public ushort AX
        {
            get
            {
                this.Table.Read(Register.AX, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.AX, ref value); }
        }

        public byte BH
        {
            get
            {
                this.Table.Read(Register.BH, out byte value);
                return value;
            }

            set { this.Table.Write(Register.BH, ref value); }
        }

        public byte BL
        {
            get
            {
                this.Table.Read(Register.BL, out byte value);
                return value;
            }

            set { this.Table.Write(Register.BL, ref value); }
        }

        public ushort BP
        {
            get
            {
                this.Table.Read(Register.BP, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.BP, ref value); }
        }

        public byte BPL
        {
            get
            {
                this.Table.Read(Register.BPL, out byte value);
                return value;
            }

            set { this.Table.Write(Register.BPL, ref value); }
        }

        public ushort BX
        {
            get
            {
                this.Table.Read(Register.BX, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.BX, ref value); }
        }

        public byte CH
        {
            get
            {
                this.Table.Read(Register.CH, out byte value);
                return value;
            }

            set { this.Table.Write(Register.CH, ref value); }
        }

        public byte CL
        {
            get
            {
                this.Table.Read(Register.CL, out byte value);
                return value;
            }

            set { this.Table.Write(Register.CL, ref value); }
        }

        public ushort CS
        {
            get
            {
                this.Table.Read(Register.CS, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.CS, ref value); }
        }

        public ushort CX
        {
            get
            {
                this.Table.Read(Register.CX, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.CX, ref value); }
        }

        public byte DH
        {
            get
            {
                this.Table.Read(Register.DH, out byte value);
                return value;
            }

            set { this.Table.Write(Register.DH, ref value); }
        }

        public ushort DI
        {
            get
            {
                this.Table.Read(Register.DI, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.DI, ref value); }
        }

        public ushort DIL
        {
            get
            {
                this.Table.Read(Register.DIL, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.DIL, ref value); }
        }

        public ushort DL
        {
            get
            {
                this.Table.Read(Register.DL, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.DL, ref value); }
        }

        public ushort DS
        {
            get
            {
                this.Table.Read(Register.DS, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.DS, ref value); }
        }

        public ushort DX
        {
            get
            {
                this.Table.Read(Register.DX, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.DX, ref value); }
        }

        public uint EAX
        {
            get
            {
                this.Table.Read(Register.EAX, out uint value);
                return value;
            }

            set { this.Table.Write(Register.EAX, ref value); }
        }

        public uint EBP
        {
            get
            {
                this.Table.Read(Register.EBP, out uint value);
                return value;
            }

            set { this.Table.Write(Register.EBP, ref value); }
        }

        public uint EBX
        {
            get
            {
                this.Table.Read(Register.EBX, out uint value);
                return value;
            }

            set { this.Table.Write(Register.EBX, ref value); }
        }

        public uint ECX
        {
            get
            {
                this.Table.Read(Register.ECX, out uint value);
                return value;
            }

            set { this.Table.Write(Register.ECX, ref value); }
        }

        public uint EDI
        {
            get
            {
                this.Table.Read(Register.EDI, out uint value);
                return value;
            }

            set { this.Table.Write(Register.EDI, ref value); }
        }

        public uint EDX
        {
            get
            {
                this.Table.Read(Register.EDX, out uint value);
                return value;
            }

            set { this.Table.Write(Register.EDX, ref value); }
        }

        public uint EFLAGS
        {
            get
            {
                this.Table.Read(Register.EFLAGS, out uint value);
                return value;
            }

            set { this.Table.Write(Register.EFLAGS, ref value); }
        }

        public uint EIP
        {
            get
            {
                this.Table.Read(Register.EIP, out uint value);
                return value;
            }

            set { this.Table.Write(Register.EIP, ref value); }
        }

        public ushort ES
        {
            get
            {
                this.Table.Read(Register.ES, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.ES, ref value); }
        }

        public uint ESI
        {
            get
            {
                this.Table.Read(Register.ESI, out uint value);
                return value;
            }

            set { this.Table.Write(Register.ESI, ref value); }
        }

        public uint ESP
        {
            get
            {
                this.Table.Read(Register.ESP, out uint value);
                return value;
            }

            set { this.Table.Write(Register.ESP, ref value); }
        }

        public ushort FPSW
        {
            get
            {
                this.Table.Read(Register.FPSW, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.FPSW, ref value); }
        }

        public ushort FS
        {
            get
            {
                this.Table.Read(Register.FS, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.FS, ref value); }
        }

        public ushort GS
        {
            get
            {
                this.Table.Read(Register.GS, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.GS, ref value); }
        }

        public ushort IP
        {
            get
            {
                this.Table.Read(Register.IP, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.IP, ref value); }
        }

        public ulong RAX
        {
            get
            {
                this.Table.Read(Register.RAX, out ulong value);
                return value;
            }

            set { this.Table.Write(Register.RAX, ref value); }
        }

        public ulong RBP
        {
            get
            {
                this.Table.Read(Register.RBP, out ulong value);
                return value;
            }

            set { this.Table.Write(Register.RBP, ref value); }
        }

        public ulong RBX
        {
            get
            {
                this.Table.Read(Register.RBX, out ulong value);
                return value;
            }

            set { this.Table.Write(Register.RBX, ref value); }
        }

        public ulong RCX
        {
            get
            {
                this.Table.Read(Register.RCX, out ulong value);
                return value;
            }

            set { this.Table.Write(Register.RCX, ref value); }
        }

        public ulong RDI
        {
            get
            {
                this.Table.Read(Register.RDI, out ulong value);
                return value;
            }

            set { this.Table.Write(Register.RDI, ref value); }
        }

        public ulong RDX
        {
            get
            {
                this.Table.Read(Register.RDX, out ulong value);
                return value;
            }

            set { this.Table.Write(Register.RDX, ref value); }
        }

        public ulong RIP
        {
            get
            {
                this.Table.Read(Register.RIP, out ulong value);
                return value;
            }

            set { this.Table.Write(Register.RIP, ref value); }
        }

        public ulong RSI
        {
            get
            {
                this.Table.Read(Register.RSI, out ulong value);
                return value;
            }

            set { this.Table.Write(Register.RSI, ref value); }
        }

        public ulong RSP
        {
            get
            {
                this.Table.Read(Register.RSP, out ulong value);
                return value;
            }

            set { this.Table.Write(Register.RSP, ref value); }
        }

        public ushort SI
        {
            get
            {
                this.Table.Read(Register.SI, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.SI, ref value); }
        }

        public byte SIL
        {
            get
            {
                this.Table.Read(Register.SIL, out byte value);
                return value;
            }

            set { this.Table.Write(Register.SIL, ref value); }
        }

        public ushort SP
        {
            get
            {
                this.Table.Read(Register.SP, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.SP, ref value); }
        }

        public byte SPL
        {
            get
            {
                this.Table.Read(Register.SPL, out byte value);
                return value;
            }

            set { this.Table.Write(Register.SPL, ref value); }
        }

        public ushort SS
        {
            get
            {
                this.Table.Read(Register.SS, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.SS, ref value); }
        }

        public FpRegister FP0
        {
            get
            {
                this.Table.Read(Register.FP0, out FpRegister value);
                return value;
            }

            set { this.Table.Write(Register.FP0, ref value); }
        }

        public FpRegister FP1
        {
            get
            {
                this.Table.Read(Register.FP1, out FpRegister value);
                return value;
            }

            set { this.Table.Write(Register.FP1, ref value); }
        }

        public FpRegister FP2
        {
            get
            {
                this.Table.Read(Register.FP2, out FpRegister value);
                return value;
            }

            set { this.Table.Write(Register.FP2, ref value); }
        }

        public FpRegister FP3
        {
            get
            {
                this.Table.Read(Register.FP3, out FpRegister value);
                return value;
            }

            set { this.Table.Write(Register.FP3, ref value); }
        }

        public FpRegister FP4
        {
            get
            {
                this.Table.Read(Register.FP4, out FpRegister value);
                return value;
            }

            set { this.Table.Write(Register.FP4, ref value); }
        }

        public FpRegister FP5
        {
            get
            {
                this.Table.Read(Register.FP5, out FpRegister value);
                return value;
            }

            set { this.Table.Write(Register.FP5, ref value); }
        }

        public FpRegister FP6
        {
            get
            {
                this.Table.Read(Register.FP6, out FpRegister value);
                return value;
            }

            set { this.Table.Write(Register.FP6, ref value); }
        }

        public FpRegister FP7
        {
            get
            {
                this.Table.Read(Register.FP7, out FpRegister value);
                return value;
            }

            set { this.Table.Write(Register.FP7, ref value); }
        }

        public ulong R8
        {
            get
            {
                this.Table.Read(Register.R8, out ulong value);
                return value;
            }

            set { this.Table.Write(Register.R8, ref value); }
        }

        public ulong R9
        {
            get
            {
                this.Table.Read(Register.R9, out ulong value);
                return value;
            }

            set { this.Table.Write(Register.R9, ref value); }
        }

        public ulong R10
        {
            get
            {
                this.Table.Read(Register.R10, out ulong value);
                return value;
            }

            set { this.Table.Write(Register.R10, ref value); }
        }

        public ulong R11
        {
            get
            {
                this.Table.Read(Register.R11, out ulong value);
                return value;
            }

            set { this.Table.Write(Register.R11, ref value); }
        }

        public ulong R12
        {
            get
            {
                this.Table.Read(Register.R12, out ulong value);
                return value;
            }

            set { this.Table.Write(Register.R12, ref value); }
        }

        public ulong R13
        {
            get
            {
                this.Table.Read(Register.R13, out ulong value);
                return value;
            }

            set { this.Table.Write(Register.R13, ref value); }
        }

        public ulong R14
        {
            get
            {
                this.Table.Read(Register.R14, out ulong value);
                return value;
            }

            set { this.Table.Write(Register.R14, ref value); }
        }

        public ulong R15
        {
            get
            {
                this.Table.Read(Register.R15, out ulong value);
                return value;
            }

            set { this.Table.Write(Register.R15, ref value); }
        }

        public XmmRegister XMM0
        {
            get
            {
                this.Table.Read(Register.XMM0, out XmmRegister value);
                return value;
            }

            set { this.Table.Write(Register.XMM0, ref value); }
        }

        public XmmRegister XMM1
        {
            get
            {
                this.Table.Read(Register.XMM1, out XmmRegister value);
                return value;
            }

            set { this.Table.Write(Register.XMM1, ref value); }
        }

        public XmmRegister XMM2
        {
            get
            {
                this.Table.Read(Register.XMM2, out XmmRegister value);
                return value;
            }

            set { this.Table.Write(Register.XMM2, ref value); }
        }

        public XmmRegister XMM3
        {
            get
            {
                this.Table.Read(Register.XMM3, out XmmRegister value);
                return value;
            }

            set { this.Table.Write(Register.XMM3, ref value); }
        }

        public XmmRegister XMM4
        {
            get
            {
                this.Table.Read(Register.XMM4, out XmmRegister value);
                return value;
            }

            set { this.Table.Write(Register.XMM4, ref value); }
        }

        public XmmRegister XMM5
        {
            get
            {
                this.Table.Read(Register.XMM5, out XmmRegister value);
                return value;
            }

            set { this.Table.Write(Register.XMM5, ref value); }
        }

        public XmmRegister XMM6
        {
            get
            {
                this.Table.Read(Register.XMM6, out XmmRegister value);
                return value;
            }

            set { this.Table.Write(Register.XMM6, ref value); }
        }

        public XmmRegister XMM7
        {
            get
            {
                this.Table.Read(Register.XMM7, out XmmRegister value);
                return value;
            }

            set { this.Table.Write(Register.XMM7, ref value); }
        }

        public YmmRegister YMM0
        {
            get
            {
                this.Table.Read(Register.YMM0, out YmmRegister value);
                return value;
            }

            set { this.Table.Write(Register.YMM0, ref value); }
        }

        public YmmRegister YMM1
        {
            get
            {
                this.Table.Read(Register.YMM1, out YmmRegister value);
                return value;
            }

            set { this.Table.Write(Register.YMM1, ref value); }
        }

        public YmmRegister YMM2
        {
            get
            {
                this.Table.Read(Register.YMM2, out YmmRegister value);
                return value;
            }

            set { this.Table.Write(Register.YMM2, ref value); }
        }

        public YmmRegister YMM3
        {
            get
            {
                this.Table.Read(Register.YMM3, out YmmRegister value);
                return value;
            }

            set { this.Table.Write(Register.YMM3, ref value); }
        }

        public YmmRegister YMM4
        {
            get
            {
                this.Table.Read(Register.YMM4, out YmmRegister value);
                return value;
            }

            set { this.Table.Write(Register.YMM4, ref value); }
        }

        public YmmRegister YMM5
        {
            get
            {
                this.Table.Read(Register.YMM5, out YmmRegister value);
                return value;
            }

            set { this.Table.Write(Register.YMM5, ref value); }
        }

        public YmmRegister YMM6
        {
            get
            {
                this.Table.Read(Register.YMM6, out YmmRegister value);
                return value;
            }

            set { this.Table.Write(Register.YMM6, ref value); }
        }

        public YmmRegister YMM7
        {
            get
            {
                this.Table.Read(Register.YMM7, out YmmRegister value);
                return value;
            }

            set { this.Table.Write(Register.YMM7, ref value); }
        }

        public byte R8B
        {
            get
            {
                this.Table.Read(Register.R8B, out byte value);
                return value;
            }

            set { this.Table.Write(Register.R8B, ref value); }
        }

        public byte R9B
        {
            get
            {
                this.Table.Read(Register.R9B, out byte value);
                return value;
            }

            set { this.Table.Write(Register.R9B, ref value); }
        }

        public byte R10B
        {
            get
            {
                this.Table.Read(Register.R10B, out byte value);
                return value;
            }

            set { this.Table.Write(Register.R10B, ref value); }
        }

        public byte R11B
        {
            get
            {
                this.Table.Read(Register.R11B, out byte value);
                return value;
            }

            set { this.Table.Write(Register.R11B, ref value); }
        }

        public byte R12B
        {
            get
            {
                this.Table.Read(Register.R12B, out byte value);
                return value;
            }

            set { this.Table.Write(Register.R12B, ref value); }
        }

        public byte R13B
        {
            get
            {
                this.Table.Read(Register.R13B, out byte value);
                return value;
            }

            set { this.Table.Write(Register.R13B, ref value); }
        }

        public byte R14B
        {
            get
            {
                this.Table.Read(Register.R14B, out byte value);
                return value;
            }

            set { this.Table.Write(Register.R14B, ref value); }
        }

        public byte R15B
        {
            get
            {
                this.Table.Read(Register.R15B, out byte value);
                return value;
            }

            set { this.Table.Write(Register.R15B, ref value); }
        }

        public uint R8D
        {
            get
            {
                this.Table.Read(Register.R8D, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R8D, ref value); }
        }

        public uint R9D
        {
            get
            {
                this.Table.Read(Register.R9D, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R9D, ref value); }
        }

        public uint R10D
        {
            get
            {
                this.Table.Read(Register.R10D, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R10D, ref value); }
        }

        public uint R11D
        {
            get
            {
                this.Table.Read(Register.R11D, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R11D, ref value); }
        }

        public uint R12D
        {
            get
            {
                this.Table.Read(Register.R12D, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R12D, ref value); }
        }

        public uint R13D
        {
            get
            {
                this.Table.Read(Register.R13D, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R13D, ref value); }
        }

        public uint R14D
        {
            get
            {
                this.Table.Read(Register.R14D, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R14D, ref value); }
        }

        public uint R15D
        {
            get
            {
                this.Table.Read(Register.R15D, out uint value);
                return value;
            }

            set { this.Table.Write(Register.R15D, ref value); }
        }

        public ushort R8W
        {
            get
            {
                this.Table.Read(Register.R8W, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.R8W, ref value); }
        }

        public ushort R9W
        {
            get
            {
                this.Table.Read(Register.R9W, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.R9W, ref value); }
        }

        public ushort R10W
        {
            get
            {
                this.Table.Read(Register.R10W, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.R10W, ref value); }
        }

        public ushort R11W
        {
            get
            {
                this.Table.Read(Register.R11W, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.R11W, ref value); }
        }

        public ushort R12W
        {
            get
            {
                this.Table.Read(Register.R12W, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.R12W, ref value); }
        }

        public ushort R13W
        {
            get
            {
                this.Table.Read(Register.R13W, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.R13W, ref value); }
        }

        public ushort R14W
        {
            get
            {
                this.Table.Read(Register.R14W, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.R14W, ref value); }
        }

        public ushort R15W
        {
            get
            {
                this.Table.Read(Register.R15W, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.R15W, ref value); }
        }

        public MmRegister IDTR
        {
            get
            {
                this.Table.Read(Register.IDTR, out MmRegister value);
                return value;
            }

            set { this.Table.Write(Register.IDTR, ref value); }
        }

        public MmRegister GDTR
        {
            get
            {
                this.Table.Read(Register.GDTR, out MmRegister value);
                return value;
            }

            set { this.Table.Write(Register.GDTR, ref value); }
        }

        public MmRegister LDTR
        {
            get
            {
                this.Table.Read(Register.LDTR, out MmRegister value);
                return value;
            }

            set { this.Table.Write(Register.LDTR, ref value); }
        }

        public MmRegister TR
        {
            get
            {
                this.Table.Read(Register.TR, out MmRegister value);
                return value;
            }

            set { this.Table.Write(Register.TR, ref value); }
        }

        public ushort FPCW
        {
            get
            {
                this.Table.Read(Register.FPCW, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.FPCW, ref value); }
        }

        public ushort FPTAG
        {
            get
            {
                this.Table.Read(Register.FPTAG, out ushort value);
                return value;
            }

            set { this.Table.Write(Register.FPTAG, ref value); }
        }

        public MsRegister MSR
        {
            get
            {
                this.Table.Read(Register.MSR, out MsRegister value);
                return value;
            }

            set { this.Table.Write(Register.MSR, ref value); }
        }
    }
}

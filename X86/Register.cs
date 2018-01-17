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
    internal enum Register : int
    {
        Invalid = 0,
        // ReSharper disable InconsistentNaming
        AH,
        AL,
        AX,
        BH,
        BL,
        BP,
        BPL,
        BX,
        CH,
        CL,
        CS,
        CX,
        DH,
        DI,
        DIL,
        DL,
        DS,
        DX,
        EAX,
        EBP,
        EBX,
        ECX,
        EDI,
        EDX,
        EFLAGS,
        EIP,

        [Obsolete]
        EIZ,

        ES,
        ESI,
        ESP,
        FPSW,
        FS,
        GS,
        IP,
        RAX,
        RBP,
        RBX,
        RCX,
        RDI,
        RDX,
        RIP,

        [Obsolete]
        RIZ,

        RSI,
        RSP,
        SI,
        SIL,
        SP,
        SPL,
        SS,
        CR0,
        CR1,
        CR2,
        CR3,
        CR4,

        [Obsolete]
        CR5,

        [Obsolete]
        CR6,

        [Obsolete]
        CR7,

        [Obsolete]
        CR8,

        [Obsolete]
        CR9,

        [Obsolete]
        CR10,

        [Obsolete]
        CR11,

        [Obsolete]
        CR12,

        [Obsolete]
        CR13,

        [Obsolete]
        CR14,

        [Obsolete]
        CR15,

        DR0,
        DR1,
        DR2,
        DR3,
        DR4,
        DR5,
        DR6,
        DR7,

        [Obsolete]
        DR8,

        [Obsolete]
        DR9,

        [Obsolete]
        DR10,

        [Obsolete]
        DR11,

        [Obsolete]
        DR12,

        [Obsolete]
        DR13,

        [Obsolete]
        DR14,

        [Obsolete]
        DR15,

        FP0,
        FP1,
        FP2,
        FP3,
        FP4,
        FP5,
        FP6,
        FP7,

        [Obsolete]
        K0,

        [Obsolete]
        K1,

        [Obsolete]
        K2,

        [Obsolete]
        K3,

        [Obsolete]
        K4,

        [Obsolete]
        K5,

        [Obsolete]
        K6,

        [Obsolete]
        K7,

        [Obsolete]
        MM0,

        [Obsolete]
        MM1,

        [Obsolete]
        MM2,

        [Obsolete]
        MM3,

        [Obsolete]
        MM4,

        [Obsolete]
        MM5,

        [Obsolete]
        MM6,

        [Obsolete]
        MM7,

        R8,
        R9,
        R10,
        R11,
        R12,
        R13,
        R14,
        R15,

        [Obsolete]
        ST0,

        [Obsolete]
        ST1,

        [Obsolete]
        ST2,

        [Obsolete]
        ST3,

        [Obsolete]
        ST4,

        [Obsolete]
        ST5,

        [Obsolete]
        ST6,

        [Obsolete]
        ST7,

        XMM0,
        XMM1,
        XMM2,
        XMM3,
        XMM4,
        XMM5,
        XMM6,
        XMM7,

        [Obsolete]
        XMM8,

        [Obsolete]
        XMM9,

        [Obsolete]
        XMM10,

        [Obsolete]
        XMM11,

        [Obsolete]
        XMM12,

        [Obsolete]
        XMM13,

        [Obsolete]
        XMM14,

        [Obsolete]
        XMM15,

        [Obsolete]
        XMM16,

        [Obsolete]
        XMM17,

        [Obsolete]
        XMM18,

        [Obsolete]
        XMM19,

        [Obsolete]
        XMM20,

        [Obsolete]
        XMM21,

        [Obsolete]
        XMM22,

        [Obsolete]
        XMM23,

        [Obsolete]
        XMM24,

        [Obsolete]
        XMM25,

        [Obsolete]
        XMM26,

        [Obsolete]
        XMM27,

        [Obsolete]
        XMM28,

        [Obsolete]
        XMM29,

        [Obsolete]
        XMM30,

        [Obsolete]
        XMM31,

        YMM0,
        YMM1,
        YMM2,
        YMM3,
        YMM4,
        YMM5,
        YMM6,
        YMM7,

        [Obsolete]
        YMM8,

        [Obsolete]
        YMM9,

        [Obsolete]
        YMM10,

        [Obsolete]
        YMM11,

        [Obsolete]
        YMM12,

        [Obsolete]
        YMM13,

        [Obsolete]
        YMM14,

        [Obsolete]
        YMM15,

        [Obsolete]
        YMM16,

        [Obsolete]
        YMM17,

        [Obsolete]
        YMM18,

        [Obsolete]
        YMM19,

        [Obsolete]
        YMM20,

        [Obsolete]
        YMM21,

        [Obsolete]
        YMM22,

        [Obsolete]
        YMM23,

        [Obsolete]
        YMM24,

        [Obsolete]
        YMM25,

        [Obsolete]
        YMM26,

        [Obsolete]
        YMM27,

        [Obsolete]
        YMM28,

        [Obsolete]
        YMM29,

        [Obsolete]
        YMM30,

        [Obsolete]
        YMM31,

        [Obsolete]
        ZMM0,

        [Obsolete]
        ZMM1,

        [Obsolete]
        ZMM2,

        [Obsolete]
        ZMM3,

        [Obsolete]
        ZMM4,

        [Obsolete]
        ZMM5,

        [Obsolete]
        ZMM6,

        [Obsolete]
        ZMM7,

        [Obsolete]
        ZMM8,

        [Obsolete]
        ZMM9,

        [Obsolete]
        ZMM10,

        [Obsolete]
        ZMM11,

        [Obsolete]
        ZMM12,

        [Obsolete]
        ZMM13,

        [Obsolete]
        ZMM14,

        [Obsolete]
        ZMM15,

        [Obsolete]
        ZMM16,

        [Obsolete]
        ZMM17,

        [Obsolete]
        ZMM18,

        [Obsolete]
        ZMM19,

        [Obsolete]
        ZMM20,

        [Obsolete]
        ZMM21,

        [Obsolete]
        ZMM22,

        [Obsolete]
        ZMM23,

        [Obsolete]
        ZMM24,

        [Obsolete]
        ZMM25,

        [Obsolete]
        ZMM26,

        [Obsolete]
        ZMM27,

        [Obsolete]
        ZMM28,

        [Obsolete]
        ZMM29,

        [Obsolete]
        ZMM30,

        [Obsolete]
        ZMM31,

        R8B,
        R9B,
        R10B,
        R11B,
        R12B,
        R13B,
        R14B,
        R15B,
        R8D,
        R9D,
        R10D,
        R11D,
        R12D,
        R13D,
        R14D,
        R15D,
        R8W,
        R9W,
        R10W,
        R11W,
        R12W,
        R13W,
        R14W,
        R15W,
        IDTR,
        GDTR,
        LDTR,
        TR,
        FPCW,
        FPTAG,
        MSR, // Model-Specific Register
        // ReSharper restore InconsistentNaming
    }
}

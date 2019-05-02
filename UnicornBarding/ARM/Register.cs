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
namespace Unicorn.ARM
{
    internal enum Register : int
    {
        Invalid = 0,
        APSR,
        APSR_NZCV,
        CPSR,
        FPEXC,
        FPINST,
        FPSCR,
        FPSCR_NZCV,
        FPSID,
        ITSTATE,
        LR,
        PC,
        SP,
        SPSR,
        D0,
        D1,
        D2,
        D3,
        D4,
        D5,
        D6,
        D7,
        D8,
        D9,
        D10,
        D11,
        D12,
        D13,
        D14,
        D15,
        D16,
        D17,
        D18,
        D19,
        D20,
        D21,
        D22,
        D23,
        D24,
        D25,
        D26,
        D27,
        D28,
        D29,
        D30,
        D31,
        FPINST2,
        MVFR0,
        MVFR1,
        MVFR2,
        Q0,
        Q1,
        Q2,
        Q3,
        Q4,
        Q5,
        Q6,
        Q7,
        Q8,
        Q9,
        Q10,
        Q11,
        Q12,
        Q13,
        Q14,
        Q15,
        R0,
        R1,
        R2,
        R3,
        R4,
        R5,
        R6,
        R7,
        R8,
        R9,
        R10,
        R11,
        R12,
        S0,
        S1,
        S2,
        S3,
        S4,
        S5,
        S6,
        S7,
        S8,
        S9,
        S10,
        S11,
        S12,
        S13,
        S14,
        S15,
        S16,
        S17,
        S18,
        S19,
        S20,
        S21,
        S22,
        S23,
        S24,
        S25,
        S26,
        S27,
        S28,
        S29,
        S30,
        S31,

        C1_C0_2,
        C13_C0_2,
        C13_C0_3,

        // alias registers
        R13 = SP,
        R14 = LR,
        R15 = PC,

        SB = R9,
        SL = R10,
        FP = R11,
        IP = R12,
    }
}

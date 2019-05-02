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
namespace Unicorn.MIPS
{
    internal enum Register : int
    {
        Invalid = 0,

        //> General purpose registers
        PC,

        _0,
        _1,
        _2,
        _3,
        _4,
        _5,
        _6,
        _7,
        _8,
        _9,
        _10,
        _11,
        _12,
        _13,
        _14,
        _15,
        _16,
        _17,
        _18,
        _19,
        _20,
        _21,
        _22,
        _23,
        _24,
        _25,
        _26,
        _27,
        _28,
        _29,
        _30,
        _31,

        //> DSP registers
        DSPCCOND,
        DSPCARRY,
        DSPEFI,
        DSPOUTFLAG,
        DSPOUTFLAG16_19,
        DSPOUTFLAG20,
        DSPOUTFLAG21,
        DSPOUTFLAG22,
        DSPOUTFLAG23,
        DSPPOS,
        DSPSCOUNT,

        //> ACC registers
        AC0,
        AC1,
        AC2,
        AC3,

        //> COP registers
        CC0,
        CC1,
        CC2,
        CC3,
        CC4,
        CC5,
        CC6,
        CC7,

        //> FPU registers
        F0,
        F1,
        F2,
        F3,
        F4,
        F5,
        F6,
        F7,
        F8,
        F9,
        F10,
        F11,
        F12,
        F13,
        F14,
        F15,
        F16,
        F17,
        F18,
        F19,
        F20,
        F21,
        F22,
        F23,
        F24,
        F25,
        F26,
        F27,
        F28,
        F29,
        F30,
        F31,

        FCC0,
        FCC1,
        FCC2,
        FCC3,
        FCC4,
        FCC5,
        FCC6,
        FCC7,

        //> AFPR128
        W0,
        W1,
        W2,
        W3,
        W4,
        W5,
        W6,
        W7,
        W8,
        W9,
        W10,
        W11,
        W12,
        W13,
        W14,
        W15,
        W16,
        W17,
        W18,
        W19,
        W20,
        W21,
        W22,
        W23,
        W24,
        W25,
        W26,
        W27,
        W28,
        W29,
        W30,
        W31,

        HI,
        LO,

        P0,
        P1,
        P2,

        MPL0,
        MPL1,
        MPL2,

        // alias registers
        ZERO = _0,
        AT = _1,
        V0 = _2,
        V1 = _3,
        A0 = _4,
        A1 = _5,
        A2 = _6,
        A3 = _7,
        T0 = _8,
        T1 = _9,
        T2 = _10,
        T3 = _11,
        T4 = _12,
        T5 = _13,
        T6 = _14,
        T7 = _15,
        S0 = _16,
        S1 = _17,
        S2 = _18,
        S3 = _19,
        S4 = _20,
        S5 = _21,
        S6 = _22,
        S7 = _23,
        T8 = _24,
        T9 = _25,
        K0 = _26,
        K1 = _27,
        GP = _28,
        SP = _29,
        FP = _30,
        S8 = _30,
        RA = _31,

        HI0 = AC0,
        HI1 = AC1,
        HI2 = AC2,
        HI3 = AC3,

        LO0 = HI0,
        LO1 = HI1,
        LO2 = HI2,
        LO3 = HI3,
    }
}

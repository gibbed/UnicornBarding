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
    internal enum Register : int
    {
        Invalid = 0,
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
        F32,
        F34,
        F36,
        F38,
        F40,
        F42,
        F44,
        F46,
        F48,
        F50,
        F52,
        F54,
        F56,
        F58,
        F60,
        F62,
        FCC0,  // Floating condition codes
        FCC1,
        FCC2,
        FCC3,
        G0,
        G1,
        G2,
        G3,
        G4,
        G5,
        G6,
        G7,
        I0,
        I1,
        I2,
        I3,
        I4,
        I5,
        FP,
        I7,
        ICC,   // Integer condition codes
        L0,
        L1,
        L2,
        L3,
        L4,
        L5,
        L6,
        L7,
        O0,
        O1,
        O2,
        O3,
        O4,
        O5,
        SP,
        O7,
        Y,

        // special register
        XCC,

        // pseudo register
        PC,   // program counter register

        // extras
        O6 = SP,
        I6 = FP,
    }
}

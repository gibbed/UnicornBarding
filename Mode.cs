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
namespace Unicorn
{
    public enum Mode
    {
        LittleEndian = 0, // little-endian mode (default mode)
        BigEndian = 1 << 30, // big-endian mode

        // arm / arm64
        ARM = 0, // ARM mode
        THUMB = 1 << 4, // THUMB mode (including Thumb-2)
        MCLASS = 1 << 5, // ARM's Cortex-M series (currently unsupported)
        V8 = 1 << 6, // ARMv8 A32 encodings for ARM (currently unsupported)

        // mips
        MICRO = 1 << 4, // MicroMips mode (currently unsupported)
        MIPS3 = 1 << 5, // Mips III ISA (currently unsupported)
        MIPS32R6 = 1 << 6, // Mips32r6 ISA (currently unsupported)
        MIPS32 = 1 << 2, // Mips32 ISA
        MIPS64 = 1 << 3, // Mips64 ISA

        // x86 / x64
        X86_16 = 1 << 1, // 16-bit mode
        X86_32 = 1 << 2, // 32-bit mode
        X86_64 = 1 << 3, // 64-bit mode

        // ppc 
        PPC32 = 1 << 2, // 32-bit mode (currently unsupported)
        PPC64 = 1 << 3, // 64-bit mode (currently unsupported)
        QPX = 1 << 4, // Quad Processing eXtensions mode (currently unsupported)

        // sparc
        SPARC32 = 1 << 2, // 32-bit mode
        SPARC64 = 1 << 3, // 64-bit mode
        V9 = 1 << 4, // SparcV9 mode (currently unsupported)

        // m68k
    }
}

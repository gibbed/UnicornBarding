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

namespace Unicorn
{
    [Flags]
    internal enum HookType
    {
        Interrupt = 1 << 0, // Hook all interrupt/syscall events
        Syscall = Interrupt,

        Instruction = 1 << 1, // Hook a particular instruction - only a very small subset of instructions supported here

        Code = 1 << 2, // Hook a range of code
        Block = 1 << 3, // Hook basic blocks

        MemoryReadUnmapped = 1 << 4, // Hook for memory read on unmapped memory
        MemoryWriteUnmapped = 1 << 5, // Hook for invalid memory write events
        MemoryFetchUnmapped = 1 << 6, // Hook for invalid memory fetch for execution events
        MemoryReadProtected = 1 << 7, // Hook for memory read on read-protected memory
        MemoryWriteProtected = 1 << 8, // Hook for memory write on write-protected memory
        MemoryFetchProtected = 1 << 9, // Hook for memory fetch on non-executable memory

        MemoryRead = 1 << 10, // Hook memory read events.
        MemoryWrite = 1 << 11, // Hook memory write events.
        MemoryFetch = 1 << 12, // Hook memory fetch for execution events
        MemoryReadAfter = 1 << 13, // Hook memory read events, but only successful access.
        // The callback will be triggered after successful read.
    }
}

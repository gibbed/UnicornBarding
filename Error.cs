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
    public enum Error : int
    {
        OK = 0, // No error: everything was fine
        OutOfMemory, // Out-Of-Memory error: uc_open(), uc_emulate()
        UnsupportedArchitecture, // Unsupported architecture: uc_open()
        InvalidHandle, // Invalid handle
        InvalidMode, // Invalid/unsupported mode: uc_open()
        UnsupportedMode = InvalidMode,
        UnsupportedVersion, // Unsupported version (bindings)
        UnmappedRead, // Quit emulation due to READ on unmapped memory: uc_emu_start()
        UnmappedWrite, // Quit emulation due to WRITE on unmapped memory: uc_emu_start()
        UnmappedFetch, // Quit emulation due to FETCH on unmapped memory: uc_emu_start()
        InvalidHookType, // Invalid hook type: uc_hook_add()
        InvalidInstruction, // Quit emulation due to invalid instruction: uc_emu_start()
        InvalidMemoryMapping, // Invalid memory mapping: uc_mem_map()
        WriteProtectionViolation, // Quit emulation due to UC_MEM_WRITE_PROT violation: uc_emu_start()
        ReadProtectionViolation, // Quit emulation due to UC_MEM_READ_PROT violation: uc_emu_start()
        FetchProtectionViolation, // Quit emulation due to UC_MEM_FETCH_PROT violation: uc_emu_start()
        InvalidArgument, // Invalid argument provided to uc_xxx function (See specific function API)
        UnalignedRead, // Unaligned read
        UnalignedWrite, // Unaligned write
        UnalignedFetch, // Unaligned fetch
        HookExists, // hook for this event already existed
        InsufficientResources, // Insufficient resource: uc_emu_start()
        UnhandledException, // Unhandled CPU exception
    }
}

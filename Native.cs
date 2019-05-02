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
using System.Runtime.InteropServices;

namespace Unicorn
{
    internal static class Native
    {
        private const string _Library = "unicorn";
        private const CallingConvention _CallingConvention = CallingConvention.Cdecl;

#pragma warning disable IDE1006 // Naming Styles

        [UnmanagedFunctionPointer(_CallingConvention)]
        public delegate void uc_cb_hookcode_t(IntPtr uc, ulong address, uint size, IntPtr user_data);

        [UnmanagedFunctionPointer(_CallingConvention)]
        public delegate void uc_cb_hookintr_t(IntPtr uc, uint intno, IntPtr user_data);

        [UnmanagedFunctionPointer(_CallingConvention)]
        public delegate uint uc_cb_insn_in_t(IntPtr uc, uint port, int size, IntPtr user_data);

        [UnmanagedFunctionPointer(_CallingConvention)]
        public delegate void uc_cb_insn_out_t(IntPtr uc, uint port, int size, uint value, IntPtr user_data);

        [UnmanagedFunctionPointer(_CallingConvention)]
        public delegate void uc_cb_hookmem_t(
            IntPtr uc,
            MemoryType type,
            ulong address,
            int size,
            long value,
            IntPtr user_data);

        [UnmanagedFunctionPointer(_CallingConvention)]
        [return: MarshalAs(UnmanagedType.I1)]
        public delegate bool uc_cb_eventmem_t(
            IntPtr uc,
            MemoryType type,
            ulong address,
            int size,
            long value,
            IntPtr user_data);

        [UnmanagedFunctionPointer(_CallingConvention)]
        public delegate void uc_cb_insn_syscall_t(IntPtr uc, IntPtr user_data);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern uint uc_version(IntPtr major, IntPtr minor);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern uint uc_version(out uint major, out uint minor);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool uc_arch_supported(Architecture arch);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_open(Architecture arch, Mode mode, out IntPtr uc);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_close(IntPtr uc);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_query(IntPtr uc, QueryType query, out UIntPtr result);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_errno(IntPtr uc);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern IntPtr uc_strerror(Error err);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_write(IntPtr uc, int regid, ref sbyte value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_write(IntPtr uc, int regid, ref byte value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_write(IntPtr uc, int regid, ref short value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_write(IntPtr uc, int regid, ref ushort value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_write(IntPtr uc, int regid, ref int value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_write(IntPtr uc, int regid, ref uint value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_write(IntPtr uc, int regid, ref long value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_write(IntPtr uc, int regid, ref ulong value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_write(IntPtr uc, int regid, ref float value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_write(IntPtr uc, int regid, ref double value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_write(IntPtr uc, int regid, ref X86.FpRegister value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_write(IntPtr uc, int regid, ref X86.XmmRegister value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_write(IntPtr uc, int regid, ref X86.YmmRegister value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_write(IntPtr uc, int regid, ref X86.MmRegister value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_write(IntPtr uc, int regid, ref X86.MsRegister value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_read(IntPtr uc, int regid, out sbyte value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_read(IntPtr uc, int regid, out byte value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_read(IntPtr uc, int regid, out short value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_read(IntPtr uc, int regid, out ushort value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_read(IntPtr uc, int regid, out int value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_read(IntPtr uc, int regid, out uint value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_read(IntPtr uc, int regid, out long value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_read(IntPtr uc, int regid, out ulong value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_read(IntPtr uc, int regid, out float value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_read(IntPtr uc, int regid, out double value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_read(IntPtr uc, int regid, out X86.FpRegister value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_read(IntPtr uc, int regid, out X86.XmmRegister value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_read(IntPtr uc, int regid, out X86.YmmRegister value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_read(IntPtr uc, int regid, out X86.MmRegister value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_reg_read(IntPtr uc, int regid, out X86.MsRegister value);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_mem_write(IntPtr uc, ulong address, byte[] bytes, UIntPtr size);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_mem_read(IntPtr uc, ulong address, byte[] bytes, UIntPtr size);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_emu_start(IntPtr uc, ulong begin, ulong until, ulong timeout, UIntPtr count);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_emu_stop(IntPtr uc);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_hook_add(IntPtr uc,
                                               out UIntPtr hh,
                                               HookType type,
                                               IntPtr callback,
                                               IntPtr user_data,
                                               ulong address,
                                               ulong end);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_hook_add(IntPtr uc,
                                               out UIntPtr hh,
                                               HookType type,
                                               IntPtr callback,
                                               IntPtr user_data,
                                               ulong address,
                                               ulong end,
                                               int instruction);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_hook_del(IntPtr uc, IntPtr hh);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_mem_map(IntPtr uc, ulong address, UIntPtr size, Protection perms);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_mem_unmap(IntPtr uc, ulong address, UIntPtr size);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_mem_protect(IntPtr uc, ulong address, UIntPtr size, Protection perms);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_mem_regions(IntPtr uc, ref IntPtr regions, out uint count);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_context_alloc(IntPtr uc, out IntPtr context);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_free(IntPtr mem);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_context_save(IntPtr uc, IntPtr context);

        [DllImport(_Library, CallingConvention = _CallingConvention)]
        public static extern Error uc_context_restore(IntPtr uc, IntPtr context);

#pragma warning restore IDE1006 // Naming Styles
    }
}

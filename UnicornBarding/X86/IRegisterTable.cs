﻿/* Copyright (c) 2018 Rick (rick 'at' gibbed 'dot' us)
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
namespace Unicorn.X86
{
    internal interface IRegisterTable
    {
        void Read(Register register, out byte value);
        void Read(Register register, out ushort value);
        void Read(Register register, out uint value);
        void Read(Register register, out ulong value);
        void Read(Register register, out FpRegister value);
        void Read(Register register, out XmmRegister value);
        void Read(Register register, out YmmRegister value);
        void Read(Register register, out MmRegister value);
        void Read(Register register, out MsRegister value);
        void Write(Register register, ref byte value);
        void Write(Register register, ref ushort value);
        void Write(Register register, ref uint value);
        void Write(Register register, ref ulong value);
        void Write(Register register, ref FpRegister value);
        void Write(Register register, ref XmmRegister value);
        void Write(Register register, ref YmmRegister value);
        void Write(Register register, ref MmRegister value);
        void Write(Register register, ref MsRegister value);
    }
}

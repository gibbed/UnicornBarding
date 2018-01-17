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
    public sealed class Memory
    {
        private readonly IMemoryManager _Manager;

        internal Memory(IMemoryManager manager)
        {
            if (manager == null)
            {
                throw new ArgumentNullException("manager");
            }

            this._Manager = manager;
        }

        public void Map(ulong address, int size, Protection protection)
        {
            this._Manager.Map(address, size, protection);
        }

        public void Unmap(ulong address, int size)
        {
            this._Manager.Unmap(address, size);
        }

        public bool UnmapSafe(ulong address, int size)
        {
            return this._Manager.UnmapSafe(address, size);
        }

        public void Protect(ulong address, int size, Protection protection)
        {
            this._Manager.Protect(address, size, protection);
        }

        public void Write(ulong address, byte[] buffer, int count)
        {
            this._Manager.Write(address, buffer, count);
        }

        public void Read(ulong address, byte[] buffer, int count)
        {
            this._Manager.Read(address, buffer, count);
        }
    }
}

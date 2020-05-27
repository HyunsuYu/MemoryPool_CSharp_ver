using System;

namespace MemoryPool_CSharp
{
    sealed public class MemoryPool_Custom : IDisposable
    {
        //  property

        //  method
        public MemoryPool_Custom()
        {

        }
        public MemoryPool_Custom(byte size)
        {

        }
        ~MemoryPool_Custom()
        {

        }
        public void Dispose()
        {

        }

        private void DIspose(bool bisDispose)
        {
            if(!bisDispose)
            {
                return;
            }
        }
    }
}

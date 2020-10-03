using System;
using System.Collections.Generic;
using System.Text;

namespace Device
{
    class Disk : IDisk
    {
        string memory;
        int MSize=0;

        public string Memory
        {
            get => memory;
            set => value = memory;
        }
        public int MemSize
        {
            get => MSize;
            set => value = MSize;
        }
        public Disk(){}
        public Disk(string memory,int memSize)
        {
            this.Memory = memory;
            this.MemSize = memSize;
        }
        public string GetName()
        {
            return null;
        }
        public string Read()
        {
            return this.Memory;
        }

        public void Write(string text)
        {
            this.Memory = text;
        }
        public override string ToString()
        {
            return $"{GetName()}\t{Memory}\t{MemSize}";
        }
    }
}

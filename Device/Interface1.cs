using System;
using System.Collections.Generic;
using System.Text;

namespace Device
{
    interface IRemovabelDisk
    {
        public bool HasDisk { get; }
        public void Inset();
        public void Reject();
    }
    interface IDisk
    {
        public string Read();
        public void Write(string text);
    }
    interface IPrintInformation
    {
        public string GetName();
        public void Print(string str);
    }
}

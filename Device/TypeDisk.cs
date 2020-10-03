using System;
using System.Collections.Generic;
using System.Text;

namespace Device
{
    class CD : Disk, IRemovabelDisk
    {
        bool hasDisk;
        Type myType = typeof(CD);
        public bool HasDisk => hasDisk;
        public CD(string text,int m):base(text,m)
        {

        }
        public void Inset()
        {
            Console.WriteLine($"Disk {myType.ToString()} is insert");
        }

        public void Reject()
        {
            Console.WriteLine($"Disk {myType.ToString()} is reject");
        }
        public string GetName()
        {
           
            return myType.ToString();
        }
        public override string ToString()
        {
            return $"{GetName()}\t{Memory}\t{MemSize}";
        }
    }
    class Flesh : Disk, IRemovabelDisk
    {
        bool hasDisk;
        Type myType = typeof(Flesh);
        public bool HasDisk => hasDisk;
        public Flesh(string text, int m) : base(text, m)
        {

        }
        public void Inset()
        {
            Console.WriteLine($"Disk {myType.ToString()} is insert");
        }

        public void Reject()
        {
            Console.WriteLine($"Disk {myType.ToString()} is reject");
        }
        public string GetName()
        {

            return myType.ToString();
        }
        public override string ToString()
        {
            return $"{GetName()}\t{Memory}\t{MemSize}";
        }
    }

    class HDD : Disk
    {
        public HDD(string text, int m) : base(text, m)
        {

        }
        Type myType = typeof(HDD);
        public string GetName()
        {
            return myType.ToString();
        }
        public override string ToString()
        {
            return $"{GetName()}\t{Memory}\t{MemSize}";
        }
    }


    class DVD: Disk, IRemovabelDisk
    {
        bool hasDisk;
        Type myType = typeof(DVD);
        public bool HasDisk => hasDisk;
        public DVD(string text, int m) : base(text, m)
        {

        }
        public void Inset()
        {
            Console.WriteLine($"Disk {myType.ToString()} is insert");
        }

        public void Reject()
        {
            Console.WriteLine($"Disk {myType.ToString()} is reject");
        }
        public string GetName()
        {

            return myType.ToString();
        }
        public override string ToString()
        {
            return $"{GetName()}\t{Memory}\t{MemSize}";
        }
    }
}

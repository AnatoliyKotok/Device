using System;

namespace Device
{
    class Program
    {
        static void Main(string[] args)
        {
            Disk d = new Disk("Hello", 250);
            CD cd=new CD("Hello",250);
            Printer p = new Printer();
            Comp c = new Comp();
            c.AddDevice(p);
            c.AddDisk(cd);
            Console.WriteLine( c.ReadInfo("Device.CD"));
            c.WriteInfo("Bye", "Device.CD");
            c.PrintDisk();
            c.ShowPrintDevice();
            Console.WriteLine( c.CheckDisk("CD"));
        }
    }
}

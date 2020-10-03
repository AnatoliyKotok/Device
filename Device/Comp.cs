using System;
using System.Collections.Generic;
using System.Text;

namespace Device
{
    class Comp
    {
        List<Disk> disks = new List<Disk>();
        List<IPrintInformation>device  = new List<IPrintInformation>();
        public void AddDevice(IPrintInformation d)
        {
            device.Add(d);
        }
        public void AddDisk(Disk d)
        {
            disks.Add(d);
        }
        public void InserReject(string name,bool b)
        {
            for (int i = 0; i < disks.Count; i++)
            {
                if (name == disks[i].GetName())
                {
                    if (b == true)
                    {
                        Console.WriteLine($"Disk {disks[i].GetName()} is insert");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Disk {disks[i].GetName()} is reject");
                        break;
                    }
                }
            }
        }
        public void PrintDisk()
        {
            for (int i = 0; i < disks.Count; i++)
            {
                Console.WriteLine(disks[i]);
            }
        }
        public void ShowPrintDevice()
        {
            for (int i = 0; i < device.Count; i++)
            {
                Console.WriteLine(device[i]);
            }
        }
        public bool CheckDisk(string d)
        {
            for (int i = 0; i < disks.Count; i++)
            {
                if (d == disks[i].GetName())
                {
                    return true;
                }
               
            }
            return false;
        }
        public string ReadInfo(string d)
        {
            foreach(var i in disks)
            {
                if (d == i.GetName())
                {
                    return i.Read();
                }
            }
            return "No info";
        }
        public bool WriteInfo(string t,string d)
        {
            for (int i = 0; i < disks.Count; i++)
            {
                if (d == disks[i].GetName())
                {
                    disks[i].Write(t);
                    return true;
                }
            }
            return false;
        }
    }
}

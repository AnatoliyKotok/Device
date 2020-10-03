using System;
using System.Collections.Generic;
using System.Text;

namespace Device
{
    class Printer : IPrintInformation
    {
        public string GetName()
        {
            Type myType = typeof(Printer);
            return myType.ToString();
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }
        public override string ToString()
        {
            return $"{GetName()}";
        }
    }

    class Monitor : IPrintInformation
    {
        public string GetName()
        {
            Type myType = typeof(Monitor);
            return myType.ToString();
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }
        public override string ToString()
        {
            return $"{GetName()}";
        }
    }
}

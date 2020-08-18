using System;
using System.Collections.Generic;
using System.Text;

namespace ISPPrinciple.GoodCode
{
    public class HPLasserJet : IPrint, IFaxTask, IScan

    {
        public void Print(string content)
        {
            Console.WriteLine(content);
        }

        public void Scan(string content)
        {
            Console.WriteLine(content);
        }

        public void Fax(string content)
        {
            Console.WriteLine(content);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ISPPrinciple.BadCode
{
    public class EPSONInkJetPrinter : IPrinterTask
    {
        public void Fax(string content)
        {
            throw new NotImplementedException();
        }

        public void Print(string content)
        {
            Console.WriteLine(content);
        }

        public void Scan(string content)
        {
            throw new NotImplementedException();
        }
    }
}

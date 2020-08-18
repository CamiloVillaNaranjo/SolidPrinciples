using System;
using System.Collections.Generic;
using System.Text;

namespace ISPPrinciple.GoodCode
{
    public class EPSONInkJetPrinter : IPrint
    {
        public void Print(string content)
        {
            Console.WriteLine(content);
        }
    }
}

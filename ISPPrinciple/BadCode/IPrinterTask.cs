using System;
using System.Collections.Generic;
using System.Text;

namespace ISPPrinciple.BadCode
{
    public interface IPrinterTask
    {
        void Print(string content);
        void Scan(string content);
        void Fax(string content);
    }
}

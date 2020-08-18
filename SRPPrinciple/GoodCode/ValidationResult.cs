using System.Collections.Generic;
using System.Linq;

namespace SRPPrinciple.GoodCode
{
    public class ValidationResult
    {
        public List<string> ErrorMessages { get; set; } = new List<string>();
        public bool IsValid { get { return !ErrorMessages.Any(); } }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator_CleanArchitecture_Dotnet8.Domain
{
    public class InvoiceAttribute
    {
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Trim
{
    [System.AttributeUsage(AttributeTargets.Property)]
    sealed class WhetherTrimAttribute : Attribute
    {
        public bool IsTrim { get; private set; }
        // This is a positional argument
        public WhetherTrimAttribute(bool isTrim)
        {
            this.IsTrim = isTrim;
        }
        
    }
}

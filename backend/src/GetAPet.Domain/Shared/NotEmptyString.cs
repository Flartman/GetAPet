using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAPet.Domain.Shared
{
    public class NotEmptyString
    {
        public NotEmptyString(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value));

            Value = value;
        }

        public string Value { get; } 
    }
}

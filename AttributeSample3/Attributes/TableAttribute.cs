using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSample3.Attributes
{
    public class TableAttribute : Attribute
    {
        public string TableName { get; set; }
    }
}

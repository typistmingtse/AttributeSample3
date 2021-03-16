using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSample3.Attributes
{
    public class ColumnAttribute : Attribute
    {
        public string ColumnName { get; set; }
    }
}

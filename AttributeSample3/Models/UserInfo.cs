using AttributeSample3.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSample3.Models
{
    [Table(TableName = "UserInfo")]
    public class UserInfo : TableBase
    {
        [Column(ColumnName = "UserName")]
        public string UserName { get; set; }

        [Column(ColumnName = null)]
        public int UserAge { get; set; }
    }
}

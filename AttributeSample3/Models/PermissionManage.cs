using AttributeSample3.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSample3.Models
{
    [Table(TableName ="PermissionManage")]
    public class PermissionManage
    {
        [Column(ColumnName = "UserName")]
        public string UserName { get; set; }
        [Column(ColumnName = "PermissionType")]
        public int PermissionType { get; set; }
    }
}

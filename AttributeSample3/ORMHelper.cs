using AttributeSample3.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSample3
{

    public class SQLServerORMHelper : ORMHelperBase
    {
        public void Insert(object table)
        {
            var insertTable = string.Empty;
            var insertColumns = string.Empty;
            var type = table.GetType();

            //取得附加在這個class上的attribute資訊。注意:使用Reflection對於效能消耗會比較大
            var tableAttr = type.GetCustomAttributes<TableAttribute>();
            foreach (var item in tableAttr)
                insertTable = item.TableName;

            //取得此Table Class的Properties
            var props = type.GetProperties();
            foreach (var prop in props)
            {
                //再從每個Property取出附加在上面的attribute資訊
                var columnAttrs = prop.GetCustomAttributes(false);

                foreach (var item in columnAttrs)
                {
                    if (item is ColumnAttribute)
                    {
                        var columnAttr = item as ColumnAttribute;
                        //如果ColumnAttribute值是null直接取Property名稱當作欄位
                        var columnNmae = columnAttr.ColumnName == null ? prop.Name : columnAttr.ColumnName;
                        insertColumns += $"{ columnNmae } ";
                    }
                }
            }

            if (tableAttr != null)
                Console.WriteLine($"Insert into table: { insertTable }, column: { insertColumns } Completed!");
        }
    }
}

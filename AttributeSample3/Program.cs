using AttributeSample3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSample3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var orm = new SQLServerORMHelper();
            orm.Insert(new UserInfo { UserName = "Peter", UserAge = 25 });
            orm.Insert(new PermissionManage { UserName = "Peter", PermissionType = 1 });

            Console.ReadKey();
        }
    }
}

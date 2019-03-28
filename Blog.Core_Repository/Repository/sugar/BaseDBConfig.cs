using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Repository.sugar
{
    public class BaseDBConfig
    {
        //public static string ConnectionString = File.ReadAllText(@"D:\my-file\dbCountPsw1.txt").Trim();

        //正常格式  - 因ioc注入所以不能使用
        //public static string ConnectionString = "server=.;uid=sa;pwd=sa;database=AppsDB_new"; 

        //ioc注入使用
        public static string ConnectionString = Appsettings.app(new string[] { "AppSettings", "RedisCaching", "ConnectionString" });//获取连接字符串
    }
}

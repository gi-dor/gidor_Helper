using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gidor_Helper.Util
{
    internal class DB_Connect
    {
        // 데이터베이스 연결
        public static String uid = "";
        public static String password = "";  
        public static String database = "";
        public static String server = "";

        public static String conStr = $"Server={server}; Database={database}; User Id={uid}; Password={password}; Integrated Security=True";
    }
}

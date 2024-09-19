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
        public static String uid = "DESKTOP-TFDKFVS\\Daun";
        public static String password = "";  // 비밀번호가 없으므로 빈 문자열
        public static String database = "giseonDB";
        public static String server = "localhost";

        public static String conStr = $"Server={server}; Database={database}; User Id={uid}; Password={password}; Integrated Security=True";
    }
}

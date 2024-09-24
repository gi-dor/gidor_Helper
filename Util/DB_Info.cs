using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace gidor_Helper.Util
{
    internal class DB_Info
    {
      public static string Get91PortConnect()
        {
             String uid = "";
             String password = "";
             String database = "";
             String server = "";

             String conStr = $"Server={server}; Database={database}; User Id={uid}; Password={password}; ";

             return conStr;
        }

         public static String Get92PortConnect()
        {
            String uid = "";
            String password = "";
            String database = "";
            String server = "";

            String conStr = $"Server={server}; Database={database}; User Id={uid}; Password={password}; ";

            return conStr;
        }



    }
}

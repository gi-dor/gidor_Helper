using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gidor_Helper.Util
{
    internal class QueryUsing
    {

        /*
          using (SqlCommand cmd = new SqlCommand(sqlQuery운영구분, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        운영구분_combo.Items.Add($"{reader["운영구분"]}");
                    }
                    reader.Close();
                }

        // sql운영구분 , 운영구분_combo , "운영구분" 
        public void test(String query , Combo combo , String column){
              using (SqlCommand cmd = new SqlCommand(query, conn)){
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        Combo combo.Items.Add("${reader[column]}")
                    }
                   reader.Close();
                }
            }

         */

        // 반복되는 쿼리로 인한 메서드 생성
        public static void ComboTest(String sqlQuery , ComboBox comboBox , String column , SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // 콤보박스이름.Items.Add($"{reader[각각의 컬럼명]}")
                    comboBox.Items.Add($"{reader[column]}");
                }
                reader.Close();
            }
        }
    
    }
}

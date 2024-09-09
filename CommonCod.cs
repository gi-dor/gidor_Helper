using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gidor_Helper.Util;

namespace gidor_Helper
{
    public partial class CommonCod : Form
    {
        public CommonCod()
        {
            InitializeComponent();
        }

        private void CommonCod_Load(object sender, EventArgs e)
        {
            try
            {
              
                // using문을 사용하면 dispose() 또는 close()를 사용하지 않아도된다
                // 만약 dispose() , close() , using() {} 을 사용하지 않는다면 메모리 누수 현상이 발생한다고 한다

                // DB_Connect 클래스에있는 conStrt을 가져와 사용한다
                using (SqlConnection conn = new SqlConnection(DB_Connect.conStr))
                {
                    conn.Open();
                    MessageBox.Show("Success , DB 연결 되었습니다  ", "DB 연결메세지", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 해당 컬럼의 ReadOnly 속성 true 
                    cod_dataGridView1.ReadOnly = true;
                    cod_dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }

            } catch(Exception ex)
            {
                MessageBox.Show($"DB 연결실패 \r\n Error : {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CodeManageButton_Click(object sender, EventArgs e)
        {
            try
            {
                String sqlQuery = " SELECT " +
                                  "     COD_NO          , " +
                                  "     COD             , " +
                                  "     COD_CONT        , " +
                                  "     COD_SLT         , " +
                                  "     CREATED_DATE    , " +
                                  "     END_DATE        , " +
                                  "     TRS_ID          , " +
                                  "     TRS_NAME        , " +
                                  "     TRS_DATE " +
                                  "FROM dbo.COD order by COD_NO ASC";

                using (SqlConnection conn = new SqlConnection(DB_Connect.conStr))
                {
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    int rowCount = dataTable.Rows.Count;
                    count_value.Text = $" {rowCount}";


                    // 기존의 모든 행을 제거합니다.
                    cod_dataGridView1.Columns.Clear();


                    // 데이터 테이블을 DataGridView에 연결
                    cod_dataGridView1.DataSource = dataTable;
                }

            } catch(Exception ex)
            {
                MessageBox.Show($"데이터 조회 실패 \r\n Error : {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

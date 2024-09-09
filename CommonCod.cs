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

        private void CodeSelectButton_Click(object sender, EventArgs e)
        {
            try
            {
                String sqlQuery = " SELECT " +
                                  "     COD_NO, " +
                                  "     COD , " +
                                  "     COD_CONT    as  코드내용 , " +
                                  "     COD_SLT     as  코드상태 , " +
                                  "     CREATED_DATE    as 생성일자 , " +
                                  "     END_DATE , " +
                                  "     TRS_ID , " +
                                  "     TRS_NAME , " +
                                  "     TRS_DATE " +
                                  "FROM dbo.COD";

                // WHERE 절을 담을 리스트
                List<string> where = new List<string>();

                // TextBox에 입력한 값이 빈문자열이 아니거나 , 공백이 아니라면 진행한다

                // TextBox1 값이 있는 경우 조건 추가 (COD)
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    where.Add($"COD LIKE '%{textBox1.Text}%'");
                }

                // TextBox2 값이 있는 경우 조건 추가 (COD_CONT)
                if (!string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    where.Add($"COD_CONT LIKE '%{textBox2.Text}%'");
                }

                // TextBox3 값이 있는 경우 조건 추가 (COD_SLT)
                if (!string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    where.Add($"COD_SLT LIKE '%{textBox3.Text}%'");
                }

                // TextBox4 값이 있는 경우 조건 추가 (CREATED_DATE)
                if (!string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    where.Add($"CREATED_DATE LIKE '%{textBox4.Text}%'");
                }

                // where 리스트 조건에 1개이상 있는지 확인
                // 1개 이상 있다면 WHERE절 추가

                // tring.Join -> 조건 LIKE '%ABC%' OR 조건 LIKE '%QWE%로 변환된다고 한다
                // += 로인해  sqlQuery 뒤에 where 조건을 추가한다
                if (where.Count > 0)
                {
                    sqlQuery += " WHERE " + string.Join(" OR ", where);
                }



                using (SqlConnection conn =  new SqlConnection(DB_Connect.conStr))
                {
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                    // 가져온 데이터를 담기
                    DataTable dataTable = new DataTable();

                    // 데이터 어댑터를 통해 데이터를 데이터 테이블에 채움
                    dataAdapter.Fill(dataTable);

                    // 조회된 건수를 Label에 표시
                    int rowCount = dataTable.Rows.Count;
                    count_value.Text = $" {rowCount}";

                    // 기존의 모든 행을 제거합니다.
                    cod_dataGridView1.Columns.Clear();


                    // 데이터 테이블을 DataGridView에 연결
                    cod_dataGridView1.DataSource = dataTable;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 조회 실패 \r\n Error : {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

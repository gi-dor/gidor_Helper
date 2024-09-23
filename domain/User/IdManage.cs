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

namespace gidor_Helper.domain.User
{
    public partial class IdManage : Form
    {
        public IdManage()
        {
            InitializeComponent();
        }

        private void IaManage_Load(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(DB_Connect.conStr))
                {
                    conn.Open();
                    MessageBox.Show("Success, DB 연결 되었습니다", "DB 연결 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 해당 컬럼의 ReadOnly 속성 true
                    Id_dataGridView1.ReadOnly = true;
                    Id_dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }

            } catch (Exception ex)
            {
                MessageBox.Show($"DB 연결이 실패 되었습니다 \r\n Error : {ex.Message} ", "DB Connect Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SELECT_ALL_BUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(DB_Connect.conStr))
                {

                    String sqlQuery = "SELECT A.USR_ID as '사용자 ID', " +
                                            " A.USR_NAME  as '사용자' , " +
                                            " A.PSD as '비밀번호' ," +
                                            " A.CUST_ID as '거래처 고객사' , " +
                                            " A.BRA_ID as  '영업소' ," +
                                            " A.AGY_ID as '지점' ," +
                                            " B.COD_CONT as '사용자 권한'," +
                                            " A.CRE_DATE as '생성일자' , " +
                                            " A.EDIT_DATE as '변경일자' ," +
                                            " A.END_DATE  as '종료일자' " +
                                        "FROM dbo.LS902T0 A " +
                                        "INNER JOIN dbo.COD B " +
                                        " ON B.COD = A.USR_PER " +
                                        "ORDER BY A.USR_ID ASC";

                    // SQL 쿼리를 실행시작 객체
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                    // 실행한 객체 cmd 를 담아서 DB에서 데이터를 가져온다
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                    // 데이터 담기
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    Id_dataGridView1.Columns.Clear();

                    Id_dataGridView1.DataSource = dataTable;

                    Id_dataGridView1.ReadOnly = true;
                    Id_dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                }

            } catch (Exception ex)
            {
                MessageBox.Show($"데이터 조회 실패 \r\n Error: {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 사용자 상세정보 조회
        private void Id_Detail(object sender, DataGridViewCellEventArgs e)
        {
            // 보여진 행의 인덱스는 0부터 시작한다 그러므로 인덱스가 0보다 같거나 큰 행을 선택해야 작동하게 만들어야 하므로 RowIndex >=0 으로 설정했다 
            if(e.RowIndex >= 0)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(DB_Connect.conStr))
                    {

                        DataGridViewRow row = Id_dataGridView1.Rows[e.RowIndex];

                        user_id_text.Text = row.Cells[0].Value.ToString();
                        user_name_text.Text = row.Cells[1].Value.ToString();
                        user_psd_text.Text = row.Cells[2].Value.ToString();
                        user_cust_id_text.Text = row.Cells[3].Value.ToString();
                        user_per_text.Text = row.Cells[6].Value.ToString();
                        user_braid_text.Text = row.Cells[4].Value.ToString();

                        cre_date_text.Text = row.Cells[7].Value.ToString();
                        edit_date_text.Text = row.Cells[8].Value.ToString();
                        end_date_text.Text = row.Cells[9].Value.ToString();

                    }
                } catch (Exception ex)
                {
                    MessageBox.Show($"물류 사용자 상세 데이터 조회 실패 \r\n Error: {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

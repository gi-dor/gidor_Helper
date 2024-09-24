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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                using(SqlConnection conn = new SqlConnection(DB_Info.Get91PortConnect()))
                {
                    conn.Open();
                    MessageBox.Show($"Success, DB 연결 되었습니다 \r\n{DB_Info.Get91PortConnect()}", "DB 연결 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                using (SqlConnection conn = new SqlConnection(DB_Info.Get91PortConnect() ) )
                {

                    String sqlQuery = "SELECT DISTINCT  A.USR_ID as '사용자 ID', " +
                                            " A.USR_NAME  as '사용자' , " +
                                            " A.PSD as '비밀번호' ," +
                                            " C.CUST_NAME  as '거래처 고객사' , " +
                                            " D.BRA_NAME as  '영업소' ," +
                                            " A.AGY_ID as '지점' ," +
                                            " B.COD_CONT as '사용자 권한'," +
                                            " A.CRE_DATE as '생성일자' , " +
                                            " A.EDIT_DATE as '변경일자' ," +
                                            " A.END_DATE  as '종료일자' , " +
                                            " A.RMK         as '비고'" +
                                        "FROM SLIS_MASTER.dbo.LS902T0 A " +
                                        " INNER JOIN SLIS_MASTER.dbo.LS901T0 B ON B.COD = A.USR_PER " +
                                        " LEFT JOIN SLIS_MASTER.dbo.LS401T0 C ON C.CUST_ID = A.CUST_ID " +  // 고객사 정보
                                        " LEFT JOIN SLIS_MASTER.dbo.LS801T0 D ON D.BRA_ID = A.BRA_ID " +  // 영업소 정보                
                                        " ORDER BY A.USR_ID ASC";

                    // SQL 쿼리를 실행시작 객체
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                    // 실행한 객체 cmd 를 담아서 DB에서 데이터를 가져온다
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                    // 데이터 담기
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    int row = dataTable.Rows.Count;
                    rowCount.Text = $" {row}";

                    Id_dataGridView1.Columns.Clear();

                    Id_dataGridView1.DataSource = dataTable;

                    Id_dataGridView1.ReadOnly = true;
                    Id_dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                }

            } catch (Exception ex)
            {
                MessageBox.Show($"모든 사용자 데이터 조회 실패 \r\n Error: {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    using (SqlConnection conn = new SqlConnection(DB_Info.Get91PortConnect()))
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
                        rmk_text.Text = row.Cells[10].Value.ToString();

                    }
                } catch (Exception ex)
                {
                    MessageBox.Show($"물류 사용자 상세 데이터 조회 실패 \r\n Error: {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

 

        private void WhereSelect_Click(object sender, EventArgs e)
        {
            try
            {

                String sqlQuery = " SELECT DISTINCT  " +
                                            " A.USR_ID as '사용자 ID', " +
                                            " A.USR_NAME  as '사용자' , " +
                                            " A.PSD as '비밀번호' ," +
                                            " C.CUST_NAME  as '거래처 고객사' , " +
                                            " D.BRA_NAME as  '영업소' ," +
                                            " A.AGY_ID as '지점' ," +
                                            " B.COD_CONT as '사용자 권한'," +
                                            " A.CRE_DATE as '생성일자' , " +
                                            " A.EDIT_DATE as '변경일자' ," +
                                            " A.END_DATE  as '종료일자' ," +
                                            " A.RMK         as '비고' "  +
                                        "FROM SLIS_MASTER.dbo.LS902T0 A " +
                                        " INNER JOIN SLIS_MASTER.dbo.LS901T0 B ON B.COD = A.USR_PER " +
                                        " LEFT JOIN SLIS_MASTER.dbo.LS401T0 C ON C.CUST_ID = A.CUST_ID " +  // 고객사 정보
                                        " LEFT JOIN SLIS_MASTER.dbo.LS801T0 D ON D.BRA_ID = A.BRA_ID ";  // 영업소 정보 


                // null ,공백 변수에담기
                Boolean whereCustName = !String.IsNullOrEmpty(CUST_NAME_LIKE.Text);
                Boolean whereUsrName = !String.IsNullOrEmpty(USR_NAME_LIKE.Text);
                Boolean whereUsrId = !String.IsNullOrEmpty(USR_ID_LIKE.Text);
                Boolean whereBraId = !String.IsNullOrEmpty(BRA_ID_TEXT.Text);

                Boolean whereCustName2 = !String.IsNullOrWhiteSpace(CUST_NAME_LIKE.Text);
                Boolean whereUsrName2 = !String.IsNullOrWhiteSpace(USR_NAME_LIKE.Text);
                Boolean whereUsrId2 = !String.IsNullOrWhiteSpace(USR_ID_LIKE.Text);
                Boolean whereBraId2 = !String.IsNullOrWhiteSpace(BRA_ID_TEXT.Text);



                // 3번쨰 버전
                if (whereCustName || whereUsrName || whereUsrId || whereBraId)
                {
                    sqlQuery += " WHERE ";


                    // 1번 조건 거래처 이름
                    // 1번 조건의 Text가 존재한다면 
                    if (whereCustName)
                    {
                        sqlQuery += $" CUST_NAME LIKE '%{CUST_NAME_LIKE.Text}%' ";
                        // WHERE CUST_NAME LIKE %조건&' 
                    }

                    // 2번 조건 사용자 이름
                    // 2-1 1번 조건이 없다면 USR_NAME LIKE '%조건%'

                    // 2-2 첫번쨰 조건이 존재한다면 AND USR_NAME LIKE '%조건%'  
                    if (whereUsrName)
                    {
                        if (whereCustName)
                        {
                            sqlQuery += " AND ";
                        }
                        sqlQuery += $"USR_NAME LIKE '%{USR_NAME_LIKE.Text}%' ";
                    }



                    // 3번 조건 사용자 ID 1번 그리고 2번 조건이 없다면  USR_ID LIKE '%조건%'

                    // 3-2 1번 또는 2번 조건이 하나라도 존재 한다면 AND USR_ID LIKE '%조건%'
                    if (whereUsrId)
                    {
                        if (whereCustName || whereUsrName)
                        {
                            sqlQuery += " AND ";
                        }
                        sqlQuery += $"USR_ID LIKE '%{USR_ID_LIKE.Text}%'";
                    }

                    // 4번 조건 영업소
                    if (!String.IsNullOrEmpty(BRA_ID_TEXT.Text))
                    {
                        // 1번 2번 3번 중 하나의 조건이라도 존재한다면 AND 를 사용해 where 조건문을 추가한다
                        if (whereCustName || whereUsrName || whereUsrId)
                        {
                            sqlQuery += " AND ";
                        }
                        // 1번 2번 3번 조건 모두 존재하지 않다면 앞서 존재하는 sqlQuery = " WHERE " + BRA_NAME LIKE '%조건%'
                        sqlQuery += $"BRA_NAME LIKE '%{BRA_ID_TEXT.Text}%'";
                    }

                }

                sqlQuery += " ORDER BY A.USR_ID ASC";



                /* 2번째 버전
                if (!String.IsNullOrEmpty(CUST_NAME_LIKE.Text) || !String.IsNullOrEmpty(USR_NAME_LIKE.Text) || 
                    !String.IsNullOrEmpty(USR_ID_LIKE.Text) || !String.IsNullOrEmpty(BRA_ID_TEXT.Text))
                {
                    sqlQuery += " WHERE ";


                    // 1번 조건 거래처 이름
                   // 1번 조건의 Text가 존재한다면 
                    if (!String.IsNullOrEmpty(CUST_NAME_LIKE.Text))
                    {
                        sqlQuery += $" CUST_NAME LIKE '%{CUST_NAME_LIKE.Text}%' ";
                        // WHERE CUST_NAME LIKE %조건&' 
                    }

                    // 2번 조건 사용자 이름
                    // 2-1 1번 조건이 없다면 USR_NAME LIKE '%조건%'

                    // 2-2 첫번쨰 조건이 존재한다면 AND USR_NAME LIKE '%조건%'  
                    if (!String.IsNullOrWhiteSpace(USR_NAME_LIKE.Text))
                    {
                        if(!String.IsNullOrEmpty(CUST_NAME_LIKE.Text)) {
                            sqlQuery += " AND ";
                        }   
                        sqlQuery += $"USR_NAME LIKE '%{USR_NAME_LIKE.Text}%' ";
                    }
             


                    // 3번 조건 사용자 ID 1번 그리고 2번 조건이 없다면  USR_ID LIKE '%조건%'

                    // 3-2 1번 또는 2번 조건이 하나라도 존재 한다면 AND USR_ID LIKE '%조건%'
                    if (!String.IsNullOrWhiteSpace(USR_ID_LIKE.Text))
                    {
                        if (!String.IsNullOrEmpty(CUST_NAME_LIKE.Text) || !String.IsNullOrEmpty(USR_NAME_LIKE.Text)) {
                            sqlQuery += " AND ";
                        }
                        sqlQuery += $"USR_ID LIKE '%{USR_ID_LIKE.Text}%'";
                    }

                    // 4번 조건 영업소
                    if(!String.IsNullOrEmpty(BRA_ID_TEXT.Text))
                    {
                        // 1번 2번 3번 중 하나의 조건이라도 존재한다면 AND 를 사용해 where 조건문을 추가한다
                        if(!String.IsNullOrEmpty(CUST_NAME_LIKE.Text) || !String.IsNullOrEmpty(USR_NAME_LIKE.Text) || !String.IsNullOrEmpty(USR_ID_LIKE.Text))
                        {
                            sqlQuery += " AND ";
                        }
                        // 1번 2번 3번 조건 모두 존재하지 않다면 앞서 존재하는 sqlQuery = " WHERE " + BRA_NAME LIKE '%조건%'
                        sqlQuery += $"BRA_NAME LIKE '%{BRA_ID_TEXT.Text}%'";
                    }

                }

                sqlQuery += " ORDER BY A.USR_ID ASC";
                */




                /*  초기 버전
                List<String> where = new List<String>();

                if (!String.IsNullOrWhiteSpace(CUST_NAME_LIKE.Text))
                {
                    where.Add($"CUST_NAME LIKE '%{CUST_NAME_LIKE.Text}%'");
                }

                if (!String.IsNullOrWhiteSpace(USR_NAME_LIKE.Text))
                {
                    where.Add($"USR_NAME LIKE '%{USR_NAME_LIKE.Text}%'");
                }

                if(!String.IsNullOrWhiteSpace(USR_ID_LIKE.Text))
                {
                    where.Add($"USR_ID LIKE '%{USR_ID_LIKE.Text}%'");
                }

                // where 리스트 조건에 1개이상 있는지 확인
                // 1개 이상 있다면 WHERE절 추가

                // tring.Join -> 조건 LIKE '%ABC%' OR 조건 LIKE '%QWE%로 변환된다고 한다
                // += 로인해  sqlQuery 뒤에 where 조건을 추가한다
                if (where.Count > 0)
                {
                    sqlQuery += " WHERE " + string.Join(" OR ", where);
                }
                */


                using (SqlConnection conn = new SqlConnection(DB_Info.Get91PortConnect()))
                {
                    // SQL 쿼리를 실행시작 객체
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                    // 실행한 객체 cmd 를 담아서 DB에서 데이터를 가져온다
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                    // 데이터 담기
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    int row = dataTable.Rows.Count;
                    rowCount.Text = $" {row}";

                    Id_dataGridView1.Columns.Clear();

                    Id_dataGridView1.DataSource = dataTable;

                    Id_dataGridView1.ReadOnly = true;
                    Id_dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }

            } catch (Exception ex)
            {
                MessageBox.Show($"조건 선택 데이터 조회 실패 \r\n Error: {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

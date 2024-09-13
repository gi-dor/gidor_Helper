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

namespace gidor_Helper.domain.ScanData
{
    public partial class ScanData : Form
    {
        public ScanData()
        {
            InitializeComponent();
        }

        private void ScannData_Load(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(DB_Connect.conStr))
                {
                    conn.Open();
                    MessageBox.Show("Success, DB 연결 되었습니다", "DB 연결 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 해당 컬럼의 ReadOnly 속성 true
                    ScanDataGridView1.ReadOnly = true;
                    ScanDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            } catch(Exception ex)
            {
                MessageBox.Show($"DB 연결 실패 \r\n Error: {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SELECT_ALL_BUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(DB_Connect.conStr))
                {
                    String sqlQuery = "SELECT  " +
                                            "A.INV_NO ,         " +
                                            "A.BRA_ID ,         " +
                                            "A.SCANN_SLT,       " +
                                            "B.COD_CONT,        " +
                                            "A.SCANN_DATE,      " +
                                            "A.SCANN_TIME,      " +
                                            "A.CAR_ID  ,        " +
                                            "A.SCANN_USR_ID  ,  " +
                                            "A.TRS_ID   ,       " +
                                            "A.TRS_NAME ,       " +
                                            "A.TRS_DATE " +
                                         " FROM LS101T0 A " +
                                         " INNER JOIN COD B " +
                                         " ON A.SCANN_SLT = B.COD " +
                                         " ORDER BY A.SCANN_DATE DESC";

                    // SQL 쿼리를 실행시작 객체
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                    // 실행한 객체 cmd 를 담아서 DB에서 데이터를 가져온다
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                    // 데이터 담기
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);


                    ScanDataGridView1.Columns.Clear();

                    int rowCount = dataTable.Rows.Count;
                    count_value.Text = $" {rowCount}";

                    ScanDataGridView1.DataSource = dataTable;

                    ScanDataGridView1.ReadOnly = true;
                    ScanDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    ScanDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
            } catch(Exception ex)
            {
                MessageBox.Show($"데이터 조회 실패 \r\n Error: {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        // 행 클릭시 해당하는 송장번호에 대한 상세 검색
        private void ScannDetail(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(DB_Connect.conStr))
                    {
                        // 선택된 행의 0번째 컬럼으로 지정을해야 INV_NO 송장에 대한 값을 사용
                        String selectColumn = ScanDataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                        String sqlQuery = "SELECT " +
                                            " A.INV_NO          , " +
                                            " A.BRA_ID          ,  " +
                                            " A.SCANN_SLT       , " +
                                            " B.COD_CONT        , " +
                                            " A.SCANN_DATE      , " +
                                            " A.SCANN_TIME      , " +
                                            " A.CAR_ID          , " +
                                            " A.SCANN_USR_ID    , " +
                                            " A.TRS_ID          ,  " +
                                            " A.TRS_NAME        , " +
                                            " A.TRS_DATE " +
                                            " FROM LS101T0 A " +
                                            " INNER JOIN COD B " +
                                            " ON A.SCANN_SLT = B.COD " +
                                            $" WHERE INV_NO = '{selectColumn}' " ;

                        SqlCommand sqlCommand = new SqlCommand(sqlQuery, conn);
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                        DataTable dataTable = new DataTable();

                        sqlDataAdapter.Fill(dataTable);

                        ScanDataGridView2.Columns.Clear();

                        ScanDataGridView2.DataSource = dataTable;

                        ScanDataGridView2.ReadOnly = true;
                        ScanDataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        ScanDataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    }
                } catch(Exception ex)
                {
                    MessageBox.Show($"데이터 조회 실패 \r\n Error: {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        // 조건 조회
        private void SELECT_BUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DB_Connect.conStr))
                {
                    String sqlQuery = "SELECT  " +
                                            "A.INV_NO ,         " +
                                            "A.BRA_ID ,         " +
                                            "A.SCANN_SLT,        " +
                                            "B.COD_CONT ,       " +
                                            "A.SCANN_DATE,      " +
                                            "A.SCANN_TIME,      " +
                                            "A.CAR_ID  ,        " +
                                            "A.SCANN_USR_ID  ,  " +
                                            "A.HTT_ID   ,       " +
                                            "A.TRS_ID   ,       " +
                                            "A.TRS_NAME ,       " +
                                            "A.TRS_DATE         " +
                                         " FROM LS101T0 A " +
                                         " INNER JOIN COD B " +
                                         " ON A.SCANN_SLT = B.COD " ;

                    List<string> where = new List<string>();

                   

                    if (!String.IsNullOrWhiteSpace(textBox1.Text))
                    {
                        where.Add($"INV_NO LIKE '%{textBox1.Text}%'");
                    }

                    if (!String.IsNullOrWhiteSpace(textBox2.Text))
                    {
                        where.Add($"BRA_ID LIKE '%{textBox2.Text}%'");
                    }



                    /* 
                     * 1. textBox3 와 textBox4 값 둘다 입력되었을 때는 Between A And B를 사용한다
                       2. textBox3 값만 입력 할 때                  
                       3. textBox4 값만 입력할 때 
                    */

                    if (!String.IsNullOrWhiteSpace(textBox3.Text) && !String.IsNullOrWhiteSpace(textBox4.Text))
                    {
                        where.Add($"SCANN_DATE BETWEEN '{textBox3.Text}' AND '{textBox4.Text}'");
                    } else if(!String.IsNullOrWhiteSpace(textBox3.Text) )
                    {
                        where.Add($"SCANN_DATE LIKE '%{textBox3.Text}%'");
                    } else if (!String.IsNullOrWhiteSpace(textBox4.Text))
                    {
                        where.Add($"SCANN_DATE LIKE '%{textBox4.Text}%'");
                    }

         
                   

                    // WHERE 조건이 하나라도 있을 때만 추가
                    if (where.Count > 0)
                    {
                        sqlQuery += " WHERE " + string.Join(" OR ", where);
                    }



                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    ScanDataGridView1.Columns.Clear();

                    int rowCount = dataTable.Rows.Count;
                    count_value.Text = $" {rowCount}";

                    ScanDataGridView1.DataSource = dataTable;


                    ScanDataGridView1.ReadOnly = true;
                    ScanDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    ScanDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
            } catch(Exception ex)
            {
                MessageBox.Show($"데이터 조회 실패 \r\n Error: {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // 스캔 상태 1개 삭제
        private void DELETE_SELECT_BUTTON_Click(object sender, EventArgs e)
        {
            try
            {   

                // 선택된 행이 0보다 크다면 
                if (ScanDataGridView2.SelectedRows.Count > 0 )
                {
                    using (SqlConnection conn = new SqlConnection(DB_Connect.conStr))
                    {
                        conn.Open();

                        // 선택한 행의 컬럼INV_NO , SCANN_SLT를 인덱스로 설정하지 않고 직접 설정해 값을 가져와 toString()
                        String INV_NO = ScanDataGridView2.SelectedRows[0].Cells["INV_NO"].Value.ToString();
                        String SCANN_SLT = ScanDataGridView2.SelectedRows[0].Cells["SCANN_SLT"].Value.ToString();

                        // scandatagridView2 에서 빈 행을 선택후 , 삭제 요청시 생서되는 null 예외 처리하기
                        if (String.IsNullOrWhiteSpace(SCANN_SLT) || String.IsNullOrWhiteSpace(INV_NO) ) 
                        {
                            MessageBox.Show("삭제할 행을 선택하지 않았습니다.", "실패 메세지", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }


                        String sqlQuery = "DELETE FROM LS101T0 " +
                                            $" WHERE INV_NO = '{INV_NO}' " +
                                            $" AND SCANN_SLT = '{SCANN_SLT}' ";


                        using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, conn))
                        {
                            // ExecuteNonQuery() INSERT, UPDATE, DELETE와 같은 데이터 변경 작업에 사용되며. 이 메서드는 데이터베이스에서 변화가 생긴 행의 갯수를 반환
                            int deleteRow = sqlCommand.ExecuteNonQuery();

                            // 실행된 쿼리 결과 확인
                            if (deleteRow > 0)
                            {
                                MessageBox.Show("행이 성공적으로 삭제되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // 삭제된 행을 DataGridView에서 제거
                                ScanDataGridView2.Rows.RemoveAt(ScanDataGridView2.SelectedRows[0].Index);
                            }
                            else
                            {
                                MessageBox.Show("삭제할 행을 찾을 수 없습니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"데이터 삭제 실패 \r\n Error: {ex.Message}", "DB Delete Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ScannDataGridView2 에 선택된 행 수정 기능
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 선택된 행이 1개 일때만 가능하게 
                if(ScanDataGridView2.SelectedRows.Count == 1)
                {
                    using (SqlConnection conn = new SqlConnection(DB_Connect.conStr))
                    {
                        conn.Open();

                        // 선택한 행에서 각 컬럼에 데이터를 변수에 담자!
                        String scannDate = ScanDataGridView2.SelectedRows[0].Cells["SCANN_DATE"].Value.ToString();
                        String scannTime = ScanDataGridView2.SelectedRows[0].Cells["SCANN_TIME"].Value.ToString();
                        String trsDate = ScanDataGridView2.SelectedRows[0].Cells["TRS_DATE"].Value.ToString();
                        
                        String invNo = ScanDataGridView2.SelectedRows[0].Cells["INV_NO"].Value.ToString();
                        String braId = ScanDataGridView2.SelectedRows[0].Cells["BRA_ID"].Value.ToString();
                        String scannSlt = ScanDataGridView2.SelectedRows[0].Cells["SCANN_SLT"].Value.ToString();


                        // scandatagridView2 에서 빈 행을 선택후 , 수정 요청시 생서되는 null 예외 처리하기
                        if (String.IsNullOrWhiteSpace(scannDate) || String.IsNullOrWhiteSpace(scannTime) ||
                            String.IsNullOrWhiteSpace(trsDate) || String.IsNullOrWhiteSpace(invNo) ||
                            String.IsNullOrWhiteSpace(braId) || String.IsNullOrWhiteSpace(scannSlt) ) 
                        {
                            MessageBox.Show("수정을 진행 할 행을 선택하지 않았습니다.", "실패 메세지", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        String sqlQuery = "UPDATE LS101T0 SET " +
                                            $"SET SCANN_DATE = '{SCANN_DATE_TEXT.Text}' , SCANN_TIME = '{SCANN_TIME_TEXT.Text}' , TRS_DATE = {TRS_DATE_TEXT.Text}" +
                                        $"WHERE INV_NO = {invNo} " +
                                        $" AND SCANN_DATE = {scannDate} " +
                                        $" AND SCANN_TIME = {scannTime} " +
                                        $" AND TRS_DATE = {trsDate} " +
                                        $" AND BRA_ID =  {braId} " +
                                        $" AND SCANN_SLT =  {scannSlt} ";
                                      
                        using(SqlCommand sqlCommand = new SqlCommand(sqlQuery,conn))
                        {
                            // ExecuteNonQuery() INSERT, UPDATE, DELETE와 같은 데이터 변경 작업에 사용되며. 이 메서드는 데이터베이스에서 변화가 생긴 행의 갯수를 반환
                            int updateRow = sqlCommand.ExecuteNonQuery();

                            // 실행된 쿼리 결과 확인
                            if (updateRow > 0)
                            {
                                MessageBox.Show("행이 성공적으로 수정 되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                RefreshDataGridView();

                            }
                            else
                            {
                                MessageBox.Show("수정 할 행을 찾을 수 없습니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                    }
                    // 선택된 행이 2개부터 일때 
                } else if(ScanDataGridView2.SelectedRows.Count > 1)
                {
                    MessageBox.Show($"수정에 대한 건은 1번에 1개의 행만 가능합니다 \r\n" , "DB Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    // 그외 조건은 선택된 행이 없을때
                    MessageBox.Show($"수정을 하기 위해서는 1개의 행을 선택해야 합니다 \r\n", "DB Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } catch (Exception ex)
            {
                MessageBox.Show($"데이터 수정 실패 \r\n Error: {ex.Message}", "DB Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RefreshDataGridView()
        {
            // DataGridView의 데이터 소스를 새로 고침하는 방법
            // 예를 들어, 데이터베이스에서 데이터를 다시 로드하는 방법
            string query = "SELECT * FROM LS101T0"; // 필요한 쿼리로 변경

            using (SqlConnection conn = new SqlConnection(DB_Connect.conStr))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                ScanDataGridView2.DataSource = dataTable;
            }
        }
    }
}

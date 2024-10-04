using System;
using System.Collections;
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
                using (SqlConnection conn = new SqlConnection(DB_Info.Get91PortConnect()))
                {
                    conn.Open();
                    MessageBox.Show($"Success , DB 연결 되었습니다 \r\n{DB_Info.Get91PortConnect()} ", "DB 연결 성공 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 해당 컬럼의 ReadOnly 속성 true
                    ScanDataGridView1.ReadOnly = true;
                    ScanDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    String sqlQuery = "SELECT BRA_ID , BRA_NAME FROM SLIS_MASTER.dbo.LS801T0 ";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            /*
                            BRA_COMBO.Items.Add(reader["BRA_ID"]);
                            BRA_COMBO.Items.Add(reader["BRA_NAME"]);
                            */
                            // BRA_COMBO.Items.Add(reader["BRA_ID"], reader["BRA_NAME"]);
                            // BRA_COMBO.Items.Add(reader["BRA_ID"] ,  reader["BRA_NAME"] );
                            BRA_COMBO.Items.Add($"{reader["BRA_ID"]} {reader["BRA_NAME"]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"DB 연결 실패 \r\n Error: {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




     
        // 전체 조회 - SCANN_DATE , SCANN_TIME 에 따른 정렬
        private void SELECT_ALL_BUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(DB_Info.Get91PortConnect()))
                {
                    String sqlQuery = "SELECT top 5000 " +
                                            " A.INV_NO       as '송장번호'      ," +
                                            " A.BRA_ID + ' ' + C.BRA_NAME     as '영업소' , " +
                                            " A.SCANN_SLT + ' ' + B.COD_CONT  as '스캔 상태'   , " +
                                            " A.SCANN_DATE   as '스캔 일자'     , " +
                                            " A.SCANN_TIME   as '스캔 시간'     , " +
                                            " A.CAR_ID       as '배송 차량'     , " +
                                            " A.SCANN_USR_ID as '스캔 ID'       , " +
                                            " A.TRS_ID       as '처리자 ID'     , " +
                                            " A.TRS_NAME    as '처리자 명'     , " +
                                            " A.TRS_DATE    as '처리 일자'       " +
                                          " FROM SLIS_MASTER.dbo.LS101T0 A " +
                                          " INNER JOIN SLIS_MASTER.dbo.LS901T0 B ON A.SCANN_SLT = B.COD  " +
                                          " INNER JOIN SLIS_MASTER.dbo.LS801T0 C ON A.BRA_ID = C.BRA_ID " +
                                         " ORDER BY A.SCANN_DATE DESC ";

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
                    
                    DataView dataView = dataTable.DefaultView;
                    dataView.Sort = " 스캔 시간 DESC ";
                    ScanDataGridView1.DataSource = dataView.ToTable();

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
        // SCANN_DATE , SCANN_TIME 으로 정렬
        private void ScannDetail(object sender, DataGridViewCellEventArgs e)
        {
            // 선택한 행이 1개는 있어야하니 0보다 크게 설정 ?
            if(e.RowIndex > 0)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(DB_Info.Get91PortConnect()))
                    {
                        // 선택된 행의 0번째 컬럼으로 지정을해야 INV_NO 송장에 대한 값을 사용
                        String selectColumn = ScanDataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                        String sqlQuery = "SELECT " +
                                            " A.INV_NO       as '송장번호'      ," +
                                            " A.BRA_ID + ' ' + C.BRA_NAME      as '영업소' , " +
                                            " A.SCANN_SLT + ' ' + B.COD_CONT   as '스캔 상태'   , " +
                                            " A.SCANN_DATE   as '스캔 일자'     , " +
                                            " A.SCANN_TIME   as '스캔 시간'     , " +
                                            " A.CAR_ID       as '배송 차량'     , " +
                                            " A.SCANN_USR_ID as '스캔 ID'       , " +
                                            " A.TRS_ID       as '처리자 ID'     , " +
                                            " A.TRS_NAME     as '처리자 명'     , " +
                                            " A.TRS_DATE     as '처리 일자'        " +
                                            " FROM SLIS_MASTER.dbo.LS101T0 A " +
                                            " INNER JOIN SLIS_MASTER.dbo.LS901T0 B ON A.SCANN_SLT = B.COD  " +
                                            " INNER JOIN SLIS_MASTER.dbo.LS801T0 C ON A.BRA_ID = C.BRA_ID " +
                                            $" WHERE INV_NO = '{selectColumn}' " +
                                            $" ORDER BY A.SCANN_DATE , A.SCANN_TIME ASC" ;

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

        /**
         * 
         * 조건 조회시 dataGridView2 SCANN_DATE , SCANN_TIME 순서에 맞게 정렬 기능 추가 해야함
         * 
         * 
         */


        // 조건 조회 
        // 1. 조건 조회를 위해 text 값을 입력해야 작동하게
        private void SELECT_BUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean INV_NO = !String.IsNullOrEmpty(textBox1.Text);
                Boolean BRA_ID = !String.IsNullOrEmpty(BRA_COMBO.Text);
                Boolean SCANN_DATE_A = !String.IsNullOrEmpty(textBox3.Text);
                Boolean SCANN_DATE_B = !String.IsNullOrEmpty(textBox4.Text);


                if (!(INV_NO || BRA_ID || SCANN_DATE_A || SCANN_DATE_B))
                {
                    MessageBox.Show($"조건 조회를 위해 값을 입력해주세요 \r\n조건을 조회 하기위한  값이 입력되지 않았습니다", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // return 문을 추가해 기존에 조건값 없이 조회 실행시 실패 메시지 이후 전체 조회 되는 기능을 제어했다
                    return;
                }

                String sqlQuery = "SELECT " +
                                        " A.INV_NO       as '송장번호'      ," +
                                            " A.BRA_ID + ' ' + C.BRA_NAME      as '영업소' , " +
                                            " A.SCANN_SLT + ' ' + B.COD_CONT   as '스캔 상태'   , " +
                                            " A.SCANN_DATE   as '스캔 일자'     , " +
                                            " A.SCANN_TIME   as '스캔 시간'     , " +
                                            " A.CAR_ID       as '배송 차량'     , " +
                                            " A.SCANN_USR_ID as '스캔 ID'       , " +
                                            " A.TRS_ID       as '처리자 ID'     , " +
                                            " A.TRS_NAME     as '처리자 명'     , " +
                                            " A.TRS_DATE     as '처리 일자'       " +
                                          " FROM SLIS_MASTER.dbo.LS101T0 A " +
                                          " INNER JOIN SLIS_MASTER.dbo.LS901T0 B ON A.SCANN_SLT = B.COD  " +
                                          " INNER JOIN SLIS_MASTER.dbo.LS801T0 C ON A.BRA_ID = C.BRA_ID ";
                                        

                if (INV_NO || BRA_ID || SCANN_DATE_A || SCANN_DATE_B)
                    {
                        sqlQuery += " WHERE ";

                        //  INV_NO 컬럼이 존재한다면 최종 쿼리는 WHERE A.INV_NO LIKE '%  입력값   %'
                        if(INV_NO)
                        {
                            //sqlQuery += $" A.INV_NO LIKE '%{textBox1.Text}%' ";
                            sqlQuery += $" A.INV_NO = '{textBox1.Text}' ";
                        }
                        
                        // BRA_NAME 컬럼의 값이 존재한다면  
                        // 1. INV_NO가 존재한다면 앞에 if문에서 WHERE A.INV_NO LIKE '%입력값%' 이 이미 존재하므로 AND를 붙이고 남은 if문 수행
                        // 2. WHERE A.INV_NO LIKE '%입력값%' AND B.COD_LIKE '%입력값%'
                        if(BRA_ID)
                        {
                            if (INV_NO)
                            {
                                sqlQuery += " AND ";
                            }
                            // 01 서울    BRA_ID = 003 터미널 
                            String braId = BRA_COMBO.Text.Substring(0,3);
                            sqlQuery += $" A.BRA_ID = '{braId}' ";
                        }
                        
                        // SCANN_DATE_A컬럼의 입력값이 존재한다면 
                        // INV_NO 또는 BRA_ID 컬럼에 대한 WHERE 쿼리가 존재하므로 
                        // AND A.SCANN_DATE LIKE '%20240925%' 
                        if(SCANN_DATE_A)
                        {
                            if(INV_NO || BRA_ID)
                            {
                                sqlQuery += " AND ";
                            }
                            sqlQuery += $" A.SCANN_DATE LIKE '%{textBox3.Text}%'";
                        }

                        // SCANN_DATE_B컬럼의 입력값이 존재한다면 
                        // SCANN_DATE_A의 입력값이 존재한다면 WHERE A.SCANN_DATE BETWEEN '%입력값%' AND '%입력값%'
                        // INV_NO 또는 BRA_ID 입력값이 존재하며 '그리고' SCANN_DATE_A의 입력값이 존재한다면
                        // AND A.SCANN_DATE BETWEEN 'A' AND 'B'

                        if(SCANN_DATE_B)
                        {
                            if ((INV_NO || BRA_ID) && SCANN_DATE_A)
                            {
                                sqlQuery += $" AND  A.SCANN_DATE BETWEEN '%{textBox3.Text}%'  AND  '%{textBox4.Text}%' ";
                            } else if ( (INV_NO || BRA_ID) && !SCANN_DATE_A)
                            {
                                MessageBox.Show($"날짜 A의 값이 필요합니다 \r\n조건을 조회 하기위한  값이 입력되지 않았습니다", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                          
                        }
                }

                sqlQuery += "ORDER BY A.SCANN_DATE ASC , A.SCANN_TIME ASC ";

                using (SqlConnection conn = new SqlConnection(DB_Info.Get91PortConnect()))
                {
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

                } // using 
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
                    using (SqlConnection conn = new SqlConnection(DB_Connect.getTestDB()))
                    {
                        conn.Open();
                        
                        // 선택한 행의 컬럼INV_NO , SCANN_SLT를 인덱스로 설정하지 않고 직접 설정해 값을 가져와 toString()
                        String INV_NO = ScanDataGridView2.SelectedRows[0].Cells["INV_NO"].Value.ToString();
                        String SCANN_SLT = ScanDataGridView2.SelectedRows[0].Cells["SCANN_SLT"].Value.ToString();
                        String BRA_ID = ScanDataGridView2.SelectedRows[0].Cells["BRA_ID"].Value.ToString();
                        String SCANN_DATE = ScanDataGridView2.SelectedRows[0].Cells["SCANN_DATE"].Value.ToString();
                        String SCANN_TIME = ScanDataGridView2.SelectedRows[0].Cells["SCANN_TIME"].Value.ToString();
                        String HTT_ID = ScanDataGridView2.SelectedRows[0].Cells["HTT_ID"].Value.ToString();
                        String TRS_ID = ScanDataGridView2.SelectedRows[0].Cells["TRS_ID"].Value.ToString();


                        // scandatagridView2 에서 빈 행을 선택후 , 삭제 요청시 생서되는 null 예외 처리하기
                        if (String.IsNullOrWhiteSpace(SCANN_SLT) || String.IsNullOrWhiteSpace(INV_NO) ) 
                        {
                            MessageBox.Show("삭제할 행을 선택하지 않았습니다.", "실패 메세지", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }


                        String deleteQuery = "DELETE FROM LS101T0 " +
                                            $" WHERE INV_NO = '{INV_NO}' " +
                                            $" AND SCANN_SLT = '{SCANN_SLT}' " +
                                            $" AND BRA_ID = '{BRA_ID}' " +
                                            $" AND SCANN_DATE = '{SCANN_DATE} '" +
                                            $" AND SCANN_TIME = '{SCANN_TIME} '" +
                                            $" AND HTT_ID = '{HTT_ID}' " +
                                            $" AND TRS_ID = '{TRS_ID}' ";


                        using (SqlCommand sqlCommand = new SqlCommand(deleteQuery, conn))
                        {
                            // ExecuteNonQuery() INSERT, UPDATE, DELETE와 같은 데이터 변경 작업에 사용되며. 이 메서드는 데이터베이스에서 변화가 생긴 행의 갯수를 반환
                            int deleteRow = sqlCommand.ExecuteNonQuery();

                            // 실행된 쿼리 결과 확인
                            if (deleteRow > 0)
                            {
                                // 삭제된 행을 DataGridView에서 제거
                                ScanDataGridView2.Rows.RemoveAt(ScanDataGridView2.SelectedRows[0].Index);
                                // 삭제 완료 이후 메시지 출력
                                MessageBox.Show("행이 성공적으로 삭제되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // view 새로고침
                                RefreshDelete();
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
                /*
                 SqlConnection 데이터베이스에 대한 연결을 관리 데이터베이스에 연결을 열고 닫는 역할.
                 명령을 실행하기 전에 연결을 열어야 하며, 작업이 끝난 후에는 연결을 닫아야 한다 ,  using(){} 문으로 인해 close()명시적으로 하지 않아도된다 Dispose().
                 */

                // 선택된 행이 1개 일때만 가능하게 
                if (ScanDataGridView2.SelectedRows.Count == 1)
                {
                    // SqlConnection을 관리하기 위한 using
                    // 명시적으로 open 호출한다 하지만 close는 호출할 필요없다 using() 에서 처리한다
                    using (SqlConnection conn = new SqlConnection(DB_Connect.getTestDB()))
                    {

                        conn.Open();

                        // 선택한 행의 첫번째 라는 의미에서 [0]을 쓴다는데 굳이 이래야하나...
                        DataGridViewRow selectedRow = ScanDataGridView2.SelectedRows[0];

                        String invNo = selectedRow.Cells["INV_NO"].Value.ToString();
                        String braId = selectedRow.Cells["BRA_ID"].Value.ToString();
                        String scannSlt = selectedRow.Cells["SCANN_SLT"].Value.ToString();
                        String scannDate = selectedRow.Cells["SCANN_DATE"].Value.ToString();
                        String scannTime = selectedRow.Cells["SCANN_TIME"].Value.ToString();
                        String carId = selectedRow.Cells["CAR_ID"].Value.ToString();
                        String scanUsrId = selectedRow.Cells["SCANN_USR_ID"].Value.ToString();
                        String httId = selectedRow.Cells["HTT_ID"].Value.ToString();
                        String trsId = selectedRow.Cells["TRS_ID"].Value.ToString();
                        String trsName = selectedRow.Cells["TRS_NAME"].Value.ToString();


                        List<string> setColumn = new List<string>();

                        // UPDATE 테이블명 SET 변경될
                        if (!String.IsNullOrEmpty(SCANN_BRAID_TEXT.Text))
                        {
                            setColumn.Add($"BRA_ID = '{SCANN_BRAID_TEXT.Text}'");
                        }

                        if (!String.IsNullOrEmpty(SCAN_SLT_TEXT.Text))
                        {
                            setColumn.Add($"SCANN_SLT = '{SCAN_SLT_TEXT.Text}'");
                        }

                        if (!String.IsNullOrEmpty(SCANN_DATE_TEXT.Text))
                        {
                            setColumn.Add($"SCANN_DATE = '{SCANN_DATE_TEXT.Text}'");
                        }

                        if (!String.IsNullOrEmpty(SCANN_TIME_TEXT.Text))
                        {
                            setColumn.Add($"SCANN_TIME = '{SCANN_TIME_TEXT.Text}'");
                        }

                        if(!String.IsNullOrEmpty(SCANN_CAR_TEXT.Text))
                        {
                            setColumn.Add($"CAR_ID = '{SCANN_CAR_TEXT.Text}'");
                        }

                        if(!String.IsNullOrEmpty(SCANN_USR_ID_TEXT.Text))
                        {
                            setColumn.Add($"SCANN_USR_ID = '{SCANN_USR_ID_TEXT.Text}'");
                            setColumn.Add($"TRS_ID = '{SCANN_USR_ID_TEXT.Text}'");
                        }

                        if(!String.IsNullOrEmpty(SCANN_HTT_TEXT.Text))
                        {
                            setColumn.Add($"HTT_ID = '{SCANN_HTT_TEXT.Text}'");
                        }

                        if(!String.IsNullOrEmpty(SCANN_TRS_NAME_TEXT.Text))
                        {
                            setColumn.Add($"TRS_NAME = '{SCANN_TRS_NAME_TEXT.Text}'");
                        }


                        string result = string.Join(", ", setColumn);

                        string updateQuery = $"UPDATE LS101T0 SET {result}" +
                                                $" , TRS_DATE = GETDATE()" +
                                            $" WHERE INV_NO = '{invNo}' " +
                                            $" AND BRA_ID = '{braId}' " +
                                            $" AND SCANN_SLT = '{scannSlt}' " +
                                            $" AND SCANN_DATE = '{scannDate}' " +
                                            $" AND SCANN_TIME = '{scannTime}' " +
                                            $" AND CAR_ID = '{carId}' " +
                                            $" AND SCANN_USR_ID = '{scanUsrId}' " +
                                            $" AND HTT_ID = '{httId}' " +
                                            $" AND TRS_ID = '{trsId}' " +
                                            $" AND TRS_NAME = '{trsName}'";

                        /*
                         SQL 쿼리를 데이터베이스에 실행하기 위한 객체. 쿼리를 실행하고 결과를 반환하거나 데이터베이스를 수정한다.
                         SqlCommand는 열려 있는 SqlConnection과 연결되어 있어야 명령을 실행
                         */
                        // SqlCommand를 사용하기 위해 또 다른 using을 씀
                        using (SqlCommand sqlCommand = new SqlCommand(updateQuery,conn))
                        {
                            int updateRow = sqlCommand.ExecuteNonQuery();

                      
                            if(updateRow > 0)
                            {
                                MessageBox.Show("데이터가 성공적으로 수정되었습니다.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                RefreshGrid();
                            } else
                            {
                                MessageBox.Show("데이터 수정 실패.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    // 선택된 행의 갯수가 맞지 않은데 수정 버튼 실행시 알람 메세지  
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

        private void RefreshGrid()
        {
            String selectColumn = ScanDataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            // dataGridView 새로고침
            string sqlQuery = "SELECT * FROM LS101T0 " +
                                $" WHERE INV_NO = '{selectColumn}' " +
                                $" ORDER BY SCANN_DATE , SCANN_TIME ASC"; 

            using (SqlConnection conn = new SqlConnection(DB_Connect.getTestDB()))
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, conn);


                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                ScanDataGridView1.DataSource = dataTable;
                ScanDataGridView2.DataSource = dataTable;
            }
        }

        private void RefreshDelete()
        {
            String sqlQuery = $"SELECT * FROM LS101T0  ORDER BY SCANN_DATE , SCANN_TIME ASC";

            using (SqlConnection conn = new SqlConnection(DB_Connect.getTestDB()))
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, conn);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                ScanDataGridView1.DataSource = dataTable;
                ScanDataGridView2.DataSource = dataTable;
            }
        }




 


    }
}

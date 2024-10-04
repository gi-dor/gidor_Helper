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
    public partial class UserDetails : Form
    {
        public UserDetails()
        {
            InitializeComponent();
        }



        // 사용자 상세 조회 Load
        private void UserDeatil_Load(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(DB_Info.Get91PortConnect()))
                {
                    conn.Open();
                    MessageBox.Show("Success, DB 연결 되었습니다", "DB 연결 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 해당 컬럼의 ReadOnly 속성 true
                    user_dataGridView1.ReadOnly = true;
                    user_dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            } catch(Exception ex)
            {
                MessageBox.Show($"DB 연결 실패 \r\n Error: {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // 사용자 부서 전체 조회 -> 추후 고객 회사로 변경예정 
        private void selectButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DB_Info.Get91PortConnect()))
                {
                    String sqlQuery = "SELECT " +
                                        "DEPARTMENT_NO          , " +
                                        "DEPARTMENT_NAME        , " +
                                        "DEPARTMENT_COD         , " +
                                        "CREATED_DATE           , " +
                                        "UPDATED_DATE" +
                                        " FROM dbo.DEPARTMENT " +
                                        " ORDER BY DEPARTMENT_NO ASC";
                
                    // SQL 쿼리를 실행시작 객체
                    SqlCommand cmd = new SqlCommand(sqlQuery,conn);

                    // 실행한 객체 cmd 를 담아서 DB에서 데이터를 가져온다
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    
                    // 데이터 담기
                    DataTable dataTable = new DataTable();

                    // 데이터 테이블 채우기

                    // SqlDataAdapter.Fill() 메서드는 내부적으로 SqlConnection 객체가 열리고 닫힌다고 한다
                    // 따라서 Load 메서드에서 사용한 conn.Open()을 명시적으로 사용하지 않아도, Fill() 메서드가 데이터베이스 연결을 열고 데이터를 가져온 후, 자동으로 연결을 닫아준다.
                    // 그러면 using도 필요없는거 아닌가?

                    // SqlDataAdapter.Fill()가 Open()과 Close()를 자동으로 처리해주지만, 연결 자체를 안전하게 해제하기 위해 using 구문으로 자원 관리를 해야한다
                    // 메모리 누수, 연결자원 누구 때문
                    dataAdapter.Fill(dataTable);

                    user_dataGridView1.Columns.Clear();

                    user_dataGridView1.DataSource = dataTable;
   
                    user_dataGridView1.ReadOnly = true;
                    user_dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            } catch(Exception ex)
            {
                MessageBox.Show($"데이터 조회 실패 \r\n Error: {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        // 조회된 브랜드의 행 더블 클릭시 발생
        // 상세 사용자 정보 조회
        private void User_Detail(object sender, DataGridViewCellEventArgs e)
        {
            // 첫번째 행의 인덱스는 0 이기에 0으로 설정했음 
            if(e.RowIndex >= 0)
            {
                try
                {
                    using(SqlConnection conn = new SqlConnection(DB_Info.Get91PortConnect())) {

                        String selectColumn = user_dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                        String sqlQuery = "SELECT " +
                     //                       "u.USER_NO,     " +
                                            "u.USER_ID,     " +
                                            "u.PASSWORD,    " +
                                            "u.NAME,        " +
                                            "u.CREATED_DATE as CREATED_DATE     ," +
                                            "u.UPDATED_DATE  as UPDATED_DATE  " +
                                            " FROM dbo.USERS u " +
                                            " INNER JOIN dbo.DEPARTMENT d " +
                                            " ON d.DEPARTMENT_COD = u.DEPARTMENT_COD " +
                                            $" WHERE u.DEPARTMENT_COD = '{selectColumn}' " +
                                            " ORDER BY u.USER_NO ASC";

                        SqlCommand sqlCommand = new SqlCommand(sqlQuery, conn);
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                        DataTable dataTable = new DataTable();
                        
                        sqlDataAdapter.Fill(dataTable);

                        // 컬럼 삭제후 재 설정
                        user_dataGridView2.Columns.Clear();


                        user_dataGridView2.DataSource = dataTable;

                        user_dataGridView2.ReadOnly = true;
                        user_dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show($"데이터 조회 실패 \r\n Error: {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

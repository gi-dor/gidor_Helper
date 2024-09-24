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

        // 코드관리 페이지 로드시 , DB 연결 성공 유무확인
        private void CommonCod_Load(object sender, EventArgs e)
        {
            try
            {
              
                // using문을 사용하면 dispose() 또는 close()를 사용하지 않아도된다
                // 만약 dispose() , close() , using() {} 을 사용하지 않는다면 메모리 누수 현상이 발생한다고 한다

                // DB_Connect 클래스에있는 conStrt을 가져와 사용한다
                using (SqlConnection conn = new SqlConnection(DB_Info.Get91PortConnect())) { 

                    conn.Open();
                    MessageBox.Show($"Success , DB 연결 되었습니다 \r\n{DB_Info.Get91PortConnect()} ", "DB 연결 성공 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 해당 컬럼의 ReadOnly 속성 true 
                    cod_dataGridView1.ReadOnly = true;
                    cod_dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }

            } catch(Exception ex)
            {
                MessageBox.Show($"DB 연결실패 \r\n Error : {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // 전체 조회
        private void CodeManageButton_Click(object sender, EventArgs e)
        {
            try
            {
                String sqlQuery = " SELECT " +
                                  " COD         AS '코드', " +
                                  " COD_CONT    AS '코드 내용' , " +
                                  " COD_SLT     AS '코드 구분' , " +
                                  " CRE_DATE    AS '생성 일자' , " +
                                  " END_DATE    AS '종료 일자' , " +
                                  " TRS_ID      AS '작성자 ID' , " +
                                  " TRS_NAME    AS '작성자 명' , " +
                                  " TRS_DATE    AS '작성 일자'" +
                                  "FROM SLIS_MASTER.dbo.LS901T0 " +
                                  "order by COD ASC";

                using (SqlConnection conn = new SqlConnection(DB_Info.Get91PortConnect()))
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



        // 특정 조건에 맞게 검색
        private void CodeSelectButton_Click(object sender, EventArgs e)
        {
            try
            {
                String sqlQuery = " SELECT " +
                                  " COD         AS '코드', " +
                                  " COD_CONT    AS '코드 내용' , " +
                                  " COD_SLT     AS '코드 구분' , " +
                                  " CRE_DATE    AS '생성 일자' , " +
                                  " END_DATE    AS '종료 일자' , " +
                                  " TRS_ID      AS '작성자 ID' , " +
                                  " TRS_NAME    AS '작성자 명' , " +
                                  " TRS_DATE    AS '작성 일자'" +
                                  "FROM SLIS_MASTER.dbo.LS901T0 ";
                                  
               

                if(!String.IsNullOrEmpty(textBox1.Text) || !String.IsNullOrEmpty(textBox2.Text) ||
                    !String.IsNullOrEmpty(textBox3.Text) || !String.IsNullOrEmpty(textBox4.Text))
                {
                    sqlQuery += " WHERE ";

                    if(!String.IsNullOrEmpty(textBox1.Text))
                    {
                        sqlQuery += $" COD LIKE '%{textBox1.Text}%' ";
                    }

                    if(!String.IsNullOrEmpty(textBox2.Text))
                    {
                        if(!String.IsNullOrEmpty(textBox1.Text))
                        {
                            sqlQuery += " AND ";
                        }
                        sqlQuery += $" COD_CONT LIKE '%{textBox2.Text}%' ";
                    }

                    if (!String.IsNullOrEmpty(textBox3.Text))
                    {
                        if(!String.IsNullOrEmpty(textBox1.Text) || !String.IsNullOrEmpty(textBox1.Text))
                        {
                            sqlQuery += " AND ";
                        }
                        sqlQuery += $" COD_SLT LIKE '%{textBox3.Text}%' ";
                    }

                    if(!String.IsNullOrEmpty(textBox4.Text))
                    {
                        if(!String.IsNullOrEmpty(textBox1.Text) || !String.IsNullOrEmpty(textBox1.Text) || !String.IsNullOrEmpty(textBox3.Text))
                        {
                            sqlQuery += " AND ";
                        }
                        sqlQuery += $" CRE_DATE LIKE '%{textBox4.Text}%' ";
                    }
                }

                sqlQuery += " ORDER BY COD ASC";



                // ************************************************   구버전 *****************************************
                /*
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
                
                */


                using (SqlConnection conn =  new SqlConnection(DB_Info.Get91PortConnect()))
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


        // 특정행 클릭시 해당 정보를 하단의 상세 정보 칸에 조회
        private void Row_Click_Detail(object sender, DataGridViewCellEventArgs e)
        {
            // 선택된 행이 1개 이상이라면 실행한다
            if(e.RowIndex > 0)
            {
                // .Rows 컨트롤의 모든 행을 포함하는 컬렉션을 가져온다 ? -> 해당 선택된 행의 컬럼들에 대한 정보를 담는거 같음
                // .RowIndex 이벤트가 발생한 셀의 행의 인덱스를 가져온다고한다
                DataGridViewRow row = cod_dataGridView1.Rows[e.RowIndex];

                // DataGridViewTextBoxCell { ColumnIndex=0, Rowndex=1 } 선택한 셀 자체의 객체를 문자열로 가져온다
                //  cod_textBox.Text = row.Cells[0].ToString();
                // cod_textBox.Text = row.Cells["COD"].ToString();

                // Value를 사용하여 실제 데이터를 가져오자

                // 특정 컬럼에 대해 명시적으로 "COD" 으로 표현 할수 있으며 INDEX를 통해 설정 할수도 있다

                // String sqlQery 에서 AS 를 사용한다면 컬럼을 명시적으로 표현하지말고 INDEX를 통해 설정해야한다
                cod_textBox.Text = row.Cells[0].Value.ToString();
                codCont_textBox.Text = row.Cells[1].Value.ToString();
                codSlt_textBox.Text = row.Cells[2].Value.ToString();
                creDate_textBox.Text = row.Cells[3].Value.ToString();
                endDate_textBox.Text = row.Cells[4].Value.ToString();


            }
        }




    }
}

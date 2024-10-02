using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gidor_Helper.Util;

namespace gidor_Helper.domain.manage
{
    public partial class BraManage : Form
    {
        public BraManage()
        {
            InitializeComponent();
        }

        private void BraManage_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DB_Info.Get91PortConnect()))
                {
                    conn.Open();
                    MessageBox.Show($"Success , DB 연결 되었습니다 \r\n{DB_Info.Get91PortConnect()} ", "DB 연결 성공 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BradataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    String sqlQuery = "SELECT " +
                                    " A.BRA_ID + ' ' + A.BRA_NAME as '영업소' ," +
                                    " B.COD_CONT as '운영구분'  , " +
                                    " C.COD_CONT as '점포구분'  , " +
                                    " D.COD_CONT as '집/배 구분', " +
                                    " E.COD_CONT as '권역구분'  , " +
                                    " F.COD_CONT as '직영/비직영 구분' " +
                                    " FROM LS801T0 A " +
                                    " INNER JOIN LS901T0 B ON A.OPR_SLT = B.COD " +
                                    " INNER JOIN LS901T0 C ON A.MKT_SLT = C.COD " +
                                    " INNER JOIN LS901T0 D ON A.ABLE_SLT = D.COD" +
                                    " INNER JOIN LS901T0 E ON A.AREA_SLT = E.COD " +
                                    " INNER JOIN LS901T0 F ON A.DIR_SLT = F.COD" +
                                    " ORDER BY A.BRA_ID ASC";


                    String sqlQuery영업소 = "SELECT BRA_ID + ' ' + BRA_NAME as '영업소' " +
                                            " FROM LS801T0  " +
                                            " ORDER BY BRA_ID";


                    String sqlQuery운영구분 = "SELECT DISTINCT " +
                                             " B.COD_CONT as '운영구분' " +
                                             "  FROM LS801T0 A " +
                                             "  INNER JOIN LS901T0 B ON A.OPR_SLT = B.COD";


                    String sqlQuery점포구분 = "SELECT DISTINCT " +
                                            " C.COD_CONT as '점포구분' " +
                                            " FROM LS801T0 A " +
                                            " INNER JOIN LS901T0 C ON A.MKT_SLT = C.COD ";

                    String sqlQuery집배구분 = " SELECT DISTINCT " +
                                              " D.COD_CONT as '집/배 구분' " +
                                              " FROM LS801T0 A " +
                                              " INNER JOIN LS901T0 D ON A.ABLE_SLT = D.COD ";

                    String sqlQuery권역구분 = " SELECT DISTINCT " +
                                             " E.COD_CONT as '권역구분' " +
                                             " FROM LS801T0 A " +
                                             " INNER JOIN LS901T0 E ON A.AREA_SLT = E.COD ";

                    String sqlQuery직영비직영구분 = " SELECT DISTINCT " +
                                                    " F.COD_CONT as '직영/비직영 구분' " +
                                                    " FROM LS801T0 A " +
                                                    " INNER JOIN LS901T0 F ON A.DIR_SLT = F.COD ";
                    
                    using (SqlCommand cmd = new SqlCommand(sqlQuery,conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            영업소_combo.Items.Add($"{reader["영업소"]}");
                          //  운영구분_combo.Items.Add($"{reader["운영구분"]}");
                          //  점포구분_combo.Items.Add($"{reader["점포구분"]}");
                          //  집배구분_combo.Items.Add($"{reader["집/배 구분"]}");
                          //  권역구분_combo.Items.Add($"{reader["권역구분"]}");
                          //  직영구분_combo.Items.Add($"{reader["직영/비직영 구분"]}");
                        }
                        reader.Close();
                        
                    }

                    QueryUsing.ComboTest(sqlQuery운영구분, 운영구분_combo, "운영구분", conn);
                    QueryUsing.ComboTest(sqlQuery점포구분, 점포구분_combo, "점포구분", conn);
                    QueryUsing.ComboTest(sqlQuery집배구분, 집배구분_combo, "집/배 구분", conn);
                    QueryUsing.ComboTest(sqlQuery권역구분, 권역구분_combo, "권역구분", conn);
                    QueryUsing.ComboTest(sqlQuery직영비직영구분, 직영구분_combo, "직영/비직영 구분", conn);

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

                    using (SqlCommand cmd = new SqlCommand(sqlQuery점포구분, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            점포구분_combo.Items.Add($"{reader["점포구분"]}");
                        }
                        reader.Close();
                    }

                    using (SqlCommand cmd = new SqlCommand(sqlQuery집배구분, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            집배구분_combo.Items.Add($"{reader["집/배 구분"]}");
                        }
                        reader.Close();
                    }

                    using (SqlCommand cmd = new SqlCommand(sqlQuery권역구분, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            권역구분_combo.Items.Add($"{reader["권역구분"]}");
                        }
                        reader.Close();
                    }

                    using (SqlCommand cmd = new SqlCommand(sqlQuery직영비직영구분, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            직영구분_combo.Items.Add($"{reader["직영/비직영 구분"]}");
                        }
                        reader.Close();
                    }
                    */

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
                using(SqlConnection conn =  new SqlConnection(DB_Info.Get91PortConnect()))
                {
                    String sqlQuery = "SELECT " +
                                        " A.BRA_ID as '영업소 코드', " +
                                        " A.BRA_ID + ' ' + A.BRA_NAME as '영업소' , " +
                                        " B.COD_CONT as '운영구분' , " +
                                        " C.COD_CONT as '점포구분' , " +
                                        " D.COD_CONT as '집/배 구분' , " +
                                        " E.COD_CONT as '권역구분' , " +
                                        " F.COD_CONT as '직영/비직영 구분', " +
                                        " A.BRA_BOSS_NAME as '영업소장' , " +
                                        " A.TEL           as '전화번호' ," +
                                        " A.RMK           as '그룹' " +
                                        " FROM LS801T0 A " +
                                        " INNER JOIN LS901T0 B ON A.OPR_SLT = B.COD " +
                                        " INNER JOIN LS901T0 C ON A.MKT_SLT = C.COD " +
                                        " INNER JOIN LS901T0 D ON A.ABLE_SLT = D.COD  " +
                                        " INNER JOIN LS901T0 E ON A.AREA_SLT = E.COD " +
                                        " INNER JOIN LS901T0 F ON A.DIR_SLT = F.COD " +
                                        " ORDER BY A.BRA_ID ASC";

                    // SQL 쿼리를 실행시작 객체
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                    // 실행한 객체 cmd 를 담아서 DB에서 데이터를 가져온다
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                    // 데이터 담기
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    BradataGridView1.Columns.Clear();

                    int rowCount = dataTable.Rows.Count;
                    count_value.Text = $" {rowCount}";

                    BradataGridView1.Columns.Clear();

                    BradataGridView1.DataSource = dataTable;

                    BradataGridView1.ReadOnly = true;
                    BradataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    BradataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



                }
            } catch(Exception ex)
            {
                MessageBox.Show($"데이터 조회 실패 \r\n Error: {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

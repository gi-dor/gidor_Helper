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
                   
                }
            } catch(Exception ex)
            {
                MessageBox.Show($"데이터 조회 실패 \r\n Error: {ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

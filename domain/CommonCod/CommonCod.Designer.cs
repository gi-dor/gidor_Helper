namespace gidor_Helper
{
    partial class CommonCod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cod_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_CONT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_SLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATED_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.END_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRS_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRS_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRS_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeManageButton = new System.Windows.Forms.Button();
            this.count_value = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.코드구분 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.CodeSelectButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.생성일자 = new System.Windows.Forms.Label();
            this.코드내용 = new System.Windows.Forms.Label();
            this.코드 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.endDate_textBox = new System.Windows.Forms.TextBox();
            this.codSlt_textBox = new System.Windows.Forms.TextBox();
            this.creDate_textBox = new System.Windows.Forms.TextBox();
            this.codCont_textBox = new System.Windows.Forms.TextBox();
            this.cod_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cod_dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cod_dataGridView1
            // 
            this.cod_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cod_dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.cod_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cod_dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD,
            this.COD_CONT,
            this.COD_SLT,
            this.CREATED_DATE,
            this.END_DATE,
            this.TRS_ID,
            this.TRS_NAME,
            this.TRS_DATE});
            this.cod_dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.cod_dataGridView1.Location = new System.Drawing.Point(1, 3);
            this.cod_dataGridView1.Name = "cod_dataGridView1";
            this.cod_dataGridView1.ReadOnly = true;
            this.cod_dataGridView1.RowTemplate.Height = 23;
            this.cod_dataGridView1.Size = new System.Drawing.Size(1073, 478);
            this.cod_dataGridView1.TabIndex = 3;
            this.cod_dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Row_Click_Detail);
            // 
            // COD
            // 
            this.COD.HeaderText = "COD";
            this.COD.Name = "COD";
            this.COD.ReadOnly = true;
            // 
            // COD_CONT
            // 
            this.COD_CONT.HeaderText = "COD_CONT";
            this.COD_CONT.Name = "COD_CONT";
            this.COD_CONT.ReadOnly = true;
            // 
            // COD_SLT
            // 
            this.COD_SLT.HeaderText = "COD_SLT";
            this.COD_SLT.Name = "COD_SLT";
            this.COD_SLT.ReadOnly = true;
            // 
            // CREATED_DATE
            // 
            this.CREATED_DATE.HeaderText = "CRE_DATE";
            this.CREATED_DATE.Name = "CREATED_DATE";
            this.CREATED_DATE.ReadOnly = true;
            // 
            // END_DATE
            // 
            this.END_DATE.HeaderText = "END_DATE";
            this.END_DATE.Name = "END_DATE";
            this.END_DATE.ReadOnly = true;
            // 
            // TRS_ID
            // 
            this.TRS_ID.HeaderText = "TRS_ID";
            this.TRS_ID.Name = "TRS_ID";
            this.TRS_ID.ReadOnly = true;
            // 
            // TRS_NAME
            // 
            this.TRS_NAME.HeaderText = "TRS_NAME";
            this.TRS_NAME.Name = "TRS_NAME";
            this.TRS_NAME.ReadOnly = true;
            // 
            // TRS_DATE
            // 
            this.TRS_DATE.HeaderText = "TRS_DATE";
            this.TRS_DATE.Name = "TRS_DATE";
            this.TRS_DATE.ReadOnly = true;
            // 
            // CodeManageButton
            // 
            this.CodeManageButton.Location = new System.Drawing.Point(1118, 43);
            this.CodeManageButton.Name = "CodeManageButton";
            this.CodeManageButton.Size = new System.Drawing.Size(149, 44);
            this.CodeManageButton.TabIndex = 4;
            this.CodeManageButton.Text = "전체 조회";
            this.CodeManageButton.UseVisualStyleBackColor = true;
            this.CodeManageButton.Click += new System.EventHandler(this.CodeManageButton_Click);
            // 
            // count_value
            // 
            this.count_value.AutoSize = true;
            this.count_value.Location = new System.Drawing.Point(1199, 198);
            this.count_value.Name = "count_value";
            this.count_value.Size = new System.Drawing.Size(61, 12);
            this.count_value.TabIndex = 9;
            this.count_value.Text = "              ";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(1116, 198);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(81, 12);
            this.count.TabIndex = 8;
            this.count.Text = "조회된 건수 : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.코드구분);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.CodeSelectButton);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.생성일자);
            this.panel1.Controls.Add(this.코드내용);
            this.panel1.Controls.Add(this.코드);
            this.panel1.Location = new System.Drawing.Point(1101, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 260);
            this.panel1.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(4, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 21);
            this.textBox3.TabIndex = 7;
            // 
            // 코드구분
            // 
            this.코드구분.AutoSize = true;
            this.코드구분.Location = new System.Drawing.Point(11, 108);
            this.코드구분.Name = "코드구분";
            this.코드구분.Size = new System.Drawing.Size(53, 12);
            this.코드구분.TabIndex = 6;
            this.코드구분.Text = "코드구분";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(5, 172);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 21);
            this.textBox4.TabIndex = 5;
            // 
            // CodeSelectButton
            // 
            this.CodeSelectButton.Location = new System.Drawing.Point(14, 212);
            this.CodeSelectButton.Name = "CodeSelectButton";
            this.CodeSelectButton.Size = new System.Drawing.Size(134, 28);
            this.CodeSelectButton.TabIndex = 4;
            this.CodeSelectButton.Text = "코드 조회";
            this.CodeSelectButton.UseVisualStyleBackColor = true;
            this.CodeSelectButton.Click += new System.EventHandler(this.CodeSelectButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(5, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 21);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 21);
            this.textBox1.TabIndex = 3;
            // 
            // 생성일자
            // 
            this.생성일자.AutoSize = true;
            this.생성일자.Location = new System.Drawing.Point(12, 157);
            this.생성일자.Name = "생성일자";
            this.생성일자.Size = new System.Drawing.Size(53, 12);
            this.생성일자.TabIndex = 2;
            this.생성일자.Text = "생성일자";
            // 
            // 코드내용
            // 
            this.코드내용.AutoSize = true;
            this.코드내용.Location = new System.Drawing.Point(12, 61);
            this.코드내용.Name = "코드내용";
            this.코드내용.Size = new System.Drawing.Size(53, 12);
            this.코드내용.TabIndex = 1;
            this.코드내용.Text = "코드내용";
            // 
            // 코드
            // 
            this.코드.AutoSize = true;
            this.코드.Location = new System.Drawing.Point(12, 12);
            this.코드.Name = "코드";
            this.코드.Size = new System.Drawing.Size(29, 12);
            this.코드.TabIndex = 0;
            this.코드.Text = "코드";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.endDate_textBox);
            this.panel2.Controls.Add(this.codSlt_textBox);
            this.panel2.Controls.Add(this.creDate_textBox);
            this.panel2.Controls.Add(this.codCont_textBox);
            this.panel2.Controls.Add(this.cod_textBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 149);
            this.panel2.TabIndex = 11;
            // 
            // endDate_textBox
            // 
            this.endDate_textBox.Location = new System.Drawing.Point(637, 23);
            this.endDate_textBox.Name = "endDate_textBox";
            this.endDate_textBox.ReadOnly = true;
            this.endDate_textBox.Size = new System.Drawing.Size(151, 21);
            this.endDate_textBox.TabIndex = 19;
            // 
            // codSlt_textBox
            // 
            this.codSlt_textBox.Location = new System.Drawing.Point(359, 87);
            this.codSlt_textBox.Name = "codSlt_textBox";
            this.codSlt_textBox.ReadOnly = true;
            this.codSlt_textBox.Size = new System.Drawing.Size(151, 21);
            this.codSlt_textBox.TabIndex = 18;
            // 
            // creDate_textBox
            // 
            this.creDate_textBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.creDate_textBox.Location = new System.Drawing.Point(359, 18);
            this.creDate_textBox.Name = "creDate_textBox";
            this.creDate_textBox.ReadOnly = true;
            this.creDate_textBox.Size = new System.Drawing.Size(151, 21);
            this.creDate_textBox.TabIndex = 17;
            // 
            // codCont_textBox
            // 
            this.codCont_textBox.Location = new System.Drawing.Point(85, 87);
            this.codCont_textBox.Name = "codCont_textBox";
            this.codCont_textBox.ReadOnly = true;
            this.codCont_textBox.Size = new System.Drawing.Size(151, 21);
            this.codCont_textBox.TabIndex = 16;
            // 
            // cod_textBox
            // 
            this.cod_textBox.Location = new System.Drawing.Point(85, 21);
            this.cod_textBox.Name = "cod_textBox";
            this.cod_textBox.ReadOnly = true;
            this.cod_textBox.Size = new System.Drawing.Size(151, 21);
            this.cod_textBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10F);
            this.label5.Location = new System.Drawing.Point(564, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "종료 일자";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F);
            this.label4.Location = new System.Drawing.Point(303, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "비고";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F);
            this.label3.Location = new System.Drawing.Point(288, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "생성 일자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(11, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "코드 내용";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "코드";
            // 
            // CommonCod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.count_value);
            this.Controls.Add(this.count);
            this.Controls.Add(this.CodeManageButton);
            this.Controls.Add(this.cod_dataGridView1);
            this.Name = "CommonCod";
            this.Text = "CommonCod";
            this.Load += new System.EventHandler(this.CommonCod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cod_dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cod_dataGridView1;
        private System.Windows.Forms.Button CodeManageButton;
        private System.Windows.Forms.Label count_value;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label 코드구분;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button CodeSelectButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label 생성일자;
        private System.Windows.Forms.Label 코드내용;
        private System.Windows.Forms.Label 코드;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox endDate_textBox;
        private System.Windows.Forms.TextBox codSlt_textBox;
        private System.Windows.Forms.TextBox creDate_textBox;
        private System.Windows.Forms.TextBox codCont_textBox;
        private System.Windows.Forms.TextBox cod_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CONT;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_SLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATED_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn END_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRS_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRS_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRS_DATE;
    }
}
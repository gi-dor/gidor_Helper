namespace gidor_Helper.domain.User
{
    partial class IdManage
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
            this.SELECT_ALL_BUTTON = new System.Windows.Forms.Button();
            this.Id_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.USER_ID_IDMANAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_NAME_IDMANAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSD_IDMANAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUST_ID_IDMANAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRA_ID_IDMANAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_PER_IDMANAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRE_DATE_IDMANAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT_DATE_IDMANAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.END_DATE_IDMANAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rmk_text = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.user_braid_text = new System.Windows.Forms.TextBox();
            this.user_per_text = new System.Windows.Forms.TextBox();
            this.end_date_text = new System.Windows.Forms.TextBox();
            this.edit_date_text = new System.Windows.Forms.TextBox();
            this.cre_date_text = new System.Windows.Forms.TextBox();
            this.user_cust_id_text = new System.Windows.Forms.TextBox();
            this.user_psd_text = new System.Windows.Forms.TextBox();
            this.user_name_text = new System.Windows.Forms.TextBox();
            this.user_id_text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Id_dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SELECT_ALL_BUTTON
            // 
            this.SELECT_ALL_BUTTON.Location = new System.Drawing.Point(627, 479);
            this.SELECT_ALL_BUTTON.Name = "SELECT_ALL_BUTTON";
            this.SELECT_ALL_BUTTON.Size = new System.Drawing.Size(149, 33);
            this.SELECT_ALL_BUTTON.TabIndex = 0;
            this.SELECT_ALL_BUTTON.Text = "전체 조회";
            this.SELECT_ALL_BUTTON.UseVisualStyleBackColor = true;
            this.SELECT_ALL_BUTTON.Click += new System.EventHandler(this.SELECT_ALL_BUTTON_Click);
            // 
            // Id_dataGridView1
            // 
            this.Id_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Id_dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Id_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Id_dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USER_ID_IDMANAGE,
            this.USER_NAME_IDMANAGE,
            this.PSD_IDMANAGE,
            this.CUST_ID_IDMANAGE,
            this.BRA_ID_IDMANAGE,
            this.USER_PER_IDMANAGE,
            this.CRE_DATE_IDMANAGE,
            this.EDIT_DATE_IDMANAGE,
            this.END_DATE_IDMANAGE});
            this.Id_dataGridView1.Location = new System.Drawing.Point(9, 2);
            this.Id_dataGridView1.Name = "Id_dataGridView1";
            this.Id_dataGridView1.RowTemplate.Height = 23;
            this.Id_dataGridView1.Size = new System.Drawing.Size(1283, 383);
            this.Id_dataGridView1.TabIndex = 1;
            this.Id_dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Id_Detail);
            // 
            // USER_ID_IDMANAGE
            // 
            this.USER_ID_IDMANAGE.HeaderText = "사용자 ID";
            this.USER_ID_IDMANAGE.Name = "USER_ID_IDMANAGE";
            // 
            // USER_NAME_IDMANAGE
            // 
            this.USER_NAME_IDMANAGE.HeaderText = "사용자";
            this.USER_NAME_IDMANAGE.Name = "USER_NAME_IDMANAGE";
            // 
            // PSD_IDMANAGE
            // 
            this.PSD_IDMANAGE.HeaderText = "비밀번호";
            this.PSD_IDMANAGE.Name = "PSD_IDMANAGE";
            // 
            // CUST_ID_IDMANAGE
            // 
            this.CUST_ID_IDMANAGE.HeaderText = "거래처";
            this.CUST_ID_IDMANAGE.Name = "CUST_ID_IDMANAGE";
            // 
            // BRA_ID_IDMANAGE
            // 
            this.BRA_ID_IDMANAGE.HeaderText = "영업소";
            this.BRA_ID_IDMANAGE.Name = "BRA_ID_IDMANAGE";
            // 
            // USER_PER_IDMANAGE
            // 
            this.USER_PER_IDMANAGE.HeaderText = "사용자 권한";
            this.USER_PER_IDMANAGE.Name = "USER_PER_IDMANAGE";
            // 
            // CRE_DATE_IDMANAGE
            // 
            this.CRE_DATE_IDMANAGE.HeaderText = "생성일자";
            this.CRE_DATE_IDMANAGE.Name = "CRE_DATE_IDMANAGE";
            // 
            // EDIT_DATE_IDMANAGE
            // 
            this.EDIT_DATE_IDMANAGE.HeaderText = "변경일자";
            this.EDIT_DATE_IDMANAGE.Name = "EDIT_DATE_IDMANAGE";
            // 
            // END_DATE_IDMANAGE
            // 
            this.END_DATE_IDMANAGE.HeaderText = "종료일자";
            this.END_DATE_IDMANAGE.Name = "END_DATE_IDMANAGE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rmk_text);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.user_braid_text);
            this.panel1.Controls.Add(this.user_per_text);
            this.panel1.Controls.Add(this.end_date_text);
            this.panel1.Controls.Add(this.edit_date_text);
            this.panel1.Controls.Add(this.cre_date_text);
            this.panel1.Controls.Add(this.user_cust_id_text);
            this.panel1.Controls.Add(this.user_psd_text);
            this.panel1.Controls.Add(this.user_name_text);
            this.panel1.Controls.Add(this.user_id_text);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 529);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 140);
            this.panel1.TabIndex = 2;
            // 
            // rmk_text
            // 
            this.rmk_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rmk_text.Location = new System.Drawing.Point(797, 9);
            this.rmk_text.Name = "rmk_text";
            this.rmk_text.Size = new System.Drawing.Size(398, 119);
            this.rmk_text.TabIndex = 22;
            this.rmk_text.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(734, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "비고";
            // 
            // user_braid_text
            // 
            this.user_braid_text.Location = new System.Drawing.Point(560, 43);
            this.user_braid_text.Name = "user_braid_text";
            this.user_braid_text.Size = new System.Drawing.Size(135, 21);
            this.user_braid_text.TabIndex = 20;
            // 
            // user_per_text
            // 
            this.user_per_text.Location = new System.Drawing.Point(560, 9);
            this.user_per_text.Name = "user_per_text";
            this.user_per_text.Size = new System.Drawing.Size(135, 21);
            this.user_per_text.TabIndex = 19;
            // 
            // end_date_text
            // 
            this.end_date_text.Location = new System.Drawing.Point(295, 70);
            this.end_date_text.Name = "end_date_text";
            this.end_date_text.Size = new System.Drawing.Size(135, 21);
            this.end_date_text.TabIndex = 18;
            // 
            // edit_date_text
            // 
            this.edit_date_text.Location = new System.Drawing.Point(295, 40);
            this.edit_date_text.Name = "edit_date_text";
            this.edit_date_text.Size = new System.Drawing.Size(135, 21);
            this.edit_date_text.TabIndex = 17;
            // 
            // cre_date_text
            // 
            this.cre_date_text.Location = new System.Drawing.Point(295, 9);
            this.cre_date_text.Name = "cre_date_text";
            this.cre_date_text.Size = new System.Drawing.Size(135, 21);
            this.cre_date_text.TabIndex = 16;
            // 
            // user_cust_id_text
            // 
            this.user_cust_id_text.Location = new System.Drawing.Point(80, 107);
            this.user_cust_id_text.Name = "user_cust_id_text";
            this.user_cust_id_text.Size = new System.Drawing.Size(135, 21);
            this.user_cust_id_text.TabIndex = 15;
            // 
            // user_psd_text
            // 
            this.user_psd_text.Location = new System.Drawing.Point(80, 70);
            this.user_psd_text.Name = "user_psd_text";
            this.user_psd_text.Size = new System.Drawing.Size(135, 21);
            this.user_psd_text.TabIndex = 14;
            // 
            // user_name_text
            // 
            this.user_name_text.Location = new System.Drawing.Point(80, 39);
            this.user_name_text.Name = "user_name_text";
            this.user_name_text.Size = new System.Drawing.Size(135, 21);
            this.user_name_text.TabIndex = 13;
            // 
            // user_id_text
            // 
            this.user_id_text.Location = new System.Drawing.Point(80, 9);
            this.user_id_text.Name = "user_id_text";
            this.user_id_text.Size = new System.Drawing.Size(135, 21);
            this.user_id_text.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(474, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "영업소";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(474, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "사용자 권한";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "종료일자";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "변경일자";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "생성일자";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "거래처";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "사용자 이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "사용자 ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "상세내용";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "조건 조회";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox12);
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(810, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 132);
            this.panel2.TabIndex = 4;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(99, 88);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(159, 21);
            this.textBox12.TabIndex = 6;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(99, 51);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(159, 21);
            this.textBox11.TabIndex = 5;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(99, 10);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(159, 21);
            this.textBox10.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "사용자 ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "사용자 이름";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "거래처 명";
            // 
            // IdManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1307, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Id_dataGridView1);
            this.Controls.Add(this.SELECT_ALL_BUTTON);
            this.Name = "IdManage";
            this.Text = "IdManage";
            this.Load += new System.EventHandler(this.IaManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Id_dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SELECT_ALL_BUTTON;
        private System.Windows.Forms.DataGridView Id_dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rmk_text;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox user_braid_text;
        private System.Windows.Forms.TextBox user_per_text;
        private System.Windows.Forms.TextBox end_date_text;
        private System.Windows.Forms.TextBox edit_date_text;
        private System.Windows.Forms.TextBox cre_date_text;
        private System.Windows.Forms.TextBox user_cust_id_text;
        private System.Windows.Forms.TextBox user_psd_text;
        private System.Windows.Forms.TextBox user_name_text;
        private System.Windows.Forms.TextBox user_id_text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_ID_IDMANAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_NAME_IDMANAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSD_IDMANAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUST_ID_IDMANAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRA_ID_IDMANAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_PER_IDMANAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRE_DATE_IDMANAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDIT_DATE_IDMANAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn END_DATE_IDMANAGE;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
    }
}
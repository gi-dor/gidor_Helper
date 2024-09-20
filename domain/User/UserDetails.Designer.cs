namespace gidor_Helper
{
    partial class UserDetails
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
            this.selectButton = new System.Windows.Forms.Button();
            this.user_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.user_dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SELECT_BUTTON = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.USR_ID902 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USR_NAME902 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSD902 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRA_ID902 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGY_ID902 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRE_DATE902 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT_DATE902 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RMK902 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRS_NAME902 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUST_ID401 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUST_NAME401 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_CONT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(469, 167);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(148, 30);
            this.selectButton.TabIndex = 8;
            this.selectButton.Text = "전체 조회";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // user_dataGridView1
            // 
            this.user_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.user_dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.user_dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.user_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUST_ID401,
            this.CUST_NAME401,
            this.COD_COD,
            this.COD_CONT});
            this.user_dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_dataGridView1.Location = new System.Drawing.Point(12, 238);
            this.user_dataGridView1.Name = "user_dataGridView1";
            this.user_dataGridView1.ReadOnly = true;
            this.user_dataGridView1.RowTemplate.Height = 23;
            this.user_dataGridView1.RowTemplate.ReadOnly = true;
            this.user_dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.user_dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.user_dataGridView1.Size = new System.Drawing.Size(1283, 161);
            this.user_dataGridView1.TabIndex = 11;
            this.user_dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.User_Detail);
            // 
            // user_dataGridView2
            // 
            this.user_dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.user_dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.user_dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.user_dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USR_ID902,
            this.USR_NAME902,
            this.PSD902,
            this.BRA_ID902,
            this.AGY_ID902,
            this.CRE_DATE902,
            this.EDIT_DATE902,
            this.RMK902,
            this.TRS_NAME902});
            this.user_dataGridView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_dataGridView2.Location = new System.Drawing.Point(12, 425);
            this.user_dataGridView2.Name = "user_dataGridView2";
            this.user_dataGridView2.ReadOnly = true;
            this.user_dataGridView2.RowTemplate.Height = 23;
            this.user_dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.user_dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.user_dataGridView2.Size = new System.Drawing.Size(1283, 252);
            this.user_dataGridView2.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SELECT_BUTTON);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(23, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 199);
            this.panel2.TabIndex = 13;
            // 
            // SELECT_BUTTON
            // 
            this.SELECT_BUTTON.Location = new System.Drawing.Point(284, 156);
            this.SELECT_BUTTON.Name = "SELECT_BUTTON";
            this.SELECT_BUTTON.Size = new System.Drawing.Size(105, 28);
            this.SELECT_BUTTON.TabIndex = 3;
            this.SELECT_BUTTON.Text = "조건 조회";
            this.SELECT_BUTTON.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "날짜B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "날짜A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "영업소";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "송장번호";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(74, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 21);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(74, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 21);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 21);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 21);
            this.textBox1.TabIndex = 1;
            // 
            // USR_ID902
            // 
            this.USR_ID902.HeaderText = "USR_ID";
            this.USR_ID902.Name = "USR_ID902";
            this.USR_ID902.ReadOnly = true;
            // 
            // USR_NAME902
            // 
            this.USR_NAME902.HeaderText = "USR_NAME";
            this.USR_NAME902.Name = "USR_NAME902";
            this.USR_NAME902.ReadOnly = true;
            // 
            // PSD902
            // 
            this.PSD902.HeaderText = "PSD";
            this.PSD902.Name = "PSD902";
            this.PSD902.ReadOnly = true;
            // 
            // BRA_ID902
            // 
            this.BRA_ID902.HeaderText = "BRA_ID";
            this.BRA_ID902.Name = "BRA_ID902";
            this.BRA_ID902.ReadOnly = true;
            // 
            // AGY_ID902
            // 
            this.AGY_ID902.HeaderText = "AGY_ID";
            this.AGY_ID902.Name = "AGY_ID902";
            this.AGY_ID902.ReadOnly = true;
            // 
            // CRE_DATE902
            // 
            this.CRE_DATE902.HeaderText = "CRE_DATE";
            this.CRE_DATE902.Name = "CRE_DATE902";
            this.CRE_DATE902.ReadOnly = true;
            // 
            // EDIT_DATE902
            // 
            this.EDIT_DATE902.HeaderText = "EDIT_DATE";
            this.EDIT_DATE902.Name = "EDIT_DATE902";
            this.EDIT_DATE902.ReadOnly = true;
            // 
            // RMK902
            // 
            this.RMK902.HeaderText = "RMK";
            this.RMK902.Name = "RMK902";
            this.RMK902.ReadOnly = true;
            // 
            // TRS_NAME902
            // 
            this.TRS_NAME902.HeaderText = "TRS_NAME";
            this.TRS_NAME902.Name = "TRS_NAME902";
            this.TRS_NAME902.ReadOnly = true;
            // 
            // CUST_ID401
            // 
            this.CUST_ID401.HeaderText = "거래처";
            this.CUST_ID401.Name = "CUST_ID401";
            this.CUST_ID401.ReadOnly = true;
            // 
            // CUST_NAME401
            // 
            this.CUST_NAME401.HeaderText = "거래처 명";
            this.CUST_NAME401.Name = "CUST_NAME401";
            this.CUST_NAME401.ReadOnly = true;
            // 
            // COD_COD
            // 
            this.COD_COD.HeaderText = "상태 구분";
            this.COD_COD.Name = "COD_COD";
            this.COD_COD.ReadOnly = true;
            // 
            // COD_CONT
            // 
            this.COD_CONT.HeaderText = "시스템 분류";
            this.COD_CONT.Name = "COD_CONT";
            this.COD_CONT.ReadOnly = true;
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1307, 712);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.user_dataGridView2);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.user_dataGridView1);
            this.Name = "UserDetails";
            this.Text = "UserDetails";
            this.Load += new System.EventHandler(this.UserDeatil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.DataGridView user_dataGridView1;
        private System.Windows.Forms.DataGridView user_dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SELECT_BUTTON;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUST_ID401;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUST_NAME401;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CONT;
        private System.Windows.Forms.DataGridViewTextBoxColumn USR_ID902;
        private System.Windows.Forms.DataGridViewTextBoxColumn USR_NAME902;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSD902;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRA_ID902;
        private System.Windows.Forms.DataGridViewTextBoxColumn AGY_ID902;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRE_DATE902;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDIT_DATE902;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMK902;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRS_NAME902;
    }
}
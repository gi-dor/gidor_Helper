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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.user_dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DEPARTMENT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTMENT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTMENT_COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATED_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPDATED_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.selectButton);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 104);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "거래처 : ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox2.Location = new System.Drawing.Point(428, 30);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(171, 20);
            this.comboBox2.TabIndex = 4;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(707, 33);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(148, 30);
            this.selectButton.TabIndex = 8;
            this.selectButton.Text = "조회";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(101, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(291, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "사용자 ID / NAME : ";
            // 
            // user_dataGridView1
            // 
            this.user_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.user_dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.user_dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.user_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DEPARTMENT_NO,
            this.DEPARTMENT_NAME,
            this.DEPARTMENT_COD,
            this.CREATED_DATE,
            this.UPDATED_DATE});
            this.user_dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.user_dataGridView1.Name = "user_dataGridView1";
            this.user_dataGridView1.ReadOnly = true;
            this.user_dataGridView1.RowTemplate.Height = 23;
            this.user_dataGridView1.RowTemplate.ReadOnly = true;
            this.user_dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.user_dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.user_dataGridView1.Size = new System.Drawing.Size(1160, 161);
            this.user_dataGridView1.TabIndex = 11;
            this.user_dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.User_Detail);
            // 
            // user_dataGridView2
            // 
            this.user_dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.user_dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.user_dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.user_dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_dataGridView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_dataGridView2.Location = new System.Drawing.Point(13, 297);
            this.user_dataGridView2.Name = "user_dataGridView2";
            this.user_dataGridView2.ReadOnly = true;
            this.user_dataGridView2.RowTemplate.Height = 23;
            this.user_dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.user_dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.user_dataGridView2.Size = new System.Drawing.Size(1159, 302);
            this.user_dataGridView2.TabIndex = 12;
            // 
            // DEPARTMENT_NO
            // 
            this.DEPARTMENT_NO.HeaderText = "DEPARTMENT_NO";
            this.DEPARTMENT_NO.Name = "DEPARTMENT_NO";
            this.DEPARTMENT_NO.ReadOnly = true;
            // 
            // DEPARTMENT_NAME
            // 
            this.DEPARTMENT_NAME.HeaderText = "DEPARTMENT_NAME";
            this.DEPARTMENT_NAME.Name = "DEPARTMENT_NAME";
            this.DEPARTMENT_NAME.ReadOnly = true;
            // 
            // DEPARTMENT_COD
            // 
            this.DEPARTMENT_COD.HeaderText = "DEPARTMENT_COD";
            this.DEPARTMENT_COD.Name = "DEPARTMENT_COD";
            this.DEPARTMENT_COD.ReadOnly = true;
            // 
            // CREATED_DATE
            // 
            this.CREATED_DATE.HeaderText = "CREATED_DATE";
            this.CREATED_DATE.Name = "CREATED_DATE";
            this.CREATED_DATE.ReadOnly = true;
            // 
            // UPDATED_DATE
            // 
            this.UPDATED_DATE.HeaderText = "UPDATED_DATE";
            this.UPDATED_DATE.Name = "UPDATED_DATE";
            this.UPDATED_DATE.ReadOnly = true;
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1184, 671);
            this.Controls.Add(this.user_dataGridView2);
            this.Controls.Add(this.user_dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "UserDetails";
            this.Text = "UserDetails";
            this.Load += new System.EventHandler(this.UserDeatil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView user_dataGridView1;
        private System.Windows.Forms.DataGridView user_dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTMENT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTMENT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTMENT_COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATED_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPDATED_DATE;
    }
}
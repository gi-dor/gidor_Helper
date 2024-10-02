namespace gidor_Helper.domain.manage
{
    partial class BraManage
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
            this.BradataGridView1 = new System.Windows.Forms.DataGridView();
            this.SELECT_ALL_BUTTON = new System.Windows.Forms.Button();
            this.EXCEL_EXPORT_BUTTON = new System.Windows.Forms.Button();
            this.운영_운영_radio = new System.Windows.Forms.RadioButton();
            this.운영_폐쇄_radio = new System.Windows.Forms.RadioButton();
            this.운영_전체_radio = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.영업소_combo = new System.Windows.Forms.ComboBox();
            this.직영구분_combo = new System.Windows.Forms.ComboBox();
            this.권역구분_combo = new System.Windows.Forms.ComboBox();
            this.집배구분_combo = new System.Windows.Forms.ComboBox();
            this.점포구분_combo = new System.Windows.Forms.ComboBox();
            this.운영구분_combo = new System.Windows.Forms.ComboBox();
            this.그룹_text = new System.Windows.Forms.TextBox();
            this.전화번호_text = new System.Windows.Forms.TextBox();
            this.영업소장이름_text = new System.Windows.Forms.TextBox();
            this.영업소이름_text = new System.Windows.Forms.TextBox();
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
            this.label12 = new System.Windows.Forms.Label();
            this.count_value = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.영업소_코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.영업소_이름 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.운영구분 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.점포구분 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.집배가능_구분 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.권역구분 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.직영구분 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.영업소장_이름 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전화번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.그룹 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BradataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BradataGridView1
            // 
            this.BradataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BradataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.BradataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.영업소_코드,
            this.영업소_이름,
            this.운영구분,
            this.점포구분,
            this.집배가능_구분,
            this.권역구분,
            this.직영구분,
            this.영업소장_이름,
            this.전화번호,
            this.그룹});
            this.BradataGridView1.Location = new System.Drawing.Point(12, 68);
            this.BradataGridView1.Name = "BradataGridView1";
            this.BradataGridView1.RowTemplate.Height = 23;
            this.BradataGridView1.Size = new System.Drawing.Size(1042, 584);
            this.BradataGridView1.TabIndex = 0;
            this.BradataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_Click_Detail);
            // 
            // SELECT_ALL_BUTTON
            // 
            this.SELECT_ALL_BUTTON.Location = new System.Drawing.Point(219, 12);
            this.SELECT_ALL_BUTTON.Name = "SELECT_ALL_BUTTON";
            this.SELECT_ALL_BUTTON.Size = new System.Drawing.Size(91, 36);
            this.SELECT_ALL_BUTTON.TabIndex = 1;
            this.SELECT_ALL_BUTTON.Text = "전체검색";
            this.SELECT_ALL_BUTTON.UseVisualStyleBackColor = true;
            this.SELECT_ALL_BUTTON.Click += new System.EventHandler(this.SELECT_ALL_BUTTON_Click);
            // 
            // EXCEL_EXPORT_BUTTON
            // 
            this.EXCEL_EXPORT_BUTTON.Location = new System.Drawing.Point(359, 12);
            this.EXCEL_EXPORT_BUTTON.Name = "EXCEL_EXPORT_BUTTON";
            this.EXCEL_EXPORT_BUTTON.Size = new System.Drawing.Size(124, 36);
            this.EXCEL_EXPORT_BUTTON.TabIndex = 2;
            this.EXCEL_EXPORT_BUTTON.Text = "Excel 내보내기";
            this.EXCEL_EXPORT_BUTTON.UseVisualStyleBackColor = true;
            this.EXCEL_EXPORT_BUTTON.Click += new System.EventHandler(this.EXCEL_EXPORT_BUTTON_Click);
            // 
            // 운영_운영_radio
            // 
            this.운영_운영_radio.AutoSize = true;
            this.운영_운영_radio.Location = new System.Drawing.Point(12, 32);
            this.운영_운영_radio.Name = "운영_운영_radio";
            this.운영_운영_radio.Size = new System.Drawing.Size(47, 16);
            this.운영_운영_radio.TabIndex = 3;
            this.운영_운영_radio.Text = "운영";
            this.운영_운영_radio.UseVisualStyleBackColor = true;
            // 
            // 운영_폐쇄_radio
            // 
            this.운영_폐쇄_radio.AutoSize = true;
            this.운영_폐쇄_radio.Location = new System.Drawing.Point(79, 32);
            this.운영_폐쇄_radio.Name = "운영_폐쇄_radio";
            this.운영_폐쇄_radio.Size = new System.Drawing.Size(47, 16);
            this.운영_폐쇄_radio.TabIndex = 4;
            this.운영_폐쇄_radio.Text = "폐쇄";
            this.운영_폐쇄_radio.UseVisualStyleBackColor = true;
            // 
            // 운영_전체_radio
            // 
            this.운영_전체_radio.AutoSize = true;
            this.운영_전체_radio.Checked = true;
            this.운영_전체_radio.Location = new System.Drawing.Point(144, 32);
            this.운영_전체_radio.Name = "운영_전체_radio";
            this.운영_전체_radio.Size = new System.Drawing.Size(47, 16);
            this.운영_전체_radio.TabIndex = 5;
            this.운영_전체_radio.TabStop = true;
            this.운영_전체_radio.Text = "전체";
            this.운영_전체_radio.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.영업소_combo);
            this.panel1.Controls.Add(this.직영구분_combo);
            this.panel1.Controls.Add(this.권역구분_combo);
            this.panel1.Controls.Add(this.집배구분_combo);
            this.panel1.Controls.Add(this.점포구분_combo);
            this.panel1.Controls.Add(this.운영구분_combo);
            this.panel1.Controls.Add(this.그룹_text);
            this.panel1.Controls.Add(this.전화번호_text);
            this.panel1.Controls.Add(this.영업소장이름_text);
            this.panel1.Controls.Add(this.영업소이름_text);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1101, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 403);
            this.panel1.TabIndex = 6;
            // 
            // 영업소_combo
            // 
            this.영업소_combo.FormattingEnabled = true;
            this.영업소_combo.Location = new System.Drawing.Point(93, 12);
            this.영업소_combo.Name = "영업소_combo";
            this.영업소_combo.Size = new System.Drawing.Size(161, 20);
            this.영업소_combo.TabIndex = 22;
            // 
            // 직영구분_combo
            // 
            this.직영구분_combo.FormattingEnabled = true;
            this.직영구분_combo.Location = new System.Drawing.Point(93, 220);
            this.직영구분_combo.Name = "직영구분_combo";
            this.직영구분_combo.Size = new System.Drawing.Size(161, 20);
            this.직영구분_combo.TabIndex = 21;
            // 
            // 권역구분_combo
            // 
            this.권역구분_combo.FormattingEnabled = true;
            this.권역구분_combo.Location = new System.Drawing.Point(93, 184);
            this.권역구분_combo.Name = "권역구분_combo";
            this.권역구분_combo.Size = new System.Drawing.Size(161, 20);
            this.권역구분_combo.TabIndex = 20;
            // 
            // 집배구분_combo
            // 
            this.집배구분_combo.FormattingEnabled = true;
            this.집배구분_combo.Location = new System.Drawing.Point(93, 148);
            this.집배구분_combo.Name = "집배구분_combo";
            this.집배구분_combo.Size = new System.Drawing.Size(161, 20);
            this.집배구분_combo.TabIndex = 19;
            // 
            // 점포구분_combo
            // 
            this.점포구분_combo.FormattingEnabled = true;
            this.점포구분_combo.Location = new System.Drawing.Point(93, 114);
            this.점포구분_combo.Name = "점포구분_combo";
            this.점포구분_combo.Size = new System.Drawing.Size(161, 20);
            this.점포구분_combo.TabIndex = 18;
            // 
            // 운영구분_combo
            // 
            this.운영구분_combo.FormattingEnabled = true;
            this.운영구분_combo.Location = new System.Drawing.Point(93, 79);
            this.운영구분_combo.Name = "운영구분_combo";
            this.운영구분_combo.Size = new System.Drawing.Size(161, 20);
            this.운영구분_combo.TabIndex = 17;
            // 
            // 그룹_text
            // 
            this.그룹_text.Location = new System.Drawing.Point(93, 325);
            this.그룹_text.Name = "그룹_text";
            this.그룹_text.Size = new System.Drawing.Size(161, 21);
            this.그룹_text.TabIndex = 15;
            // 
            // 전화번호_text
            // 
            this.전화번호_text.Location = new System.Drawing.Point(93, 291);
            this.전화번호_text.Name = "전화번호_text";
            this.전화번호_text.Size = new System.Drawing.Size(161, 21);
            this.전화번호_text.TabIndex = 14;
            // 
            // 영업소장이름_text
            // 
            this.영업소장이름_text.Location = new System.Drawing.Point(93, 261);
            this.영업소장이름_text.Name = "영업소장이름_text";
            this.영업소장이름_text.Size = new System.Drawing.Size(161, 21);
            this.영업소장이름_text.TabIndex = 13;
            // 
            // 영업소이름_text
            // 
            this.영업소이름_text.Location = new System.Drawing.Point(93, 48);
            this.영업소이름_text.Name = "영업소이름_text";
            this.영업소이름_text.Size = new System.Drawing.Size(161, 21);
            this.영업소이름_text.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "그룹";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "전화번호";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "영업소장 이름";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "직영구분";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "권역구분";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "집배가능구분";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "점포구분";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "운영구분";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "영업소 이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "영업소코드";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1099, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "상세정보";
            // 
            // count_value
            // 
            this.count_value.AutoSize = true;
            this.count_value.Location = new System.Drawing.Point(993, 34);
            this.count_value.Name = "count_value";
            this.count_value.Size = new System.Drawing.Size(61, 12);
            this.count_value.TabIndex = 13;
            this.count_value.Text = "              ";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(906, 34);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(81, 12);
            this.count.TabIndex = 12;
            this.count.Text = "조회된 건수 : ";
            // 
            // 영업소_코드
            // 
            this.영업소_코드.HeaderText = "영업소 코드";
            this.영업소_코드.Name = "영업소_코드";
            // 
            // 영업소_이름
            // 
            this.영업소_이름.HeaderText = "영업소";
            this.영업소_이름.Name = "영업소_이름";
            // 
            // 운영구분
            // 
            this.운영구분.HeaderText = "운영구분";
            this.운영구분.Name = "운영구분";
            // 
            // 점포구분
            // 
            this.점포구분.HeaderText = "점포구분";
            this.점포구분.Name = "점포구분";
            // 
            // 집배가능_구분
            // 
            this.집배가능_구분.HeaderText = "집배가능 구분";
            this.집배가능_구분.Name = "집배가능_구분";
            // 
            // 권역구분
            // 
            this.권역구분.HeaderText = "권역구분";
            this.권역구분.Name = "권역구분";
            // 
            // 직영구분
            // 
            this.직영구분.HeaderText = "직영구분";
            this.직영구분.Name = "직영구분";
            // 
            // 영업소장_이름
            // 
            this.영업소장_이름.HeaderText = "영업소장 이름";
            this.영업소장_이름.Name = "영업소장_이름";
            // 
            // 전화번호
            // 
            this.전화번호.HeaderText = "전화번호";
            this.전화번호.Name = "전화번호";
            // 
            // 그룹
            // 
            this.그룹.HeaderText = "그룹";
            this.그룹.Name = "그룹";
            // 
            // BraManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1423, 681);
            this.Controls.Add(this.count_value);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.운영_전체_radio);
            this.Controls.Add(this.운영_폐쇄_radio);
            this.Controls.Add(this.운영_운영_radio);
            this.Controls.Add(this.EXCEL_EXPORT_BUTTON);
            this.Controls.Add(this.SELECT_ALL_BUTTON);
            this.Controls.Add(this.BradataGridView1);
            this.Name = "BraManage";
            this.Text = "BraManage";
            this.Load += new System.EventHandler(this.BraManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BradataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BradataGridView1;
        private System.Windows.Forms.Button SELECT_ALL_BUTTON;
        private System.Windows.Forms.Button EXCEL_EXPORT_BUTTON;
        private System.Windows.Forms.RadioButton 운영_운영_radio;
        private System.Windows.Forms.RadioButton 운영_폐쇄_radio;
        private System.Windows.Forms.RadioButton 운영_전체_radio;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox 그룹_text;
        private System.Windows.Forms.TextBox 전화번호_text;
        private System.Windows.Forms.TextBox 영업소장이름_text;
        private System.Windows.Forms.TextBox 영업소이름_text;
        private System.Windows.Forms.ComboBox 직영구분_combo;
        private System.Windows.Forms.ComboBox 권역구분_combo;
        private System.Windows.Forms.ComboBox 집배구분_combo;
        private System.Windows.Forms.ComboBox 점포구분_combo;
        private System.Windows.Forms.ComboBox 운영구분_combo;
        private System.Windows.Forms.ComboBox 영업소_combo;
        private System.Windows.Forms.Label count_value;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.DataGridViewTextBoxColumn 영업소_코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 영업소_이름;
        private System.Windows.Forms.DataGridViewTextBoxColumn 운영구분;
        private System.Windows.Forms.DataGridViewTextBoxColumn 점포구분;
        private System.Windows.Forms.DataGridViewTextBoxColumn 집배가능_구분;
        private System.Windows.Forms.DataGridViewTextBoxColumn 권역구분;
        private System.Windows.Forms.DataGridViewTextBoxColumn 직영구분;
        private System.Windows.Forms.DataGridViewTextBoxColumn 영업소장_이름;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전화번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 그룹;
    }
}
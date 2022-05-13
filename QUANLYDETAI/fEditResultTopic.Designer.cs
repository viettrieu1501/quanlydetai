
namespace QUANLYDETAI
{
    partial class fEditResultTopic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEditResultTopic));
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dpkProtection = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.numPoint = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameTopic = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.cbContent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbRewardForm = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.guna2ImageButton1.Location = new System.Drawing.Point(464, 8);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(40, 25);
            this.guna2ImageButton1.TabIndex = 176;
            this.guna2ImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbRewardForm);
            this.groupBox2.Controls.Add(this.cbContent);
            this.groupBox2.Controls.Add(this.dpkProtection);
            this.groupBox2.Controls.Add(this.numPoint);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNameTopic);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            this.groupBox2.Location = new System.Drawing.Point(8, 56);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(487, 243);
            this.groupBox2.TabIndex = 173;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin kết quả";
            // 
            // dpkProtection
            // 
            this.dpkProtection.Checked = true;
            this.dpkProtection.FillColor = System.Drawing.Color.White;
            this.dpkProtection.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkProtection.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkProtection.Location = new System.Drawing.Point(245, 58);
            this.dpkProtection.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpkProtection.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpkProtection.Name = "dpkProtection";
            this.dpkProtection.Size = new System.Drawing.Size(228, 36);
            this.dpkProtection.TabIndex = 157;
            this.dpkProtection.Value = new System.DateTime(2022, 4, 21, 21, 44, 59, 571);
            // 
            // numPoint
            // 
            this.numPoint.BackColor = System.Drawing.Color.Transparent;
            this.numPoint.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.numPoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numPoint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numPoint.ForeColor = System.Drawing.Color.Black;
            this.numPoint.Location = new System.Drawing.Point(15, 201);
            this.numPoint.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPoint.Name = "numPoint";
            this.numPoint.Size = new System.Drawing.Size(225, 36);
            this.numPoint.TabIndex = 156;
            this.numPoint.UpDownButtonFillColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(11, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 148;
            this.label2.Text = "Điểm:";
            // 
            // txtNameTopic
            // 
            this.txtNameTopic.BackColor = System.Drawing.Color.Transparent;
            this.txtNameTopic.BaseColor = System.Drawing.Color.White;
            this.txtNameTopic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.txtNameTopic.BorderSize = 1;
            this.txtNameTopic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameTopic.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNameTopic.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            this.txtNameTopic.FocusedForeColor = System.Drawing.Color.Empty;
            this.txtNameTopic.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameTopic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNameTopic.Location = new System.Drawing.Point(15, 58);
            this.txtNameTopic.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameTopic.Name = "txtNameTopic";
            this.txtNameTopic.PasswordChar = '\0';
            this.txtNameTopic.Radius = 2;
            this.txtNameTopic.SelectedText = "";
            this.txtNameTopic.Size = new System.Drawing.Size(225, 36);
            this.txtNameTopic.TabIndex = 126;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(244, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 52;
            this.label6.Text = "Ngày bảo vệ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(241, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Hình thức khen thưởng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(11, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Tên đề tài:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(11, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Nội dung:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 37);
            this.label1.TabIndex = 172;
            this.label1.Text = "Kết quả đề tài";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 3;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.btnUpdate.Location = new System.Drawing.Point(395, 313);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 36);
            this.btnUpdate.TabIndex = 178;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 3;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(63)))));
            this.btnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.btnExit.Location = new System.Drawing.Point(289, 313);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 36);
            this.btnExit.TabIndex = 177;
            this.btnExit.Text = "Hủy";
            this.btnExit.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // cbContent
            // 
            this.cbContent.BackColor = System.Drawing.Color.Transparent;
            this.cbContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.cbContent.BorderRadius = 2;
            this.cbContent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbContent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContent.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            this.cbContent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            this.cbContent.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbContent.ItemHeight = 30;
            this.cbContent.Items.AddRange(new object[] {
            "Đạt loại xuất sắc",
            "Đạt loại giỏi",
            "Đạt loại khá",
            "Không hoàn thành"});
            this.cbContent.Location = new System.Drawing.Point(15, 127);
            this.cbContent.Name = "cbContent";
            this.cbContent.Size = new System.Drawing.Size(225, 36);
            this.cbContent.TabIndex = 160;
            // 
            // cbRewardForm
            // 
            this.cbRewardForm.BackColor = System.Drawing.Color.Transparent;
            this.cbRewardForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.cbRewardForm.BorderRadius = 2;
            this.cbRewardForm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRewardForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRewardForm.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            this.cbRewardForm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            this.cbRewardForm.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbRewardForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbRewardForm.ItemHeight = 30;
            this.cbRewardForm.Items.AddRange(new object[] {
            "",
            "Bằng khen",
            "Giấy khen"});
            this.cbRewardForm.Location = new System.Drawing.Point(245, 128);
            this.cbRewardForm.Name = "cbRewardForm";
            this.cbRewardForm.Size = new System.Drawing.Size(228, 36);
            this.cbRewardForm.TabIndex = 161;
            // 
            // fEditResultTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 361);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fEditResultTopic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fEditResultTopic";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2NumericUpDown numPoint;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtNameTopic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpkProtection;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2ComboBox cbRewardForm;
        private Guna.UI2.WinForms.Guna2ComboBox cbContent;
    }
}
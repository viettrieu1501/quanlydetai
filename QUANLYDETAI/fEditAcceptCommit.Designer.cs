
namespace QUANLYDETAI
{
    partial class fEditAcceptCommit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEditAcceptCommit));
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbAcceptCommit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dpkAccecpt = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtNameTopic = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2.SuspendLayout();
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
            this.guna2ImageButton1.Location = new System.Drawing.Point(297, 5);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(40, 25);
            this.guna2ImageButton1.TabIndex = 162;
            this.guna2ImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 37);
            this.label1.TabIndex = 159;
            this.label1.Text = "Hội đồng nghiệm thu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbAcceptCommit);
            this.groupBox2.Controls.Add(this.dpkAccecpt);
            this.groupBox2.Controls.Add(this.txtNameTopic);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            this.groupBox2.Location = new System.Drawing.Point(6, 61);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(319, 218);
            this.groupBox2.TabIndex = 158;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hội đồng";
            // 
            // cbAcceptCommit
            // 
            this.cbAcceptCommit.BackColor = System.Drawing.Color.Transparent;
            this.cbAcceptCommit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.cbAcceptCommit.BorderRadius = 2;
            this.cbAcceptCommit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAcceptCommit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAcceptCommit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            this.cbAcceptCommit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            this.cbAcceptCommit.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbAcceptCommit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbAcceptCommit.ItemHeight = 30;
            this.cbAcceptCommit.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbAcceptCommit.Location = new System.Drawing.Point(17, 107);
            this.cbAcceptCommit.Name = "cbAcceptCommit";
            this.cbAcceptCommit.Size = new System.Drawing.Size(283, 36);
            this.cbAcceptCommit.TabIndex = 159;
            // 
            // dpkAccecpt
            // 
            this.dpkAccecpt.Checked = true;
            this.dpkAccecpt.FillColor = System.Drawing.Color.White;
            this.dpkAccecpt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkAccecpt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkAccecpt.Location = new System.Drawing.Point(17, 170);
            this.dpkAccecpt.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpkAccecpt.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpkAccecpt.Name = "dpkAccecpt";
            this.dpkAccecpt.Size = new System.Drawing.Size(283, 36);
            this.dpkAccecpt.TabIndex = 158;
            this.dpkAccecpt.Value = new System.DateTime(2022, 4, 21, 21, 44, 59, 571);
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
            this.txtNameTopic.Location = new System.Drawing.Point(17, 47);
            this.txtNameTopic.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameTopic.Name = "txtNameTopic";
            this.txtNameTopic.PasswordChar = '\0';
            this.txtNameTopic.Radius = 2;
            this.txtNameTopic.ReadOnly = true;
            this.txtNameTopic.SelectedText = "";
            this.txtNameTopic.Size = new System.Drawing.Size(283, 36);
            this.txtNameTopic.TabIndex = 152;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(13, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày nghiệm thu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(13, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên hội đồng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(13, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên đề tài:";
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
            this.btnUpdate.Location = new System.Drawing.Point(225, 284);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 36);
            this.btnUpdate.TabIndex = 175;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdateAcc_Click);
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
            this.btnExit.Location = new System.Drawing.Point(119, 284);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 36);
            this.btnExit.TabIndex = 174;
            this.btnExit.Text = "Hủy";
            this.btnExit.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // fEditAcceptCommit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(341, 330);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fEditAcceptCommit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fEditAcceptCommit";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaTextBox txtNameTopic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpkAccecpt;
        private Guna.UI2.WinForms.Guna2ComboBox cbAcceptCommit;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}
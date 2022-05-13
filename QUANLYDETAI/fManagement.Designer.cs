
namespace QUANLYDETAI
{
    partial class fManagement
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManagement));
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNN = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNameApp = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pMain = new System.Windows.Forms.Panel();
            this.tileReportTopic = new Guna.UI2.WinForms.Guna2TileButton();
            this.tileTopic = new Guna.UI2.WinForms.Guna2TileButton();
            this.tileAddTopic = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pMenu = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnIntroduct = new Guna.UI2.WinForms.Guna2GradientButton();
            this.MenuSettings = new System.Windows.Forms.Panel();
            this.btnChangePass = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAccountMana = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSetting = new Guna.UI2.WinForms.Guna2GradientButton();
            this.MenuManager = new System.Windows.Forms.Panel();
            this.btnOrganManager = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSpecMana = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnStaffManager = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnManager = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNavigationPanel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNN)).BeginInit();
            this.panel1.SuspendLayout();
            this.pMain.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.MenuSettings.SuspendLayout();
            this.MenuManager.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Quản lý đề tài";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            this.groupBox1.Location = new System.Drawing.Point(26, 233);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(407, 306);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(4, 12);
            this.chart.Margin = new System.Windows.Forms.Padding(2);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Tomato,
        System.Drawing.Color.Violet,
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.LimeGreen};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "{0:0.##}%";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "nd";
            series1.YValueMembers = "tl";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(399, 289);
            this.chart.TabIndex = 22;
            this.chart.Text = "chart";
            title1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Tỉ lệ đề tài theo cấp năm 2021";
            this.chart.Titles.Add(title1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNN);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(51)))));
            this.groupBox2.Location = new System.Drawing.Point(454, 233);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(365, 306);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đề tài cấp nhà nước";
            // 
            // dgvNN
            // 
            this.dgvNN.AllowUserToAddRows = false;
            this.dgvNN.AllowUserToDeleteRows = false;
            this.dgvNN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName});
            this.dgvNN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNN.Location = new System.Drawing.Point(2, 22);
            this.dgvNN.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNN.Name = "dgvNN";
            this.dgvNN.ReadOnly = true;
            this.dgvNN.RowHeadersVisible = false;
            this.dgvNN.RowHeadersWidth = 51;
            this.dgvNN.RowTemplate.Height = 24;
            this.dgvNN.Size = new System.Drawing.Size(361, 282);
            this.dgvNN.TabIndex = 1;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "MaDT";
            this.colID.HeaderText = "Mã đê tài";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 75;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "TenDT";
            this.colName.HeaderText = "Tên đề tài";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 280;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.lbNameApp);
            this.panel1.Controls.Add(this.guna2ImageButton1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 25);
            this.panel1.TabIndex = 137;
            // 
            // lbNameApp
            // 
            this.lbNameApp.AutoSize = true;
            this.lbNameApp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameApp.Location = new System.Drawing.Point(5, 3);
            this.lbNameApp.Name = "lbNameApp";
            this.lbNameApp.Size = new System.Drawing.Size(89, 17);
            this.lbNameApp.TabIndex = 2;
            this.lbNameApp.Text = "Quản lý đề tài";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.guna2ImageButton1.Location = new System.Drawing.Point(800, 0);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(40, 25);
            this.guna2ImageButton1.TabIndex = 0;
            this.guna2ImageButton1.Click += new System.EventHandler(this.btnClosedWin_Click);
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.tileReportTopic);
            this.pMain.Controls.Add(this.tileTopic);
            this.pMain.Controls.Add(this.tileAddTopic);
            this.pMain.Controls.Add(this.panel1);
            this.pMain.Controls.Add(this.groupBox2);
            this.pMain.Controls.Add(this.groupBox1);
            this.pMain.Controls.Add(this.label1);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pMain.Location = new System.Drawing.Point(174, 0);
            this.pMain.Margin = new System.Windows.Forms.Padding(2);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(840, 565);
            this.pMain.TabIndex = 22;
            // 
            // tileReportTopic
            // 
            this.tileReportTopic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tileReportTopic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tileReportTopic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tileReportTopic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tileReportTopic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.tileReportTopic.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileReportTopic.ForeColor = System.Drawing.Color.White;
            this.tileReportTopic.Image = global::QUANLYDETAI.Properties.Resources.statistics;
            this.tileReportTopic.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tileReportTopic.ImageOffset = new System.Drawing.Point(10, 20);
            this.tileReportTopic.ImageSize = new System.Drawing.Size(60, 60);
            this.tileReportTopic.Location = new System.Drawing.Point(566, 88);
            this.tileReportTopic.Name = "tileReportTopic";
            this.tileReportTopic.Size = new System.Drawing.Size(248, 105);
            this.tileReportTopic.TabIndex = 140;
            this.tileReportTopic.Text = "Báo cáo-thống kê";
            this.tileReportTopic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tileReportTopic.TextOffset = new System.Drawing.Point(80, -50);
            this.tileReportTopic.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // tileTopic
            // 
            this.tileTopic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tileTopic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tileTopic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tileTopic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tileTopic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.tileTopic.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileTopic.ForeColor = System.Drawing.Color.White;
            this.tileTopic.Image = global::QUANLYDETAI.Properties.Resources.report__2_;
            this.tileTopic.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tileTopic.ImageOffset = new System.Drawing.Point(10, 20);
            this.tileTopic.ImageSize = new System.Drawing.Size(60, 60);
            this.tileTopic.Location = new System.Drawing.Point(301, 88);
            this.tileTopic.Name = "tileTopic";
            this.tileTopic.Size = new System.Drawing.Size(248, 105);
            this.tileTopic.TabIndex = 139;
            this.tileTopic.Text = "Danh sách đề tài";
            this.tileTopic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tileTopic.TextOffset = new System.Drawing.Point(80, -50);
            this.tileTopic.Click += new System.EventHandler(this.tileTopic_Click);
            // 
            // tileAddTopic
            // 
            this.tileAddTopic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tileAddTopic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tileAddTopic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tileAddTopic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tileAddTopic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.tileAddTopic.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileAddTopic.ForeColor = System.Drawing.Color.White;
            this.tileAddTopic.Image = global::QUANLYDETAI.Properties.Resources.check_list__1_;
            this.tileAddTopic.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tileAddTopic.ImageOffset = new System.Drawing.Point(10, 20);
            this.tileAddTopic.ImageSize = new System.Drawing.Size(60, 60);
            this.tileAddTopic.Location = new System.Drawing.Point(30, 88);
            this.tileAddTopic.Name = "tileAddTopic";
            this.tileAddTopic.Size = new System.Drawing.Size(248, 105);
            this.tileAddTopic.TabIndex = 138;
            this.tileAddTopic.Text = "Đăng ký đề tài";
            this.tileAddTopic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tileAddTopic.TextOffset = new System.Drawing.Point(80, -50);
            this.tileAddTopic.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btnLogOut.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnLogOut.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnLogOut.Image = global::QUANLYDETAI.Properties.Resources.log_out;
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogOut.Location = new System.Drawing.Point(0, 459);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(174, 53);
            this.btnLogOut.TabIndex = 143;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pMenu
            // 
            this.pMenu.AllowDrop = true;
            this.pMenu.BackColor = System.Drawing.Color.Transparent;
            this.pMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pMenu.BackgroundImage")));
            this.pMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMenu.Controls.Add(this.btnLogOut);
            this.pMenu.Controls.Add(this.btnIntroduct);
            this.pMenu.Controls.Add(this.MenuSettings);
            this.pMenu.Controls.Add(this.btnSetting);
            this.pMenu.Controls.Add(this.MenuManager);
            this.pMenu.Controls.Add(this.btnManager);
            this.pMenu.Controls.Add(this.panel2);
            this.pMenu.Controls.Add(this.btnNavigationPanel);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.pMenu.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.pMenu.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.pMenu.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(174, 565);
            this.pMenu.TabIndex = 19;
            this.pMenu.Text = "gunaGradientPanel1";
            // 
            // btnIntroduct
            // 
            this.btnIntroduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIntroduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIntroduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIntroduct.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIntroduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIntroduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIntroduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btnIntroduct.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btnIntroduct.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntroduct.ForeColor = System.Drawing.Color.White;
            this.btnIntroduct.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnIntroduct.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnIntroduct.Image = global::QUANLYDETAI.Properties.Resources.info;
            this.btnIntroduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnIntroduct.ImageSize = new System.Drawing.Size(30, 30);
            this.btnIntroduct.Location = new System.Drawing.Point(0, 512);
            this.btnIntroduct.Name = "btnIntroduct";
            this.btnIntroduct.Size = new System.Drawing.Size(174, 53);
            this.btnIntroduct.TabIndex = 142;
            this.btnIntroduct.Text = "Giới thiệu";
            this.btnIntroduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnIntroduct.Click += new System.EventHandler(this.btnIntroduct_Click);
            // 
            // MenuSettings
            // 
            this.MenuSettings.Controls.Add(this.btnChangePass);
            this.MenuSettings.Controls.Add(this.btnAccountMana);
            this.MenuSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuSettings.Location = new System.Drawing.Point(0, 373);
            this.MenuSettings.Name = "MenuSettings";
            this.MenuSettings.Size = new System.Drawing.Size(174, 88);
            this.MenuSettings.TabIndex = 147;
            // 
            // btnChangePass
            // 
            this.btnChangePass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangePass.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangePass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.btnChangePass.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnChangePass.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnChangePass.Image = global::QUANLYDETAI.Properties.Resources.reload;
            this.btnChangePass.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChangePass.ImageSize = new System.Drawing.Size(25, 25);
            this.btnChangePass.Location = new System.Drawing.Point(0, 45);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(174, 45);
            this.btnChangePass.TabIndex = 146;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnAccountMana
            // 
            this.btnAccountMana.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccountMana.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccountMana.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccountMana.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccountMana.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccountMana.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccountMana.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.btnAccountMana.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.btnAccountMana.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAccountMana.ForeColor = System.Drawing.Color.White;
            this.btnAccountMana.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnAccountMana.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnAccountMana.Image = global::QUANLYDETAI.Properties.Resources.skills__2_;
            this.btnAccountMana.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccountMana.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAccountMana.Location = new System.Drawing.Point(0, 0);
            this.btnAccountMana.Name = "btnAccountMana";
            this.btnAccountMana.Size = new System.Drawing.Size(174, 45);
            this.btnAccountMana.TabIndex = 145;
            this.btnAccountMana.Text = "Quản lý tài khoản";
            this.btnAccountMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccountMana.Click += new System.EventHandler(this.btnAccountMana_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetting.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btnSetting.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnSetting.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnSetting.Image = global::QUANLYDETAI.Properties.Resources.settings__1_;
            this.btnSetting.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSetting.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSetting.Location = new System.Drawing.Point(0, 320);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(174, 53);
            this.btnSetting.TabIndex = 146;
            this.btnSetting.Text = "Hệ thống";
            this.btnSetting.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // MenuManager
            // 
            this.MenuManager.Controls.Add(this.btnOrganManager);
            this.MenuManager.Controls.Add(this.btnSpecMana);
            this.MenuManager.Controls.Add(this.btnStaffManager);
            this.MenuManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuManager.Location = new System.Drawing.Point(0, 185);
            this.MenuManager.Name = "MenuManager";
            this.MenuManager.Size = new System.Drawing.Size(174, 135);
            this.MenuManager.TabIndex = 142;
            // 
            // btnOrganManager
            // 
            this.btnOrganManager.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrganManager.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrganManager.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrganManager.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrganManager.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrganManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrganManager.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.btnOrganManager.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.btnOrganManager.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOrganManager.ForeColor = System.Drawing.Color.White;
            this.btnOrganManager.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnOrganManager.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnOrganManager.Image = global::QUANLYDETAI.Properties.Resources.corporate;
            this.btnOrganManager.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrganManager.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOrganManager.Location = new System.Drawing.Point(0, 90);
            this.btnOrganManager.Name = "btnOrganManager";
            this.btnOrganManager.Size = new System.Drawing.Size(174, 45);
            this.btnOrganManager.TabIndex = 144;
            this.btnOrganManager.Text = "Quản lý khoa";
            this.btnOrganManager.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrganManager.Click += new System.EventHandler(this.btnOrganManager_Click);
            // 
            // btnSpecMana
            // 
            this.btnSpecMana.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSpecMana.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSpecMana.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSpecMana.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSpecMana.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSpecMana.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpecMana.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.btnSpecMana.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.btnSpecMana.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSpecMana.ForeColor = System.Drawing.Color.White;
            this.btnSpecMana.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnSpecMana.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnSpecMana.Image = global::QUANLYDETAI.Properties.Resources.career;
            this.btnSpecMana.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSpecMana.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSpecMana.Location = new System.Drawing.Point(0, 45);
            this.btnSpecMana.Name = "btnSpecMana";
            this.btnSpecMana.Size = new System.Drawing.Size(174, 45);
            this.btnSpecMana.TabIndex = 143;
            this.btnSpecMana.Text = "Quản lý bộ môn";
            this.btnSpecMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSpecMana.Click += new System.EventHandler(this.btnSpecMana_Click);
            // 
            // btnStaffManager
            // 
            this.btnStaffManager.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStaffManager.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStaffManager.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaffManager.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaffManager.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStaffManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaffManager.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.btnStaffManager.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(220)))));
            this.btnStaffManager.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStaffManager.ForeColor = System.Drawing.Color.White;
            this.btnStaffManager.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnStaffManager.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnStaffManager.Image = global::QUANLYDETAI.Properties.Resources.staff__1_;
            this.btnStaffManager.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaffManager.ImageSize = new System.Drawing.Size(25, 25);
            this.btnStaffManager.Location = new System.Drawing.Point(0, 0);
            this.btnStaffManager.Name = "btnStaffManager";
            this.btnStaffManager.Size = new System.Drawing.Size(174, 45);
            this.btnStaffManager.TabIndex = 142;
            this.btnStaffManager.Text = "Quản lý nhân viên";
            this.btnStaffManager.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaffManager.Click += new System.EventHandler(this.btnStaffManager_Click);
            // 
            // btnManager
            // 
            this.btnManager.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManager.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManager.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManager.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManager.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManager.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btnManager.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btnManager.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.ForeColor = System.Drawing.Color.White;
            this.btnManager.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnManager.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.btnManager.Image = global::QUANLYDETAI.Properties.Resources.project__1_;
            this.btnManager.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManager.ImageSize = new System.Drawing.Size(30, 30);
            this.btnManager.Location = new System.Drawing.Point(0, 132);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(174, 53);
            this.btnManager.TabIndex = 141;
            this.btnManager.Text = "Quản lý";
            this.btnManager.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 91);
            this.panel2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QUANLYDETAI.Properties.Resources.user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(49, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.panel2_Click);
            // 
            // btnNavigationPanel
            // 
            this.btnNavigationPanel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNavigationPanel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNavigationPanel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNavigationPanel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNavigationPanel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavigationPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btnNavigationPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btnNavigationPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNavigationPanel.ForeColor = System.Drawing.Color.White;
            this.btnNavigationPanel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btnNavigationPanel.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.btnNavigationPanel.Image = global::QUANLYDETAI.Properties.Resources.menu;
            this.btnNavigationPanel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNavigationPanel.ImageSize = new System.Drawing.Size(35, 35);
            this.btnNavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.btnNavigationPanel.Name = "btnNavigationPanel";
            this.btnNavigationPanel.Size = new System.Drawing.Size(174, 41);
            this.btnNavigationPanel.TabIndex = 1;
            this.btnNavigationPanel.Click += new System.EventHandler(this.btnNavigationPanel_Click);
            // 
            // fManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 565);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fManagement";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.pMenu.ResumeLayout(false);
            this.MenuSettings.ResumeLayout(false);
            this.MenuManager.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaGradientPanel pMenu;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GradientButton btnNavigationPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox groupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvNN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNameApp;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2TileButton tileAddTopic;
        private Guna.UI2.WinForms.Guna2TileButton tileTopic;
        private Guna.UI2.WinForms.Guna2TileButton tileReportTopic;
        private System.Windows.Forms.Panel pMain;
        private Guna.UI2.WinForms.Guna2GradientButton btnManager;
        private System.Windows.Forms.Panel MenuManager;
        private Guna.UI2.WinForms.Guna2GradientButton btnSpecMana;
        private Guna.UI2.WinForms.Guna2GradientButton btnStaffManager;
        private Guna.UI2.WinForms.Guna2GradientButton btnOrganManager;
        private Guna.UI2.WinForms.Guna2GradientButton btnSetting;
        private Guna.UI2.WinForms.Guna2GradientButton btnAccountMana;
        private System.Windows.Forms.Panel MenuSettings;
        private Guna.UI2.WinForms.Guna2GradientButton btnChangePass;
        private Guna.UI2.WinForms.Guna2GradientButton btnIntroduct;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogOut;
    }
}
namespace GroundStationGoliathX
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.glControl1 = new OpenTK.GLControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbEkran = new System.Windows.Forms.RichTextBox();
            this.cbComPort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbBaud = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.label7 = new System.Windows.Forms.Label();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.SeriPort = new System.IO.Ports.SerialPort(this.components);
            this.guna2CustomGradientPanel4 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel5 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CircleProgressBar3 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2CircleProgressBar2 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnBaglan = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            this.guna2CustomGradientPanel4.SuspendLayout();
            this.guna2CircleProgressBar1.SuspendLayout();
            this.guna2CustomGradientPanel5.SuspendLayout();
            this.guna2CircleProgressBar3.SuspendLayout();
            this.guna2CircleProgressBar2.SuspendLayout();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(15, 9);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(808, 486);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.BorderRadius = 18;
            this.guna2CustomGradientPanel2.Controls.Add(this.label3);
            this.guna2CustomGradientPanel2.Controls.Add(this.label1);
            this.guna2CustomGradientPanel2.Controls.Add(this.rtbEkran);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnBaglan);
            this.guna2CustomGradientPanel2.Controls.Add(this.cbComPort);
            this.guna2CustomGradientPanel2.Controls.Add(this.cbBaud);
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(12, 19);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(681, 264);
            this.guna2CustomGradientPanel2.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(408, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Baud Rate : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(418, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "COM  : ";
            // 
            // rtbEkran
            // 
            this.rtbEkran.AcceptsTab = true;
            this.rtbEkran.BackColor = System.Drawing.Color.DimGray;
            this.rtbEkran.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbEkran.Location = new System.Drawing.Point(12, 16);
            this.rtbEkran.Margin = new System.Windows.Forms.Padding(4);
            this.rtbEkran.Name = "rtbEkran";
            this.rtbEkran.ReadOnly = true;
            this.rtbEkran.Size = new System.Drawing.Size(389, 233);
            this.rtbEkran.TabIndex = 0;
            this.rtbEkran.Text = "";
            // 
            // cbComPort
            // 
            this.cbComPort.BackColor = System.Drawing.Color.Transparent;
            this.cbComPort.BorderColor = System.Drawing.Color.Black;
            this.cbComPort.BorderRadius = 18;
            this.cbComPort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComPort.FillColor = System.Drawing.Color.DimGray;
            this.cbComPort.FocusedColor = System.Drawing.Color.Black;
            this.cbComPort.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.cbComPort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbComPort.ForeColor = System.Drawing.Color.Black;
            this.cbComPort.ItemHeight = 30;
            this.cbComPort.Location = new System.Drawing.Point(512, 14);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(140, 36);
            this.cbComPort.TabIndex = 44;
            // 
            // cbBaud
            // 
            this.cbBaud.BackColor = System.Drawing.Color.Transparent;
            this.cbBaud.BorderColor = System.Drawing.Color.Black;
            this.cbBaud.BorderRadius = 18;
            this.cbBaud.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaud.FillColor = System.Drawing.Color.DimGray;
            this.cbBaud.FocusedColor = System.Drawing.Color.Black;
            this.cbBaud.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.cbBaud.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBaud.ForeColor = System.Drawing.Color.Black;
            this.cbBaud.ItemHeight = 30;
            this.cbBaud.Location = new System.Drawing.Point(512, 56);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(140, 36);
            this.cbBaud.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(664, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 49;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 18;
            this.guna2CustomGradientPanel1.Controls.Add(this.label9);
            this.guna2CustomGradientPanel1.Controls.Add(this.label6);
            this.guna2CustomGradientPanel1.Controls.Add(this.label17);
            this.guna2CustomGradientPanel1.Controls.Add(this.label8);
            this.guna2CustomGradientPanel1.Controls.Add(this.zedGraphControl2);
            this.guna2CustomGradientPanel1.Controls.Add(this.label7);
            this.guna2CustomGradientPanel1.Controls.Add(this.zedGraphControl1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label10);
            this.guna2CustomGradientPanel1.Controls.Add(this.button1);
            this.guna2CustomGradientPanel1.Controls.Add(this.button2);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(12, 616);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(959, 391);
            this.guna2CustomGradientPanel1.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(243, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 24);
            this.label9.TabIndex = 50;
            this.label9.Text = "Görev Zamanı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(467, 364);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Yükselik :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Red;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(561, 364);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 16);
            this.label17.TabIndex = 15;
            this.label17.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(102, 364);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "0";
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.BackColor = System.Drawing.Color.Snow;
            this.zedGraphControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zedGraphControl2.Location = new System.Drawing.Point(9, 88);
            this.zedGraphControl2.Margin = new System.Windows.Forms.Padding(9);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(459, 267);
            this.zedGraphControl2.TabIndex = 36;
            this.zedGraphControl2.UseExtendedPrintDialog = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(18, 364);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Basınç : ";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.BackColor = System.Drawing.Color.Snow;
            this.zedGraphControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zedGraphControl1.Location = new System.Drawing.Point(471, 88);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(9);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(451, 267);
            this.zedGraphControl1.TabIndex = 32;
            this.zedGraphControl1.Tag = "";
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(427, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 24);
            this.label10.TabIndex = 30;
            this.label10.Text = "0";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(13, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 44);
            this.button1.TabIndex = 27;
            this.button1.Text = "Start Graphing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(123, 32);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 44);
            this.button2.TabIndex = 28;
            this.button2.Text = "Pause Graphing";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CustomGradientPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel3.BorderRadius = 18;
            this.guna2CustomGradientPanel3.Controls.Add(this.gmap);
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(1052, 526);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(838, 481);
            this.guna2CustomGradientPanel3.TabIndex = 51;
            // 
            // gmap
            // 
            this.gmap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap.BackColor = System.Drawing.Color.Red;
            this.gmap.Bearing = 0F;
            this.gmap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Red;
            this.gmap.ForeColor = System.Drawing.Color.Red;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemory = 5;
            this.gmap.Location = new System.Drawing.Point(13, 25);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 2;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(814, 429);
            this.gmap.TabIndex = 41;
            this.gmap.Zoom = 0D;
            // 
            // guna2CustomGradientPanel4
            // 
            this.guna2CustomGradientPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CustomGradientPanel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel4.BorderRadius = 18;
            this.guna2CustomGradientPanel4.Controls.Add(this.glControl1);
            this.guna2CustomGradientPanel4.FillColor = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel4.FillColor2 = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel4.FillColor3 = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel4.FillColor4 = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel4.Location = new System.Drawing.Point(1052, 12);
            this.guna2CustomGradientPanel4.Name = "guna2CustomGradientPanel4";
            this.guna2CustomGradientPanel4.Size = new System.Drawing.Size(838, 508);
            this.guna2CustomGradientPanel4.TabIndex = 52;
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.Controls.Add(this.label12);
            this.guna2CircleProgressBar1.Controls.Add(this.label4);
            this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(33, 14);
            this.guna2CircleProgressBar1.Minimum = 0;
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(213, 213);
            this.guna2CircleProgressBar1.TabIndex = 53;
            this.guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(85, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 21);
            this.label12.TabIndex = 55;
            this.label12.Text = "Hız";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(71, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "% 0";
            // 
            // guna2CustomGradientPanel5
            // 
            this.guna2CustomGradientPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2CustomGradientPanel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel5.BorderRadius = 17;
            this.guna2CustomGradientPanel5.Controls.Add(this.guna2CircleProgressBar3);
            this.guna2CustomGradientPanel5.Controls.Add(this.guna2CircleProgressBar2);
            this.guna2CustomGradientPanel5.Controls.Add(this.guna2CircleProgressBar1);
            this.guna2CustomGradientPanel5.FillColor = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel5.FillColor2 = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel5.FillColor3 = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel5.FillColor4 = System.Drawing.Color.Red;
            this.guna2CustomGradientPanel5.Location = new System.Drawing.Point(15, 353);
            this.guna2CustomGradientPanel5.Name = "guna2CustomGradientPanel5";
            this.guna2CustomGradientPanel5.Size = new System.Drawing.Size(956, 257);
            this.guna2CustomGradientPanel5.TabIndex = 54;
            // 
            // guna2CircleProgressBar3
            // 
            this.guna2CircleProgressBar3.Controls.Add(this.label14);
            this.guna2CircleProgressBar3.Controls.Add(this.label11);
            this.guna2CircleProgressBar3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2CircleProgressBar3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar3.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar3.Location = new System.Drawing.Point(691, 14);
            this.guna2CircleProgressBar3.Minimum = 0;
            this.guna2CircleProgressBar3.Name = "guna2CircleProgressBar3";
            this.guna2CircleProgressBar3.ProgressColor = System.Drawing.Color.Purple;
            this.guna2CircleProgressBar3.ProgressColor2 = System.Drawing.Color.Purple;
            this.guna2CircleProgressBar3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar3.Size = new System.Drawing.Size(213, 213);
            this.guna2CircleProgressBar3.TabIndex = 54;
            this.guna2CircleProgressBar3.Text = "guna2CircleProgressBar3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(86, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 21);
            this.label14.TabIndex = 57;
            this.label14.Text = "Güç";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(72, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 37);
            this.label11.TabIndex = 0;
            this.label11.Text = "% 0";
            // 
            // guna2CircleProgressBar2
            // 
            this.guna2CircleProgressBar2.Controls.Add(this.label13);
            this.guna2CircleProgressBar2.Controls.Add(this.label5);
            this.guna2CircleProgressBar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2CircleProgressBar2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar2.Location = new System.Drawing.Point(369, 14);
            this.guna2CircleProgressBar2.Minimum = 0;
            this.guna2CircleProgressBar2.Name = "guna2CircleProgressBar2";
            this.guna2CircleProgressBar2.ProgressColor = System.Drawing.Color.Teal;
            this.guna2CircleProgressBar2.ProgressColor2 = System.Drawing.Color.Teal;
            this.guna2CircleProgressBar2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar2.Size = new System.Drawing.Size(213, 213);
            this.guna2CircleProgressBar2.TabIndex = 54;
            this.guna2CircleProgressBar2.Text = "guna2CircleProgressBar2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(83, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 21);
            this.label13.TabIndex = 56;
            this.label13.Text = "RPM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(73, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "% 0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(44, 317);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 55;
            this.label15.Text = "label15";
            // 
            // btnBaglan
            // 
            this.btnBaglan.Animated = true;
            this.btnBaglan.AnimatedGIF = true;
            this.btnBaglan.BackColor = System.Drawing.Color.Transparent;
            this.btnBaglan.BorderRadius = 20;
            this.btnBaglan.BorderThickness = 1;
            this.btnBaglan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBaglan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBaglan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBaglan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBaglan.FillColor = System.Drawing.Color.DimGray;
            this.btnBaglan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBaglan.ForeColor = System.Drawing.Color.White;
            this.btnBaglan.Image = global::Youtube3D_Simulasyon.Properties.Resources.wifi__2_1;
            this.btnBaglan.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBaglan.Location = new System.Drawing.Point(512, 98);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(140, 58);
            this.btnBaglan.TabIndex = 43;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.guna2CustomGradientPanel5);
            this.Controls.Add(this.guna2CustomGradientPanel4);
            this.Controls.Add(this.guna2CustomGradientPanel3);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Ground Station GoliathX";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.guna2CustomGradientPanel4.ResumeLayout(false);
            this.guna2CircleProgressBar1.ResumeLayout(false);
            this.guna2CircleProgressBar1.PerformLayout();
            this.guna2CustomGradientPanel5.ResumeLayout(false);
            this.guna2CircleProgressBar3.ResumeLayout(false);
            this.guna2CircleProgressBar3.PerformLayout();
            this.guna2CircleProgressBar2.ResumeLayout(false);
            this.guna2CircleProgressBar2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2Button btnBaglan;
        private Guna.UI2.WinForms.Guna2ComboBox cbComPort;
        private Guna.UI2.WinForms.Guna2ComboBox cbBaud;
        private System.Windows.Forms.RichTextBox rtbEkran;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.Label label7;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.IO.Ports.SerialPort SeriPort;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar3;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
    }
}


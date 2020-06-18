using System.Drawing;

namespace Spanel
{
    partial class form_panel
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_panel));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.display = new System.Windows.Forms.RichTextBox();
            this.btn_openPanel = new System.Windows.Forms.Button();
            this.btn_closePanel = new System.Windows.Forms.Button();
            this.btn_autoPanel = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eAngle = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.redled = new Bulb.LedBulb();
            this.autoled = new Bulb.LedBulb();
            this.table_all = new System.Windows.Forms.TableLayoutPanel();
            this.txt_amper = new System.Windows.Forms.RichTextBox();
            this.txt_agle = new System.Windows.Forms.RichTextBox();
            this.txt_date = new System.Windows.Forms.RichTextBox();
            this.txt_hour = new System.Windows.Forms.RichTextBox();
            this.t_volt = new System.Windows.Forms.RichTextBox();
            this.t_amper = new System.Windows.Forms.RichTextBox();
            this.t_angle = new System.Windows.Forms.RichTextBox();
            this.t_date = new System.Windows.Forms.RichTextBox();
            this.t_hour = new System.Windows.Forms.RichTextBox();
            this.txt_volt = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ledright = new Bulb.LedBulb();
            this.ledleft = new Bulb.LedBulb();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.table_all.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(6, 19);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(366, 141);
            this.display.TabIndex = 0;
            this.display.Text = "";
            // 
            // btn_openPanel
            // 
            this.btn_openPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            this.btn_openPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_openPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_openPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_openPanel.Location = new System.Drawing.Point(6, 166);
            this.btn_openPanel.Name = "btn_openPanel";
            this.btn_openPanel.Size = new System.Drawing.Size(75, 23);
            this.btn_openPanel.TabIndex = 1;
            this.btn_openPanel.Text = "Open";
            this.btn_openPanel.UseVisualStyleBackColor = false;
            this.btn_openPanel.Click += new System.EventHandler(this.btn_openPanel_Click);
            // 
            // btn_closePanel
            // 
            this.btn_closePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            this.btn_closePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_closePanel.Location = new System.Drawing.Point(87, 166);
            this.btn_closePanel.Name = "btn_closePanel";
            this.btn_closePanel.Size = new System.Drawing.Size(75, 23);
            this.btn_closePanel.TabIndex = 2;
            this.btn_closePanel.Text = "Close";
            this.btn_closePanel.UseVisualStyleBackColor = false;
            this.btn_closePanel.Click += new System.EventHandler(this.btn_closePanel_Click);
            // 
            // btn_autoPanel
            // 
            this.btn_autoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(0)))), ((int)(((byte)(44)))));
            this.btn_autoPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_autoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_autoPanel.Location = new System.Drawing.Point(168, 166);
            this.btn_autoPanel.Name = "btn_autoPanel";
            this.btn_autoPanel.Size = new System.Drawing.Size(75, 23);
            this.btn_autoPanel.TabIndex = 3;
            this.btn_autoPanel.Text = "Automatıc";
            this.btn_autoPanel.UseVisualStyleBackColor = false;
            this.btn_autoPanel.Click += new System.EventHandler(this.btn_autoPanel_Click);
            // 
            // btn_up
            // 
            this.btn_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(99)))));
            this.btn_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_up.Location = new System.Drawing.Point(79, 19);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 23);
            this.btn_up.TabIndex = 6;
            this.btn_up.Text = "Up";
            this.btn_up.UseVisualStyleBackColor = false;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_down
            // 
            this.btn_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(99)))));
            this.btn_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_down.Location = new System.Drawing.Point(79, 99);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 23);
            this.btn_down.TabIndex = 7;
            this.btn_down.Text = "Down";
            this.btn_down.UseVisualStyleBackColor = false;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_left
            // 
            this.btn_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(99)))));
            this.btn_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_left.Location = new System.Drawing.Point(23, 59);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(69, 23);
            this.btn_left.TabIndex = 5;
            this.btn_left.Text = "West";
            this.btn_left.UseVisualStyleBackColor = false;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(99)))));
            this.btn_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_right.Location = new System.Drawing.Point(137, 59);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(73, 23);
            this.btn_right.TabIndex = 4;
            this.btn_right.Text = "East";
            this.btn_right.UseVisualStyleBackColor = false;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eAngle);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.btn_left);
            this.groupBox1.Controls.Add(this.btn_right);
            this.groupBox1.Controls.Add(this.btn_down);
            this.groupBox1.Controls.Add(this.btn_up);
            this.groupBox1.Location = new System.Drawing.Point(18, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 130);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // eAngle
            // 
            this.eAngle.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.eAngle.Location = new System.Drawing.Point(217, 59);
            this.eAngle.Name = "eAngle";
            this.eAngle.Size = new System.Drawing.Size(79, 20);
            this.eAngle.TabIndex = 18;
            this.eAngle.Text = "Enter Angle";
            this.eAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.eAngle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.eAngle_MouseClick);
            this.eAngle.Leave += new System.EventHandler(this.eAngle_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Spanel.Properties.Resources.round_compass;
            this.pictureBox3.InitialImage = global::Spanel.Properties.Resources.round_compass;
            this.pictureBox3.Location = new System.Drawing.Point(302, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 72);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.redled);
            this.groupBox2.Controls.Add(this.autoled);
            this.groupBox2.Controls.Add(this.display);
            this.groupBox2.Controls.Add(this.btn_openPanel);
            this.groupBox2.Controls.Add(this.btn_closePanel);
            this.groupBox2.Controls.Add(this.btn_autoPanel);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 200);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Panel";
            // 
            // redled
            // 
            this.redled.Color = System.Drawing.Color.Red;
            this.redled.Location = new System.Drawing.Point(347, 164);
            this.redled.Name = "redled";
            this.redled.On = false;
            this.redled.Padding = new System.Windows.Forms.Padding(3);
            this.redled.Size = new System.Drawing.Size(25, 30);
            this.redled.TabIndex = 19;
            // 
            // autoled
            // 
            this.autoled.Color = System.Drawing.Color.LawnGreen;
            this.autoled.Location = new System.Drawing.Point(316, 164);
            this.autoled.Name = "autoled";
            this.autoled.On = false;
            this.autoled.Padding = new System.Windows.Forms.Padding(3);
            this.autoled.Size = new System.Drawing.Size(25, 30);
            this.autoled.TabIndex = 5;
            // 
            // table_all
            // 
            this.table_all.ColumnCount = 2;
            this.table_all.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.79693F));
            this.table_all.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.20306F));
            this.table_all.Controls.Add(this.txt_amper, 0, 1);
            this.table_all.Controls.Add(this.txt_agle, 0, 2);
            this.table_all.Controls.Add(this.txt_date, 0, 3);
            this.table_all.Controls.Add(this.txt_hour, 0, 4);
            this.table_all.Controls.Add(this.t_volt, 1, 0);
            this.table_all.Controls.Add(this.t_amper, 1, 1);
            this.table_all.Controls.Add(this.t_angle, 1, 2);
            this.table_all.Controls.Add(this.t_date, 1, 3);
            this.table_all.Controls.Add(this.t_hour, 1, 4);
            this.table_all.Controls.Add(this.txt_volt, 0, 0);
            this.table_all.Location = new System.Drawing.Point(469, 410);
            this.table_all.Name = "table_all";
            this.table_all.RowCount = 5;
            this.table_all.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_all.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_all.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_all.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_all.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_all.Size = new System.Drawing.Size(522, 200);
            this.table_all.TabIndex = 11;
            // 
            // txt_amper
            // 
            this.txt_amper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(151)))), ((int)(((byte)(159)))));
            this.txt_amper.Font = new System.Drawing.Font("Cooper Black", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amper.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_amper.Location = new System.Drawing.Point(3, 43);
            this.txt_amper.Name = "txt_amper";
            this.txt_amper.Size = new System.Drawing.Size(110, 34);
            this.txt_amper.TabIndex = 1;
            this.txt_amper.Text = "CURRENT";
            // 
            // txt_agle
            // 
            this.txt_agle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(151)))), ((int)(((byte)(159)))));
            this.txt_agle.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_agle.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_agle.Location = new System.Drawing.Point(3, 83);
            this.txt_agle.Name = "txt_agle";
            this.txt_agle.Size = new System.Drawing.Size(110, 34);
            this.txt_agle.TabIndex = 2;
            this.txt_agle.Text = "SUN ANGLE";
            // 
            // txt_date
            // 
            this.txt_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(151)))), ((int)(((byte)(159)))));
            this.txt_date.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_date.Location = new System.Drawing.Point(3, 123);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(110, 34);
            this.txt_date.TabIndex = 3;
            this.txt_date.Text = "DATE";
            // 
            // txt_hour
            // 
            this.txt_hour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(151)))), ((int)(((byte)(159)))));
            this.txt_hour.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hour.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_hour.Location = new System.Drawing.Point(3, 163);
            this.txt_hour.Name = "txt_hour";
            this.txt_hour.Size = new System.Drawing.Size(110, 34);
            this.txt_hour.TabIndex = 4;
            this.txt_hour.Text = "HOUR";
            // 
            // t_volt
            // 
            this.t_volt.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_volt.Location = new System.Drawing.Point(121, 3);
            this.t_volt.Name = "t_volt";
            this.t_volt.Size = new System.Drawing.Size(398, 34);
            this.t_volt.TabIndex = 5;
            this.t_volt.Text = "";
            // 
            // t_amper
            // 
            this.t_amper.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_amper.Location = new System.Drawing.Point(121, 43);
            this.t_amper.Name = "t_amper";
            this.t_amper.Size = new System.Drawing.Size(398, 34);
            this.t_amper.TabIndex = 6;
            this.t_amper.Text = "";
            // 
            // t_angle
            // 
            this.t_angle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_angle.Location = new System.Drawing.Point(121, 83);
            this.t_angle.Name = "t_angle";
            this.t_angle.Size = new System.Drawing.Size(398, 34);
            this.t_angle.TabIndex = 7;
            this.t_angle.Text = "";
            // 
            // t_date
            // 
            this.t_date.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_date.Location = new System.Drawing.Point(121, 123);
            this.t_date.Name = "t_date";
            this.t_date.Size = new System.Drawing.Size(398, 34);
            this.t_date.TabIndex = 8;
            this.t_date.Text = "";
            // 
            // t_hour
            // 
            this.t_hour.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_hour.Location = new System.Drawing.Point(121, 163);
            this.t_hour.Name = "t_hour";
            this.t_hour.Size = new System.Drawing.Size(398, 34);
            this.t_hour.TabIndex = 9;
            this.t_hour.Text = "";
            // 
            // txt_volt
            // 
            this.txt_volt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(151)))), ((int)(((byte)(159)))));
            this.txt_volt.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_volt.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_volt.Location = new System.Drawing.Point(3, 3);
            this.txt_volt.Name = "txt_volt";
            this.txt_volt.Size = new System.Drawing.Size(110, 34);
            this.txt_volt.TabIndex = 10;
            this.txt_volt.Text = "VOLTAGE";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ledright);
            this.groupBox3.Controls.Add(this.ledleft);
            this.groupBox3.Location = new System.Drawing.Point(18, 396);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 209);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dead Cells";
            // 
            // ledright
            // 
            this.ledright.Color = System.Drawing.Color.Cyan;
            this.ledright.Location = new System.Drawing.Point(255, 9);
            this.ledright.Name = "ledright";
            this.ledright.On = false;
            this.ledright.Padding = new System.Windows.Forms.Padding(3);
            this.ledright.Size = new System.Drawing.Size(25, 30);
            this.ledright.TabIndex = 19;
            // 
            // ledleft
            // 
            this.ledleft.Color = System.Drawing.Color.Cyan;
            this.ledleft.Location = new System.Drawing.Point(81, 9);
            this.ledleft.Name = "ledleft";
            this.ledleft.On = false;
            this.ledleft.Padding = new System.Windows.Forms.Padding(3);
            this.ledleft.Size = new System.Drawing.Size(25, 30);
            this.ledleft.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(460, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.Name = "volt";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "amper";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(531, 354);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(460, 396);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(537, 217);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "State Table";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Spanel.Properties.Resources.cell;
            this.pictureBox2.Location = new System.Drawing.Point(203, 432);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 170);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Spanel.Properties.Resources.cell;
            this.pictureBox1.Location = new System.Drawing.Point(18, 432);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 170);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // form_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1009, 622);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.table_all);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_panel";
            this.Text = "SOLAR PANEL INTERFACE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_panel_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_panel_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.table_all.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox display;
        private System.Windows.Forms.Button btn_openPanel;
        private System.Windows.Forms.Button btn_closePanel;
        private System.Windows.Forms.Button btn_autoPanel;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel table_all;
        private System.Windows.Forms.RichTextBox txt_amper;
        private System.Windows.Forms.RichTextBox txt_agle;
        private System.Windows.Forms.RichTextBox txt_date;
        private System.Windows.Forms.RichTextBox txt_hour;
        private System.Windows.Forms.RichTextBox t_volt;
        private System.Windows.Forms.RichTextBox t_amper;
        private System.Windows.Forms.RichTextBox t_angle;
        private System.Windows.Forms.RichTextBox t_date;
        private System.Windows.Forms.RichTextBox t_hour;
        private System.Windows.Forms.RichTextBox txt_volt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox eAngle;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Bulb.LedBulb redled;
        private Bulb.LedBulb autoled;
        private Bulb.LedBulb ledright;
        private Bulb.LedBulb ledleft;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}


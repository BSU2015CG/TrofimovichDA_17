namespace Lab6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sbrotX = new System.Windows.Forms.HScrollBar();
            this.sbrotY = new System.Windows.Forms.HScrollBar();
            this.sbrotZ = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbrotx = new System.Windows.Forms.Label();
            this.lbroty = new System.Windows.Forms.Label();
            this.lbrotz = new System.Windows.Forms.Label();
            this.lbscaleZ = new System.Windows.Forms.Label();
            this.lbscaleY = new System.Windows.Forms.Label();
            this.lbscaleX = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sbscaleZ = new System.Windows.Forms.HScrollBar();
            this.sbscaleY = new System.Windows.Forms.HScrollBar();
            this.sbscaleX = new System.Windows.Forms.HScrollBar();
            this.lbtranZ = new System.Windows.Forms.Label();
            this.lbtranY = new System.Windows.Forms.Label();
            this.lbtranX = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.sbtranZ = new System.Windows.Forms.HScrollBar();
            this.sbtranY = new System.Windows.Forms.HScrollBar();
            this.sbtranX = new System.Windows.Forms.HScrollBar();
            this.rbxy = new System.Windows.Forms.RadioButton();
            this.rbyz = new System.Windows.Forms.RadioButton();
            this.rbxz = new System.Windows.Forms.RadioButton();
            this.matrixView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixView)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.Maximum = 10D;
            chartArea1.AxisX.Minimum = -10D;
            chartArea1.AxisX2.Interval = 10D;
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.Maximum = 10D;
            chartArea1.AxisY.Minimum = -10D;
            chartArea1.AxisY2.Interval = 10D;
            chartArea1.Name = "Ox";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(61, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series1.ChartArea = "Ox";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Ox";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(329, 323);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Paint += new System.Windows.Forms.PaintEventHandler(this.chart1_Paint);
            // 
            // sbrotX
            // 
            this.sbrotX.LargeChange = 1;
            this.sbrotX.Location = new System.Drawing.Point(418, 246);
            this.sbrotX.Maximum = 360;
            this.sbrotX.Name = "sbrotX";
            this.sbrotX.Size = new System.Drawing.Size(186, 25);
            this.sbrotX.TabIndex = 1;
            this.sbrotX.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbrot);
            // 
            // sbrotY
            // 
            this.sbrotY.LargeChange = 1;
            this.sbrotY.Location = new System.Drawing.Point(418, 272);
            this.sbrotY.Maximum = 360;
            this.sbrotY.Name = "sbrotY";
            this.sbrotY.Size = new System.Drawing.Size(186, 25);
            this.sbrotY.TabIndex = 2;
            this.sbrotY.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbrot);
            // 
            // sbrotZ
            // 
            this.sbrotZ.LargeChange = 1;
            this.sbrotZ.Location = new System.Drawing.Point(418, 297);
            this.sbrotZ.Maximum = 360;
            this.sbrotZ.Name = "sbrotZ";
            this.sbrotZ.Size = new System.Drawing.Size(186, 25);
            this.sbrotZ.TabIndex = 3;
            this.sbrotZ.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbrot);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rotation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Z:";
            // 
            // lbrotx
            // 
            this.lbrotx.AutoSize = true;
            this.lbrotx.Location = new System.Drawing.Point(608, 257);
            this.lbrotx.Name = "lbrotx";
            this.lbrotx.Size = new System.Drawing.Size(13, 13);
            this.lbrotx.TabIndex = 8;
            this.lbrotx.Text = "0";
            // 
            // lbroty
            // 
            this.lbroty.AutoSize = true;
            this.lbroty.Location = new System.Drawing.Point(608, 284);
            this.lbroty.Name = "lbroty";
            this.lbroty.Size = new System.Drawing.Size(13, 13);
            this.lbroty.TabIndex = 9;
            this.lbroty.Text = "0";
            // 
            // lbrotz
            // 
            this.lbrotz.AutoSize = true;
            this.lbrotz.Location = new System.Drawing.Point(608, 309);
            this.lbrotz.Name = "lbrotz";
            this.lbrotz.Size = new System.Drawing.Size(13, 13);
            this.lbrotz.TabIndex = 10;
            this.lbrotz.Text = "0";
            // 
            // lbscaleZ
            // 
            this.lbscaleZ.AutoSize = true;
            this.lbscaleZ.Location = new System.Drawing.Point(608, 91);
            this.lbscaleZ.Name = "lbscaleZ";
            this.lbscaleZ.Size = new System.Drawing.Size(13, 13);
            this.lbscaleZ.TabIndex = 20;
            this.lbscaleZ.Text = "1";
            // 
            // lbscaleY
            // 
            this.lbscaleY.AutoSize = true;
            this.lbscaleY.Location = new System.Drawing.Point(608, 66);
            this.lbscaleY.Name = "lbscaleY";
            this.lbscaleY.Size = new System.Drawing.Size(13, 13);
            this.lbscaleY.TabIndex = 19;
            this.lbscaleY.Text = "1";
            // 
            // lbscaleX
            // 
            this.lbscaleX.AutoSize = true;
            this.lbscaleX.Location = new System.Drawing.Point(608, 39);
            this.lbscaleX.Name = "lbscaleX";
            this.lbscaleX.Size = new System.Drawing.Size(13, 13);
            this.lbscaleX.TabIndex = 18;
            this.lbscaleX.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Z:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(398, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "X:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(415, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Scale";
            // 
            // sbscaleZ
            // 
            this.sbscaleZ.LargeChange = 1;
            this.sbscaleZ.Location = new System.Drawing.Point(418, 79);
            this.sbscaleZ.Maximum = 20;
            this.sbscaleZ.Name = "sbscaleZ";
            this.sbscaleZ.Size = new System.Drawing.Size(186, 25);
            this.sbscaleZ.TabIndex = 13;
            this.sbscaleZ.Value = 10;
            this.sbscaleZ.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbscale);
            // 
            // sbscaleY
            // 
            this.sbscaleY.LargeChange = 1;
            this.sbscaleY.Location = new System.Drawing.Point(418, 54);
            this.sbscaleY.Maximum = 20;
            this.sbscaleY.Name = "sbscaleY";
            this.sbscaleY.Size = new System.Drawing.Size(186, 25);
            this.sbscaleY.TabIndex = 12;
            this.sbscaleY.Value = 10;
            this.sbscaleY.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbscale);
            // 
            // sbscaleX
            // 
            this.sbscaleX.LargeChange = 1;
            this.sbscaleX.Location = new System.Drawing.Point(418, 28);
            this.sbscaleX.Maximum = 20;
            this.sbscaleX.Name = "sbscaleX";
            this.sbscaleX.Size = new System.Drawing.Size(186, 25);
            this.sbscaleX.TabIndex = 11;
            this.sbscaleX.Value = 10;
            this.sbscaleX.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbscale);
            // 
            // lbtranZ
            // 
            this.lbtranZ.AutoSize = true;
            this.lbtranZ.Location = new System.Drawing.Point(608, 200);
            this.lbtranZ.Name = "lbtranZ";
            this.lbtranZ.Size = new System.Drawing.Size(13, 13);
            this.lbtranZ.TabIndex = 30;
            this.lbtranZ.Text = "0";
            // 
            // lbtranY
            // 
            this.lbtranY.AutoSize = true;
            this.lbtranY.Location = new System.Drawing.Point(608, 175);
            this.lbtranY.Name = "lbtranY";
            this.lbtranY.Size = new System.Drawing.Size(13, 13);
            this.lbtranY.TabIndex = 29;
            this.lbtranY.Text = "0";
            // 
            // lbtranX
            // 
            this.lbtranX.AutoSize = true;
            this.lbtranX.Location = new System.Drawing.Point(608, 148);
            this.lbtranX.Name = "lbtranX";
            this.lbtranX.Size = new System.Drawing.Size(13, 13);
            this.lbtranX.TabIndex = 28;
            this.lbtranX.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(398, 188);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Z:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(398, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Y:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(398, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "X:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(415, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Translate";
            // 
            // sbtranZ
            // 
            this.sbtranZ.LargeChange = 1;
            this.sbtranZ.Location = new System.Drawing.Point(418, 188);
            this.sbtranZ.Maximum = 50;
            this.sbtranZ.Minimum = -50;
            this.sbtranZ.Name = "sbtranZ";
            this.sbtranZ.Size = new System.Drawing.Size(186, 25);
            this.sbtranZ.TabIndex = 23;
            this.sbtranZ.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbtran);
            // 
            // sbtranY
            // 
            this.sbtranY.LargeChange = 1;
            this.sbtranY.Location = new System.Drawing.Point(418, 163);
            this.sbtranY.Maximum = 50;
            this.sbtranY.Minimum = -50;
            this.sbtranY.Name = "sbtranY";
            this.sbtranY.Size = new System.Drawing.Size(186, 25);
            this.sbtranY.TabIndex = 22;
            this.sbtranY.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbtran);
            // 
            // sbtranX
            // 
            this.sbtranX.LargeChange = 1;
            this.sbtranX.Location = new System.Drawing.Point(418, 137);
            this.sbtranX.Maximum = 50;
            this.sbtranX.Minimum = -50;
            this.sbtranX.Name = "sbtranX";
            this.sbtranX.Size = new System.Drawing.Size(186, 25);
            this.sbtranX.TabIndex = 21;
            this.sbtranX.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbtran);
            // 
            // rbxy
            // 
            this.rbxy.AutoSize = true;
            this.rbxy.Checked = true;
            this.rbxy.Location = new System.Drawing.Point(12, 12);
            this.rbxy.Name = "rbxy";
            this.rbxy.Size = new System.Drawing.Size(43, 17);
            this.rbxy.TabIndex = 31;
            this.rbxy.TabStop = true;
            this.rbxy.Text = "Oxy";
            this.rbxy.UseVisualStyleBackColor = true;
            this.rbxy.CheckedChanged += new System.EventHandler(this.rbproj);
            // 
            // rbyz
            // 
            this.rbyz.AutoSize = true;
            this.rbyz.Location = new System.Drawing.Point(12, 36);
            this.rbyz.Name = "rbyz";
            this.rbyz.Size = new System.Drawing.Size(43, 17);
            this.rbyz.TabIndex = 32;
            this.rbyz.Text = "Oyz";
            this.rbyz.UseVisualStyleBackColor = true;
            this.rbyz.CheckedChanged += new System.EventHandler(this.rbproj);
            // 
            // rbxz
            // 
            this.rbxz.AutoSize = true;
            this.rbxz.Location = new System.Drawing.Point(12, 60);
            this.rbxz.Name = "rbxz";
            this.rbxz.Size = new System.Drawing.Size(43, 17);
            this.rbxz.TabIndex = 33;
            this.rbxz.Text = "Oxz";
            this.rbxz.UseVisualStyleBackColor = true;
            this.rbxz.CheckedChanged += new System.EventHandler(this.rbproj);
            // 
            // matrixView
            // 
            this.matrixView.AllowUserToAddRows = false;
            this.matrixView.AllowUserToDeleteRows = false;
            this.matrixView.AllowUserToResizeColumns = false;
            this.matrixView.AllowUserToResizeRows = false;
            this.matrixView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matrixView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matrixView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixView.ColumnHeadersVisible = false;
            this.matrixView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrixView.DefaultCellStyle = dataGridViewCellStyle1;
            this.matrixView.Location = new System.Drawing.Point(674, 126);
            this.matrixView.Name = "matrixView";
            this.matrixView.ReadOnly = true;
            this.matrixView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matrixView.RowHeadersVisible = false;
            this.matrixView.RowTemplate.Height = 30;
            this.matrixView.Size = new System.Drawing.Size(241, 122);
            this.matrixView.TabIndex = 34;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(674, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Transformation matrix:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 364);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.matrixView);
            this.Controls.Add(this.rbxz);
            this.Controls.Add(this.rbyz);
            this.Controls.Add(this.rbxy);
            this.Controls.Add(this.lbtranZ);
            this.Controls.Add(this.lbtranY);
            this.Controls.Add(this.lbtranX);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.sbtranZ);
            this.Controls.Add(this.sbtranY);
            this.Controls.Add(this.sbtranX);
            this.Controls.Add(this.lbscaleZ);
            this.Controls.Add(this.lbscaleY);
            this.Controls.Add(this.lbscaleX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sbscaleZ);
            this.Controls.Add(this.sbscaleY);
            this.Controls.Add(this.sbscaleX);
            this.Controls.Add(this.lbrotz);
            this.Controls.Add(this.lbroty);
            this.Controls.Add(this.lbrotx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sbrotZ);
            this.Controls.Add(this.sbrotY);
            this.Controls.Add(this.sbrotX);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "3D Transformations";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.HScrollBar sbrotX;
        private System.Windows.Forms.HScrollBar sbrotY;
        private System.Windows.Forms.HScrollBar sbrotZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbrotx;
        private System.Windows.Forms.Label lbroty;
        private System.Windows.Forms.Label lbrotz;
        private System.Windows.Forms.Label lbscaleZ;
        private System.Windows.Forms.Label lbscaleY;
        private System.Windows.Forms.Label lbscaleX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.HScrollBar sbscaleZ;
        private System.Windows.Forms.HScrollBar sbscaleY;
        private System.Windows.Forms.HScrollBar sbscaleX;
        private System.Windows.Forms.Label lbtranZ;
        private System.Windows.Forms.Label lbtranY;
        private System.Windows.Forms.Label lbtranX;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.HScrollBar sbtranZ;
        private System.Windows.Forms.HScrollBar sbtranY;
        private System.Windows.Forms.HScrollBar sbtranX;
        private System.Windows.Forms.RadioButton rbxy;
        private System.Windows.Forms.RadioButton rbyz;
        private System.Windows.Forms.RadioButton rbxz;
        private System.Windows.Forms.DataGridView matrixView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label5;
    }
}


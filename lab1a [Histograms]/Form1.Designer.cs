namespace Lab1a
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lbRedName = new System.Windows.Forms.Label();
            this.pnRed = new System.Windows.Forms.Panel();
            this.lbRedMax = new System.Windows.Forms.Label();
            this.lbRed0 = new System.Windows.Forms.Label();
            this.lbRed255 = new System.Windows.Forms.Label();
            this.lbGreen255 = new System.Windows.Forms.Label();
            this.lbGreen0 = new System.Windows.Forms.Label();
            this.lbGreenMax = new System.Windows.Forms.Label();
            this.pnGreen = new System.Windows.Forms.Panel();
            this.lbGreenName = new System.Windows.Forms.Label();
            this.lbBlue255 = new System.Windows.Forms.Label();
            this.lbBlue0 = new System.Windows.Forms.Label();
            this.lbBlueMax = new System.Windows.Forms.Label();
            this.pnBlue = new System.Windows.Forms.Panel();
            this.lbBlueName = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(640, 480);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // lbRedName
            // 
            this.lbRedName.AutoSize = true;
            this.lbRedName.Location = new System.Drawing.Point(658, 12);
            this.lbRedName.Name = "lbRedName";
            this.lbRedName.Size = new System.Drawing.Size(128, 13);
            this.lbRedName.TabIndex = 1;
            this.lbRedName.Text = "Гистограмма красного:";
            // 
            // pnRed
            // 
            this.pnRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnRed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnRed.Location = new System.Drawing.Point(684, 41);
            this.pnRed.Name = "pnRed";
            this.pnRed.Size = new System.Drawing.Size(258, 100);
            this.pnRed.TabIndex = 2;
            this.pnRed.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_Paint);
            // 
            // lbRedMax
            // 
            this.lbRedMax.AutoSize = true;
            this.lbRedMax.Location = new System.Drawing.Point(658, 25);
            this.lbRedMax.Name = "lbRedMax";
            this.lbRedMax.Size = new System.Drawing.Size(26, 13);
            this.lbRedMax.TabIndex = 3;
            this.lbRedMax.Text = "max";
            // 
            // lbRed0
            // 
            this.lbRed0.AutoSize = true;
            this.lbRed0.Location = new System.Drawing.Point(671, 148);
            this.lbRed0.Name = "lbRed0";
            this.lbRed0.Size = new System.Drawing.Size(13, 13);
            this.lbRed0.TabIndex = 4;
            this.lbRed0.Text = "0";
            // 
            // lbRed255
            // 
            this.lbRed255.AutoSize = true;
            this.lbRed255.Location = new System.Drawing.Point(924, 148);
            this.lbRed255.Name = "lbRed255";
            this.lbRed255.Size = new System.Drawing.Size(25, 13);
            this.lbRed255.TabIndex = 5;
            this.lbRed255.Text = "255";
            // 
            // lbGreen255
            // 
            this.lbGreen255.AutoSize = true;
            this.lbGreen255.Location = new System.Drawing.Point(924, 304);
            this.lbGreen255.Name = "lbGreen255";
            this.lbGreen255.Size = new System.Drawing.Size(25, 13);
            this.lbGreen255.TabIndex = 10;
            this.lbGreen255.Text = "255";
            // 
            // lbGreen0
            // 
            this.lbGreen0.AutoSize = true;
            this.lbGreen0.Location = new System.Drawing.Point(671, 304);
            this.lbGreen0.Name = "lbGreen0";
            this.lbGreen0.Size = new System.Drawing.Size(13, 13);
            this.lbGreen0.TabIndex = 9;
            this.lbGreen0.Text = "0";
            // 
            // lbGreenMax
            // 
            this.lbGreenMax.AutoSize = true;
            this.lbGreenMax.Location = new System.Drawing.Point(658, 181);
            this.lbGreenMax.Name = "lbGreenMax";
            this.lbGreenMax.Size = new System.Drawing.Size(26, 13);
            this.lbGreenMax.TabIndex = 8;
            this.lbGreenMax.Text = "max";
            // 
            // pnGreen
            // 
            this.pnGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnGreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnGreen.Location = new System.Drawing.Point(684, 197);
            this.pnGreen.Name = "pnGreen";
            this.pnGreen.Size = new System.Drawing.Size(258, 100);
            this.pnGreen.TabIndex = 7;
            this.pnGreen.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_Paint);
            // 
            // lbGreenName
            // 
            this.lbGreenName.AutoSize = true;
            this.lbGreenName.Location = new System.Drawing.Point(657, 168);
            this.lbGreenName.Name = "lbGreenName";
            this.lbGreenName.Size = new System.Drawing.Size(128, 13);
            this.lbGreenName.TabIndex = 6;
            this.lbGreenName.Text = "Гистограмма зеленого:";
            // 
            // lbBlue255
            // 
            this.lbBlue255.AutoSize = true;
            this.lbBlue255.Location = new System.Drawing.Point(924, 460);
            this.lbBlue255.Name = "lbBlue255";
            this.lbBlue255.Size = new System.Drawing.Size(25, 13);
            this.lbBlue255.TabIndex = 15;
            this.lbBlue255.Text = "255";
            // 
            // lbBlue0
            // 
            this.lbBlue0.AutoSize = true;
            this.lbBlue0.Location = new System.Drawing.Point(671, 460);
            this.lbBlue0.Name = "lbBlue0";
            this.lbBlue0.Size = new System.Drawing.Size(13, 13);
            this.lbBlue0.TabIndex = 14;
            this.lbBlue0.Text = "0";
            // 
            // lbBlueMax
            // 
            this.lbBlueMax.AutoSize = true;
            this.lbBlueMax.Location = new System.Drawing.Point(658, 337);
            this.lbBlueMax.Name = "lbBlueMax";
            this.lbBlueMax.Size = new System.Drawing.Size(26, 13);
            this.lbBlueMax.TabIndex = 13;
            this.lbBlueMax.Text = "max";
            // 
            // pnBlue
            // 
            this.pnBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBlue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnBlue.Location = new System.Drawing.Point(684, 353);
            this.pnBlue.Name = "pnBlue";
            this.pnBlue.Size = new System.Drawing.Size(258, 100);
            this.pnBlue.TabIndex = 12;
            this.pnBlue.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_Paint);
            // 
            // lbBlueName
            // 
            this.lbBlueName.AutoSize = true;
            this.lbBlueName.Location = new System.Drawing.Point(658, 324);
            this.lbBlueName.Name = "lbBlueName";
            this.lbBlueName.Size = new System.Drawing.Size(116, 13);
            this.lbBlueName.TabIndex = 11;
            this.lbBlueName.Text = "Гистограмма синего:";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 498);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(236, 35);
            this.buttonLoad.TabIndex = 16;
            this.buttonLoad.Text = "Загрузить файл";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Open file";
            this.openFileDialog.Filter = "All files|*.*";
            this.openFileDialog.RestoreDirectory = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(961, 545);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.lbBlue255);
            this.Controls.Add(this.lbBlue0);
            this.Controls.Add(this.lbBlueMax);
            this.Controls.Add(this.pnBlue);
            this.Controls.Add(this.lbBlueName);
            this.Controls.Add(this.lbGreen255);
            this.Controls.Add(this.lbGreen0);
            this.Controls.Add(this.lbGreenMax);
            this.Controls.Add(this.pnGreen);
            this.Controls.Add(this.lbGreenName);
            this.Controls.Add(this.lbRed255);
            this.Controls.Add(this.lbRed0);
            this.Controls.Add(this.lbRedMax);
            this.Controls.Add(this.pnRed);
            this.Controls.Add(this.lbRedName);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Гистограммы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lbRedName;
        private System.Windows.Forms.Panel pnRed;
        private System.Windows.Forms.Label lbRedMax;
        private System.Windows.Forms.Label lbRed0;
        private System.Windows.Forms.Label lbRed255;
        private System.Windows.Forms.Label lbGreen255;
        private System.Windows.Forms.Label lbGreen0;
        private System.Windows.Forms.Label lbGreenMax;
        private System.Windows.Forms.Panel pnGreen;
        private System.Windows.Forms.Label lbGreenName;
        private System.Windows.Forms.Label lbBlue255;
        private System.Windows.Forms.Label lbBlue0;
        private System.Windows.Forms.Label lbBlueMax;
        private System.Windows.Forms.Panel pnBlue;
        private System.Windows.Forms.Label lbBlueName;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1a
{
    public partial class Form1 : Form
    {
        private int[] redHist = new int[256];
        private int[] greenHist = new int[256];
        private int[] blueHist = new int[256];
        private double redM = 0;
        private double greenM = 0;
        private double blueM = 0;
        private Image source = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if ( openFileDialog.ShowDialog() == DialogResult.OK )
                try {
                    source = Image.FromFile(openFileDialog.FileName);
                    pictureBox.Image = source;
                    picUpdated();
                } catch (Exception ex) {
                    MessageBox.Show("Не удалось открыть изображение. " + ex.Message);
                }
        }

        private void picUpdated()
        {
            createHist();
            pnRed.Refresh();
            pnGreen.Refresh();
            pnBlue.Refresh();
        }

        private void createHist()
        {
            double redC = 0, greenC = 0, blueC = 0;
            redM = 0; greenM = 0; blueM = 0;
            Bitmap pic = new Bitmap(pictureBox.Image);
            
            redHist = new int[256]; greenHist = new int[256]; blueHist = new int[256];
            
            for (int x = 0; x < pic.Width; ++x)
                for (int y = 0; y < pic.Height; ++y) {
                    Color col = pic.GetPixel(x, y);
                    redC += col.R;
                    if (++redHist[col.R] > redM) redM = redHist[col.R];
                    greenC += col.G;
                    if (++greenHist[col.G] > greenM) greenM = greenHist[col.G];
                    blueC += col.B;
                    if (++blueHist[col.B] > blueM) blueM = blueHist[col.B];
                }
            double area = pic.Width * pic.Height;
            String format = "{0,-9}   Среднее : {1:0.##}";
            lbRedMax.Text   = String.Format(format, redM, redC / area);
            lbGreenMax.Text = String.Format(format, greenM, greenC / area);
            lbBlueMax.Text  = String.Format(format, blueM, blueC / area);

        }

        private void pn_Paint(object sender, PaintEventArgs e)
        {
            Panel pn = sender as Panel;
            Graphics g = e.Graphics;
            int[] hist = null;
            double m = 1.0;
            Color back = Color.Black;
            Pen pen = null;
            if (pn == pnRed) { hist = redHist; m = Math.Max(m, redM); back = Color.FromArgb(255, 192, 192); pen = new Pen(Color.Red); }
            else if (pn == pnGreen) { hist = greenHist; m = Math.Max(m, greenM); back = Color.FromArgb(192, 255, 192); pen = new Pen(Color.Lime); }
            else if (pn == pnBlue) { hist = blueHist; m = Math.Max(m, blueM); back = Color.FromArgb(192, 192, 255); pen = new Pen(Color.Blue); }
            g.Clear(back);
            for (int i = 0; i < 256; ++i) {
                g.DrawLine(pen, i, pn.Height, i, pn.Height - (int)(pn.Height * hist[i] / m));
            }

        }

    }
}

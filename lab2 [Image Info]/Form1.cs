using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                foreach ( string name in openFileDialog1.FileNames ) {
                    try
                    {
                        Image im = Image.FromFile(name);
                        richTextBox1.AppendText(name + ":\r\n");
                        
                        richTextBox1.AppendText("Width = " + im.PhysicalDimension.Width + " pixels\r\n");
                        richTextBox1.AppendText("Height = " + im.PhysicalDimension.Height + " pixels\r\n");

                        richTextBox1.AppendText("Horizontal Resolution = " + im.VerticalResolution + " dpi\r\n");
                        richTextBox1.AppendText("Vertical Resolution = " + im.HorizontalResolution + " dpi\r\n");

                        bool cm = false;
                        foreach (System.Drawing.Imaging.PropertyItem pitem in im.PropertyItems)
                        {
                            //richTextBox1.AppendText(pitem.Id.ToString("x") + "\r\n");
                            if (pitem.Id == 0x0103) { // Compression type property
                                string comp = "No compression";
                                if (BitConverter.ToInt16(pitem.Value, 0) == 2)
                                    comp = "CCITT Group 3";
                                else if (BitConverter.ToInt16(pitem.Value, 0) == 3)
                                    comp = "Facsimile-compatible CCITT Group 3";
                                else if (BitConverter.ToInt16(pitem.Value, 0) == 4)
                                    comp = "CCITT Group 4 (T.6)";
                                else if (BitConverter.ToInt16(pitem.Value, 0) == 5)
                                    comp = "LZW";
                                richTextBox1.AppendText("Compression = " + comp + "\r\n");
                                cm = true;
                            }
                        }
                        if (!cm) richTextBox1.AppendText("No compression info stored in file.\r\n");

                        richTextBox1.AppendText("============\r\n");
                    }
                    catch (Exception)
                    {
                        richTextBox1.AppendText(name + " is not a supported image.\r\n");
                    }
                }
            }
        }
    }
}

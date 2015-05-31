using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        Mat4f projectionMatrix;
        Mat4f scaleMatrix;
        Mat4f translateMatrix;
        Mat4f rotateXMatrix;
        Mat4f rotateYMatrix;
        Mat4f rotateZMatrix;
        Mat4f transformMatrix;

        Vec4f[] points;
        int[] lines;

        public Form1()
        {
            InitializeComponent();
            projectionMatrix = Transform.identity();
            transformMatrix = Transform.identity();
            rotateXMatrix = Transform.identity();
            rotateYMatrix = Transform.identity();
            rotateZMatrix = Transform.identity();
            translateMatrix = Transform.identity();
            scaleMatrix = Transform.identity();
            points = new Vec4f[] { 
                new Vec4f(-1, -3, -1, 1),
                new Vec4f(-1, -3,  1, 1),
                new Vec4f( 1, -3,  1, 1),
                new Vec4f( 1, -3, -1, 1),
                
                new Vec4f(-1,  1, -1, 1),
                new Vec4f(-1,  1,  1, 1),
                new Vec4f( 1,  1,  1, 1),
                new Vec4f( 1,  1, -1, 1),
                
                new Vec4f(-3,  1, -1, 1),
                new Vec4f(-3,  1,  1, 1),
                new Vec4f( 3,  1,  1, 1),
                new Vec4f( 3,  1, -1, 1),
                
                new Vec4f(-3,  3, -1, 1),
                new Vec4f(-3,  3,  1, 1),
                new Vec4f( 3,  3,  1, 1),
                new Vec4f( 3,  3, -1, 1)
            };
            lines = new int[] { 0, 4, 8, 12, 15, 11, 7, 3, 0, 1, 5, 9, 13, 14, 10, 6, 2, 1, -1, 
                2, 3, -1, 6, 7, -1, 10, 11, -1, 14, 15, -1, 12, 13, -1, 8, 9, -1, 5, 4 };

            matrixView.Rows.Add(4);
            updateAll();
        }

        private void updateAll()
        {
            transformMatrix = Transform.identity();
            transformMatrix = rotateZMatrix * transformMatrix;
            transformMatrix = rotateYMatrix * transformMatrix;
            transformMatrix = rotateXMatrix * transformMatrix;
            transformMatrix = translateMatrix * transformMatrix;
            transformMatrix = scaleMatrix * transformMatrix;

            matrixView.Rows[0].Cells[0].Value = transformMatrix.a.x;
            matrixView.Rows[0].Cells[1].Value = transformMatrix.a.y;
            matrixView.Rows[0].Cells[2].Value = transformMatrix.a.z;
            matrixView.Rows[0].Cells[3].Value = transformMatrix.a.w;
            matrixView.Rows[1].Cells[0].Value = transformMatrix.b.x;
            matrixView.Rows[1].Cells[1].Value = transformMatrix.b.y;
            matrixView.Rows[1].Cells[2].Value = transformMatrix.b.z;
            matrixView.Rows[1].Cells[3].Value = transformMatrix.b.w;
            matrixView.Rows[2].Cells[0].Value = transformMatrix.c.x;
            matrixView.Rows[2].Cells[1].Value = transformMatrix.c.y;
            matrixView.Rows[2].Cells[2].Value = transformMatrix.c.z;
            matrixView.Rows[2].Cells[3].Value = transformMatrix.c.w;
            matrixView.Rows[3].Cells[0].Value = transformMatrix.d.x;
            matrixView.Rows[3].Cells[1].Value = transformMatrix.d.y;
            matrixView.Rows[3].Cells[2].Value = transformMatrix.d.z;
            matrixView.Rows[3].Cells[3].Value = transformMatrix.d.w;

            chart1.Invalidate();
        }

        private void chart1_Paint(object sender, PaintEventArgs e)
        {
            Mat4f mat = projectionMatrix * transformMatrix;
            chart1.Series["Ox"].Points.Clear();

            foreach (int i in lines)
            {
                if (i == -1)
                    chart1.Series["Ox"].Points.AddXY(Double.NaN, Double.NaN);
                else
                {
                    Vec4f res = mat * points[i];
                    chart1.Series["Ox"].Points.AddXY(res.x, res.y);
                }
            }
        }

        private void sbrot(object sender, ScrollEventArgs e)
        {
            if (sender == sbrotX)
            {
                rotateXMatrix = Transform.rotateMatrix("x", e.NewValue * Math.PI / 180);
                lbrotx.Text = e.NewValue.ToString();
            }
            if (sender == sbrotY) { 
                rotateYMatrix = Transform.rotateMatrix("y", e.NewValue * Math.PI / 180);
                lbroty.Text = e.NewValue.ToString();
            }
            if (sender == sbrotZ) {
                rotateZMatrix = Transform.rotateMatrix("z", e.NewValue * Math.PI / 180);
                lbrotz.Text = e.NewValue.ToString();
            }
            updateAll();
        }

        private void sbtran(object sender, ScrollEventArgs e)
        {
            translateMatrix = Transform.translateMatrix(0.1*sbtranX.Value, 0.1*sbtranY.Value, 0.1*sbtranZ.Value);
            lbtranX.Text = ( 0.1 * sbtranX.Value ).ToString();
            lbtranY.Text = ( 0.1 * sbtranY.Value ).ToString();
            lbtranZ.Text = ( 0.1 * sbtranZ.Value ).ToString();
            updateAll();
        }

        private void sbscale(object sender, ScrollEventArgs e)
        {
            scaleMatrix = Transform.scaleMatrix(0.1 * sbscaleX.Value, 0.1 * sbscaleY.Value, 0.1 * sbscaleZ.Value);
            lbscaleX.Text = (0.1 * sbscaleX.Value).ToString();
            lbscaleY.Text = (0.1 * sbscaleY.Value).ToString();
            lbscaleZ.Text = (0.1 * sbscaleZ.Value).ToString();
            updateAll();
        }

        private void rbproj(object sender, EventArgs e)
        {
            if (rbxy.Checked) projectionMatrix = Transform.projectMatrix("xy");
            else if (rbyz.Checked) projectionMatrix = Transform.projectMatrix("yz");
            else if (rbxz.Checked) projectionMatrix = Transform.projectMatrix("xz");
            updateAll();
        }
    }
}

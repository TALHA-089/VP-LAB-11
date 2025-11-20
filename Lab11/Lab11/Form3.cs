using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form3 : Form
    {
        private bool ShouldPaint = false;

        public Form3()
        {
            InitializeComponent();
        }

        private void Painter_MouseDown(object sender, MouseEventArgs e)
        {
            ShouldPaint = true;
        }

        private void Painter_MouseMove(object sender, MouseEventArgs e)
        {
            if (ShouldPaint)
            {
                using (Graphics graphics = CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(Color.BlueViolet), e.X, e.Y, 4, 4);
                }
            }
        }

        private void Painter_MouseUp(object sender, MouseEventArgs e)
        {
            ShouldPaint = false;
        }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form5 : Form
    {
        // State variables for drawing parameters
        private bool ShouldPaint = false;
        private int brushThick1 = 4; // Initial thickness
        private int brushThick2 = 4; // Initial thickness
        private Color frontColor = Color.BlueViolet; // Initial brush color

        public Form5()
        {
            InitializeComponent();
        }

        // --- Mouse Event Handlers (Drawing Logic) ---

        private void Painter_MouseDown(object sender, MouseEventArgs e)
        {
            ShouldPaint = true;
        }

        private void Painter_MouseMove(object sender, MouseEventArgs e)
        {
            if (ShouldPaint)
            {
                // Use the current brush color and thickness variables
                using (Graphics graphics = CreateGraphics())
                {
                    // Draw a solid ellipse (dot) using current settings
                    graphics.FillEllipse(new SolidBrush(frontColor), e.X, e.Y, brushThick1, brushThick2);
                }
            }
        }

        private void Painter_MouseUp(object sender, MouseEventArgs e)
        {
            ShouldPaint = false;
        }

        // --- Menu Strip Event Handlers (Control Logic) ---

        // Color -> Custom color: Changes the brush color
        private void customColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                frontColor = colorDlg.Color;
            }
        }

        // Color -> Custom Background Color: Changes the form's background color
        private void customBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDlg.Color;
            }
        }

        // Brush Thickness Handlers
        private void thickness6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brushThick1 = 6;
            brushThick2 = 6;
        }

        private void thickness10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brushThick1 = 10;
            brushThick2 = 10;
        }

        private void thickness20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brushThick1 = 20;
            brushThick2 = 20;
        }

        private void thickness40ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brushThick1 = 40;
            brushThick2 = 40;
        }

        // Reset Parameters: Resets colors, thickness, and clears the drawing
        private void resetParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Reset state variables
            frontColor = Color.BlueViolet;
            brushThick1 = 4;
            brushThick2 = 4;

            // Reset background color to the default
            this.BackColor = SystemColors.Control;

            // Clear the drawing surface by forcing a redraw
            this.Invalidate();
        }
    }
}
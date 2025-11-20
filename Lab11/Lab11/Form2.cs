using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /*
         * Event: myForm_MouseClick (or Form1_MouseClick)
         * Objective: Display the X and Y coordinates of the mouse click in a label.
         */
        private void myForm_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X; // Get the X coordinate 
            int y = e.Y; // Get the Y coordinate 

            // Assuming your label is named 'label1'
            label1.Text = "Mouse Clicked at " + x + " , " + y; // 
        }
    }
}
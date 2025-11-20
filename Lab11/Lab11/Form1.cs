using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Event: Form1_KeyDown
         * Objective: On pressing the 'A' key, change the Form's BackColor to White
         * and the label1's Font to Verdana, size 20, and ForeColor to Turquoise.
         */
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the key pressed is the 'A' key
            if (e.KeyCode == Keys.A)
            {
                // Change the Form's Background Color
                this.BackColor = Color.White; // FormBackgroundColor="White"

                // Change the Label's Font and Color
                label1.Font = new Font("Verdana", 20f); // FontType="Verdana", FontSize="20"
                label1.ForeColor = Color.Turquoise;     // FontColor="Turquoise"
            }
        }
    }
}
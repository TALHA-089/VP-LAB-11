namespace Lab11
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brushThicknessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thickness6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thickness10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thickness20ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thickness40ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetParametersToolStripMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushThicknessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thickness6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thickness10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thickness20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thickness40ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.brushThicknessToolStripMenuItem,
            this.resetParametersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customColorToolStripMenuItem,
            this.customBackgroundToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // customColorToolStripMenuItem
            // 
            this.customColorToolStripMenuItem.Name = "customColorToolStripMenuItem";
            this.customColorToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.customColorToolStripMenuItem.Text = "Custom color";
            this.customColorToolStripMenuItem.Click += new System.EventHandler(this.customColorToolStripMenuItem_Click); // Event connection
            // 
            // customBackgroundToolStripMenuItem
            // 
            this.customBackgroundToolStripMenuItem.Name = "customBackgroundToolStripMenuItem";
            this.customBackgroundToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.customBackgroundToolStripMenuItem.Text = "Custom Background";
            this.customBackgroundToolStripMenuItem.Click += new System.EventHandler(this.customBackgroundToolStripMenuItem_Click); // Event connection
            // 
            // brushThicknessToolStripMenuItem
            // 
            this.brushThicknessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thickness6ToolStripMenuItem,
            this.thickness10ToolStripMenuItem,
            this.thickness20ToolStripMenuItem,
            this.thickness40ToolStripMenuItem});
            this.brushThicknessToolStripMenuItem.Name = "brushThicknessToolStripMenuItem";
            this.brushThicknessToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.brushThicknessToolStripMenuItem.Text = "Brush Thickness";
            // 
            // thickness6ToolStripMenuItem
            // 
            this.thickness6ToolStripMenuItem.Name = "thickness6ToolStripMenuItem";
            this.thickness6ToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.thickness6ToolStripMenuItem.Text = "6, 6";
            this.thickness6ToolStripMenuItem.Click += new System.EventHandler(this.thickness6ToolStripMenuItem_Click); // Event connection
            // 
            // thickness10ToolStripMenuItem
            // 
            this.thickness10ToolStripMenuItem.Name = "thickness10ToolStripMenuItem";
            this.thickness10ToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.thickness10ToolStripMenuItem.Text = "10, 10";
            this.thickness10ToolStripMenuItem.Click += new System.EventHandler(this.thickness10ToolStripMenuItem_Click); // Event connection
            // 
            // thickness20ToolStripMenuItem
            // 
            this.thickness20ToolStripMenuItem.Name = "thickness20ToolStripMenuItem";
            this.thickness20ToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.thickness20ToolStripMenuItem.Text = "20, 20";
            this.thickness20ToolStripMenuItem.Click += new System.EventHandler(this.thickness20ToolStripMenuItem_Click); // Event connection
            // 
            // thickness40ToolStripMenuItem
            // 
            this.thickness40ToolStripMenuItem.Name = "thickness40ToolStripMenuItem";
            this.thickness40ToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.thickness40ToolStripMenuItem.Text = "40, 40";
            this.thickness40ToolStripMenuItem.Click += new System.EventHandler(this.thickness40ToolStripMenuItem_Click); // Event connection
            // 
            // resetParametersToolStripMenuItem
            // 
            this.resetParametersToolStripMenuItem.Name = "resetParametersToolStripMenuItem";
            this.resetParametersToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.resetParametersToolStripMenuItem.Text = "Reset Parameters";
            this.resetParametersToolStripMenuItem.Click += new System.EventHandler(this.resetParametersToolStripMenuItem_Click); // Event connection
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Drawing";

            // CRUCIAL STEPS: Attach Mouse Events for Drawing
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Painter_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Painter_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Painter_MouseUp);

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
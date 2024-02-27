namespace MultipleLanguages.App
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.langMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.arMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.langMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1157, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // langMenu
            // 
            this.langMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arMenuItem,
            this.enMenuItem,
            this.frMenuItem});
            this.langMenu.Name = "langMenu";
            this.langMenu.Size = new System.Drawing.Size(54, 24);
            this.langMenu.Text = "اللغة";
            // 
            // arMenuItem
            // 
            this.arMenuItem.Name = "arMenuItem";
            this.arMenuItem.Size = new System.Drawing.Size(136, 26);
            this.arMenuItem.Text = "عربي";
            // 
            // enMenuItem
            // 
            this.enMenuItem.Name = "enMenuItem";
            this.enMenuItem.Size = new System.Drawing.Size(136, 26);
            this.enMenuItem.Text = "انجليزي";
            // 
            // frMenuItem
            // 
            this.frMenuItem.Name = "frMenuItem";
            this.frMenuItem.Size = new System.Drawing.Size(136, 26);
            this.frMenuItem.Text = "فرنسي";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1157, 583);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem langMenu;
        private System.Windows.Forms.ToolStripMenuItem arMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}


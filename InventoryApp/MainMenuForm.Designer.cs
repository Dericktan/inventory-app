namespace InventoryApp
{
    partial class MainMenuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mASTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRANSACTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLOSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUSTOMERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUPPLIERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mASTERToolStripMenuItem,
            this.tRANSACTIONToolStripMenuItem,
            this.rEPORTToolStripMenuItem,
            this.cLOSEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(663, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mASTERToolStripMenuItem
            // 
            this.mASTERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cUSTOMERToolStripMenuItem,
            this.sUPPLIERToolStripMenuItem});
            this.mASTERToolStripMenuItem.Name = "mASTERToolStripMenuItem";
            this.mASTERToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.mASTERToolStripMenuItem.Text = "MASTER";
            // 
            // tRANSACTIONToolStripMenuItem
            // 
            this.tRANSACTIONToolStripMenuItem.Name = "tRANSACTIONToolStripMenuItem";
            this.tRANSACTIONToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.tRANSACTIONToolStripMenuItem.Text = "TRANSACTION";
            // 
            // rEPORTToolStripMenuItem
            // 
            this.rEPORTToolStripMenuItem.Name = "rEPORTToolStripMenuItem";
            this.rEPORTToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.rEPORTToolStripMenuItem.Text = "REPORT";
            // 
            // cLOSEToolStripMenuItem
            // 
            this.cLOSEToolStripMenuItem.Name = "cLOSEToolStripMenuItem";
            this.cLOSEToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.cLOSEToolStripMenuItem.Text = "CLOSE";
            // 
            // cUSTOMERToolStripMenuItem
            // 
            this.cUSTOMERToolStripMenuItem.Name = "cUSTOMERToolStripMenuItem";
            this.cUSTOMERToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cUSTOMERToolStripMenuItem.Text = "CUSTOMER";
            // 
            // sUPPLIERToolStripMenuItem
            // 
            this.sUPPLIERToolStripMenuItem.Name = "sUPPLIERToolStripMenuItem";
            this.sUPPLIERToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sUPPLIERToolStripMenuItem.Text = "SUPPLIER";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 465);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mASTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUSTOMERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUPPLIERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRANSACTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLOSEToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}
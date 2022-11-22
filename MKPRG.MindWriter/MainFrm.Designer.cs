
namespace MKPRG.MindWriter
{
    partial class MainFrm
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addChildWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mainFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cmdLabel = new System.Windows.Forms.Label();
            this.tbxCmd = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.mainFormTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addChildWindowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // addChildWindowToolStripMenuItem
            // 
            this.addChildWindowToolStripMenuItem.Name = "addChildWindowToolStripMenuItem";
            this.addChildWindowToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.addChildWindowToolStripMenuItem.Text = "&Add Child Window";
            this.addChildWindowToolStripMenuItem.Click += new System.EventHandler(this.addChildWindowToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 237);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mainFormTableLayoutPanel
            // 
            this.mainFormTableLayoutPanel.ColumnCount = 3;
            this.mainFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainFormTableLayoutPanel.Controls.Add(this.tbxCmd, 1, 0);
            this.mainFormTableLayoutPanel.Controls.Add(this.cmdLabel, 0, 0);
            this.mainFormTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainFormTableLayoutPanel.Name = "mainFormTableLayoutPanel";
            this.mainFormTableLayoutPanel.RowCount = 4;
            this.mainFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.mainFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainFormTableLayoutPanel.Size = new System.Drawing.Size(800, 213);
            this.mainFormTableLayoutPanel.TabIndex = 2;
            // 
            // cmdLabel
            // 
            this.cmdLabel.AutoSize = true;
            this.cmdLabel.Location = new System.Drawing.Point(3, 0);
            this.cmdLabel.Name = "cmdLabel";
            this.cmdLabel.Size = new System.Drawing.Size(32, 13);
            this.cmdLabel.TabIndex = 0;
            this.cmdLabel.Text = "CMD";
            this.cmdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxCmd
            // 
            this.tbxCmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxCmd.Location = new System.Drawing.Point(53, 3);
            this.tbxCmd.Name = "tbxCmd";
            this.tbxCmd.Size = new System.Drawing.Size(724, 22);
            this.tbxCmd.TabIndex = 1;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 259);
            this.Controls.Add(this.mainFormTableLayoutPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.ShowIcon = false;
            this.Text = "Mind Writer ";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainFrm_ResizeEnd);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainFormTableLayoutPanel.ResumeLayout(false);
            this.mainFormTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem addChildWindowToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel mainFormTableLayoutPanel;
        private System.Windows.Forms.Label cmdLabel;
        private System.Windows.Forms.TextBox tbxCmd;
    }
}


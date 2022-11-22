using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKPRG.MindWriter
{
    /// <summary>
    /// mko, 20.11.2022
    /// Main Window, servers Commandlines, Windows- Managment etc.
    /// 
    /// Below Main Window can be created Child Windows. Main Window arranges Child Windows aoutomatically. 
    /// If Main Window is moved to an other screen, then all child windows are created on Screen to wich Main Windows was moved.
    /// </summary>
    public partial class MainFrm : Form
    {
        WindowPlacementManager plcMgr;

        public MainFrm()
        {
            InitializeComponent();

            plcMgr = new WindowPlacementManager(this);
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            TopMost = true;            
            WindowState = FormWindowState.Maximized;           

            plcMgr.PlaceMainWindow();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void SecondForm_FormClosed(object sender, FormClosedEventArgs e)
        {      
            if(sender is ChildForm child)
            {
                plcMgr.RemoveChildWindow(child);
            }

        }

        private void addChildWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var childWnd = new ChildForm(plcMgr);
            childWnd.Location = this.Location;
            childWnd.Text = $"🜶 {plcMgr.ChildWindowCount}";
            childWnd.Show();
            childWnd.FormClosed += SecondForm_FormClosed;
            
        }

        /// <summary>
        /// Ensures, that mainForm ist anytime placed well.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrm_ResizeEnd(object sender, EventArgs e)
        {
            plcMgr.PlaceMainWindow();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theif_Escape
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        #region [ Button Click Events ]

        //New Game Button
        private void btnNew_Click(object sender, EventArgs e)
        {
            //Create the GetName form, and launch it
            FrmGetName frm = new FrmGetName();
            frm.Show();

            //Hide this form
            this.Hide();
        }

        //  Load Game Button
        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            //to-do
        }

        //  Exit Game Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        //  When this form is closed ( not hidden ) ensure that everything is closed.
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
                Application.Exit();
        }
    }
}

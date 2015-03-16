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
    public partial class FrmGetName : Form
    {
        public FrmGetName()
        {
            InitializeComponent();
        }


        //  Back Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();

            frm.Show();
           

            //Close this form
            this.Close();
        }


        //  Play Button
        private void btnPlay_Click(object sender, EventArgs e)
        {
            FrmGame frm = null;
            //If the textbox is not blank, create FormGame with user-name
            if (txtName.Text.Trim() != String.Empty)
            {
                //Get the text from the the textbox and
                //Launch the second form, that contains the game interface
                frm = new FrmGame(txtName.Text);
            }
            //Else create it with generic "User"
            else
            {
                frm = new FrmGame();
            }

            frm.Show();

            //Close this form
            this.Close();
        }
    }
}

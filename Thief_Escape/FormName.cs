using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thief_Escape
{
    //-----------------------------------------------------------------------------------------------------
    public partial class FormName : Form
    {
        //-----------------------------------------------------------------------------------------------------
        public FormName()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnPlay_Click(object sender, EventArgs e)
        {
            FormGame frm1 = null;
            //If the textbox is not blank, create FormGame with user-name
            if (txtName.Text.Trim() != String.Empty)
            {
                //Get the text from the the textbox and
                //Launch the second form, that contains the game interface
                frm1 = new FormGame(txtName.Text);
            }
                //Else create it with generic "User"
            else
            {
                frm1 = new FormGame();
            }

            frm1.Show();

            //Close this form
            this.Close();
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMainMenu frm2 = new FormMainMenu();

            frm2.Show();

            //Close this form
            this.Close();
        }
    }
}



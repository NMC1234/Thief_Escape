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
			//Get the text from the the textbox and
			//Launch the second form, that contains the game interface
			FormGame frm1 = new FormGame(txtName.Text);

			frm1.Show();

			//Hide this form
            this.Close();
		}

		//-----------------------------------------------------------------------------------------------------
		private void btnBack_Click(object sender, EventArgs e)
		{
			FormMainMenu frm2 = new FormMainMenu();

			frm2.Show();

			//Hide this form
			this.Close();
		}
	}
}



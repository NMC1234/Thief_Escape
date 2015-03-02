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
	public partial class FormMainMenu : Form
	{
		public FormMainMenu( )
		{
			InitializeComponent( );
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			//Create the player name form, and launch it
			FormName frm = new FormName( );
			frm.Show( );

			//Hide this form
			this.Hide( );
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit( );
		}

		private void btnLoadGame_Click(object sender, EventArgs e)
		{
			//To be implimented
		}
	}
}

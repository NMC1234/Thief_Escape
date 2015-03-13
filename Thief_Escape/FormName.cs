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

		private void FormName_Load(object sender, EventArgs e)
		{
			ToolTip enterName = new ToolTip( );
			enterName.AutomaticDelay = 300;
			enterName.IsBalloon = false;
			enterName.UseAnimation = false;
			enterName.UseFading = false;
			enterName.ShowAlways = true;
			enterName.ToolTipTitle = "Enter Name";
			enterName.SetToolTip(this.txtName, "Please Enter your Name.");
			

			ToolTip playGame = new ToolTip( );
			playGame.AutomaticDelay = 300;
			playGame.IsBalloon = false;
			playGame.UseAnimation = false;
			playGame.UseFading = false;
			playGame.ShowAlways = true;
			playGame.ToolTipTitle = "Play Game";
			playGame.SetToolTip(this.btnPlay, "Select To Start New Game.");

			ToolTip mainMenu = new ToolTip( );
			mainMenu.AutomaticDelay = 300;
			mainMenu.IsBalloon = false;
			mainMenu.UseAnimation = false;
			mainMenu.UseFading = false;
			mainMenu.ShowAlways = true;
			mainMenu.ToolTipTitle = "Main Menu";
			mainMenu.SetToolTip(this.btnBack, "Select To Return To Main Menu.");
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

		private void txtName_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				btnPlay.PerformClick( );
			}
			else if(e.KeyCode == Keys.Tab)
			{
				btnPlay.Focus( );
			}
		}

		private void FormName_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				btnPlay.PerformClick( );
			}
			else if(e.KeyCode == Keys.Tab)
			{
				btnPlay.Focus( );
			}
		}
	}
}



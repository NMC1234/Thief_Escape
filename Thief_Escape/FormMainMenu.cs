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
		public FormMainMenu()
		{
			InitializeComponent();
		}

		#region [ Button Click ]
		private void btnNew_Click(object sender, EventArgs e)
		{
			//Create the player name form, and launch it
			FormName frmName = new FormName();
			frmName.Show();

			//Hide this form
			this.Hide();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnLoadGame_Click(object sender, EventArgs e)
		{
			//To be implimented
		}

		#endregion

		#region Load Event

		private void FormMainMenu_Load(object sender, EventArgs e)
		{
			this.btnNew.Focus( );

			ToolTip newGame = new ToolTip( );
			newGame.InitialDelay = 500;
			newGame.IsBalloon = false;
			newGame.UseAnimation = false;
			newGame.UseFading = false;
			newGame.ToolTipTitle = "New Game";
			newGame.ShowAlways = true;
			newGame.SetToolTip(this.btnNew, "Select To Start A New Game");
			
			ToolTip loadGame = new ToolTip( );
			loadGame.InitialDelay = 500;
			loadGame.IsBalloon = false;
			loadGame.UseAnimation = false;
			loadGame.UseFading = false;
			loadGame.ToolTipTitle = "Load Game";
			loadGame.ShowAlways = true;
			loadGame.SetToolTip(this.btnLoadGame, "Select To Load A Previous Game");

			ToolTip exitGame = new ToolTip( );
			exitGame.InitialDelay = 500;
			exitGame.IsBalloon = false;
			exitGame.UseAnimation = false;
			exitGame.UseFading = false;
			exitGame.ToolTipTitle = "Exit Game";
			exitGame.ShowAlways = true;
			exitGame.SetToolTip(this.btnExit, "Select To Exit Game Application");
		}

		#endregion

	
		
	}
}

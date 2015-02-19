
//User Interface file for group Phiv project
//Created by: Keegon Cabinaw
//Created on 02/15/2015

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
	

	//-----------------------------------------------------------------------------------------------------
	public partial class FormGame : Form
	{
		//-----------------------------------------------------------------------------------------------------
		#region [ Globals ]
		//-----------------------------------------------------------------------------------------------------
		Grid map;
		Player player;
		string name;

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------

		#region [ Constructors ]
		// Overloaded FormGame constructor to pass in name from name form
		public FormGame(string playername)
		{
			InitializeComponent();

			//Change the player name
			name = playername;
		}

		public FormGame()
		{
			// TODO: Complete member initialization
			InitializeComponent();
		}
		#endregion

		//-----------------------------------------------------------------------------------------------------
		#region [ LoadEvent ]
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		private void FormGamePlay_Load(object sender, EventArgs e)
		{
			//Make the grid
			map = new Grid();
			map.CreateTestGrid();

			//make the map
			CreateTestMap();

			//Propigate Image Map
			CreateTestMap();
			//Make the player
			player = new Player(name);
			player.SetCurrentCell(map.WhatIsStartingCellX, map.WhatIsStartingCellY);

			//Get the initial valid movements
			CheckMovement(player.CurrentCellX, player.CurrentCellY);

			//Output initial prompt
			InitalPrompt();
			//Output information about surrounding tiles
			OutputAroundPlayer(false);
		}

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region [ Movement Buttons Click ]
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		private void btnMoveNorth_Click(object sender, EventArgs e)
		{
			//Move the player north, (y axis - 1 )
			player.SetCurrentCell(
			player.CurrentCellX,
			(player.CurrentCellY - 1)
			);

			//Check new movements
			CheckMovement(player.CurrentCellX, player.CurrentCellY);

			//Change map image possition
			MoveCurrentPos(
			player.CurrentCellX,
			player.CurrentCellY,
			WhatIsPrevCellColor(Direction.NORTH),
			Direction.NORTH);

			//Output surrounding cells
			OutputAroundPlayer(true);
		}

		//-----------------------------------------------------------------------------------------------------
		private void btnMoveWest_Click(object sender, EventArgs e)
		{
			//Move the player west, (x axis - 1)
			player.SetCurrentCell(
			(player.CurrentCellX - 1),
			player.CurrentCellY
			);

			//Check new movements
			CheckMovement(player.CurrentCellX, player.CurrentCellY);

			//Change map possition
			MoveCurrentPos(
			player.CurrentCellX,
			player.CurrentCellY,
			WhatIsPrevCellColor(Direction.WEST),
			Direction.WEST);

			//Output surrounding cells
			OutputAroundPlayer(true);
		}

		//-----------------------------------------------------------------------------------------------------
		private void btnMoveEast_Click(object sender, EventArgs e)
		{
			//Move the player east, (x axis + 1)
			player.SetCurrentCell(
			(player.CurrentCellX + 1),
			player.CurrentCellY
			);

			//Check new movements
			CheckMovement(player.CurrentCellX, player.CurrentCellY);

			//Change map possition
			MoveCurrentPos(
			player.CurrentCellX,
			player.CurrentCellY,
			WhatIsPrevCellColor(Direction.EAST),
			Direction.EAST);

			//Output surrounding cells
			OutputAroundPlayer(true);
		}

		//-----------------------------------------------------------------------------------------------------
		private void btnMoveSouth_Click(object sender, EventArgs e)
		{
			//Move the player south, (y axis + 1 )
			player.SetCurrentCell(
			player.CurrentCellX,
			(player.CurrentCellY + 1)
			);

			//Check new movements
			CheckMovement(player.CurrentCellX, player.CurrentCellY);

			//Change map possition
			MoveCurrentPos(
			player.CurrentCellX,
			player.CurrentCellY,
			WhatIsPrevCellColor(Direction.SOUTH),
			Direction.SOUTH);

			//Output surrounding cells
			OutputAroundPlayer(true);
		}

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region [ Change Visual Map Cell Functions ]
		//-----------------------------------------------------------------------------------------------------
		//Returns the moved from cell's map color.
		//-----------------------------------------------------------------------------------------------------
		private Color WhatIsPrevCellColor(Direction direction)
		{
			Color color = Color.Brown;
			CellType cell = CellType.Generic;
			DoorType door = DoorType.Generic;
			StairsType stairs = StairsType.Generic;
			bool IsStartingCell = false;
			bool isStairs = false;
			bool isBejeweledKitten = false;

			//Switch statement to find previous cell's type
			switch(direction) {
				case Direction.NORTH:

					//get previous cell's type
					cell = map.GetCellType(player.CurrentCellX, (player.CurrentCellY + 1));
					//Check is previous cell is starting cell
					IsStartingCell = map.IsStartingCell(player.CurrentCellX, (player.CurrentCellY + 1));
					

					//check if in fact door celltype and if so save door type
					if(cell == CellType.Door) {
						door = map.GetDoorType(player.CurrentCellX, (player.CurrentCellY + 1));
					}
					//check if in fact stairs celltype and if so save stairs type
					else if(cell == CellType.Stairs) {
						stairs = map.GetStairsType(player.CurrentCellX, (player.CurrentCellY + 1));
					}
					break;
				case Direction.SOUTH:

					//get previous cell's type
					cell = map.GetCellType(player.CurrentCellX, (player.CurrentCellY - 1));
					//Check is previous cell is starting cell
					IsStartingCell = map.IsStartingCell(player.CurrentCellX, (player.CurrentCellY - 1));

					//check if in fact door celltype and if so save door type
					if(cell == CellType.Door) {
						door = map.GetDoorType(player.CurrentCellX, (player.CurrentCellY - 1));
					}
					//check if in fact stairs celltype and if so save stairs type
					else if(cell == CellType.Stairs) {
						stairs = map.GetStairsType(player.CurrentCellX, (player.CurrentCellY - 1));
					}
					break;
				case Direction.EAST:

					//get previous cell's type
					cell = map.GetCellType((player.CurrentCellX - 1), player.CurrentCellY);
					//Check is previous cell is starting cell
					IsStartingCell = map.IsStartingCell((player.CurrentCellX - 1), player.CurrentCellY);

					//check if in fact door celltype and if so save door type
					if(cell == CellType.Door) {
						door = map.GetDoorType((player.CurrentCellX - 1), player.CurrentCellY);
					}
					//check if in fact stairs celltype and if so save stairs type
					else if(cell == CellType.Stairs) {
						stairs = map.GetStairsType((player.CurrentCellX - 1), player.CurrentCellY);
					}
					break;
				case Direction.WEST:

					//get previous cell's type
					cell = map.GetCellType((player.CurrentCellX + 1), player.CurrentCellY);
					//Check is previous cell is starting cell
					IsStartingCell = map.IsStartingCell((player.CurrentCellX + 1), player.CurrentCellY);

					//check if in fact door celltype and if so save door type
					if(cell == CellType.Door) {
						door = map.GetDoorType((player.CurrentCellX + 1), player.CurrentCellY);
					}
					//check if in fact stairs celltype and if so save stairs type
					else if(cell == CellType.Stairs) {
						stairs = map.GetStairsType((player.CurrentCellX + 1), player.CurrentCellY);
					}
					break;

				//default:
				//	break;
			}

			//Switch statement to select color based on previous cell type
			//Initial if-else statement to week out the starting cell
			//Will need to be expanded to handle other floor and wall types.
			if(IsStartingCell) {
				color = Color.DarkGreen;
			}
			else {
				switch(cell) {

					case CellType.Floor:
						color = Color.White;
						break;

					case CellType.Wall:
						color = Color.DarkGray;
						break;

					case CellType.Door:
						if(door == DoorType.DoorUnlocked)
							color = Color.Blue;
						else if(door == DoorType.DoorLocked)
							color = Color.Red;
						break;

					case CellType.Stairs:
						isStairs = true;
						if(stairs == StairsType.StairsUp)
							color = Color.Cyan;
						else if(stairs == StairsType.StairsDpwn)
							color = Color.Salmon;
						break;

					case CellType.BejeweledKitten:
						isBejeweledKitten = true;
						color = Color.Purple;
						break;
					//default:
					//	break;
				}
			}
		
				
			return color;

		}

		public void MoveCurrentPos(int x, int y, Color color, Direction direction)
		{
			//change cordinates from start point 0 to start point 1
			x++;
			y++;

			//Change color of Current Cell to orange, [Y, X] !!!! Y must be first
			grdconMap[y, x].BackColor = Color.Orange;

			//Switch statement to change back previous current cell's color to default
			switch(direction) {
				case Direction.NORTH:
					//set previous current cell with correct color
					grdconMap[(y + 1), x].BackColor = color;
					break;
				case Direction.SOUTH:
					//set previous current cell with correct color
					grdconMap[(y - 1), x].BackColor = color;
					break;
				case Direction.EAST:
					//set previous current cell with correct color
					grdconMap[y, (x - 1)].BackColor = color;
					break;
				case Direction.WEST:
					//set previous current cell with correct color
					grdconMap[y, (x + 1)].BackColor = color;
					break;
				//default:
				//	break;
			}

		}

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region [ Methods ]
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		public void InitalPrompt()
		{
			lstDialog.Items.Add(string.Format("Hello, {0}, welcome to the game", name));
			lstDialog.Items.Add("Help Robbie get out of the house with all his treasures!");
			lstDialog.Items.Add("");
		}

		//-----------------------------------------------------------------------------------------------------
		public void PardonDust()
		{
			MessageBox.Show("Pardon our dust, we're still under construction.");
		}

		//-----------------------------------------------------------------------------------------------------
		public void CheckMovement(int currentX, int currentY)
		{
			//Check for Northern Movement
			if(currentY - 1 < map.MapSize && (map.GetCellType(currentX, currentY - 1) == CellType.Floor)) {
				btnMoveNorth.Enabled = true;
			}
			else {
				btnMoveNorth.Enabled = false;
			}

			//Check for Southern Movement
			if(currentY + 1 < map.MapSize && (map.GetCellType(currentX, currentY + 1) == CellType.Floor)) {
				btnMoveSouth.Enabled = true;
			}
			else {
				btnMoveSouth.Enabled = false;
			}

			//Check for Western Movement
			if(currentX - 1 < map.MapSize && (map.GetCellType(currentX - 1, currentY) == CellType.Floor)) {
				btnMoveWest.Enabled = true;
			}
			else {
				btnMoveWest.Enabled = false;
			}

			//Check for Eastern Movement
			if(currentX + 1 < map.MapSize && (map.GetCellType(currentX + 1, currentY) == CellType.Floor)) {
				btnMoveEast.Enabled = true;
			}
			else {
				btnMoveEast.Enabled = false;
			}
		}

		//-----------------------------------------------------------------------------------------------------
		public void OutputAroundPlayer(bool clear)
		{
			if(clear)
				lstOutput.Items.Clear();

			Surroundings(player.CurrentCellX, player.CurrentCellY, Direction.NORTH);
			Surroundings(player.CurrentCellX, player.CurrentCellY, Direction.SOUTH);
			Surroundings(player.CurrentCellX, player.CurrentCellY, Direction.WEST);
			Surroundings(player.CurrentCellX, player.CurrentCellY, Direction.EAST);
			//Place a blank line
			lstOutput.Items.Add("");

			//Select the last item in the list
			lstOutput.SelectedIndex = lstOutput.Items.Count - 1;

		}

		//-----------------------------------------------------------------------------------------------------
		public void Surroundings(int targetX, int targetY, Direction direction)
		{
			CellType cell = CellType.Generic;

			switch(direction) {
				case Direction.NORTH:
					//North is Y + 1
					if(targetY + 1 < map.MapSize) {
						cell = map.GetCellType(targetX, targetY + 1);
					}
					break;
				case Direction.SOUTH:
					//North is Y - 1
					if(targetY + 1 < map.MapSize) {
						cell = map.GetCellType(targetX, targetY - 1);
					}
					break;
				case Direction.EAST:
					//North is X + 1
					if(targetY + 1 < map.MapSize) {
						cell = map.GetCellType(targetX + 1, targetY);
					}
					break;
				case Direction.WEST:
					//North is X - 1
					if(targetY + 1 < map.MapSize) {
						cell = map.GetCellType(targetX - 1, targetY);
					}
					break;
			}
			//Add the the output to the listbox
			lstOutput.Items.Add
			(
			String.Format("There is a {0} {1} of you.", cell.ToString().ToLower(), direction.ToString().ToLower())
			);
		}

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region [ Action Buttons Click ]
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		private void btnAction1_Click(object sender, EventArgs e)
		{
			PardonDust();
		}

		//-----------------------------------------------------------------------------------------------------
		private void btnAction2_Click(object sender, EventArgs e)
		{
			PardonDust();
		}

		//-----------------------------------------------------------------------------------------------------
		private void btnAction3_Click(object sender, EventArgs e)
		{
			PardonDust();
		}

		//-----------------------------------------------------------------------------------------------------
		private void btnAction4_Click(object sender, EventArgs e)
		{
			PardonDust();
		}

		//-----------------------------------------------------------------------------------------------------
		private void btnAction5_Click(object sender, EventArgs e)
		{
			PardonDust();
		}

		//button used to open the map form
		//-----------------------------------------------------------------------------------------------------
		private void btnAction6_Click(object sender, EventArgs e)
		{
			PardonDust();

			
		}

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region [ Menu Buttons Click ]
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		private void btnLoadGame_Click(object sender, EventArgs e)
		{
			//to-do
			//Planned feature: Load a game from a save file
		}

		//-----------------------------------------------------------------------------------------------------
		private void btnSaveGame_Click(object sender, EventArgs e)
		{
			//to-do
			//Planned feature: Save a gamestate to file
		}

		//-----------------------------------------------------------------------------------------------------
		private void btnMainMenu_Click(object sender, EventArgs e)
		{
			//Load the menu form
			//FormMenu frm = new FormMenu();
			//frm.Show();

			//Close this form
			this.Close();
		}

		# endregion

		//-----------------------------------------------------------------------------------------------------
		#region [ Menu Buttons Hover ]
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		private void btnLoadGame_MouseHover(object sender, EventArgs e)
		{
			lblMenuHover.Text = "This feature is not yet implemented.";
		}

		//-----------------------------------------------------------------------------------------------------
		private void btnLoadGame_MouseLeave(object sender, EventArgs e)
		{
			lblMenuHover.Text = "";
		}

		//-----------------------------------------------------------------------------------------------------
		private void btnSaveGame_MouseHover(object sender, EventArgs e)
		{
			lblMenuHover.Text = "This feature is not yet implemented.";
		}

		//-----------------------------------------------------------------------------------------------------
		private void btnSaveGame_MouseLeave(object sender, EventArgs e)
		{
			lblMenuHover.Text = "";
		}

		//-----------------------------------------------------------------------------------------------------
		private void btnMainMenu_MouseHover(object sender, EventArgs e)
		{
			lblMenuHover.Text = "Return to Main Menu.";
		}

		//-----------------------------------------------------------------------------------------------------
		private void btnMainMenu_MouseLeave(object sender, EventArgs e)
		{
			lblMenuHover.Text = "";
		}

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

		#region [ Creation of Image Map]

		public void CreateTestMap()
		{
			//Get column and row count
			int maxX = grdconMap.ColCount;
			int maxY = grdconMap.RowCount;

			//Map cell type colors
			Color wallColor = Color.DarkGray;
			Color floorColor = Color.White;
			Color startingCellColor = Color.DarkGreen;
			Color doorColorLocked = Color.Red;
			Color doorColorUnlocked = Color.Blue;
			Color stairsUpColor = Color.Cyan;
			Color stairsDownColor = Color.Salmon;
			Color bejeweledKittenColor = Color.Purple;

			//Colorize map according to cell type
			//starting Cell
			grdconMap[2, 2].BackColor = startingCellColor;

			//Walls
			grdconMap[1, 1].BackColor = wallColor;
			grdconMap[1, 2].BackColor = wallColor;
			grdconMap[1, 3].BackColor = wallColor;
			grdconMap[1, 4].BackColor = wallColor;
			grdconMap[1, 5].BackColor = wallColor;
			grdconMap[2, 1].BackColor = wallColor;
			grdconMap[2, 5].BackColor = wallColor;
			grdconMap[3, 1].BackColor = wallColor;
			grdconMap[3, 3].BackColor = wallColor;
			grdconMap[3, 5].BackColor = wallColor;
			grdconMap[4, 1].BackColor = wallColor;
			grdconMap[4, 5].BackColor = wallColor;
			grdconMap[5, 1].BackColor = wallColor;
			grdconMap[5, 2].BackColor = wallColor;
			grdconMap[5, 3].BackColor = wallColor;
			grdconMap[5, 4].BackColor = wallColor;
			grdconMap[5, 5].BackColor = wallColor;

			//Floors
			grdconMap[2, 4].BackColor = floorColor;
			grdconMap[3, 2].BackColor = floorColor;
			grdconMap[3, 4].BackColor = floorColor;
			grdconMap[4, 2].BackColor = floorColor;
			grdconMap[4, 3].BackColor = floorColor;
			grdconMap[4, 4].BackColor = floorColor;

			//Doors
			grdconMap[3, 2].BackColor = doorColorLocked;

			//Loops that will fill all unused cell back
			for(int x = 1; x <= maxX; x++) {
				for(int y = 6; y <= maxY; y++) {
					grdconMap[x, y].BackColor = Color.Black;
				}

			}
			for(int x = 6; x <= maxX; x++) {
				for(int y = 1; y <= maxY; y++) {
					grdconMap[x, y].BackColor = Color.Black;
				}

			}
			//************************************************
		}

		#endregion
	}
}



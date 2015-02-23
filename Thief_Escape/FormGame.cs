
//User Interface file for group Phiv project
//Created by: Keegon Cabinaw
//Created on 02/15/2015
//Reformed/modified/refined by: Zachary T. Vig
//Date 02/18/2015
//Combined map and game ui forms

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
	public partial class FormGame : Form
	{
		#region [ Globals ]
		//-----------------------------------------------------------------------------------------------------

		//Declaration of Cell objects & Misc. vars
		Grid mapCells;
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
		//-----------------------------------------------------------------------------------------------------

		//Default constructor
		public FormGame()
		{
			// TODO: Complete member initialization
			InitializeComponent();
		}
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region [ LoadEvent ]
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		private void FormGamePlay_Load(object sender, EventArgs e)
		{
			//Instantiation of the grid object
			//mapCells = new Grid();
			//Passing in arg to make cutom map size
			mapCells = new Grid(16);

			//Call various mapCell creation methods here
			//method call that Creates the structure of the grid of cell object
			//mapCells.CreateTestGrid();
			//Creation of bigger test map
			mapCells.CreateTestGridBig();

			//make the image map grid
			//CreateTestMap();
			CreateTestMapBig();

			//Make the player
			//uncomment when the get of the player name is implimented
			//player = new Player(name);
			player = new Player();

			//Sets the first starting point by asking the grid for it's preset,
			//by array creation method
			player.SetCurrentCell(mapCells.WhatIsStartingCellX, mapCells.WhatIsStartingCellY);

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
			// X and Y is the moved to cell
			//prevcolor function returns the color that should be left in the moved from cell
			//Direction of button passed as arg
			MoveCurrentPos(
			player.CurrentCellX,
			player.CurrentCellY,
			WhatIsPrevCellColor(Direction.NORTH),
			Direction.NORTH);

			//Output surrounding cell types in text output
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

			//Change map image possition
			// X and Y is the moved to cell
			//prevcolor function returns the color that should be left in the moved from cell
			//Direction of button passed as arg
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

			//Change map image possition
			// X and Y is the moved to cell
			//prevcolor function returns the color that should be left in the moved from cell
			//Direction of button passed as arg
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

			//Change map image possition
			// X and Y is the moved to cell
			//prevcolor function returns the color that should be left in the moved from cell
			//Direction of button passed as arg
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
			//method scoped variables needed for the logic statements
			Color color = Color.Brown;
			CellType cell = CellType.Generic;
			DoorType door = DoorType.Generic;
			StairsType stairs = StairsType.Generic;
			bool IsStartingCell = false;
			bool isStairs = false;
			bool isBejeweledKitten = false;

			//Switch statement to find previous cell's type
			//first checks direction
			//Uses reverse of next cell math to pull previous cell properties
			//Then checks if it's a door, stairs, etc.
			//and gets it's respective type
			switch(direction) {


				case Direction.NORTH:
					//get previous cell's type
					cell = mapCells.GetCellType(player.CurrentCellX, (player.CurrentCellY + 1));
					//Check is previous cell is starting cell
					IsStartingCell = mapCells.IsStartingCell(player.CurrentCellX, (player.CurrentCellY + 1));

					//check if in fact door celltype and if so save door type
					if(cell == CellType.Door) {
						door = mapCells.GetDoorType(player.CurrentCellX, (player.CurrentCellY + 1));
					}
					//check if in fact stairs celltype and if so save stairs type
					else if(cell == CellType.Stairs) {
						stairs = mapCells.GetStairsType(player.CurrentCellX, (player.CurrentCellY + 1));
					}
					break;



				case Direction.SOUTH:
					//get previous cell's type
					cell = mapCells.GetCellType(player.CurrentCellX, (player.CurrentCellY - 1));
					//Check is previous cell is starting cell
					IsStartingCell = mapCells.IsStartingCell(player.CurrentCellX, (player.CurrentCellY - 1));

					//check if in fact door celltype and if so save door type
					if(cell == CellType.Door) {
						door = mapCells.GetDoorType(player.CurrentCellX, (player.CurrentCellY - 1));
					}
					//check if in fact stairs celltype and if so save stairs type
					else if(cell == CellType.Stairs) {
						stairs = mapCells.GetStairsType(player.CurrentCellX, (player.CurrentCellY - 1));
					}
					break;



				case Direction.EAST:
					//get previous cell's type
					cell = mapCells.GetCellType((player.CurrentCellX - 1), player.CurrentCellY);
					//Check is previous cell is starting cell
					IsStartingCell = mapCells.IsStartingCell((player.CurrentCellX - 1), player.CurrentCellY);

					//check if in fact door celltype and if so save door type
					if(cell == CellType.Door) {
						door = mapCells.GetDoorType((player.CurrentCellX - 1), player.CurrentCellY);
					}
					//check if in fact stairs celltype and if so save stairs type
					else if(cell == CellType.Stairs) {
						stairs = mapCells.GetStairsType((player.CurrentCellX - 1), player.CurrentCellY);
					}
					break;



				case Direction.WEST:
					//get previous cell's type
					cell = mapCells.GetCellType((player.CurrentCellX + 1), player.CurrentCellY);
					//Check if previous cell is starting cell
					IsStartingCell = mapCells.IsStartingCell((player.CurrentCellX + 1), player.CurrentCellY);

					//check if in fact door celltype and if so save door type
					if(cell == CellType.Door) {
						door = mapCells.GetDoorType((player.CurrentCellX + 1), player.CurrentCellY);
					}
					//check if in fact stairs celltype and if so save stairs type
					else if(cell == CellType.Stairs) {
						stairs = mapCells.GetStairsType((player.CurrentCellX + 1), player.CurrentCellY);
					}
					break;

				//default:
				//	break;
			}
			//-----------------------------------------------------------------------------------------------------

			//-----------------------------------------------------------------------------------------------------

			//Switch statement to select color based on previous cell type
			//Initial if-else statement to weed out the starting cell
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
		
			//returns the decided upon color for the previous cell	
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
		//starting dialog
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
			//Movement validation checks the bounds of the passed x and y
			//Checks if cell type is a floor or a DoorType.Unlocked
			//if not that button is disabled

			//Check for Northern Movement
			if(currentY - 1 < mapCells.MapSize
				&& (mapCells.GetCellType(currentX, currentY - 1)
				== (CellType.Floor))) {
				btnMoveNorth.Enabled = true;
			}
			else if(currentY - 1 < mapCells.MapSize
				&& (mapCells.GetDoorType(currentX, currentY - 1)
				== (DoorType.DoorUnlocked))) {
				btnMoveNorth.Enabled = true;
			}
			else {
				btnMoveNorth.Enabled = false;
			}

			//Check for Southern Movement
			if(currentY + 1 < mapCells.MapSize
				&& (mapCells.GetCellType(currentX, currentY + 1) 
				== CellType.Floor)) {
				btnMoveSouth.Enabled = true;
			}
			else if(currentY + 1 < mapCells.MapSize
				&& (mapCells.GetDoorType(currentX, currentY + 1)
				== DoorType.DoorUnlocked)) {
				btnMoveSouth.Enabled = true;
			}
			else {
				btnMoveSouth.Enabled = false;
			}

			//Check for Western Movement
			if(currentX - 1 < mapCells.MapSize 
				&& (mapCells.GetCellType(currentX - 1, currentY) 
				== CellType.Floor)) {
				btnMoveWest.Enabled = true;
			}
			else if(currentX - 1 < mapCells.MapSize
				&& (mapCells.GetDoorType(currentX - 1, currentY)
				== DoorType.DoorUnlocked)) {
				btnMoveWest.Enabled = true;
			}
			else {
				btnMoveWest.Enabled = false;
			}

			//Check for Eastern Movement
			if(currentX + 1 < mapCells.MapSize 
				&& (mapCells.GetCellType(currentX + 1, currentY) 
				== CellType.Floor)) {
				btnMoveEast.Enabled = true;
			}
			else if(currentX + 1 < mapCells.MapSize
				&& (mapCells.GetDoorType(currentX + 1, currentY)
				== DoorType.DoorUnlocked)) {
				btnMoveEast.Enabled = true;
			}
			else {
				btnMoveEast.Enabled = false;
			}
		}

		//-----------------------------------------------------------------------------------------------------

		//This method outputs the types of the 4 cells surrounding the current cell
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
		public void Surroundings(int currentX, int currentY, Direction direction)
		{
			CellType cell = CellType.Generic;

			switch(direction) {

				case Direction.NORTH:
					//North is Y - 1
					if(currentY - 1 < mapCells.MapSize) {
						cell = mapCells.GetCellType(currentX, currentY - 1);
					}
					break;


				case Direction.SOUTH:
					//North is Y + 1
					if(currentY + 1 < mapCells.MapSize) {
						cell = mapCells.GetCellType(currentX, currentY + 1);
					}
					break;


				case Direction.EAST:
					//North is X + 1
					if(currentY + 1 < mapCells.MapSize) {
						cell = mapCells.GetCellType(currentX + 1, currentY);
					}
					break;


				case Direction.WEST:
					//North is X - 1
					if(currentY - 1 < mapCells.MapSize) {
						cell = mapCells.GetCellType(currentX - 1, currentY);
					}
					break;

				//default:
				//	break;
			}

			//Add the output to the listbox
			lstOutput.Items.Add(String.Format("There is a {0} {1} of you.",
				cell.ToString().ToLower(), direction.ToString().ToLower()));
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

			//Loops that will fill all unused cells black
			//No longer required since default cell backcolor is black
			//Hold onto this, might need it later
			//for(int x = 1; x <= maxX; x++) {
			//	for(int y = 6; y <= maxY; y++) {
			//		grdconMap[y, x].BackColor = Color.Black;
			//	}

			//}

			//for(int x = 6; x <= maxX; x++) {
			//	for(int y = 1; y <= maxY; y++) {
			//		grdconMap[y, x].BackColor = Color.Black;
			//	}

			//}
			//************************************************
		}

		public void CreateTestMapBig()
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

			//starting Cell
			grdconMap[2, 2].BackColor = startingCellColor;

			#region walls
			//The four far sides of walls

			//top wall
			for(int i = 1; i < 17; i++) {
				grdconMap[1, i].BackColor = wallColor;
			}

			//bottom wall
			for(int i = 1; i < 17; i++) {
				grdconMap[16, i].BackColor = wallColor;
			}

			//Left wall
			for(int i = 1; i < 17; i++) {
				grdconMap[i, 1].BackColor = wallColor;
			}

			//right wall
			for(int i = 1; i < 17; i++) {
				grdconMap[i, 16].BackColor = wallColor;
			}

			//Rest of the walls
			grdconMap[4, 3].BackColor = wallColor;
			grdconMap[2, 4].BackColor = wallColor;
			grdconMap[3, 4].BackColor = wallColor;
			grdconMap[4, 4].BackColor = wallColor;
			grdconMap[4, 5].BackColor = wallColor;
			grdconMap[4, 6].BackColor = wallColor;
			grdconMap[2, 8].BackColor = wallColor;
			grdconMap[3, 8].BackColor = wallColor;
			grdconMap[4, 8].BackColor = wallColor;
			grdconMap[2, 9].BackColor = wallColor;
			grdconMap[3, 9].BackColor = wallColor;
			grdconMap[4, 9].BackColor = wallColor;
			grdconMap[3, 11].BackColor = wallColor;
			grdconMap[4, 11].BackColor = wallColor;
			grdconMap[2, 13].BackColor = wallColor;
			grdconMap[3, 13].BackColor = wallColor;
			grdconMap[4, 13].BackColor = wallColor;
			grdconMap[5, 8].BackColor = wallColor;
			grdconMap[5, 9].BackColor = wallColor;
			grdconMap[5, 11].BackColor = wallColor;
			for(int i = 2; i < 7; i++) {
				grdconMap[6, i].BackColor = wallColor;

			}
			grdconMap[6, 8].BackColor = wallColor;
			grdconMap[6, 9].BackColor = wallColor;
			grdconMap[6, 11].BackColor = wallColor;
			grdconMap[6, 13].BackColor = wallColor;
			grdconMap[7, 6].BackColor = wallColor;
			grdconMap[7, 8].BackColor = wallColor;
			grdconMap[7, 9].BackColor = wallColor;
			grdconMap[7, 10].BackColor = wallColor;
			grdconMap[7, 11].BackColor = wallColor;
			grdconMap[7, 13].BackColor = wallColor;
			grdconMap[7, 14].BackColor = wallColor;
			grdconMap[7, 15].BackColor = wallColor;
			grdconMap[8, 3].BackColor = wallColor;
			grdconMap[8, 4].BackColor = wallColor;
			grdconMap[8, 5].BackColor = wallColor;
			grdconMap[8, 6].BackColor = wallColor;
			grdconMap[8, 8].BackColor = wallColor;
			grdconMap[8, 11].BackColor = wallColor;
			grdconMap[9, 3].BackColor = wallColor;
			grdconMap[9, 4].BackColor = wallColor;
			grdconMap[9, 8].BackColor = wallColor;
			grdconMap[9, 11].BackColor = wallColor;
			grdconMap[10, 4].BackColor = wallColor;
			grdconMap[10, 8].BackColor = wallColor;
			grdconMap[10, 10].BackColor = wallColor;
			grdconMap[10, 11].BackColor = wallColor;
			grdconMap[10, 12].BackColor = wallColor;
			grdconMap[10, 13].BackColor = wallColor;
			grdconMap[10, 14].BackColor = wallColor;
			grdconMap[11, 8].BackColor = wallColor;
			grdconMap[12, 4].BackColor = wallColor;
			grdconMap[12, 5].BackColor = wallColor;
			grdconMap[12, 7].BackColor = wallColor;
			grdconMap[12, 8].BackColor = wallColor;
			grdconMap[12, 9].BackColor = wallColor;
			grdconMap[12, 10].BackColor = wallColor;
			grdconMap[12, 12].BackColor = wallColor;
			grdconMap[12, 13].BackColor = wallColor;
			grdconMap[13, 2].BackColor = wallColor;
			grdconMap[13, 3].BackColor = wallColor;
			grdconMap[13, 4].BackColor = wallColor;
			grdconMap[13, 5].BackColor = wallColor;
			grdconMap[13, 7].BackColor = wallColor;
			grdconMap[13, 8].BackColor = wallColor;
			grdconMap[13, 9].BackColor = wallColor;
			grdconMap[13, 10].BackColor = wallColor;
			grdconMap[13, 12].BackColor = wallColor;
			grdconMap[13, 13].BackColor = wallColor;
			grdconMap[13, 14].BackColor = wallColor;
			grdconMap[13, 15].BackColor = wallColor;
			grdconMap[14, 5].BackColor = wallColor;
			grdconMap[14, 12].BackColor = wallColor;

			#endregion

			#region doors
			//Doors
			grdconMap[4, 2].BackColor = doorColorUnlocked;
			grdconMap[2, 11].BackColor = doorColorUnlocked;
			grdconMap[10, 9].BackColor = doorColorUnlocked;
			grdconMap[10, 15].BackColor = doorColorUnlocked;
			grdconMap[11, 4].BackColor = doorColorUnlocked;
			grdconMap[4, 7].BackColor = doorColorLocked;
			grdconMap[5, 13].BackColor = doorColorLocked;
			grdconMap[9, 2].BackColor = doorColorLocked;
			grdconMap[15, 5].BackColor = doorColorLocked;
			grdconMap[15, 12].BackColor = doorColorLocked;

			#endregion

			#region Stairs
			grdconMap[14, 2].BackColor = stairsUpColor;
			grdconMap[14, 15].BackColor = stairsDownColor;

			#endregion

			#region floors
			//Floors
			grdconMap[2, 3].BackColor = floorColor;
			grdconMap[2, 5].BackColor = floorColor;
			grdconMap[2, 6].BackColor = floorColor;
			grdconMap[2, 7].BackColor = floorColor;
			grdconMap[2, 10].BackColor = floorColor;
			grdconMap[2, 12].BackColor = floorColor;
			grdconMap[2, 14].BackColor = floorColor;
			grdconMap[2, 15].BackColor = floorColor;
			grdconMap[3, 2].BackColor = floorColor;
			grdconMap[3, 3].BackColor = floorColor;
			grdconMap[3, 5].BackColor = floorColor;
			grdconMap[3, 6].BackColor = floorColor;
			grdconMap[3, 7].BackColor = floorColor;
			grdconMap[3, 10].BackColor = floorColor;
			grdconMap[3, 12].BackColor = floorColor;
			grdconMap[3, 14].BackColor = floorColor;
			grdconMap[3, 15].BackColor = floorColor;
			grdconMap[4, 10].BackColor = floorColor;
			grdconMap[4, 12].BackColor = floorColor;
			grdconMap[4, 14].BackColor = floorColor;
			grdconMap[4, 15].BackColor = floorColor;
			for(int i = 2; i < 8; i++) {
				grdconMap[5, i].BackColor = floorColor;
			}
			grdconMap[5, 10].BackColor = floorColor;
			grdconMap[5, 12].BackColor = floorColor;
			grdconMap[5, 14].BackColor = floorColor;
			grdconMap[5, 15].BackColor = floorColor;
			grdconMap[6, 7].BackColor = floorColor;
			grdconMap[6, 10].BackColor = floorColor;
			grdconMap[6, 12].BackColor = floorColor;
			grdconMap[6, 14].BackColor = floorColor;
			grdconMap[6, 15].BackColor = floorColor;
			grdconMap[7, 2].BackColor = floorColor;
			grdconMap[7, 3].BackColor = floorColor;
			grdconMap[7, 4].BackColor = floorColor;
			grdconMap[7, 5].BackColor = floorColor;
			grdconMap[7, 7].BackColor = floorColor;
			grdconMap[7, 12].BackColor = floorColor;
			grdconMap[8, 2].BackColor = floorColor;
			grdconMap[8, 3].BackColor = floorColor;
			grdconMap[8, 7].BackColor = floorColor;
			grdconMap[8, 9].BackColor = floorColor;
			grdconMap[8, 10].BackColor = floorColor;
			grdconMap[8, 12].BackColor = floorColor;
			grdconMap[8, 13].BackColor = floorColor;
			grdconMap[8, 14].BackColor = floorColor;
			grdconMap[8, 15].BackColor = floorColor;
			grdconMap[9, 5].BackColor = floorColor;
			grdconMap[9, 6].BackColor = floorColor;
			grdconMap[9, 7].BackColor = floorColor;
			grdconMap[9, 9].BackColor = floorColor;
			grdconMap[9, 10].BackColor = floorColor;
			grdconMap[9, 12].BackColor = floorColor;
			grdconMap[9, 13].BackColor = floorColor;
			grdconMap[9, 14].BackColor = floorColor;
			grdconMap[9, 15].BackColor = floorColor;
			grdconMap[10, 2].BackColor = floorColor;
			grdconMap[10, 3].BackColor = floorColor;
			grdconMap[10, 5].BackColor = floorColor;
			grdconMap[10, 6].BackColor = floorColor;
			grdconMap[10, 7].BackColor = floorColor;
			grdconMap[11, 2].BackColor = floorColor;
			grdconMap[11, 3].BackColor = floorColor;
			grdconMap[11, 5].BackColor = floorColor;
			grdconMap[11, 6].BackColor = floorColor;
			grdconMap[11, 7].BackColor = floorColor;
			for (int i = 9; i < 16; i++)
			{
			 grdconMap[11, i].BackColor = floorColor;
			}
			grdconMap[12, 2].BackColor = floorColor;
			grdconMap[12, 3].BackColor = floorColor;
			grdconMap[12, 6].BackColor = floorColor;
			grdconMap[12, 11].BackColor = floorColor;
			grdconMap[12, 14].BackColor = floorColor;
			grdconMap[12, 15].BackColor = floorColor;
			grdconMap[13, 6].BackColor = floorColor;
			grdconMap[13, 11].BackColor = floorColor;
			grdconMap[14, 3].BackColor = floorColor;
			grdconMap[14, 4].BackColor = floorColor;
			for (int i = 6; i < 12; i++)
			{
			 grdconMap[14, i].BackColor = floorColor;
			}
			grdconMap[14, 13].BackColor = floorColor;
			grdconMap[14, 14].BackColor = floorColor;
			grdconMap[15, 2].BackColor = floorColor;
			grdconMap[15, 3].BackColor = floorColor;
			grdconMap[15, 4].BackColor = floorColor;
			for (int i = 6; i < 12; i++)
			{
			 grdconMap[15, i].BackColor = floorColor;
			}
			grdconMap[15, 13].BackColor = floorColor;
			grdconMap[15, 14].BackColor = floorColor;
			grdconMap[15, 15].BackColor = floorColor;

			#endregion
		}

		#endregion
	}
}



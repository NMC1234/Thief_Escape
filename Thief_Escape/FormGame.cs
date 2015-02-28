
//User Interface file for group Phiv project
//Created by: Keegon Cabinaw
//Created on 02/15/2015
//Reformed/modified/refined by: Zachary T. Vig
//Date 02/18/2015
//Combined map and game ui forms
//Updated: 02/27/2015

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
	public partial class FormGame : Form
	{
		#region [ Globals ]
		//Declaration of Cell objects & Misc. vars
		Grid mapCells;
		Player player;
		string name;
		int counter;

		#endregion
		

		#region [ Constructors ]

		// Overloaded FormGame constructor to pass in name from name form
		public FormGame(string playername)
		{
			InitializeComponent( );

			//Change the player name
			name = playername;
		}

		//Default constructor
		//-----------------------------------------------------------------------------------------------------
		public FormGame( )
		{
			// TODO: Complete member initialization
			InitializeComponent( );
		}
		#endregion
		

		#region [ LoadEvent ]
		private void FormGamePlay_Load(object sender, EventArgs e)
		{
			//Instantiation of the grid object
			//mapCells = new Grid();
			mapCells = new Grid(16);

			//Call various mapCell creation methods here
			//method call that Creates the structure of the grid of cell object
			mapCells.CreateTestGridBig( );

			//make the image map grid
			CreateTestMapBig( );

			//Make the player
			player = new Player(name);
			//player = new Player( );

			//Sets the first starting point by asking the grid for it's preset,
			//by array creation method
			player.SetCurrentCell(mapCells.WhatIsStartingCellX, mapCells.WhatIsStartingCellY);

			//Get the initial valid movements
			CheckMovement(player.CurrentCellX, player.CurrentCellY);

			//Initial Fog of war
			FogOfWar(Direction.GENERIC);

			//Output initial prompt
			InitalPrompt( );

			//Output information about surrounding tiles
			OutputAroundPlayer(false);
		}

		#endregion
		

		#region [ Movement Validation/Output/ImageMapupdate ]
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region Movement buttons
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		private void btnMoveNorth_Click(object sender, EventArgs e)
		{
			//disable current cell blink till movement to new cell in completed
			tmrCellBlink.Enabled = false;

			//Move the player north, (y axis - 1 )
			player.SetCurrentCell(
			player.CurrentCellX,
			(player.CurrentCellY - 1)
			);

			//Remake Fog of war on movement
			FogOfWar(Direction.NORTH);

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

			//Re-enable current cell blinking once moved to new cell
			tmrCellBlink.Enabled = true;

			//Output surrounding cell types in text output
			OutputAroundPlayer(true);
		}

		//-----------------------------------------------------------------------------------------------------
		private void btnMoveWest_Click(object sender, EventArgs e)
		{
			//disable current cell blink till movement to new cell in completed
			tmrCellBlink.Enabled = false;

			//Move the player west, (x axis - 1)
			player.SetCurrentCell(
			(player.CurrentCellX - 1),
			player.CurrentCellY
			);

			//Remake Fog of war on movement
			FogOfWar(Direction.WEST);

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

			//Re-enable current cell blinking once moved to new cell
			tmrCellBlink.Enabled = true;

			//Output surrounding cells
			OutputAroundPlayer(true);
		}

		//-----------------------------------------------------------------------------------------------------
		private void btnMoveEast_Click(object sender, EventArgs e)
		{
			//disable current cell blink till movement to new cell in completed
			tmrCellBlink.Enabled = false;

			//Move the player east, (x axis + 1)
			player.SetCurrentCell(
			(player.CurrentCellX + 1),
			player.CurrentCellY
			);

			//Remake Fog of war on movement
			FogOfWar(Direction.EAST);

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

			//Re-enable current cell blinking once moved to new cell
			tmrCellBlink.Enabled = true;

			//Output surrounding cells
			OutputAroundPlayer(true);
		}

		//-----------------------------------------------------------------------------------------------------
		private void btnMoveSouth_Click(object sender, EventArgs e)
		{
			//disable current cell blink till movement to new cell in completed
			tmrCellBlink.Enabled = false;

			//Move the player south, (y axis + 1 )
			player.SetCurrentCell(
			player.CurrentCellX,
			(player.CurrentCellY + 1)
			);

			//Remake Fog of war on movement
			FogOfWar(Direction.SOUTH);

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

			//Re-enable current cell blinking once moved to new cell
			tmrCellBlink.Enabled = true;

			//Output surrounding cells
			OutputAroundPlayer(true);
		}

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------


		//This method outputs the types of the 4 cells surrounding the current cell
		//-----------------------------------------------------------------------------------------------------
		public void CheckMovement(int currentX, int currentY)
		{
			//Movement validation checks the bounds of the passed x and y
			//Checks if cell type is a floor or a DoorType.Unlocked
			//if not that button is disabled

			#region [Check for Northern Movement]

			if(currentY - 1 < mapCells.MapSize
			&& (mapCells.GetCellType(currentX, currentY - 1)
			== (CellType.FLOOR)))
			{
				btnMoveNorth.Enabled = true;
			}
			else if(currentY - 1 < mapCells.MapSize
			&& (mapCells.GetDoorType(currentX, currentY - 1)
			== (DoorType.DOORUNLOCKED)))
			{
				btnMoveNorth.Enabled = true;
			}
			else if(currentY - 1 < mapCells.MapSize
			&& (mapCells.GetCellType(currentX, currentY - 1)
			== (CellType.BEJEWELEDKITTEN)))
			{
				btnMoveNorth.Enabled = true;
			}
			else if(currentY - 1 < mapCells.MapSize
			&& (mapCells.GetCellType(currentX, currentY - 1)
			== (CellType.STAIRS)))
			{
				btnMoveNorth.Enabled = true;
			}
			else if(currentY - 1 < mapCells.MapSize
			&& (mapCells.GetCellType(currentX, currentY - 1)
			== (CellType.KEY)))
			{
				btnMoveNorth.Enabled = true;
			}
			else
			{
				btnMoveNorth.Enabled = false;
			}
			#endregion

			#region [Check for Southern Movement]
			if(currentY + 1 < mapCells.MapSize
			&& (mapCells.GetCellType(currentX, currentY + 1)
			== CellType.FLOOR))
			{
				btnMoveSouth.Enabled = true;
			}
			else if(currentY + 1 < mapCells.MapSize
			&& (mapCells.GetDoorType(currentX, currentY + 1)
			== DoorType.DOORUNLOCKED))
			{
				btnMoveSouth.Enabled = true;
			}
			else if(currentY + 1 < mapCells.MapSize
			&& (mapCells.GetCellType(currentX, currentY + 1)
			== (CellType.BEJEWELEDKITTEN)))
			{
				btnMoveNorth.Enabled = true;
			}
			else if(currentY + 1 < mapCells.MapSize
			&& (mapCells.GetCellType(currentX, currentY + 1)
			== (CellType.STAIRS)))
			{
				btnMoveNorth.Enabled = true;
			}
			else if(currentY + 1 < mapCells.MapSize
			&& (mapCells.GetCellType(currentX, currentY + 1)
			== (CellType.KEY)))
			{
				btnMoveNorth.Enabled = true;
			}
			else
			{
				btnMoveSouth.Enabled = false;
			}
			#endregion

			#region [Check for Western Movement]
			if(currentX - 1 < mapCells.MapSize
			&& (mapCells.GetCellType(currentX - 1, currentY)
			== CellType.FLOOR))
			{
				btnMoveWest.Enabled = true;
			}
			else if(currentX - 1 < mapCells.MapSize
			&& (mapCells.GetDoorType(currentX - 1, currentY)
			== DoorType.DOORUNLOCKED))
			{
				btnMoveWest.Enabled = true;
			}
			else if(currentX - 1 < mapCells.MapSize
			&& (mapCells.GetCellType(currentX - 1, currentY)
			== CellType.BEJEWELEDKITTEN))
			{
				btnMoveWest.Enabled = true;
			}
			else if(currentX - 1 < mapCells.MapSize
			&& (mapCells.GetCellType(currentX - 1, currentY)
			== CellType.STAIRS))
			{
				btnMoveWest.Enabled = true;
			}
			else if(currentX - 1 < mapCells.MapSize
			&& (mapCells.GetCellType(currentX - 1, currentY)
			== CellType.KEY))
			{
				btnMoveWest.Enabled = true;
			}
			else
			{
				btnMoveWest.Enabled = false;
			}
			#endregion

			#region [Check for Eastern Movement]

			if(currentX + 1 < mapCells.MapSize
			&& (mapCells.GetCellType(currentX + 1, currentY)
			== CellType.FLOOR))
			{
				btnMoveEast.Enabled = true;
			}
			else if(currentX + 1 < mapCells.MapSize
			&& (mapCells.GetDoorType(currentX + 1, currentY)
			== DoorType.DOORUNLOCKED))
			{
				btnMoveEast.Enabled = true;
			}
			else if(currentX + 1 < mapCells.MapSize
			&& (mapCells.GetCellType(currentX + 1, currentY)
			== CellType.BEJEWELEDKITTEN))
			{
				btnMoveWest.Enabled = true;
			}
			else if(currentX + 1 < mapCells.MapSize
			&& (mapCells.GetCellType(currentX + 1, currentY)
			== CellType.STAIRS))
			{
				btnMoveWest.Enabled = true;
			}
			else if(currentX + 1 < mapCells.MapSize
			&& (mapCells.GetCellType(currentX + 1, currentY)
			== CellType.KEY))
			{
				btnMoveWest.Enabled = true;
			}
			else
			{
				btnMoveEast.Enabled = false;
			}

			#endregion

		}

		//-----------------------------------------------------------------------------------------------------
		public void OutputAroundPlayer(bool clear)
		{
			if(clear)
				lstOutput.Items.Clear( );

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
		#region [ Change Visual Map Cell Functions ]
		//-----------------------------------------------------------------------------------------------------
		//Returns the moved from cell's map color.
		//-----------------------------------------------------------------------------------------------------
		private Color WhatIsPrevCellColor(Direction direction)
		{
			//method scoped variables needed for the logic statements
			Color color = Color.Brown;
			CellType cell = CellType.GENERIC;
			DoorType door = DoorType.GENERIC;
			StairsType stairs = StairsType.GENERIC;
			bool IsStartingCell = false;
			bool isStairs = false;
			bool isBejeweledKitten = false;

			//Switch statement to find previous cell's type
			//first checks direction
			//Uses reverse of next cell math to pull previous cell properties
			//Then checks if it's a door, stairs, etc.
			//and gets it's respective type
			switch(direction)
			{

				case Direction.NORTH:
					//get previous cell's type
					cell = mapCells.GetCellType(player.CurrentCellX, (player.CurrentCellY + 1));
					//Check is previous cell is starting cell
					IsStartingCell = mapCells.IsStartingCell(player.CurrentCellX, (player.CurrentCellY + 1));

					//check if in fact door celltype and if so save door type
					if(cell == CellType.DOOR)
					{
						door = mapCells.GetDoorType(player.CurrentCellX, (player.CurrentCellY + 1));
					}
					//check if in fact stairs celltype and if so save stairs type
					else if(cell == CellType.STAIRS)
					{
						stairs = mapCells.GetStairsType(player.CurrentCellX, (player.CurrentCellY + 1));
					}
					break;

				case Direction.SOUTH:
					//get previous cell's type
					cell = mapCells.GetCellType(player.CurrentCellX, (player.CurrentCellY - 1));
					//Check is previous cell is starting cell
					IsStartingCell = mapCells.IsStartingCell(player.CurrentCellX, (player.CurrentCellY - 1));

					//check if in fact door celltype and if so save door type
					if(cell == CellType.DOOR)
					{
						door = mapCells.GetDoorType(player.CurrentCellX, (player.CurrentCellY - 1));
					}
					//check if in fact stairs celltype and if so save stairs type
					else if(cell == CellType.STAIRS)
					{
						stairs = mapCells.GetStairsType(player.CurrentCellX, (player.CurrentCellY - 1));
					}
					break;

				case Direction.EAST:
					//get previous cell's type
					cell = mapCells.GetCellType((player.CurrentCellX - 1), player.CurrentCellY);
					//Check is previous cell is starting cell
					IsStartingCell = mapCells.IsStartingCell((player.CurrentCellX - 1), player.CurrentCellY);

					//check if in fact door celltype and if so save door type
					if(cell == CellType.DOOR)
					{
						door = mapCells.GetDoorType((player.CurrentCellX - 1), player.CurrentCellY);
					}
					//check if in fact stairs celltype and if so save stairs type
					else if(cell == CellType.STAIRS)
					{
						stairs = mapCells.GetStairsType((player.CurrentCellX - 1), player.CurrentCellY);
					}
					break;

				case Direction.WEST:
					//get previous cell's type
					cell = mapCells.GetCellType((player.CurrentCellX + 1), player.CurrentCellY);
					//Check if previous cell is starting cell
					IsStartingCell = mapCells.IsStartingCell((player.CurrentCellX + 1), player.CurrentCellY);

					//check if in fact door celltype and if so save door type
					if(cell == CellType.DOOR)
					{
						door = mapCells.GetDoorType((player.CurrentCellX + 1), player.CurrentCellY);
					}
					//check if in fact stairs celltype and if so save stairs type
					else if(cell == CellType.STAIRS)
					{
						stairs = mapCells.GetStairsType((player.CurrentCellX + 1), player.CurrentCellY);
					}
					break;

				//default:
				//	break;
			}

			//Switch statement to select color based on previous cell type
			//Initial if-else statement to weed out the starting cell
			//Will need to be expanded to handle other floor and wall types.
			if(IsStartingCell)
			{
				color = Color.DarkGreen;
			}
			else
			{
				switch(cell)
				{

					case CellType.FLOOR:
						color = Color.White;
						break;

					//No longer needed since wall is now an image
					//case CellType.WALL:
					//	color = Color.DarkGray;
					//	break;

					case CellType.DOOR:
						if(door == DoorType.DOORUNLOCKED)
							color = Color.Blue;
						else if(door == DoorType.DOORLOCKED)
							color = Color.Red;
						break;

					case CellType.STAIRS:
						isStairs = true;
						if(stairs == StairsType.STAIRSUP)
							color = Color.Cyan;
						else if(stairs == StairsType.STAIRSDOWN)
							color = Color.Salmon;
						break;

					case CellType.BEJEWELEDKITTEN:
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

		//-----------------------------------------------------------------------------------------------------
		public void MoveCurrentPos(int x, int y, Color color, Direction direction)
		{
			//change cordinates from start point 0 to start point 1
			x++;
			y++;

			//Change color of Current Cell to orange, [Y, X] !!!! Y must be first
			grdconMap[y, x].BackColor = Color.Orange;

			//Switch statement to change back previous current cell's color to default
			switch(direction)
			{

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
		public void FogOfWar(Direction direction)
		{
			//Image to apply to cells outside fog of war
			Image blackoutImage = Image.FromFile("CellBlackoutImage.png");
			Image wallImage = Image.FromFile("CellWallImage.png");


			//Version 1 of Fog of War
			////loop to blackout all cells before a portion is removed by remove blackout
			//for(int x = 1; x < (mapCells.MapSize + 1); x++)
			//{
			//	for(int y = 1; y < (mapCells.MapSize + 1); y++)
			//	{
			//		grdconMap[y, x].BackgroundImage = blackoutImage;
			//	}

			//}


			//Version 2 of Fog of War
			//For loops backout all surrounding cells outside of viewable area
			for(int x = 1; x < (player.CurrentCellX - 1); x++)
			{
				for(int y = 1; y < (player.CurrentCellY - 1); y++)
				{
					grdconMap[y, x].BackgroundImage = blackoutImage;
				}
				
			}

			for(int x = (player.CurrentCellX + 4); x < (mapCells.MapSize + 1); x++)
			{
				for(int y = 1; y < (mapCells.MapSize + 1); y++)
				{
					grdconMap[y, x].BackgroundImage = blackoutImage;
				}
			}

			for(int x = 1; x < (mapCells.MapSize + 1); x++)
			{
				for(int y = (player.CurrentCellY + 4); y < (mapCells.MapSize + 1); y++)
				{
					grdconMap[y, x].BackgroundImage = blackoutImage;
				}
			}

			for(int x = 1; x < (player.CurrentCellX - 1); x++)
			{
				for(int y = (player.CurrentCellY - 1); y < (mapCells.MapSize + 1); y++)
				{
					grdconMap[y, x].BackgroundImage = blackoutImage;
				}
			}

			for(int x = 1; x < (player.CurrentCellX + 4); x++)
			{
				for(int y = 1; y < (player.CurrentCellY - 1); y++)
				{
					grdconMap[y, x].BackgroundImage = blackoutImage;
				}
			}

			////loops to create a ring of transparency cells on outerborder of visual range
			////horizontal lines
			////Image blackout60Image = Image.FromFile("Cell60prcBlackout.png");


			//for(int x = (player.CurrentCellX - 2); x < (player.CurrentCellX + 6); x++)
			//{
			//	int y;
			//	y = (player.CurrentCellY - 2);
			//	grdconMap[y, x].BackgroundImage = blackout60Image;
			//}

			//for(int x = (player.CurrentCellX - 2); x < (player.CurrentCellX + 6); x++)
			//{
			//	int y;
			//	y = (player.CurrentCellY + 5);
			//	grdconMap[y, x].BackgroundImage = blackout60Image;
			//}

			////Vertical line
			//for(int y = (player.CurrentCellY - 2); y < (player.CurrentCellY + 5); y++)
			//{
			//	int x;
			//	x = (player.CurrentCellX - 2);
			//	grdconMap[y, x].BackgroundImage = blackout60Image;
			//}

			//for(int y = (player.CurrentCellY - 2); y < (player.CurrentCellY + 5); y++)
			//{
			//	int x;
			//	x = (player.CurrentCellX + 5);
			//	grdconMap[y, x].BackgroundImage = blackout60Image;
			//}


			//Removes blackout for cells player can see

			//pair of loops that will remove blackout for viewable area
			for(int x = (player.CurrentCellX - 1); x < (player.CurrentCellX + 4); x++)
			{

				for(int y = (player.CurrentCellY - 1); y < (player.CurrentCellY + 4); y++)
				{
					//removes the background image for that cell
					grdconMap[y, x].ResetBackgroundImage( );

					//checks if current cell is out of range of the cell object array
					if((((x - 1) >= 0) && ((y - 1) >= 0))
						& ((x <= mapCells.MapSize) && (y <= mapCells.MapSize)))
					{
						//if statement to check if the current cell is a wall
						//if so then it assigns that cell the wall background image
						if(mapCells.GetCellType((x - 1), (y - 1)) == CellType.WALL)
						{
							grdconMap[y, x].BackgroundImage = wallImage;
						}
					}
				}
			}

		}

		//-----------------------------------------------------------------------------------------------------
		#region [ Blink Current Cell]
	
		//The tick event function for the tmrCellBlink timer
		private void tmrCellBlink_Tick(object sender, EventArgs e)
		{
			//for each tick count gets increased
			//current cell is changed to a different color depending on
			//if counter is even or odd
			counter++;

			if((counter % 2) != 0)
			{
				BlinkCurrentCellBack( );
			}
			if((counter % 2) == 0)
			{
				BlinkCurrentCell( );

			}
		}

		//When counter is odd this method is called
		//-----------------------------------------------------------------------------------------------------
		public void BlinkCurrentCell( )
		{

			grdconMap[(player.CurrentCellY + 1), (player.CurrentCellX + 1)].BackColor = Color.DimGray;

		}

		//when counter is even this method is called
		public void BlinkCurrentCellBack( )
		{

			grdconMap[(player.CurrentCellY + 1), (player.CurrentCellX + 1)].BackColor = Color.Orange;

		}

		#endregion
	
		#endregion

		#endregion
		

		#region [ Methods ]
		//starting dialog
		public void InitalPrompt( )
		{
			lstDialog.Items.Add(string.Format("Hello, {0}, welcome to the game", name));
			lstDialog.Items.Add("Help Robbie get out of the house with all his treasures!");
			lstDialog.Items.Add("");
		}

		public void PardonDust( )
		{
			MessageBox.Show("Pardon our dust, we're still under construction.");
		}

		//this method outputs the types of walls surrounding the player to the textbox
		//MIGHT WANT TO REMOVE
		//NOT REALLY NEEDED WITH THE MAP
		//-----------------------------------------------------------------------------------------------------
		public void Surroundings(int currentX, int currentY, Direction direction)
		{
			CellType cell = CellType.GENERIC;

			switch(direction)
			{

				case Direction.NORTH:
					//North is Y - 1
					if(currentY - 1 < mapCells.MapSize)
					{
						cell = mapCells.GetCellType(currentX, currentY - 1);
					}
					break;

				case Direction.SOUTH:
					//North is Y + 1
					if(currentY + 1 < mapCells.MapSize)
					{
						cell = mapCells.GetCellType(currentX, currentY + 1);
					}
					break;

				case Direction.EAST:
					//North is X + 1
					if(currentY + 1 < mapCells.MapSize)
					{
						cell = mapCells.GetCellType(currentX + 1, currentY);
					}
					break;

				case Direction.WEST:
					//North is X - 1
					if(currentY - 1 < mapCells.MapSize)
					{
						cell = mapCells.GetCellType(currentX - 1, currentY);
					}
					break;

				//default:
				//	break;
			}

			//Add the output to the listbox
			lstOutput.Items.Add(String.Format("There is a {0} {1} of you.",
			cell.ToString( ).ToLower( ), direction.ToString( ).ToLower( )));
		}

		#endregion
		

		#region [ Action Buttons Click ]
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		private void btnAction1_Click(object sender, EventArgs e)
		{
			PardonDust( );
		}

		private void btnAction2_Click(object sender, EventArgs e)
		{
			PardonDust( );
		}

		private void btnAction3_Click(object sender, EventArgs e)
		{
			PardonDust( );
		}

		private void btnAction4_Click(object sender, EventArgs e)
		{
			PardonDust( );
		}

		private void btnAction5_Click(object sender, EventArgs e)
		{
			PardonDust( );
		}

		//button used to open the map form
		//-----------------------------------------------------------------------------------------------------
		private void btnAction6_Click(object sender, EventArgs e)
		{
			PardonDust( );
		}

		#endregion
		

		#region [ Menu Buttons Click ]
		private void btnLoadGame_Click(object sender, EventArgs e)
		{
			//to-do
			//Planned feature: Load a game from a save file
		}

		private void btnSaveGame_Click(object sender, EventArgs e)
		{
			//to-do
			//Planned feature: Save a gamestate to file
		}

		private void btnMainMenu_Click(object sender, EventArgs e)
		{
			//Load the menu form
			//FormMenu frm = new FormMenu();
			//frm.Show();

			//Close this form
			this.Close( );
		}

		# endregion
		

		#region [ Menu Buttons Hover ]
		private void btnLoadGame_MouseHover(object sender, EventArgs e)
		{
			lblMenuHover.Text = "This feature is not yet implemented.";
		}

		private void btnLoadGame_MouseLeave(object sender, EventArgs e)
		{
			lblMenuHover.Text = "";
		}

		private void btnSaveGame_MouseHover(object sender, EventArgs e)
		{
			lblMenuHover.Text = "This feature is not yet implemented.";
		}

		private void btnSaveGame_MouseLeave(object sender, EventArgs e)
		{
			lblMenuHover.Text = "";
		}

		private void btnMainMenu_MouseHover(object sender, EventArgs e)
		{
			lblMenuHover.Text = "Return to Main Menu.";
		}

		private void btnMainMenu_MouseLeave(object sender, EventArgs e)
		{
			lblMenuHover.Text = "";
		}

		#endregion
		

		#region [ Creation of Image Map]
		public void CreateTestMapBig( )
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

			//MAY NOT NEED TO ASSIGN WALLS AN IMAGE HERE
			//DONE BY REMOVE BLACKOUT LOOP FOR FOG OF WAR
			//#region walls
			////-----------------------------------------------------------------------------------------------------

			////Image for walls
			//Image wallImage = Image.FromFile("CellWallImage.png");

			////The four far sides of walls

			////top wall
			//for(int i = 1; i < 17; i++) {
			//	grdconMap[1, i].BackgroundImage = wallImage;
			//}

			////bottom wall
			//for(int i = 1; i < 17; i++) {
			//	grdconMap[16, i].BackgroundImage = wallImage;
			//}

			////Left wall
			//for(int i = 1; i < 17; i++) {
			//	grdconMap[i, 1].BackgroundImage = wallImage;
			//}

			////right wall
			//for(int i = 1; i < 17; i++) {
			//	grdconMap[i, 16].BackgroundImage = wallImage;
			//}

			////Rest of the walls
			//grdconMap[4, 3].BackgroundImage = wallImage;

			//grdconMap[2, 4].BackgroundImage = wallImage;
			//grdconMap[3, 4].BackgroundImage = wallImage;
			//grdconMap[4, 4].BackgroundImage = wallImage;
			//grdconMap[4, 5].BackgroundImage = wallImage;
			//grdconMap[4, 6].BackgroundImage = wallImage;
			//grdconMap[2, 8].BackgroundImage = wallImage;
			//grdconMap[3, 8].BackgroundImage = wallImage;
			//grdconMap[4, 8].BackgroundImage = wallImage;
			//grdconMap[2, 9].BackgroundImage = wallImage;
			//grdconMap[3, 9].BackgroundImage = wallImage;
			//grdconMap[4, 9].BackgroundImage = wallImage;
			//grdconMap[3, 11].BackgroundImage = wallImage;
			//grdconMap[4, 11].BackgroundImage = wallImage;
			//grdconMap[2, 13].BackgroundImage = wallImage;
			//grdconMap[3, 13].BackgroundImage = wallImage;
			//grdconMap[4, 13].BackgroundImage = wallImage;
			//grdconMap[5, 8].BackgroundImage = wallImage;
			//grdconMap[5, 9].BackgroundImage = wallImage;
			//grdconMap[5, 11].BackgroundImage = wallImage;
			//for(int i = 2; i < 7; i++) {
			//	grdconMap[6, i].BackgroundImage = wallImage;

			//}
			//grdconMap[6, 8].BackgroundImage = wallImage;
			//grdconMap[6, 9].BackgroundImage = wallImage;
			//grdconMap[6, 11].BackgroundImage = wallImage;
			//grdconMap[6, 13].BackgroundImage = wallImage;
			//grdconMap[7, 6].BackgroundImage = wallImage;
			//grdconMap[7, 8].BackgroundImage = wallImage;
			//grdconMap[7, 9].BackgroundImage = wallImage;
			//grdconMap[7, 10].BackgroundImage = wallImage;
			//grdconMap[7, 11].BackgroundImage = wallImage;
			//grdconMap[7, 13].BackgroundImage = wallImage;
			//grdconMap[7, 14].BackgroundImage = wallImage;
			//grdconMap[7, 15].BackgroundImage = wallImage;
			//grdconMap[8, 3].BackgroundImage = wallImage;
			//grdconMap[8, 4].BackgroundImage = wallImage;
			//grdconMap[8, 5].BackgroundImage = wallImage;
			//grdconMap[8, 6].BackgroundImage = wallImage;
			//grdconMap[8, 8].BackgroundImage = wallImage;
			//grdconMap[8, 11].BackgroundImage = wallImage;
			//grdconMap[9, 3].BackgroundImage = wallImage;
			//grdconMap[9, 4].BackgroundImage = wallImage;
			//grdconMap[9, 8].BackgroundImage = wallImage;
			//grdconMap[9, 11].BackgroundImage = wallImage;
			//grdconMap[10, 4].BackgroundImage = wallImage;
			//grdconMap[10, 8].BackgroundImage = wallImage;
			//grdconMap[10, 10].BackgroundImage = wallImage;
			//grdconMap[10, 11].BackgroundImage = wallImage;
			//grdconMap[10, 12].BackgroundImage = wallImage;
			//grdconMap[10, 13].BackgroundImage = wallImage;
			//grdconMap[10, 14].BackgroundImage = wallImage;
			//grdconMap[11, 8].BackgroundImage = wallImage;
			//grdconMap[12, 4].BackgroundImage = wallImage;
			//grdconMap[12, 5].BackgroundImage = wallImage;
			//grdconMap[12, 7].BackgroundImage = wallImage;
			//grdconMap[12, 8].BackgroundImage = wallImage;
			//grdconMap[12, 9].BackgroundImage = wallImage;
			//grdconMap[12, 10].BackgroundImage = wallImage;
			//grdconMap[12, 12].BackgroundImage = wallImage;
			//grdconMap[12, 13].BackgroundImage = wallImage;
			//grdconMap[13, 2].BackgroundImage = wallImage;
			//grdconMap[13, 3].BackgroundImage = wallImage;
			//grdconMap[13, 4].BackgroundImage = wallImage;
			//grdconMap[13, 5].BackgroundImage = wallImage;
			//grdconMap[13, 7].BackgroundImage = wallImage;
			//grdconMap[13, 8].BackgroundImage = wallImage;
			//grdconMap[13, 9].BackgroundImage = wallImage;
			//grdconMap[13, 10].BackgroundImage = wallImage;
			//grdconMap[13, 12].BackgroundImage = wallImage;
			//grdconMap[13, 13].BackgroundImage = wallImage;
			//grdconMap[13, 14].BackgroundImage = wallImage;
			//grdconMap[13, 15].BackgroundImage = wallImage;
			//grdconMap[14, 5].BackgroundImage = wallImage;
			//grdconMap[14, 12].BackgroundImage = wallImage;

			////-----------------------------------------------------------------------------------------------------
			//#endregion

			//-----------------------------------------------------------------------------------------------------
			#region doors
			//-----------------------------------------------------------------------------------------------------
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

			//-----------------------------------------------------------------------------------------------------
			#endregion
			//-----------------------------------------------------------------------------------------------------

			//-----------------------------------------------------------------------------------------------------
			#region STAIRS
			//-----------------------------------------------------------------------------------------------------
			grdconMap[14, 2].BackColor = stairsUpColor;
			grdconMap[14, 15].BackColor = stairsDownColor;

			//-----------------------------------------------------------------------------------------------------
			#endregion
			//-----------------------------------------------------------------------------------------------------

			//-----------------------------------------------------------------------------------------------------
			#region floors
			//-----------------------------------------------------------------------------------------------------
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
			for(int i = 2; i < 8; i++)
			{
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
			for(int i = 9; i < 16; i++)
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
			for(int i = 6; i < 12; i++)
			{
				grdconMap[14, i].BackColor = floorColor;
			}
			grdconMap[14, 13].BackColor = floorColor;
			grdconMap[14, 14].BackColor = floorColor;
			grdconMap[15, 2].BackColor = floorColor;
			grdconMap[15, 3].BackColor = floorColor;
			grdconMap[15, 4].BackColor = floorColor;
			for(int i = 6; i < 12; i++)
			{
				grdconMap[15, i].BackColor = floorColor;
			}
			grdconMap[15, 13].BackColor = floorColor;
			grdconMap[15, 14].BackColor = floorColor;
			grdconMap[15, 15].BackColor = floorColor;

			//-----------------------------------------------------------------------------------------------------
			#endregion
			//-----------------------------------------------------------------------------------------------------
		}

		#endregion
		

	}
}



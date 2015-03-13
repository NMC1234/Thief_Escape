
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
		List<Item> Inventory;
		Item key, kitten;
		string name;
		int counter;
		Direction keyDirection;

		//Exit bool is used to prevent unwanted shutdowns 
		//  when going to the main menu.
		bool exit = true;

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

			//Defaut constructor creates name of "User"
			name = "User";
		}
		#endregion
		

		#region [ LoadEvent ]
		private void FormGamePlay_Load(object sender, EventArgs e)
		{
			#region [ ToolTips ]
			ToolTip movOptions = new ToolTip( );
			movOptions.InitialDelay = 500;
			movOptions.IsBalloon = false;
			movOptions.UseAnimation = false;
			movOptions.UseFading = false;
			movOptions.ToolTipTitle = "Movement Options";
			movOptions.ShowAlways = true;
			movOptions.SetToolTip(this.btnMoveNorth, "Moves Character North. Keybind: W/UP/Num-8.");
			movOptions.SetToolTip(this.btnMoveEast, "Moves Character East, Keybinds: D/RIGHT/Num-6.");
			movOptions.SetToolTip(this.btnMoveSouth, "Moves Character South, Keybinds: S/DOWN/Num-2.");
			movOptions.SetToolTip(this.btnMoveWest, "Moves Character West, Keybinds: A/LEFT/Num-4.");

			ToolTip useKey = new ToolTip( );
			useKey.AutomaticDelay = 300;
			useKey.IsBalloon = false;
			useKey.UseAnimation = false;
			useKey.UseFading = false;
			useKey.ShowAlways = true;
			useKey.ToolTipTitle = "Use Key";
			useKey.SetToolTip(this.btnUseKey, "Press to use up a Key and Unlock a Door Around You.  Keybinds: K");

			ToolTip pickupKey = new ToolTip( );
			pickupKey.AutomaticDelay = 300;
			pickupKey.IsBalloon = false;
			pickupKey.UseAnimation = false;
			pickupKey.UseFading = false;
			pickupKey.ShowAlways = true;
			pickupKey.ToolTipTitle = "Pickup Key";
			pickupKey.SetToolTip(this.btnPickupKey, "Press to Pickup a Key Around You and Add to Inventory. Keybinds: P");

			ToolTip map = new ToolTip( );
			map.AutomaticDelay = 300;
			map.IsBalloon = false;
			map.UseAnimation = false;
			map.UseFading = false;
			map.ShowAlways = true;
			map.ToolTipTitle = "Visual Map of Surroundings";
			map.SetToolTip(this.grdconMap, "A Visual Map of the Current Floor");

			ToolTip options = new ToolTip( );
			options.AutomaticDelay = 300;
			options.IsBalloon = false;
			options.UseAnimation = false;
			options.UseFading = false;
			options.ShowAlways = true;
			options.ToolTipTitle = "Menu Options";
			options.SetToolTip(this.btnMainMenu, "Select to Return to Main Menu");
			options.SetToolTip(this.btnLoadGame, "Select to Load a Previously Saved Game.");
			options.SetToolTip(this.btnSaveGame, "Select to Save Your Game.");

			ToolTip legend = new ToolTip( );
			legend.AutomaticDelay = 300;
			legend.IsBalloon = false;
			legend.UseAnimation = false;
			legend.UseFading = false;
			legend.ShowAlways = true;
			legend.ToolTipTitle = "Map Legend";
			legend.SetToolTip(this.grpboxLegend, "A Legend of the Various Objects on the Map.");

			ToolTip lists = new ToolTip( );
			lists.AutomaticDelay = 300;
			lists.IsBalloon = false;
			lists.UseAnimation = false;
			lists.UseFading = false;
			lists.ShowAlways = true;
			lists.ToolTipTitle = "Information Output Display";
			lists.SetToolTip(this.lstDialog, "Dialog From and About the Game");
			lists.SetToolTip(this.tabDialog, "Tabs the Will Display Past Dialog, What is Surrounding You, and Your Current Inventory.");
			lists.SetToolTip(this.lstOutput, "What Types of Things are Around You.");
			lists.SetToolTip(this.lstInventory, "What You Currently Have In Your Inventory.");

			#endregion

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

			//standard item instantiation
			key = new Item(Item.ItemType.Key);
			kitten = new Item(Item.ItemType.JewelKitten);

			//Inventory list instantiation and call to initial inventory
			Inventory = new List<Item>( );
			InitialInventory(0, Inventory);

			//Sets the first starting point by asking the grid for it's preset,
			//by array creation method
			player.SetCurrentCell(mapCells.WhatIsStartingCellX, mapCells.WhatIsStartingCellY);

			//Get the initial valid movements
			CheckMovement(player.CurrentCellX, player.CurrentCellY);

			//Initial Fog of war
			InitialFogOfWar( );

			//Output initial prompt
			InitalPrompt( );

			//Output information about surrounding tiles
			OutputAroundPlayer(false);

			//General Variable instanciation
			keyDirection = Direction.GENERIC;
		}

		#endregion


		#region [ Movement Check/Buttons ]

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
			&& (mapCells.GetDoorType(currentX, currentY - 1)
			== (DoorType.DOORLOCKED)))
			{
				btnMoveNorth.Enabled = false;
			}
			else if(currentY - 1 < mapCells.MapSize
			&& (mapCells.GetCellType(currentX, currentY - 1)
			== (CellType.BEJEWELEDKITTEN)))
			{
				btnMoveNorth.Enabled = false;
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
				btnPickupKey.Enabled = true;
				btnMoveNorth.Enabled = false;
				keyDirection = Direction.NORTH;
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
			&& (mapCells.GetDoorType(currentX, currentY + 1)
			== DoorType.DOORLOCKED))
			{
				btnMoveSouth.Enabled = false;
			}
			else if(currentY + 1 < mapCells.MapSize
			&& (mapCells.GetCellType(currentX, currentY + 1)
			== (CellType.BEJEWELEDKITTEN)))
			{
				btnMoveNorth.Enabled = false;
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
				btnMoveNorth.Enabled = false;
				btnPickupKey.Enabled = true;
				keyDirection = Direction.SOUTH;
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
			&& (mapCells.GetDoorType(currentX - 1, currentY)
			== DoorType.DOORLOCKED))
			{
				btnMoveWest.Enabled = false;
			}
			else if(currentX - 1 < mapCells.MapSize
			&& (mapCells.GetCellType(currentX - 1, currentY)
			== CellType.BEJEWELEDKITTEN))
			{
				btnMoveWest.Enabled = false;
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
				btnPickupKey.Enabled = true;
				keyDirection = Direction.WEST;
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
			&& (mapCells.GetDoorType(currentX + 1, currentY)
			== DoorType.DOORLOCKED))
			{
				btnMoveEast.Enabled = false;
			}
			else if(currentX + 1 < mapCells.MapSize
			&& (mapCells.GetCellType(currentX + 1, currentY)
			== CellType.BEJEWELEDKITTEN))
			{
				btnMoveWest.Enabled = false;
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
				btnPickupKey.Enabled = true;
				keyDirection = Direction.EAST;
			}
			else
			{
				btnMoveEast.Enabled = false;
			}

			#endregion

		}

		//-----------------------------------------------------------------------------------------------------
		public void Surroundings(int currentX, int currentY, Direction direction)
		{
			//this method outputs the types of walls surrounding the player to the textbox
			//MIGHT WANT TO REMOVE
			//NOT REALLY NEEDED WITH THE MAP
			//-----------------------------------------------------------------------------------------------------
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
			this.Focus( );
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
			this.Focus( );
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
			this.Focus( );
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
			this.Focus( );
		}

		//-----------------------------------------------------------------------------------------------------
		#endregion


		#region [ Change Visual Map Cell Functions ]

		#region [ Blink Current Cell]

		private void tmrCellBlink_Tick(object sender, EventArgs e)
		{
			//The tick event function for the tmrCellBlink timer
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

		
		public void BlinkCurrentCell( )
		{
			//When counter is odd this method is called
			//-----------------------------------------------------------------------------------------------------

			grdconMap[(player.CurrentCellY + 1), (player.CurrentCellX + 1)].BackColor = Color.DimGray;

		}

		
		public void BlinkCurrentCellBack( )
		{
			//when counter is even this method is called
			//-----------------------------------------------------------------------------------------------------
			grdconMap[(player.CurrentCellY + 1), (player.CurrentCellX + 1)].BackColor = Color.Orange;

		}

		#endregion

		private Color WhatIsPrevCellColor(Direction direction)
		{
			//Returns the moved from cell's map color.
			//-----------------------------------------------------------------------------------------------------
			//method scoped variables needed for the logic statements
			Color color = Color.Brown;
			CellType cell = CellType.GENERIC;
			DoorType door = DoorType.GENERIC;
			StairsType stairs = StairsType.GENERIC;
			bool IsStartingCell = false;
			bool isStairs = false;
			bool isBejeweledKitten = false;
			bool isKey = false;

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

					case CellType.KEY:
						isKey = true;
						color = Color.SpringGreen;
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

			//Version 3 of Fog of War
			//Will only reveal and fill correct lines of cells relative to movement direction
			switch(direction)
			{
				#region North
					case Direction.NORTH:
						//Reveal north lines of cells upon movement
						for(int x = (player.CurrentCellX - 1); x < (player.CurrentCellX + 4); x++)
						{
							int y = (player.CurrentCellY - 1);

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

						//Blackout southern cell line upon movement
						for(int x = (player.CurrentCellX - 1); x < (player.CurrentCellX + 4); x++)
						{
							int y = (player.CurrentCellY + 4);

							//Black out image applied
							grdconMap[y, x].BackgroundImage = blackoutImage;
						}
				#endregion
				break;

				#region South
					case Direction.SOUTH:
					//Reveal south lines of cells upon movement
					for(int x = (player.CurrentCellX - 1); x < (player.CurrentCellX + 4); x++)
					{
						int y = (player.CurrentCellY + 3);

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

					//Blackout northern cell line upon movement
					for(int x = (player.CurrentCellX - 1); x < (player.CurrentCellX + 4); x++)
					{
						int y = (player.CurrentCellY - 2);

						//Black out image applied
						grdconMap[y, x].BackgroundImage = blackoutImage;
					}
				#endregion
				break;

				#region East
					case Direction.EAST:
					//Reveal east line of cells upon movement
					for(int y = (player.CurrentCellY - 1); y < (player.CurrentCellY + 4); y++)
					{
						int x = (player.CurrentCellX + 3);

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

					//Blackout western cell line upon movement
					for(int y = (player.CurrentCellY - 1); y < (player.CurrentCellY + 4); y++)
					{
						int x = (player.CurrentCellX - 2);

						//Black out image applied
						grdconMap[y, x].BackgroundImage = blackoutImage;
					}
				#endregion
				break;

				#region West
					case Direction.WEST:
					//Reveal east line of cells upon movement
					for(int y = (player.CurrentCellY - 1); y < (player.CurrentCellY + 4); y++)
					{
						int x = (player.CurrentCellX - 1);

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

					//Blackout western cell line upon movement
					for(int y = (player.CurrentCellY - 1); y < (player.CurrentCellY + 4); y++)
					{
						int x = (player.CurrentCellX + 4);

						//Black out image applied
						grdconMap[y, x].BackgroundImage = blackoutImage;
					}
				#endregion
				break;

				//case Direction.GENERIC:
				//	break;
				//default:
				//	break;
			}


			//Version 2 of Fog of War
			//For loops backout all surrounding cells outside of viewable area
			//for(int x = 1; x < (player.CurrentCellX - 1); x++)
			//{
			//	for(int y = 1; y < (player.CurrentCellY - 1); y++)
			//	{
			//		grdconMap[y, x].BackgroundImage = blackoutImage;
			//	}
				
			//}

			//for(int x = (player.CurrentCellX + 4); x < (mapCells.MapSize + 1); x++)
			//{
			//	for(int y = 1; y < (mapCells.MapSize + 1); y++)
			//	{
			//		grdconMap[y, x].BackgroundImage = blackoutImage;
			//	}
			//}

			//for(int x = 1; x < (mapCells.MapSize + 1); x++)
			//{
			//	for(int y = (player.CurrentCellY + 4); y < (mapCells.MapSize + 1); y++)
			//	{
			//		grdconMap[y, x].BackgroundImage = blackoutImage;
			//	}
			//}

			//for(int x = 1; x < (player.CurrentCellX - 1); x++)
			//{
			//	for(int y = (player.CurrentCellY - 1); y < (mapCells.MapSize + 1); y++)
			//	{
			//		grdconMap[y, x].BackgroundImage = blackoutImage;
			//	}
			//}

			//for(int x = 1; x < (player.CurrentCellX + 4); x++)
			//{
			//	for(int y = 1; y < (player.CurrentCellY - 1); y++)
			//	{
			//		grdconMap[y, x].BackgroundImage = blackoutImage;
			//	}
			//}
		}

		//-----------------------------------------------------------------------------------------------------
		public void InitialFogOfWar( )
		{
			Image blackoutImage = Image.FromFile("CellBlackoutImage.png");
			Image wallImage = Image.FromFile("CellWallImage.png");

			////loop to blackout all cells before a portion is removed by remove blackout
			for(int x = 1; x < (mapCells.MapSize + 1); x++)
			{
				for(int y = 1; y < (mapCells.MapSize + 1); y++)
				{
					grdconMap[y, x].BackgroundImage = blackoutImage;
				}

			}

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

		#endregion


		#region [ Item manipulation ]

		private void btnPickupKey_Click(object sender, EventArgs e)
		{
			int[] key = CheckForNearbyKey();
			if (key[0] != 0)
			{
				 Inventory.Add(mapCells.PickUpKey(key[1], key[2]));
				 UpdateInventory();
				PickedUpKeyMapCellChange(key[1], key[2]);
			}
			else
			{
				lstDialog.Items.Add("There is no key nearby!");
				lstDialog.SelectedIndex = lstDialog.Items.Count - 1;
				lstDialog.SelectedIndex = -1;
			}
			grpMovement.Focus( );
		}

		private void PickedUpKeyMapCellChange( int x, int y)
		{
			grdconMap[(y + 1), (x + 1)].BackColor = Color.White;
		}

		private int[] CheckForNearbyKey()
		{
			//The array defined as (bool,x-coord,y-coord). Bool is 0-false 1-true, with default of false.
			int[] result = { 0, 0, 0 };
			
			//Creates starting point for search, 1 cell up and 1 cell left.
			int x = player.CurrentCellX - 1;
			int y = player.CurrentCellY - 1;

			//Goes through each "column" of the search area
			for (int ix = 0; ix < 3; ix++)
			{
				//Goes through each "row" of the column
				for (int iy = 0; iy < 3; iy++)
				{
					//If the cell has a key, return true.
					if (mapCells.IsKey((x+ix),(y+iy)))
					{
						//Bool true
						result[0] = 1;
						//Key's x-coord
						result[1] = (x + ix);
						//Key's y-coord
						result[2] = (y + iy);
					}
				}
			}

			return result;

		}

		private void btnUseKey_Click(object sender, EventArgs e)
		{
			//Event called when the Use Key button is pressed
			//First checks if there is a key object in the inventory
			//If so then it opens that door
			//Then re-checks movement options to allow movement to now unlocked door
			//Then removes the used key from inventory
			if(Inventory.Contains(key))
			{
				OpenDoor( );
				CheckMovement(player.CurrentCellX, player.CurrentCellY);
				RemoveKey( );
			}
			else
				MessageBox.Show("You don't have any Keys", "Can't Unlock Door");

			grpMovement.Focus( );
		}

		private void RemoveKey( )
		{
			//Removes a used key from the inventory then updates the listbox
			Inventory.Remove(key);
			UpdateInventory( );
		}

		private void OpenDoor( )
		{
			//Gets direction of door then sets the door type for that cell to DoorType.UNLOCKED
			//Then changes that cell's mapcell to the unlocked door color
			Direction doorDirection;
			doorDirection = LookForLockedDoor(player.CurrentCellX, player.CurrentCellY);

			switch(doorDirection)
			{
				case Direction.NORTH:
					mapCells.SetDoorType(player.CurrentCellX, (player.CurrentCellY - 1), DoorType.DOORUNLOCKED);
					grdconMap[player.CurrentCellY, (player.CurrentCellX + 1)].BackColor = Color.Blue;
					break;

				case Direction.SOUTH:
					mapCells.SetDoorType(player.CurrentCellX, (player.CurrentCellY + 1), DoorType.DOORUNLOCKED);
					grdconMap[(player.CurrentCellY + 2), (player.CurrentCellX + 1)].BackColor = Color.Blue;
					break;

				case Direction.EAST:
					mapCells.SetDoorType((player.CurrentCellX + 1), player.CurrentCellY, DoorType.DOORUNLOCKED);
					grdconMap[(player.CurrentCellY + 1), (player.CurrentCellX + 2)].BackColor = Color.Blue;
					break;

				case Direction.WEST:
					mapCells.SetDoorType((player.CurrentCellX - 1), player.CurrentCellY, DoorType.DOORUNLOCKED);
					grdconMap[(player.CurrentCellY + 1), (player.CurrentCellX)].BackColor = Color.Blue;
					break;
				case Direction.GENERIC:
					MessageBox.Show("OpenDoor method was given a direction of Direction.GENERIC.  This should not happen.",
						"This should not show up");
				break;
				//default:
				//	break;
			}

		}

		private Direction LookForLockedDoor(int currentX, int currentY)
		{
			//Checks the four directions around the current cell and looks for a locked door
			//If it finds a locked door then LookForLockedDoor returns the direction of it
			Direction doorDirection = Direction.GENERIC;

			//north
			if((mapCells.GetDoorType(currentX, currentY - 1)
			== (DoorType.DOORLOCKED)))
			{
				doorDirection = Direction.NORTH;
			}

			//south
			if((mapCells.GetDoorType(currentX, currentY + 1)
			== DoorType.DOORLOCKED))
			{
				doorDirection = Direction.SOUTH;
			}

			//west
			if((mapCells.GetDoorType(currentX - 1, currentY)
			== DoorType.DOORLOCKED))
			{
				doorDirection = Direction.WEST;
			}

			//east
			if((mapCells.GetDoorType(currentX + 1, currentY)
			== DoorType.DOORLOCKED))
			{
				doorDirection = Direction.EAST;
			}


			return doorDirection;
		}


		private void InitialInventory(int style, List<Item> currentInv)
		{
			//First argument is used in deciding which default items to load on map-load if any
			//Second argument is a copy of the inventory as currentinv
			//Then adds any default items to currentinv
			//re-assigns currentinv to inventory
			//Then updates the inventory listbox


			//add keys for testing
			currentInv.Add(key);
			currentInv.Add(key);
			currentInv.Add(key);
			currentInv.Add(key);


			Inventory = currentInv;

			UpdateInventory( );

		}

		private void UpdateInventory( )
		{
			//Clears out the inventory list box
			//Then with a loop adds each object back to the inventory list box
			lstInventory.Items.Clear( );
			foreach(Item inv in Inventory)
			{
				lstInventory.Items.Add(inv.ToString( ));
				//To add a line space between items in list box
				lstInventory.Items.Add(" ");

			}

		}

		#endregion


		#region [ Methods ]

		private void WhenKeyIsPressed(KeyEventArgs e)
		{
			//When a key is pressed, switch will decide which key and call specific action
			//used for keyboard shortcuts to game buttons
			switch(e.KeyCode)
			{
				case Keys.Left:
					btnMoveWest.PerformClick( );
					break;
				case Keys.Right:
					btnMoveEast.PerformClick( );
					break;
				case Keys.Up:
					btnMoveNorth.PerformClick( );
					break;
				case Keys.Down:
					btnMoveSouth.PerformClick( );
					break;

				case Keys.W:
					btnMoveNorth.PerformClick( );
					break;
				case Keys.A:
					btnMoveWest.PerformClick( );
					break;
				case Keys.S:
					btnMoveSouth.PerformClick( );
					break;
				case Keys.D:
					btnMoveEast.PerformClick( );
					break;

				case Keys.K:
					btnUseKey.PerformClick( );
					break;
				case Keys.P:
					btnPickupKey.PerformClick( );
					break;


				case Keys.NumPad0:
					break;
				case Keys.NumPad1:
					break;
				case Keys.NumPad2:
					btnMoveSouth.PerformClick( );
					break;
				case Keys.NumPad3:
					break;
				case Keys.NumPad4:
					btnMoveWest.PerformClick( );
					break;
				case Keys.NumPad5:
					break;
				case Keys.NumPad6:
					btnMoveEast.PerformClick( );
					break;
				case Keys.NumPad7:
					break;
				case Keys.NumPad8:
					btnMoveNorth.PerformClick( );
					break;
				case Keys.NumPad9:
					break;

				case Keys.Enter:
					break;
				case Keys.Escape:
					Application.Exit( );
					break;

				case Keys.F1:
					break;
				case Keys.F10:
					break;
				case Keys.F11:
					break;
				case Keys.F12:
					break;
				case Keys.F2:
					break;
				case Keys.F3:
					break;
				case Keys.F4:
					break;
				case Keys.F5:
					break;
				case Keys.F6:
					break;
				case Keys.F7:
					break;
				case Keys.F8:
					break;
				case Keys.F9:
					break;

				case Keys.PageDown:
					break;
				case Keys.PageUp:
					break;

				case Keys.Tab:
					break;

				default:
					break;
			}
		}

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

		//starting dialog
		public void InitalPrompt( )
		{
			lstDialog.Items.Add(string.Format("Hello {0}, welcome to the game", name));
			lstDialog.Items.Add("Help Robbie get out of the house with all his treasures!");
			lstDialog.Items.Add("");
		}

		public void PardonDust( )
		{
			MessageBox.Show("Pardon our dust, we're still under construction.");
		}

		#endregion
		

		#region [ Action Buttons Click ]
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------

		

		private void btnAction2_Click(object sender, EventArgs e)
		{
			PardonDust( );
		}

		private void btnAction3_Click(object sender, EventArgs e)
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
			//Change the exit bool to false;
			exit = false;
			//Load the menu form
			FormMainMenu frm = new FormMainMenu();
			frm.Show();

			//Close this form
			this.Close( );
		}


		# endregion
		

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
			Color Key = Color.SpringGreen;

			//starting Cell
			grdconMap[2, 2].BackColor = startingCellColor;

		
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

			#region [ Items ]
			grdconMap[8, 10].BackColor = Key;

			#endregion
		}

		#endregion


		#region [ Stock Events ]
		private void PrimaryKeyDownEvent(object sender, KeyEventArgs e)
		{
			switch(e.KeyCode)
			{
				case Keys.Left:
					btnMoveWest.PerformClick( );
					break;
				case Keys.Right:
					btnMoveEast.PerformClick( );
					break;
				case Keys.Up:
					btnMoveNorth.PerformClick( );
					break;
				case Keys.Down:
					btnMoveSouth.PerformClick( );
					break;

				case Keys.W:
					btnMoveNorth.PerformClick( );
					break;
				case Keys.A:
					btnMoveWest.PerformClick( );
					break;
				case Keys.S:
					btnMoveSouth.PerformClick( );
					break;
				case Keys.D:
					btnMoveEast.PerformClick( );
					break;

				case Keys.K:
					btnUseKey.PerformClick( );
					break;
				case Keys.P:
					btnPickupKey.PerformClick( );
					break;


				case Keys.NumPad0:
					break;
				case Keys.NumPad1:
					break;
				case Keys.NumPad2:
					btnMoveSouth.PerformClick( );
					break;
				case Keys.NumPad3:
					break;
				case Keys.NumPad4:
					btnMoveWest.PerformClick( );
					break;
				case Keys.NumPad5:
					break;
				case Keys.NumPad6:
					btnMoveEast.PerformClick( );
					break;
				case Keys.NumPad7:
					break;
				case Keys.NumPad8:
					btnMoveNorth.PerformClick( );
					break;
				case Keys.NumPad9:
					break;

				case Keys.Enter:
					break;
				case Keys.Escape:
					Application.Exit( );
					break;

				case Keys.F1:
					break;
				case Keys.F10:
					break;
				case Keys.F11:
					break;
				case Keys.F12:
					break;
				case Keys.F2:
					break;
				case Keys.F3:
					break;
				case Keys.F4:
					break;
				case Keys.F5:
					break;
				case Keys.F6:
					break;
				case Keys.F7:
					break;
				case Keys.F8:
					break;
				case Keys.F9:
					break;

				case Keys.PageDown:
					break;
				case Keys.PageUp:
					break;

				case Keys.Tab:
					break;

				default:
					break;
			}
		}
		#endregion


		#region [ Close Event ]

		private void FormGame_FormClosed(object sender, FormClosedEventArgs e)
		{
			 if (exit)
			Application.Exit();
		}       

		#endregion

	

		 




		 

		 
		

		

		


		

	}
}



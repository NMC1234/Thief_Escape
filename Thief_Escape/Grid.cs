//Created by Zachary T. Vig
//Grid.cs Class for group Phiv project
//Created on: 02/08/2015
//Last Modified: 02/27/2015

//Merged by: Keegon Cabinaw
//Merged on:02/15/2015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thief_Escape
{
	#region [ Enums ]
	//-----------------------------------------------------------------------------------------------------

	//Moved here from FormGame because this Enum has more to do with the Grid than the game
	//-----------------------------------------------------------------------------------------------------
	public enum Direction
	{
		NORTH,
		SOUTH,
		EAST,
		WEST,
		GENERIC
	}

	//-----------------------------------------------------------------------------------------------------
	#endregion

	class Grid
	{
		#region [ Fields ]
		//-----------------------------------------------------------------------------------------------------
		//declaration of _map array
		private Cell[,] _map;

		//Map size used for the instantiation of the array
		//Need to find a better way to set this
		private int _mapSize = 0;

		private int _startingCellX = 0;
		private int _startingCellY = 0;

		#endregion


		#region  [ Properties ]

		//Returns current map size
		public int MapSize
		{
			get { return _mapSize; }
			set { }
		}

		//Use this property to get asigned starting cell x value
		//-----------------------------------------------------------------------------------------------------
		public int WhatIsStartingCellX
		{
			get { return _startingCellX; }
			set { }
		}

		//Use this property to get asigned starting cell y value
		//-----------------------------------------------------------------------------------------------------
		public int WhatIsStartingCellY
		{
			get { return _startingCellY; }
			set { }
		}

		#endregion


		#region [ Constructors ]
		//Default constructor that propigates the _map array with cell objects
		//max x and y of array is set by _mapsize var
		//-----------------------------------------------------------------------------------------------------
		public Grid()
		{

			//For loop that will instatiate the _map array with a specific number of cell objects
			_map = new Cell[_mapSize, _mapSize];
			for(int x = 0; x < _mapSize; x++) {
				for(int y = 0; y < _mapSize; y++) {
					_map[x, y] = new Cell();
				}
			}

		}

		//Overloaded contructor that will create, then instatiate, a custom sized map array
		//-----------------------------------------------------------------------------------------------------
		public Grid(int mapSize)
		{
			_mapSize = mapSize;
			//For loop that will instatiate the _map array with a specific number of cell objects
			_map = new Cell[_mapSize, _mapSize];
			for(int x = 0; x < _mapSize; x++) {
				for(int y = 0; y < _mapSize; y++) {
					_map[x, y] = new Cell();
				}
			}
		}

		#endregion


		#region [ Methods ]
		public void CreateTestGridBig()
		{

			//-----------------------------------------------------------------------------------------------------
			#region [Walls]
			//-----------------------------------------------------------------------------------------------------
			//Create walls
			//

			//create top row of walls
			for(int i = 0; i < 16; i++) {
				_map[0, i].CreateWall(WallType.WALLGENERAL);
			}

			//create bottom row of walls
			for(int i = 0; i < 16; i++) {
				_map[15, i].CreateWall(WallType.WALLGENERAL);
			}

			//create left column of walls
			for(int i = 0; i < 15; i++) {
				_map[i, 0].CreateWall(WallType.WALLGENERAL);
			}

			//create right column of walls
			for(int i = 0; i < 15; i++) {
				_map[i, 15].CreateWall(WallType.WALLGENERAL);
			}

			//create all other walls
			_map[1, 5].CreateWall(WallType.WALLGENERAL);
			_map[1, 12].CreateWall(WallType.WALLGENERAL);

			_map[2, 3].CreateWall(WallType.WALLGENERAL);
			_map[2, 5].CreateWall(WallType.WALLGENERAL);
			_map[2, 8].CreateWall(WallType.WALLGENERAL);
			_map[2, 12].CreateWall(WallType.WALLGENERAL);

			_map[3, 1].CreateWall(WallType.WALLGENERAL);
			_map[3, 2].CreateWall(WallType.WALLGENERAL);
			_map[3, 3].CreateWall(WallType.WALLGENERAL);
			_map[3, 5].CreateWall(WallType.WALLGENERAL);
			_map[3, 7].CreateWall(WallType.WALLGENERAL);
			_map[3, 8].CreateWall(WallType.WALLGENERAL);
			_map[3, 9].CreateWall(WallType.WALLGENERAL);
			_map[3, 11].CreateWall(WallType.WALLGENERAL);
			_map[3, 12].CreateWall(WallType.WALLGENERAL);

			_map[4, 3].CreateWall(WallType.WALLGENERAL);
			_map[4, 5].CreateWall(WallType.WALLGENERAL);
			_map[4, 7].CreateWall(WallType.WALLGENERAL);
			_map[4, 11].CreateWall(WallType.WALLGENERAL);
			_map[4, 12].CreateWall(WallType.WALLGENERAL);
			_map[4, 13].CreateWall(WallType.WALLGENERAL);

			_map[5, 3].CreateWall(WallType.WALLGENERAL);
			_map[5, 5].CreateWall(WallType.WALLGENERAL);
			_map[5, 6].CreateWall(WallType.WALLGENERAL);
			_map[5, 7].CreateWall(WallType.WALLGENERAL);

			_map[6, 11].CreateWall(WallType.WALLGENERAL);
			_map[6, 12].CreateWall(WallType.WALLGENERAL);

			_map[7, 1].CreateWall(WallType.WALLGENERAL);
			_map[7, 2].CreateWall(WallType.WALLGENERAL);
			_map[7, 3].CreateWall(WallType.WALLGENERAL);
			_map[7, 4].CreateWall(WallType.WALLGENERAL);
			_map[7, 5].CreateWall(WallType.WALLGENERAL);
			_map[7, 6].CreateWall(WallType.WALLGENERAL);
			_map[7, 7].CreateWall(WallType.WALLGENERAL);
			_map[7, 8].CreateWall(WallType.WALLGENERAL);
			_map[7, 9].CreateWall(WallType.WALLGENERAL);
			_map[7, 10].CreateWall(WallType.WALLGENERAL);
			_map[7, 11].CreateWall(WallType.WALLGENERAL);
			_map[7, 12].CreateWall(WallType.WALLGENERAL);

			_map[8, 1].CreateWall(WallType.WALLGENERAL);
			_map[8, 2].CreateWall(WallType.WALLGENERAL);
			_map[8, 3].CreateWall(WallType.WALLGENERAL);
			_map[8, 4].CreateWall(WallType.WALLGENERAL);
			_map[8, 5].CreateWall(WallType.WALLGENERAL);
			_map[8, 6].CreateWall(WallType.WALLGENERAL);
			_map[8, 11].CreateWall(WallType.WALLGENERAL);
			_map[8, 12].CreateWall(WallType.WALLGENERAL);

			_map[9, 6].CreateWall(WallType.WALLGENERAL);
			_map[9, 9].CreateWall(WallType.WALLGENERAL);
			_map[9, 11].CreateWall(WallType.WALLGENERAL);
			_map[9, 12].CreateWall(WallType.WALLGENERAL);

			_map[10, 2].CreateWall(WallType.WALLGENERAL);
			_map[10, 3].CreateWall(WallType.WALLGENERAL);
			_map[10, 4].CreateWall(WallType.WALLGENERAL);
			_map[10, 5].CreateWall(WallType.WALLGENERAL);
			_map[10, 6].CreateWall(WallType.WALLGENERAL);
			_map[10, 7].CreateWall(WallType.WALLGENERAL);
			_map[10, 8].CreateWall(WallType.WALLGENERAL);
			_map[10, 9].CreateWall(WallType.WALLGENERAL);

			_map[11, 9].CreateWall(WallType.WALLGENERAL);
			_map[11, 11].CreateWall(WallType.WALLGENERAL);
			_map[11, 12].CreateWall(WallType.WALLGENERAL);
			_map[11, 13].CreateWall(WallType.WALLGENERAL);

			_map[12, 1].CreateWall(WallType.WALLGENERAL);
			_map[12, 2].CreateWall(WallType.WALLGENERAL);
			_map[12, 3].CreateWall(WallType.WALLGENERAL);
			_map[12, 5].CreateWall(WallType.WALLGENERAL);
			_map[12, 6].CreateWall(WallType.WALLGENERAL);
			_map[12, 9].CreateWall(WallType.WALLGENERAL);
			_map[12, 11].CreateWall(WallType.WALLGENERAL);
			_map[12, 12].CreateWall(WallType.WALLGENERAL);

			_map[13, 6].CreateWall(WallType.WALLGENERAL);
			_map[13, 9].CreateWall(WallType.WALLGENERAL);
			_map[13, 12].CreateWall(WallType.WALLGENERAL);

			_map[14, 6].CreateWall(WallType.WALLGENERAL);
			_map[14, 12].CreateWall(WallType.WALLGENERAL);

			//-----------------------------------------------------------------------------------------------------
			#endregion
			//-----------------------------------------------------------------------------------------------------

			//-----------------------------------------------------------------------------------------------------
			#region [Floors]
			//-----------------------------------------------------------------------------------------------------

			_map[1, 2].CreateFloor(FloorType.FLOORGENERAL);
			_map[1, 4].CreateFloor(FloorType.FLOORGENERAL);
			_map[1, 6].CreateFloor(FloorType.FLOORGENERAL);
			_map[1, 7].CreateFloor(FloorType.FLOORGENERAL);
			_map[1, 9].CreateFloor(FloorType.FLOORGENERAL);
			_map[1, 10].CreateFloor(FloorType.FLOORGENERAL);
			_map[1, 11].CreateFloor(FloorType.FLOORGENERAL);

			_map[2, 1].CreateFloor(FloorType.FLOORGENERAL);
			_map[2, 2].CreateFloor(FloorType.FLOORGENERAL);
			_map[2, 4].CreateFloor(FloorType.FLOORGENERAL);
			_map[2, 6].CreateFloor(FloorType.FLOORGENERAL);
			_map[2, 7].CreateFloor(FloorType.FLOORGENERAL);
			_map[2, 9].CreateFloor(FloorType.FLOORGENERAL);
			_map[2, 10].CreateFloor(FloorType.FLOORGENERAL);
			_map[2, 11].CreateFloor(FloorType.FLOORGENERAL);
			_map[2, 13].CreateFloor(FloorType.FLOORGENERAL);
			_map[2, 14].CreateFloor(FloorType.FLOORGENERAL);

			_map[3, 4].CreateFloor(FloorType.FLOORGENERAL);
			_map[3, 6].CreateFloor(FloorType.FLOORGENERAL);
			_map[3, 13].CreateFloor(FloorType.FLOORGENERAL);
			_map[3, 14].CreateFloor(FloorType.FLOORGENERAL);

			_map[4, 1].CreateFloor(FloorType.FLOORGENERAL);
			_map[4, 2].CreateFloor(FloorType.FLOORGENERAL);
			_map[4, 4].CreateFloor(FloorType.FLOORGENERAL);
			_map[4, 6].CreateFloor(FloorType.FLOORGENERAL);
			_map[4, 8].CreateFloor(FloorType.FLOORGENERAL);
			_map[4, 9].CreateFloor(FloorType.FLOORGENERAL);
			_map[4, 10].CreateFloor(FloorType.FLOORGENERAL);

			_map[5, 1].CreateFloor(FloorType.FLOORGENERAL);
			_map[5, 2].CreateFloor(FloorType.FLOORGENERAL);
			_map[5, 4].CreateFloor(FloorType.FLOORGENERAL);
			_map[5, 8].CreateFloor(FloorType.FLOORGENERAL);
			_map[5, 9].CreateFloor(FloorType.FLOORGENERAL);
			_map[5, 10].CreateFloor(FloorType.FLOORGENERAL);
			_map[5, 11].CreateFloor(FloorType.FLOORGENERAL);
			_map[5, 12].CreateFloor(FloorType.FLOORGENERAL);
			_map[5, 13].CreateFloor(FloorType.FLOORGENERAL);
			_map[5, 14].CreateFloor(FloorType.FLOORGENERAL);

			_map[6, 1].CreateFloor(FloorType.FLOORGENERAL);
			_map[6, 2].CreateFloor(FloorType.FLOORGENERAL);
			_map[6, 4].CreateFloor(FloorType.FLOORGENERAL);
			_map[6, 5].CreateFloor(FloorType.FLOORGENERAL);
			_map[6, 6].CreateFloor(FloorType.FLOORGENERAL);
			_map[6, 7].CreateFloor(FloorType.FLOORGENERAL);
			_map[6, 8].CreateFloor(FloorType.FLOORGENERAL);
			_map[6, 9].CreateFloor(FloorType.FLOORGENERAL);
			_map[6, 10].CreateFloor(FloorType.FLOORGENERAL);
			_map[6, 13].CreateFloor(FloorType.FLOORGENERAL);
			_map[6, 14].CreateFloor(FloorType.FLOORGENERAL);

			_map[7, 13].CreateFloor(FloorType.FLOORGENERAL);
			_map[7, 14].CreateFloor(FloorType.FLOORGENERAL);

			_map[8, 7].CreateFloor(FloorType.FLOORGENERAL);
			_map[8, 8].CreateFloor(FloorType.FLOORGENERAL);
			_map[8, 10].CreateFloor(FloorType.FLOORGENERAL);
			_map[8, 13].CreateFloor(FloorType.FLOORGENERAL);
			_map[8, 14].CreateFloor(FloorType.FLOORGENERAL);

			_map[9, 1].CreateFloor(FloorType.FLOORGENERAL);
			_map[9, 2].CreateFloor(FloorType.FLOORGENERAL);
			_map[9, 3].CreateFloor(FloorType.FLOORGENERAL);
			_map[9, 4].CreateFloor(FloorType.FLOORGENERAL);
			_map[9, 5].CreateFloor(FloorType.FLOORGENERAL);
			_map[9, 7].CreateFloor(FloorType.FLOORGENERAL);
			_map[9, 8].CreateFloor(FloorType.FLOORGENERAL);
			_map[9, 10].CreateFloor(FloorType.FLOORGENERAL);
			_map[9, 13].CreateFloor(FloorType.FLOORGENERAL);
			_map[9, 14].CreateFloor(FloorType.FLOORGENERAL);

			_map[10, 10].CreateFloor(FloorType.FLOORGENERAL);
			_map[10, 11].CreateFloor(FloorType.FLOORGENERAL);
			_map[10, 12].CreateFloor(FloorType.FLOORGENERAL);
			_map[10, 13].CreateFloor(FloorType.FLOORGENERAL);
			_map[10, 14].CreateFloor(FloorType.FLOORGENERAL);

			_map[11, 1].CreateFloor(FloorType.FLOORGENERAL);
			_map[11, 2].CreateFloor(FloorType.FLOORGENERAL);
			_map[11, 3].CreateFloor(FloorType.FLOORGENERAL);
			_map[11, 4].CreateFloor(FloorType.FLOORGENERAL);
			_map[11, 5].CreateFloor(FloorType.FLOORGENERAL);
			_map[11, 6].CreateFloor(FloorType.FLOORGENERAL);
			_map[11, 7].CreateFloor(FloorType.FLOORGENERAL);
			_map[11, 8].CreateFloor(FloorType.FLOORGENERAL);
			_map[11, 10].CreateFloor(FloorType.FLOORGENERAL);

			_map[12, 7].CreateFloor(FloorType.FLOORGENERAL);
			_map[12, 8].CreateFloor(FloorType.FLOORGENERAL);
			_map[12, 10].CreateFloor(FloorType.FLOORGENERAL);
			_map[12, 13].CreateFloor(FloorType.FLOORGENERAL);
			_map[12, 14].CreateFloor(FloorType.FLOORGENERAL);

			_map[13, 1].CreateFloor(FloorType.FLOORGENERAL);
			_map[13, 2].CreateFloor(FloorType.FLOORGENERAL);
			_map[13, 3].CreateFloor(FloorType.FLOORGENERAL);
			_map[13, 4].CreateFloor(FloorType.FLOORGENERAL);
			_map[13, 5].CreateFloor(FloorType.FLOORGENERAL);
			_map[13, 7].CreateFloor(FloorType.FLOORGENERAL);
			_map[13, 8].CreateFloor(FloorType.FLOORGENERAL);
			_map[13, 10].CreateFloor(FloorType.FLOORGENERAL);
			_map[13, 11].CreateFloor(FloorType.FLOORGENERAL);
			_map[13, 13].CreateFloor(FloorType.FLOORGENERAL);
			_map[13, 14].CreateFloor(FloorType.FLOORGENERAL);

			_map[14, 1].CreateFloor(FloorType.FLOORGENERAL);
			_map[14, 2].CreateFloor(FloorType.FLOORGENERAL);
			_map[14, 3].CreateFloor(FloorType.FLOORGENERAL);
			_map[14, 4].CreateFloor(FloorType.FLOORGENERAL);
			_map[14, 5].CreateFloor(FloorType.FLOORGENERAL);
			_map[14, 7].CreateFloor(FloorType.FLOORGENERAL);
			_map[14, 8].CreateFloor(FloorType.FLOORGENERAL);
			_map[14, 10].CreateFloor(FloorType.FLOORGENERAL);
			_map[14, 11].CreateFloor(FloorType.FLOORGENERAL);
			_map[14, 14].CreateFloor(FloorType.FLOORGENERAL);

			//-----------------------------------------------------------------------------------------------------
			#endregion
			//-----------------------------------------------------------------------------------------------------

			//-----------------------------------------------------------------------------------------------------
			#region [Doors]
			//-----------------------------------------------------------------------------------------------------

			//Unlocked doors
			_map[1, 3].CreateDoor(DoorType.DOORUNLOCKED);
			_map[10, 1].CreateDoor(DoorType.DOORUNLOCKED);
			_map[8, 9].CreateDoor(DoorType.DOORUNLOCKED);
			_map[14, 9].CreateDoor(DoorType.DOORUNLOCKED);
			_map[3, 10].CreateDoor(DoorType.DOORUNLOCKED);

			//Locked doors
			_map[6, 3].CreateDoor(DoorType.DOORLOCKED);
			_map[12, 4].CreateDoor(DoorType.DOORLOCKED);
			_map[1, 8].CreateDoor(DoorType.DOORLOCKED);
			_map[4, 14].CreateDoor(DoorType.DOORLOCKED);
			_map[11, 14].CreateDoor(DoorType.DOORLOCKED);

			//-----------------------------------------------------------------------------------------------------
			#endregion
			//-----------------------------------------------------------------------------------------------------

			//-----------------------------------------------------------------------------------------------------
			#region [STAIRS]
			//-----------------------------------------------------------------------------------------------------

			//STAIRS up
			_map[1, 13].CreateStairs(StairsType.STAIRSUP);

			//STAIRS down
			_map[14, 13].CreateStairs(StairsType.STAIRSDOWN);

			//-----------------------------------------------------------------------------------------------------
			#endregion
			//-----------------------------------------------------------------------------------------------------

			//Assignment of starting cell
			_map[1, 1].SetStartingCell(true);
			this.SetStartingCell(1, 1);

		}

		//Methods used to interaxt with specific cell objects in the array
		//They require at least an x and y component passed to them as arguments

		//Method to set the starting cell
		//validates the range of x and y values
		//internally sets the passed x and y arguments
		//sets IsStartingCell boolean to true for that cell object
		//-----------------------------------------------------------------------------------------------------
		public void SetStartingCell(int x, int y)
		{
			if(((x >= 0) && (x <= 100)) & ((y >= 0) && (y <= 100))) {
				_startingCellX = x;
				_startingCellY = y;
				//_map[_startingCellX, _startingCellY].IsStartingCell = true;
			}
		}

		//Sets door type
		//-----------------------------------------------------------------------------------------------------
		public void SetDoorType(int x, int y, DoorType door)
		{
			_map[x, y].WhatSetDoorType = door;
		}

		//Picks up the kitten by changing the kitten cell type
		//-----------------------------------------------------------------------------------------------------
		public void PickUpKitten(int x, int y)
		{
			_map[x, y].PickUpKitten( );
		}

		//Picks up the Key by changing the Key cell type
		//-----------------------------------------------------------------------------------------------------
		public void PickUpKey(int x, int y)
		{
			_map[x, y].PickUpKey( );
		}

		//Checks if the passed in array location is the starting cell
		//-----------------------------------------------------------------------------------------------------
		public bool IsStartingCell(int x, int y)
		{
			bool currentCell = false;

			currentCell = _map[x, y].IsStartingCell;

			return currentCell;
		}

		//Checks if Cell is kitten cell
		//-----------------------------------------------------------------------------------------------------
		public bool IsBejeweledKitten(int x, int y)
		{
			bool currentCell = false;

			currentCell = _map[x, y].IsBejeweledKitten;

			return currentCell;

		}

		//Checks if Cell is key cell
		//-----------------------------------------------------------------------------------------------------
		public bool IsKey(int x, int y)
		{
			bool currentCell = false;

			currentCell = _map[x, y].IsKey;

			return currentCell;
		}

		//Gets cell type
		//-----------------------------------------------------------------------------------------------------
		public CellType GetCellType(int x, int y)
		{
			CellType currentCell = CellType.WALL;

			currentCell = _map[x, y].WhatIsCellType;

			return currentCell;
		}

		//gets wall type
		//-----------------------------------------------------------------------------------------------------
		public WallType GetWallType(int x, int y)
		{
			WallType currentCell = WallType.WALLGENERAL;

			currentCell = _map[x, y].WhatIsWallType;

			return currentCell;
		}

		//gets floor type
		//-----------------------------------------------------------------------------------------------------
		public FloorType GetFloorType(int x, int y)
		{
			FloorType currentCell = FloorType.FLOORGENERAL;

			currentCell = _map[x, y].WhatIsFloorType;

			return currentCell;
		}

		//gets door type
		//-----------------------------------------------------------------------------------------------------
		public DoorType GetDoorType(int x, int y)
		{
			DoorType currentCell = DoorType.DOORLOCKED;

			currentCell = _map[x, y].WhatSetDoorType;

			return currentCell;
		}

		// gets stairs type
		//-----------------------------------------------------------------------------------------------------
		public StairsType GetStairsType(int x, int y)
		{
			StairsType currentCell = StairsType.GENERIC;

			currentCell = _map[x, y].WhatIsStairsType;

			return currentCell;
		}

		//Gets Bejeweled kitten type

		//-----------------------------------------------------------------------------------------------------
		public KittenType GetKittenType(int x, int y)
		{
			KittenType currentCell = KittenType.GENERIC;

			currentCell = _map[x, y].WhatIsKittenType;

			return currentCell;
		}

		//Gets Key Type

		//-----------------------------------------------------------------------------------------------------
		public KeyType GetKeyType(int x, int y)
		{
			KeyType currentCell = KeyType.GENERIC;

			currentCell = _map[x, y].WhatIsKeyType;

			return currentCell;
		}

		#endregion
		

	}
}



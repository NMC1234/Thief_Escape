//Created by Zachary T. Vig
//Grid.cs Class for group Phiv project
//Created on: 02/08/2015
//Last Modified: 02/16/2015

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

	//Moved here from FormGame because this Enum has more to do with the Grid than the game
	public enum Direction
	{
		NORTH,
		SOUTH,
		EAST,
		WEST
	}

	#endregion
	class Grid
	{
		//-----------------------------------------------------------------------------------------------------
		#region [ Fields ]
		//-----------------------------------------------------------------------------------------------------

		//Need to find a way to move the array to the constructor
		//if possible then there can be an override to construct with a different sized array
		//to allow for different sized maps
		private Cell[,] _map;
		private int _mapSize = 5;

		private int _startingCellX = 0;
		private int _startingCellY = 0;

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region  [ Properties ]
		//-----------------------------------------------------------------------------------------------------

		//Returns current map size
		//-----------------------------------------------------------------------------------------------------
		public int MapSize
		{
			get { return _mapSize; }
			set { }
		}

		//Not really sure how to handle grid get and set

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

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region [ Constructors ]
		//-----------------------------------------------------------------------------------------------------

		//Default constructor that propigates the _map array with cell objects
		//x and y of array is set by _mapsize var
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

			_map = new Cell[mapSize, mapSize];
			for(int x = 0; x < mapSize; x++) {
				for(int y = 0; y < mapSize; y++) {
					_map[x, y] = new Cell();
				}
			}
		}

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region [ Methods ]
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		public void CreateTestGrid()
		{
			//Creation of the surrounding general walls
			_map[0, 0].CreateWall(WallType.WallGeneral);
			_map[0, 1].CreateWall(WallType.WallGeneral);
			_map[0, 2].CreateWall(WallType.WallGeneral);
			_map[0, 3].CreateWall(WallType.WallGeneral);
			_map[0, 4].CreateWall(WallType.WallGeneral);
			_map[1, 0].CreateWall(WallType.WallGeneral);
			_map[2, 0].CreateWall(WallType.WallGeneral);
			_map[3, 0].CreateWall(WallType.WallGeneral);
			_map[4, 0].CreateWall(WallType.WallGeneral);
			_map[2, 2].CreateWall(WallType.WallGeneral);
			_map[3, 2].CreateWall(WallType.WallGeneral);
			_map[4, 1].CreateWall(WallType.WallGeneral);
			_map[4, 2].CreateWall(WallType.WallGeneral);
			_map[4, 3].CreateWall(WallType.WallGeneral);
			_map[4, 4].CreateWall(WallType.WallGeneral);
			_map[1, 4].CreateWall(WallType.WallGeneral);
			_map[2, 4].CreateWall(WallType.WallGeneral);
			_map[3, 4].CreateWall(WallType.WallGeneral);

			//Creation of gernal Floors
			_map[1, 1].CreateFloor(FloorType.FloorGeneral);
			_map[2, 1].CreateFloor(FloorType.FloorGeneral);
			_map[3, 1].CreateFloor(FloorType.FloorGeneral);
			_map[1, 3].CreateFloor(FloorType.FloorGeneral);
			_map[2, 3].CreateFloor(FloorType.FloorGeneral);
			_map[3, 2].CreateFloor(FloorType.FloorGeneral);
			_map[3, 3].CreateFloor(FloorType.FloorGeneral);

			//Creation of locked door
			_map[1, 2].CreateDoor(DoorType.DoorLocked);

			//Asignment of starting Cell
			_map[1, 1].SetStartingCell(true);
			this.SetStartingCell(1, 1);
			

			//This setup doesn't contribute
			//_map[1, 1].SetStartingCell(true);

		}

		//Methods used to interaxt with specific cell objects in the array
		//They require at least an x and y component passed to them as arguments
		//-----------------------------------------------------------------------------------------------------
		public void SetStartingCell(int x, int y)
		{
			if(((x >= 0) && (x <= 100)) & ((y >= 0) && (y <= 100))) {
				_startingCellX = x;
				_startingCellY = y;
				_map[x, y].IsStartingCell = true;
			}
		}

		//-----------------------------------------------------------------------------------------------------
		public void SetDoorType(int x, int y, DoorType door)
		{
			_map[x, y].WhatSetDoorType = door;
		}

		//-----------------------------------------------------------------------------------------------------

		public bool IsStartingCell(int x, int y)
		{
			bool startCell = false;
			startCell = _map[x, y].IsStartingCell;
			return startCell;
		}

		public CellType GetCellType(int x, int y)
		{
			CellType currentCell = CellType.Wall;

			currentCell = _map[x, y].WhatIsCellType;

			return currentCell;
		}

		//-----------------------------------------------------------------------------------------------------
		public WallType GetWallType(int x, int y)
		{
			WallType currentCell = WallType.WallGeneral;

			currentCell = _map[x, y].WhatIsWallType;

			return currentCell;
		}

		//-----------------------------------------------------------------------------------------------------
		public FloorType GetFloorType(int x, int y)
		{
			FloorType currentCell = FloorType.FloorGeneral;

			currentCell = _map[x, y].WhatIsFloorType;

			return currentCell;
		}

		//-----------------------------------------------------------------------------------------------------
		public DoorType GetDoorType(int x, int y)
		{
			DoorType currentCell = DoorType.DoorLocked;

			currentCell = _map[x, y].WhatSetDoorType;

			return currentCell;
		}

		//-----------------------------------------------------------------------------------------------------
		public StairsType GetStairsType(int x, int y)
		{
			StairsType currentCell = StairsType.Generic;

			currentCell = _map[x, y].WhatIsStairsType;

			return currentCell;
		}

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

	}
}



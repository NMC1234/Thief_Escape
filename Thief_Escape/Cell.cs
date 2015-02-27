
//***********************************************
//Created by: Zachary T. Vig
//Cell.cs Class For Group Phiv project
//Created on: 02/05/2015
//Updated on : 02/16/2015
//**************************************************

//Merged by: Keegon Cabinaw
//Merged on: 02/15/2015

/*
* ********************************************************************
* Cell Class
* Used as cell objects in the array created in the grid class
* Can be FLOOR, WALL, or DOOR type
*
*

**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thief_Escape
{

	//Class specific Enums
	//-----------------------------------------------------------------------------------------------------
	#region [ Enums ]
	//Various base cell types
	//-----------------------------------------------------------------------------------------------------
	public enum CellType
	{
		FLOOR,
		WALL,
		DOOR,
		GENERIC,
		STAIRS,
		BEJEWELEDKITTEN,
		KEY

	}

	//The different floor types
	//-----------------------------------------------------------------------------------------------------
	public enum FloorType
	{
		FLOORGENERAL,
		FLOORITEM,
		FLOORSECRET,
		FLOORKEY,
		GENERIC

	}

	//The different wall types
	//-----------------------------------------------------------------------------------------------------
	public enum WallType
	{
		WALLGENERAL,
		WALLITEM,
		WALLSECRET,
		WALLKEY,
		GENERIC

	}

	//The differnt door types
	//-----------------------------------------------------------------------------------------------------
	public enum DoorType
	{
		DOORLOCKED,
		DOORUNLOCKED,
		GENERIC
	}

	//The different stairs type
	//-----------------------------------------------------------------------------------------------------
	public enum StairsType
	{
		STAIRSUP,
		STAIRSDOWN,
		GENERIC
	}

	//The different Bejeweled Kitten types
	//-----------------------------------------------------------------------------------------------------
	public enum KittenType
	{
		AVAILABLE,
		PICKEDUP,
		GENERIC
	}

	//The different key types
	//-----------------------------------------------------------------------------------------------------
	public enum KeyType
	{
		AVAILABLE,
		PICKEDUP,
		GENERIC
	}

	//-----------------------------------------------------------------------------------------------------
	#endregion
	//-----------------------------------------------------------------------------------------------------

	//-----------------------------------------------------------------------------------------------------

	class Cell
	{
		//-----------------------------------------------------------------------------------------------------
		#region [ Fields ]
		//Internal Cell type variables
		//-----------------------------------------------------------------------------------------------------
		private CellType _cell;
		private WallType _wall;
		private FloorType _floor;
		private DoorType _door;
		private StairsType _stairs;
		private KeyType _key;
		private KittenType _kitten;
		private bool _startingCell;
		private bool _isBejeweledKitten;
		private bool _isKey;

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region [ Properties ]
		// Get and Set for cell object properties
		//-----------------------------------------------------------------------------------------------------
		public CellType WhatIsCellType
		{
			get { return _cell; }
			//no external set must be set through ceate methods
			set { }
		}

		//-----------------------------------------------------------------------------------------------------
		public WallType WhatIsWallType
		{
			get { return _wall; }
			//No external set must call create methode to set type
			set { }
		}

		//-----------------------------------------------------------------------------------------------------
		public FloorType WhatIsFloorType
		{
			get { return _floor; }
			//No external set must call create methode to set type
			set { }
		}

		//-----------------------------------------------------------------------------------------------------
		public DoorType WhatSetDoorType
		{
			get { return _door; }
			//Must have external set to changed from locked to unlocked
			set { _door = value; }
		}

		//-----------------------------------------------------------------------------------------------------
		public StairsType WhatIsStairsType
		{
			get { return _stairs; }
			//no external set must call ceate stairs method
			set { }
		}

		//-----------------------------------------------------------------------------------------------------
		public KeyType WhatIsKeyType
		{
			get { return _key; }
			//no external set must be set through ceate methods
			set { }
		}
		//-----------------------------------------------------------------------------------------------------

		public KittenType WhatIsKittenType
		{
			get { return _kitten; }
			set { }
		}
		//-----------------------------------------------------------------------------------------------------

		public bool IsStartingCell
		{
			get { return _startingCell; }
			//no external set must call create kitten method
			set { }
		}
		//-----------------------------------------------------------------------------------------------------

		public bool IsBejeweledKitten
		{
			get { return _isBejeweledKitten; }
			set { }
		}
		//-----------------------------------------------------------------------------------------------------

		public bool IsKey
		{
			get { return _isKey; }
			set { }
		}
		//-----------------------------------------------------------------------------------------------------
		#endregion

		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region [ Constructors ]
		//Default Constructor
		//-----------------------------------------------------------------------------------------------------
		public Cell()
		{
			_startingCell = false;
			_isBejeweledKitten = false;
		}

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region  [ Methods ]
		//-----------------------------------------------------------------------------------------------------
		//External acessable methods to set the type of cell in the map array

		//Sets current cell as starting Cell
		//-----------------------------------------------------------------------------------------------------
		//Method to set cell object as starting cell
		public void SetStartingCell(bool startCell)
		{
			if(startCell) 
			{
				_startingCell = true;
			}
		}

		//Creates a FLOOR cell type
		//-----------------------------------------------------------------------------------------------------
		public void CreateFloor(FloorType floorType)
		{

			if(floorType == FloorType.FLOORGENERAL)
			{
				_cell = CellType.FLOOR;
				_floor = FloorType.FLOORGENERAL;
			}
			else if(floorType == FloorType.FLOORITEM) 
			{
				_cell = CellType.FLOOR;
				_floor = FloorType.FLOORITEM;
			}
			else if(floorType == FloorType.FLOORSECRET) 
			{
				_cell = CellType.FLOOR;
				_floor = FloorType.FLOORSECRET;
			}

		}

		//Creates a WALL cell type
		//-----------------------------------------------------------------------------------------------------
		public void CreateWall(WallType wallType)
		{

			if(wallType == WallType.WALLGENERAL) 
			{
				_cell = CellType.WALL;
				_wall = WallType.WALLGENERAL;
			}
			else if(wallType == WallType.WALLITEM) 
			{
				_cell = CellType.WALL;
				_wall = WallType.WALLITEM;
			}
			else if(wallType == WallType.WALLSECRET) 
			{
				_cell = CellType.WALL;
				_wall = WallType.WALLSECRET;
			}

		}

		//creates a DOOR Cell Type
		//-----------------------------------------------------------------------------------------------------
		public void CreateDoor(DoorType doorType)
		{

			if(doorType == DoorType.DOORLOCKED) 
			{
				_cell = CellType.DOOR;
				_door = DoorType.DOORLOCKED;
			}
			else if(doorType == DoorType.DOORUNLOCKED) 
			{
				_cell = CellType.DOOR;
				_door = DoorType.DOORUNLOCKED;
			}

		}

		//Creates a stairs cell type
		//-----------------------------------------------------------------------------------------------------
		public void CreateStairs(StairsType stairsType)
		{
			if(stairsType == StairsType.STAIRSUP) 
			{
				_cell = CellType.STAIRS;
				_stairs = StairsType.STAIRSUP;
			}
			else if(stairsType == StairsType.STAIRSDOWN) 
			{
				_cell = CellType.STAIRS;
				_stairs = StairsType.STAIRSDOWN;
			}

		}

		//Creates a Key cell type
		//Pick up key method that changes the key cell type
		//-----------------------------------------------------------------------------------------------------
		public void CreateKey(KeyType keyType)
		{
			if(keyType == KeyType.AVAILABLE)
			{
				_cell = CellType.KEY;
				_key = KeyType.AVAILABLE;
				_isKey = true;
			}
				
		}

		public void PickUpKey( )
		{
			_key = KeyType.PICKEDUP;
		}

		//Sets current cell object as bejeweled kitten
		//-----------------------------------------------------------------------------------------------------
		public void CreateBejeweledKitten()
		{
			_cell = CellType.BEJEWELEDKITTEN;
			_kitten = KittenType.AVAILABLE;
			_isBejeweledKitten = true;
		}

		public void PickUpKitten( )
		{
			_kitten = KittenType.PICKEDUP;
		}

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

	}

}



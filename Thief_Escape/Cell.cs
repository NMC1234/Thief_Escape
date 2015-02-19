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
* Can be Floor, Wall, or Door type
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
	//-----------------------------------------------------------------------------------------------------

	//Note: I remove the static modifiers because they were throwing errors, on both the merged version and the original - Keegon
	//-----------------------------------------------------------------------------------------------------
	public enum CellType
	{
		Floor,
		Wall,
		Door,
		Generic,
		Stairs,
		BejeweledKitten

	}

	//-----------------------------------------------------------------------------------------------------
	public enum FloorType
	{
		FloorGeneral,
		FloorItem,
		FloorSecret,
		Generic

	}

	//-----------------------------------------------------------------------------------------------------
	public enum WallType
	{
		WallGeneral,
		WallItem,
		WallSecret,
		Generic

	}

	//-----------------------------------------------------------------------------------------------------
	public enum DoorType
	{
		DoorLocked,
		DoorUnlocked,
		Generic
	}

	//-----------------------------------------------------------------------------------------------------
	public enum StairsType
	{
		StairsUp,
		StairsDpwn,
		Generic
	}

	//-----------------------------------------------------------------------------------------------------
	#endregion
	//-----------------------------------------------------------------------------------------------------

	class Cell
	{
		//-----------------------------------------------------------------------------------------------------
		#region [ Fields ]
		//-----------------------------------------------------------------------------------------------------

		//Internal Cell type variables
		private CellType _cell;
		private WallType _wall;
		private FloorType _floor;
		private DoorType _door;
		private StairsType _stairs;
		private bool _startingCell;
		private bool _isBejeweledKitten;

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region [ Properties ]
		//-----------------------------------------------------------------------------------------------------
		// Get and Set
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
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region [ Constructors ]
		//-----------------------------------------------------------------------------------------------------

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
		public void SetStartingCell(bool startCell)
		{
			if(startCell) {
				_startingCell = true;
			}
		}

		//Creates a Floor cell type
		//-----------------------------------------------------------------------------------------------------
		public void CreateFloor(FloorType floorType)
		{

			if(floorType == FloorType.FloorGeneral) {
				_cell = CellType.Floor;
				_floor = FloorType.FloorGeneral;
			}
			else if(floorType == FloorType.FloorItem) {
				_cell = CellType.Floor;
				_floor = FloorType.FloorItem;
			}
			else if(floorType == FloorType.FloorSecret) {
				_cell = CellType.Floor;
				_floor = FloorType.FloorSecret;
			}

		}

		//Creates a Wall cell type
		//-----------------------------------------------------------------------------------------------------
		public void CreateWall(WallType wallType)
		{

			if(wallType == WallType.WallGeneral) {
				_cell = CellType.Wall;
				_wall = WallType.WallGeneral;
			}
			else if(wallType == WallType.WallItem) {
				_cell = CellType.Wall;
				_wall = WallType.WallItem;
			}
			else if(wallType == WallType.WallSecret) {
				_cell = CellType.Wall;
				_wall = WallType.WallSecret;
			}

		}

		//creates a Door Cell Type
		//-----------------------------------------------------------------------------------------------------
		public void CreateDoor(DoorType doorType)
		{

			if(doorType == DoorType.DoorLocked) {
				_cell = CellType.Door;
				_door = DoorType.DoorLocked;
			}
			else if(doorType == DoorType.DoorUnlocked) {
				_cell = CellType.Door;
				_door = DoorType.DoorUnlocked;
			}

		}

		//Creates a stairs cell type
		//-----------------------------------------------------------------------------------------------------
		public void CreateStairs(StairsType stairsType)
		{
			if(stairsType == StairsType.StairsUp) {
				_cell = CellType.Stairs;
				_stairs = StairsType.StairsUp;
			}
			else if(stairsType == StairsType.StairsDpwn) {
				_cell = CellType.Stairs;
				_stairs = StairsType.StairsDpwn;
			}

		}

		//Sets current cell object as bejeweled kitten
		//-----------------------------------------------------------------------------------------------------
		public void CreateBejeweledKitten()
		{
			_cell = CellType.BejeweledKitten;
			_isBejeweledKitten = true;
		}

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

	}

}



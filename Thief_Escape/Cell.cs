
//***********************************************
//Created by: Zachary T. Vig
//Cell.cs Class For Group Phiv project
//Created on: 02/05/2015
//Updated on : 02/27/2015
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
using System.Globalization;

namespace Thief_Escape
{

	//Class specific Enums
	//-----------------------------------------------------------------------------------------------------
	#region [ Enums ]
	//-----------------------------------------------------------------------------------------------------
	//Various base cell types
	//-----------------------------------------------------------------------------------------------------
	public enum CellType
	{
		FLOOR,
		WALL,
		DOOR,
		GENERIC,
		STAIRS,
		ITEM
	}

	//The different floor types
	//-----------------------------------------------------------------------------------------------------
	public enum FloorType
	{
		FLOORGENERAL,
		FLOORITEM,
		FLOORSECRET,
		GENERIC

	}

	//The different wall types
	//-----------------------------------------------------------------------------------------------------
	public enum WallType
	{
		WALLGENERAL,
		WALLITEM,
		WALLSECRET,
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

	//the different item types
	//-----------------------------------------------------------------------------------------------------
	public enum ItemType
	{
		AVAILABLE,
		PICKEDUP,
		GENERIC
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

		//most commmon cell types
		private CellType _cell;
		private WallType _wall;
		private FloorType _floor;
		private DoorType _door;
		private StairsType _stairs;
		

		//Specialized Cell types
		private KeyType _keyType;
		private KittenType _kittenType;
		private ItemType _itemType;


		private bool _startingCell;
		private bool _isBejeweledKitten;
		private bool _isKey;
		private bool _hasItem;

		//if cell contains an item
		private Item _item;

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region [ Properties ]
		//-----------------------------------------------------------------------------------------------------
		// Get and Set for cell object properties
		//-----------------------------------------------------------------------------------------------------
		public Item GetItem
		{
			get { return _item; }
		}

		//-----------------------------------------------------------------------------------------------------

		public ItemType WhatIsItemType
		{
			get { return _itemType; }
		}


		public CellType WhatIsCellType
		{
			get { return _cell; }
			//no external set must be set through ceate methods
		}

		//-----------------------------------------------------------------------------------------------------
		public WallType WhatIsWallType
		{
			get { return _wall; }
			//No external set must call create methode to set type
		}

		//-----------------------------------------------------------------------------------------------------
		public FloorType WhatIsFloorType
		{
			get { return _floor; }
			//No external set must call create methode to set type
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
		}

		//-----------------------------------------------------------------------------------------------------
		public KeyType WhatIsKeyType
		{
			get { return _keyType; }
			//no external set must be set through ceate methods
		}

		//-----------------------------------------------------------------------------------------------------
		public KittenType WhatIsKittenType
		{
			get { return _kittenType; }
		}

		//-----------------------------------------------------------------------------------------------------
		public bool IsStartingCell
		{
			get { return _startingCell; }
			//no external set must call create kitten method
			set { _startingCell = value; }
		}

		//-----------------------------------------------------------------------------------------------------
		public bool IsBejeweledKitten
		{
			get { return _isBejeweledKitten; }
		}

		//-----------------------------------------------------------------------------------------------------
		public bool IsKey
		{
			get { return _isKey; }
		}

		//-----------------------------------------------------------------------------------------------------
		public bool HasItem
		{
			get { return _hasItem; }
		}

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region [ Constructors ]
		//Default Constructor
		//-----------------------------------------------------------------------------------------------------
		public Cell( )
		{
			_cell = CellType.GENERIC;
			_door = DoorType.GENERIC;
			_floor = FloorType.GENERIC;
			_wall = WallType.GENERIC;
			_itemType = ItemType.GENERIC;
			_keyType = KeyType.GENERIC;
			_kittenType = KittenType.GENERIC;
			_stairs = StairsType.GENERIC;
			_hasItem = false;
			_isBejeweledKitten = false;
			_isKey = false;
			_startingCell = false;
			
			
		}

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region  [ Methods ]
		//-----------------------------------------------------------------------------------------------------
		//External acessable methods to set the type of cell in the map array
		//Sets current cell as starting Cell
		//Method to set cell object as starting cell
		//-----------------------------------------------------------------------------------------------------

		private void CreateFloorItem(Item item)
		{
			_cell = CellType.ITEM;
			_floor = FloorType.FLOORITEM;
			_itemType = ItemType.AVAILABLE;
			_hasItem = true;
			_item = item;

		}
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
		public void CreateKey(Item item)
		{
			
			CreateFloorItem(item);

			_keyType = KeyType.AVAILABLE;
			_isKey = true;

		}

		//-----------------------------------------------------------------------------------------------------
		public void CreateBejeweledKitten(Item item )
		{
			CreateFloorItem(item);

			_kittenType = KittenType.AVAILABLE;
			_isBejeweledKitten = true;
			
		}

		//-----------------------------------------------------------------------------------------------------
		public Item PickUpItem( )
		{
			//copy the cells item to a temp var
			Item currentItem = _item;
			

			if(_isKey == true)
			{
				_cell = CellType.FLOOR;
				_keyType = KeyType.PICKEDUP;
				_itemType = ItemType.PICKEDUP;
				_floor = FloorType.FLOORGENERAL;
				_isKey = false;
				_hasItem = false;
			}
			else if(_isBejeweledKitten == true)
			{
				_cell = CellType.FLOOR;
				_kittenType = KittenType.PICKEDUP;
				_itemType = ItemType.PICKEDUP;
				_floor = FloorType.FLOORGENERAL;
				_isBejeweledKitten = false;
				_hasItem = false;
			}
			else
				throw new MemberAccessException("There is no Item in the cell which you are trying to pick something up from.");


			//Empty out the _item var since the item is being picked up
			_item = null;
			//return temp var of cell's item
			return currentItem;
		}

	
		#endregion
		//-----------------------------------------------------------------------------------------------------

		#region [ Overridden Methods ]

		public override string ToString( )
		{
			string cellDescription = "There is a " + Convert.ToString(_cell).ToLower( ) + " that way";
			//TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
			//cellDescription = ti.ToTitleCase(cellDescription);

			switch(_cell)
			{
				case CellType.FLOOR:
					cellDescription += " which is a " + Convert.ToString(_floor).ToLower( ) + ".";
					break;
				case CellType.WALL:
					cellDescription += " which is a " + Convert.ToString(_wall).ToLower( ) + ".";
					break;
				case CellType.DOOR:
					if(_door == DoorType.DOORLOCKED)
						cellDescription += " that is Locked.";
					else if(_door == DoorType.DOORUNLOCKED)
						cellDescription += " That is Unlocked.";
					break;
				case CellType.GENERIC:
					break;
				case CellType.STAIRS:
					cellDescription = "There is a set of " + Convert.ToString(_cell).ToLower( ) + " that way";
					if(_stairs == StairsType.STAIRSUP)
						cellDescription += " which go up.";
					else if(_stairs == StairsType.STAIRSDOWN)
						cellDescription += " which go down.";
					break;

				case CellType.ITEM:
					if(_itemType == ItemType.AVAILABLE)
					{
						if(_isBejeweledKitten)
							cellDescription = "There is a Bejeweled Kitten that way which is " + Convert.ToString(_kittenType).ToLower( ) + ".";
						else if(_isKey)
							cellDescription = "There is a Key that way which is " + Convert.ToString(_keyType).ToLower( ) + ".";
					}
					else if(_itemType == ItemType.PICKEDUP)
						cellDescription += " which you already picked up.";
					break;
				//case CellType.BEJEWELEDKITTEN:
				//	break;
				//case CellType.KEY:
				//	break;
				//default:
				//	break;
			}

			
			return cellDescription;
		}

		#endregion

	}

}



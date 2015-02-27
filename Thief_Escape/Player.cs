//Player class file for group Phiv project
//Created by: Zachary T. Vig
//Created on 02/1/2015

//Merged by : Keegon Cabinaw
//Merged on: 02/15/2015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thief_Escape
{
	class Player
	{
		#region [ Fields ]
		//-----------------------------------------------------------------------------------------------------

		int _currentCellX = 0,
		_currentCellY = 0;

		string _name = null;

		//-----------------------------------------------------------------------------------------------------
		#endregion


		#region [ properties ]
		//-----------------------------------------------------------------------------------------------------

		//public property to pull current cell x
		//-----------------------------------------------------------------------------------------------------
		public int CurrentCellX
		{
			get { return _currentCellX; }
			set { }
		}

		//public property to pull current cell y
		//-----------------------------------------------------------------------------------------------------
		public int CurrentCellY
		{
			get { return _currentCellY; }
			set { }
		}

		//Players Name
		//-----------------------------------------------------------------------------------------------------
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		//Player's Inventory
		//-----------------------------------------------------------------------------------------------------
		public List<Item> Inventory = new List<Item>();

		//-----------------------------------------------------------------------------------------------------
		#endregion


		#region  [ Constructors ]
		//-----------------------------------------------------------------------------------------------------

		//default contructor
		//-----------------------------------------------------------------------------------------------------
		public Player()
		{

		}

		//Constructor with player name propertie
		//-----------------------------------------------------------------------------------------------------
		public Player(string sentname)
		{
			_name = sentname;
		}

		//Constructor with both a name property and an x,y for the current cell
		//-----------------------------------------------------------------------------------------------------
		public Player(string sentName, int x, int y)
		{
			_name = sentName;
			_currentCellX = x;
			_currentCellY = y;
		}
		//-----------------------------------------------------------------------------------------------------
		#endregion
	

		#region [ Methods ]
		//-----------------------------------------------------------------------------------------------------

		//method to set the current players current cell
		//-----------------------------------------------------------------------------------------------------
		public void SetCurrentCell(int x, int y)
		{
			_currentCellX = x;
			_currentCellY = y;
		}

		//-----------------------------------------------------------------------------------------------------
		#endregion
	

	}
}



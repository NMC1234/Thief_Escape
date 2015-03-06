using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thief_Escape
{
	class Item
	{
		//-----------------------------------------------------------------------------------------------------
		#region [ Enums ]
		//-----------------------------------------------------------------------------------------------------
		//Class level enumeration to define the types of the item.
		//-----------------------------------------------------------------------------------------------------
		public enum ItemType
		{
			JewelKitten,
			Key,
			Generic
			//GENERIC is just something to initialize an object to, it is equal to null
		}
		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region [ Fields ]
		//-----------------------------------------------------------------------------------------------------

		//Item's display name
		private string _name;

		//Item''s description
		private string _description;

		//Item's type
		private ItemType _itemType;

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region [ Properties ]
		//-----------------------------------------------------------------------------------------------------

		//Get or set the display name of the object
		//-----------------------------------------------------------------------------------------------------
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		//Get or set the description of the object
		//-----------------------------------------------------------------------------------------------------
		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		//Get or set the item type of the object
		//-----------------------------------------------------------------------------------------------------
		public ItemType itemType
		{
			get { return _itemType; }
			set { _itemType = value; }
		}

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region [ Constructors ]
		//-----------------------------------------------------------------------------------------------------

		//Default constructor, assumes GENERIC
		//-----------------------------------------------------------------------------------------------------
		public Item( )
		{
			itemType = Item.ItemType.Generic;
			Name = "GENERIC Item";
			Description = "Its a perfectly GENERIC... thing.";
		}
		//Overloaded constructor, creates pre-defined items based on type.
		//-----------------------------------------------------------------------------------------------------
		public Item(ItemType type)
		{
			switch(type)
			{
				//Jewel encrusted kitten
				case ItemType.JewelKitten:
					itemType = ItemType.JewelKitten;
					Name = "Jewel Encrusted Kitten";
					Description = "It's a cat made of jewels! So expensive!";
					break;

				//Key
				case ItemType.Key:
					itemType = ItemType.Key;
					Name = "Key";
					Description = "I've been told this opens doors.";
					break;

				//Anything else is a GENERIC item.
				default:
					itemType = Item.ItemType.Generic;
					Name = "GENERIC Item";
					Description = "Its a perfectly GENERIC... thing.";
					break;
			}
		}

		//-----------------------------------------------------------------------------------------------------
		#endregion
		//-----------------------------------------------------------------------------------------------------

		//-----------------------------------------------------------------------------------------------------
		#region [ Methods ]

		public override string ToString( )
		{
			return string.Format("Name: {0} || Item Type: {1} || Description: {2}",
				_name, Convert.ToString(_itemType), _description);
		}
		#endregion
		//-----------------------------------------------------------------------------------------------------
	}
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theif_Escape
{
    class Item
    {
        #region [ Class Enumeration ]


        public enum ItemType
        {
            KITTEN,
            KEY,
            GENERIC

        }


        #endregion


        #region [ Fields ]


        //Item's display name
        private string _name;


        //Item''s description
        private string _description;


        //Item's type
        private ItemType _itemType;


        #endregion


        #region [ Properties ]

        //Get or set the display name of the object
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Get or set the description of the object
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        //Get or set the item type of the object
        public ItemType itemType
        {
            get { return _itemType; }
            set { _itemType = value; }
        }


        #endregion


        #region [ Constructors ]


        //Default constructor, assumes GENERIC
        public Item()
        {
            itemType = Item.ItemType.GENERIC;
            Name = "Generic Item";
            Description = "Its a perfectly Generic... thing.";
        }


        //Overloaded constructor, creates pre-defined items based on type.
        public Item(ItemType type)
        {
            switch (type)
            {
                //Jewel encrusted kitten
                case ItemType.KITTEN:
                    itemType = ItemType.KITTEN;
                    Name = "Jewel Encrusted Kitten";
                    Description = "It's a cat made of jewels! So expensive!";
                    break;

                //Key
                case ItemType.KEY:
                    itemType = ItemType.KEY;
                    Name = "Key";
                    Description = "I've been told this opens doors.";
                    break;

                //Anything else is a GENERIC item.
                default:
                    itemType = Item.ItemType.GENERIC;
                    Name = "Generic Item";
                    Description = "Its a perfectly Generic... thing.";
                    break;
            }
        }


        #endregion


        #region [ Methods ]

        //Return a string based on the Item
        public override string ToString()
        {
            return string.Format("{0} || {1}",
                Name, Description);
        }


        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theif_Escape
{
    class Cell
    {

        #region [ Class Enumerations ]
        //Enumeration of all possible types of the cell.
        public enum Archetypes
        {
            WALL,
            FLOOR,
            DOOR,
            STAIR
        }


        //Enumeration of all possible modifiers for the cell's type.
        public enum Modifiers
        {
            NULL,
            LOCKED,
            UNLOCKED
        }

        //Enumeration of all items possible to be found in a cell.
        public enum Contents
        {
            NULL,
            KEY,
            KITTEN
        }

        #endregion


        #region [ Fields ]

        private Archetypes _archtype;
        private Modifiers _modifier;
        private Contents _contents;
        private Grid.MapFiles _destination;
        private int[] _destinationCoords;

        #endregion


        #region [ Properties ]


        //Gets or sets the Archetype of the cell.
        public Archetypes Archetype
        {
            get { return _archtype; }

            set
            {
                //Change the Archetype
                _archtype = value;

                //Doors and Stairs cannot have Items
                if (value == Archetypes.DOOR | value == Archetypes.STAIR)
                {
                    _contents = Contents.NULL;
                }

                //Doors default to unlocked.
                if (_archtype == Archetypes.DOOR)
                {
                    _modifier = Modifiers.UNLOCKED;
                }

                //Only Doors have modifiers
                if (value != Archetypes.DOOR)
                {
                    _modifier = Modifiers.NULL;
                }
            }
        }


        //Gets or sets the Modifier of the cell.
        public Modifiers Modifier
        {
            get { return _modifier; }

            set
            {
                //If you're changing the modifier...
                if (value != Modifiers.NULL)
                {
                    //...AND the cell is currently a door...
                    if (_archtype == Archetypes.DOOR)
                    {
                        //...then set the modifier.
                        _modifier = value;
                    }

                    //...AND the cell is not a door...
                    else
                    {
                        //...then throw an exception.
                        throw new ArgumentException("Only Cells of ArcheType DOOR can have modifiers.");
                    }
                }

                //If you are clearing the modifier...
                else
                {
                    //...then throw an exception.
                    throw new ArgumentException("Cells of ArcheType DOOR must be LOCKED or UNLOCKED.");
                }
            }
        }


        //Gets or sets the contents of the cell.
        public Contents Content
        {
            get { return _contents; }

            set
            {
                //If your changing the contents...
                if (value != Contents.NULL)
                {
                    //...AND the cell is a Door or a Stair...
                    if (_archtype == Archetypes.DOOR | _archtype == Archetypes.STAIR)
                    {
                        //..Throw an exception
                        throw new ArgumentException("Cells of type DOOR and type STAIR must have Content set to NULL");
                    }
                    //...AND the cell is not a Door or a Stair...
                    else
                    {
                        //...then set the contents.
                        _contents = value;
                    }
                }

                //If your clearing the contents...
                else
                {
                    //...then clear the contents.
                    _contents = value;
                }
            }
        }


        //Gets or sets the destination map of a Stair cell.
        public Grid.MapFiles Destination 
        {
            get { return _destination; }
            set
            {
                if (Archetype == Archetypes.STAIR)
                {
                    _destination = value;
                }
                else
                    throw new ArgumentException("Only stair cells can have a destination.");
            }
        }


        //Gets of sets the destination coordinates of a Stair Cell.
        public int[] DestinationCoords 
        {
            get { return _destinationCoords; }
            set
            {
                if (Archetype == Archetypes.STAIR)
                {
                    _destinationCoords = value;
                }
                else
                    throw new ArgumentException("Only stair cells can  have destination coordinates.");
            }
        }

        #endregion


        #region [ Constructors ]


        //Default Constructor
        public Cell()
        {
            //The Default Cell is an empty floor.
            Archetype = Archetypes.FLOOR;
        }


        //Overloaded Constructor - Allows Definition of ArcheType
        public Cell(Archetypes type)
        {
            Archetype = type;

            //Defaults to 'unlocked' modifier for Door
            if (type == Archetypes.DOOR)
                _modifier = Modifiers.UNLOCKED;

            //Defaults to 'empty' contents for Walls and Floors
            if (type == Archetypes.FLOOR | type == Archetypes.WALL)
                _contents = Contents.NULL;
        }


        //Overloaded Constructor - Allows Definition of ArcheType.DOOR and Modifier
        public Cell(Archetypes type, Modifiers mod)
        {
            Archetype = type;
            Modifier = mod;
        }


        //Overloaded Constructor - Allows Definition of ArcheType and Contents
        public Cell(Archetypes type,Contents item)
        {
            Archetype = type;
            Content = item;
        }


        #endregion
    }
}

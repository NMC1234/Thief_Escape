using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Drawing;

namespace Theif_Escape
{
    public partial class FrmGame : Form
    {
        #region [ Globals ]


        Player player;
        List<Item> Inventory;
        Item key, kitten;
        Grid cellGrid;
        string name;

        //Exit bool is used to prevent unwanted shutdowns 
        //  when going to the main menu.
        bool exit = true;


        #region [ Colors ]

        //  Define the colors for the cells
        Color wallColor = Color.DimGray;
        Color floorColor = Color.White;
        Color doorUnlockedColor = Color.Chocolate;
        Color doorLockedColor = Color.SaddleBrown;
        Color stairColor = Color.Cyan;
        Color kittenColor = Color.Purple;
        Color keyColor = Color.SpringGreen;

        // Define fog color
        Color fogColor = Color.Black;

        #endregion

        #endregion


        #region [ Constructors ]


        //Default constructor
        public FrmGame()
        {
            InitializeComponent();

            //Defaut constructor creates name of "User"
            name = "User";
        }



        // Overloaded FormGame constructor to pass in name from name form
        public FrmGame(string playername)
        {
            InitializeComponent();

            //Change the player name
            name = playername;
        }


        #endregion


        #region [ Form Events ]


        //  Form Closed
        private void FrmGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exit)
                Application.Exit();

        }

        //  Arrow-Key Press handler
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //  Switch on Key press -- This can be used for other keys, currently only handles arrow keys.
            switch (keyData)
            {
                    //  Move west
                case Keys.Left:
                    btnMoveWest.PerformClick();
                    break;

                    //  Move east
                case Keys.Right:
                    btnMoveEast.PerformClick();
                    break;

                    //  Move north
                case Keys.Up:
                    btnMoveNorth.PerformClick();
                    break;

                    //  Move south
                case Keys.Down:
                    btnMoveSouth.PerformClick();
                    break;

                    //  Do nothing
                default:
                    break;

            }
            //  No idea what this does, compiler error if removed.
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //  Form Loaded
        private void FrmGame_Load(object sender, EventArgs e)
        {
            //  Create the Player
            player = new Player(name);

            //  Create Items
            key = new Item(Item.ItemType.KEY);
            kitten = new Item(Item.ItemType.KITTEN);   

            //  Create the Inventory
            Inventory = new List<Item>();
         
            //  Update Inventory Dialog
            UpdateInventory();

            //  Create the Grid
            cellGrid = new Grid(Grid.MapFiles.Test1);

            //  Place the player
            player.SetLocation(cellGrid.StartingCell);
            player.CurrentMap = Grid.MapFiles.Test1;

            //  Make everything black
            InitialFog();

            //  Clear the fog around the player
            ViewArea();

            //  Check Valid Movements
            CheckValidMovements(player.XCoord, player.YCoord);

            //  Initial Prompt
            InitalPrompt();

        }

        //starting dialog
        public void InitalPrompt()
        {
            lstDialog.Items.Add(string.Format("Hello {0}, welcome to the game", name));
            lstDialog.Items.Add("Help Robbie get out of the house with all his treasures!");
            lstDialog.Items.Add("");
        }


        #endregion


        #region [ Menu Button Clicks ]


        //  Load Button
        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            //to-do
            //Planned feature: Load a game from a save file
        }


        //  Save Button
        private void btnSaveGame_Click(object sender, EventArgs e)
        {
            //to-do
            //Planned feature: Save a gamestate to file
        }


        //  Menu Button
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            //Change the exit bool to false;
            exit = false;
            //Load the menu form
            FrmMain frm = new FrmMain();
            frm.Show();

            //Close this form
            this.Close();
        }


        #endregion


        #region [ Movement ]

        #region [ Movement Button Clicks ]

        //  North Button
        private void btnMoveNorth_Click(object sender, EventArgs e)
        {
            //  Move the player North ( y - 1 )
            PlayerMovement(Grid.Direction.NORTH);

        }

        //  East Button
        private void btnMoveEast_Click(object sender, EventArgs e)
        {
            //  Move the player East ( x + 1 )
            PlayerMovement(Grid.Direction.EAST);

        }

        // South Button
        private void btnMoveSouth_Click(object sender, EventArgs e)
        {
            //  Move the player South ( y + 1 )
            PlayerMovement(Grid.Direction.SOUTH);
        }

        //  West Button
        private void btnMoveWest_Click(object sender, EventArgs e)
        {
            //  Move the player West ( x - 1 )
            PlayerMovement(Grid.Direction.WEST);
        }


        #endregion

        #region [ Movement Methods ]


        //Enables or dissables buttons based on the cells surrounding the player
        public void CheckValidMovements(int x, int y)
        {


            //Check the cell north of the player. y - 1
            //  If the cell is a wall, disable movement
            if (cellGrid.CheckType(x, y - 1) == Cell.Archetypes.WALL)
            {
                btnMoveNorth.Enabled = false;
            }
            //  If the cell is a Door and is LOCKED, disable movement
            else if (cellGrid.CheckType(x, y - 1) == Cell.Archetypes.DOOR & cellGrid.CheckDoorModifier(x, y - 1) == Cell.Modifiers.LOCKED)
            {
                btnMoveNorth.Enabled = false;
            }
            //  Everything else can be moved into
            else
            {
                btnMoveNorth.Enabled = true;
            }

            //Check the cell south of the player. y + 1
            //  If the cell is a wall, disable movement
            if (cellGrid.CheckType(x, y + 1) == Cell.Archetypes.WALL)
            {
                btnMoveSouth.Enabled = false;
            }
            //  If the cell is a Door and is LOCKED, disable movement
            else if (cellGrid.CheckType(x, y + 1) == Cell.Archetypes.DOOR & cellGrid.CheckDoorModifier(x, y + 1) == Cell.Modifiers.LOCKED)
            {
                btnMoveSouth.Enabled = false;
            }
            //  Everything else can be moved into
            else
            {
                btnMoveSouth.Enabled = true;
            }
            //Check the cell west of the player. x - 1
            //  If the cell is a wall, disable movement
            if (cellGrid.CheckType(x - 1, y) == Cell.Archetypes.WALL)
            {
                btnMoveWest.Enabled = false;
            }
            //  If the cell is a Door and is LOCKED, disable movement
            else if (cellGrid.CheckType(x - 1, y) == Cell.Archetypes.DOOR & cellGrid.CheckDoorModifier(x - 1, y) == Cell.Modifiers.LOCKED)
            {
                btnMoveWest.Enabled = false;
            }
            //  Everything else can be moved into
            else
            {
                btnMoveWest.Enabled = true;
            }

            //Check the cell east of the player. x + 1
            //  If the cell is a wall, disable movement
            if (cellGrid.CheckType(x + 1, y) == Cell.Archetypes.WALL)
            {
                btnMoveEast.Enabled = false;
            }
            //  If the cell is a Door and is LOCKED, disable movement
            else if (cellGrid.CheckType(x + 1, y) == Cell.Archetypes.DOOR & cellGrid.CheckDoorModifier(x + 1, y) == Cell.Modifiers.LOCKED)
            {
                btnMoveEast.Enabled = false;
            }
            //  Everything else can be moved into
            else
            {
                btnMoveEast.Enabled = true;
            }
        }

        //  Handles all of the player movements - passed in the direction.
        internal void PlayerMovement(Grid.Direction direction)
        {
            //Move the player
            switch (direction)
            {
                case Grid.Direction.NORTH:
                    player.YCoord--;
                    break;
                case Grid.Direction.SOUTH:
                    player.YCoord++;
                    break;
                case Grid.Direction.EAST:
                    player.XCoord++;
                    break;
                case Grid.Direction.WEST:
                    player.XCoord--;
                    break;
            }
            //Clear the fog
            ViewArea();

            //Update the fog
            UpdateFog(direction);

            //Re-validate valid movements.
            CheckValidMovements(player.XCoord, player.YCoord);
        }



        #endregion

        #endregion


        #region [ Actions ]

        #region [ Action Button Clicks ]


        // Pick-up Key Button
        private void btnPickupKey_Click(object sender, EventArgs e)
        {
            int[] keyDetails = CheckForNearbyKey();
            if (keyDetails[0] != 0)
            {
                //  Remove key from grid.
                cellGrid.RemoveItem(keyDetails[1], keyDetails[2]);

                //  Refresh grid.
                ViewArea();

                //  Add a key to the inventory
                Inventory.Add(key);
                UpdateInventory();

                //  Tell user they have picked up a key.
                lstDialog.Items.Add("I have found a Key, I can use this to open doors.");
                lstDialog.SelectedIndex = lstDialog.Items.Count - 1;
                lstDialog.SelectedIndex = -1;
            }
            else
            {
                //  Tell user there is no key nearby.
                lstDialog.Items.Add("There is no key nearby!");
                lstDialog.SelectedIndex = lstDialog.Items.Count - 1;
                lstDialog.SelectedIndex = -1;
            }

            //  Update
            UpdateInventory();
        }


        // Use Key Button
        private void btnUseKey_Click(object sender, EventArgs e)
        {
            bool foundDoor = false;

            //First checks if the player has a key in its inventory
            if (Inventory.Contains<Item>(key))
            {
                //Creates starting point for search, 1 cell up and 1 cell left, centered on the player.
                int x = player.XCoord - 1;
                int y = player.YCoord - 1;


                //Goes through each "column" of the search area
                for (int ix = 0; ix < 3; ix++)
                {
                    //Goes through each "row" of the column
                    for (int iy = 0; iy < 3; iy++)
                    {
                        //If the cell is a door, check if its locked.
                        if (cellGrid.CheckType((x + ix), (y + iy)) == Cell.Archetypes.DOOR)
                        {
                            foundDoor = true;

                            //  Search found a locked door.
                            if (cellGrid.CheckDoorModifier((x + ix), (y + iy)) == Cell.Modifiers.LOCKED)
                            {
                                Inventory.Remove(key);
                                cellGrid.ToggleDoorModifier((x + ix), (y + iy));

                                //Door is now unlocked
                                lstDialog.Items.Add("This door is now unlocked.");
                                lstDialog.SelectedIndex = lstDialog.Items.Count - 1;
                                lstDialog.SelectedIndex = -1;
                            }
                                
                            else
                            {
                                //Door is already unlocked
                                lstDialog.Items.Add("This door is already unlocked.");
                                lstDialog.SelectedIndex = lstDialog.Items.Count - 1;
                                lstDialog.SelectedIndex = -1;
                            }


                        }
                    }
                }
                //  Tell the user there is no door if the search didn't find one.
                if (!foundDoor)
                {
                    lstDialog.Items.Add("I don't see a door near me.");
                    lstDialog.SelectedIndex = lstDialog.Items.Count - 1;
                    lstDialog.SelectedIndex = -1;
                }
            }
            else if (!(Inventory.Contains(key)))
            {
                //  Player does not have key.
                lstDialog.Items.Add("I don't have a key to use.");
                lstDialog.SelectedIndex = lstDialog.Items.Count - 1;
                lstDialog.SelectedIndex = -1;
            }

            //Refresh the map
            ViewArea();

            //Revalidate movements
            CheckValidMovements(player.XCoord, player.YCoord);

            //Update Inventory
            UpdateInventory();
        }


        //  Use Stairs Button
        private void btnUseStairs_Click(object sender, EventArgs e)
        {
            //Check to see if the player is currently standing on stairs.
            if (cellGrid.CheckType(player.XCoord,player.YCoord) == Cell.Archetypes.STAIR)
            {
                // Get the stairs destination
                Grid.MapFiles destination = cellGrid.Destination(player.XCoord, player.YCoord);
                int[] coords = cellGrid.DestinationCoords(player.XCoord, player.YCoord);

                //Fog everything
                InitialFog();

                //  Recreate the grid
                cellGrid = new Grid(destination);

                //Place the player
                player.XCoord = coords[0];
                player.YCoord = coords[1];

                // Refresh the view
                ViewArea();

                //Check new valid movements
                CheckValidMovements(player.XCoord,player.YCoord);

                //Tell the user they have used stairs.
                //  Tell user there not on the stairs
                lstDialog.Items.Add("Those where some tall stairs.");
                lstDialog.SelectedIndex = lstDialog.Items.Count - 1;
                lstDialog.SelectedIndex = -1;
            }

            else
            {
                //  Tell user there not on the stairs
                lstDialog.Items.Add("I have to be on the stairs to use them.");
                lstDialog.SelectedIndex = lstDialog.Items.Count - 1;
                lstDialog.SelectedIndex = -1;
            }
        }
        #endregion

        #region [ Action Methods ]

        private int[] CheckForNearbyKey()
        {
            //The array defined as (bool,x-coord,y-coord). Bool is 0-false 1-true, with default of false.
            int[] result = { 0, 0, 0 };

            //Creates starting point for search, 1 cell up and 1 cell left, centered on the player.
            int x = player.XCoord - 1;
            int y = player.YCoord - 1;

            //Goes through each "column" of the search area
            for (int ix = 0; ix < 3; ix++)
            {
                //Goes through each "row" of the column
                for (int iy = 0; iy < 3; iy++)
                {
                    //If the cell has a key, return true.
                    if (cellGrid.CheckForItem((x + ix), (y + iy)) == Cell.Contents.KEY)
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

        private void UpdateInventory()
        {
            //  Clear the current inventory dialog
            lstInventory.Items.Clear();

            // If the inventory is not empty
            if (Inventory.Count != 0)
            {
                //  Return the string of each item in the inventory 
                foreach (Item inv in Inventory)
                {
                    lstInventory.Items.Add(inv.ToString());
                    lstInventory.Items.Add(" ");

                }
            }
            else
            {
                //Dialog message for empty inventory.
                lstInventory.Items.Add("I've got some mighty fine lint in my pocket.");
            }
        }

        #endregion

        #endregion


        #region [ Image Map ]


        //Clears the fog and refreshes colors in a 5x5 square, centered on the players location
        public void ViewArea()
        {

            //  Get lower and upper Grid Bounds of the Clear, with validations to limit values.
            #region [ Bounds ]
            //      Northern Bound ( y - 2 )
            int lowerY = player.YCoord - 2;
            if (lowerY < 0)
                lowerY = 0;

            //      Southern Bound ( y + 2 )
            int upperY = player.YCoord + 2;
            if (upperY > cellGrid.MapSize - 1)
                upperY = cellGrid.MapSize - 1;

            //      Eastern Bound ( x + 2 )
            int upperX = player.XCoord + 2;
            if (upperX > cellGrid.MapSize - 1)
                upperX = cellGrid.MapSize - 1;

            //      Western Bound ( x - 2 )
            int lowerX = player.XCoord - 2;
            if (lowerX < 0)
                lowerX = 0;
            #endregion

            //  NOTE :: The Grid and the Map have flipped X and Y values, as well as the Map being indented X+1 and Y+1 from the Grid.

            //  For-loop through each 'column' of the Grid ( 'row' of the Map), starting at the lowerX bound and stopping at the upperX bound
            for (int x = lowerX; x <= upperX; x++)
            {
                //  For-loop through each 'row' of the Grid ( 'column' of the Map), starting at the lowerY bound and stopping at the upperY bound
                for (int y = lowerY; y <= upperY; y++)
                {
                    //Clear the face from the cell
                    grdconMap[y + 1, x + 1].Text = "";

                    //  Get the Archetype of the cell
                    Cell.Archetypes type = cellGrid.CheckType(x, y);

                    //  Switch on the Archetype - Get details as needed to continue switching.
                    switch (type)
                    {
                        // Walls - can contain Items
                        #region  [ Wall Switching ]


                        case Cell.Archetypes.WALL:
                            {
                                //Get contents
                                Cell.Contents cont = cellGrid.CheckForItem(x, y);

                                //  Switch on Contents
                                switch (cont)
                                {
                                    case Cell.Contents.NULL:
                                        {
                                            grdconMap[y + 1, x + 1].BackColor = wallColor;
                                        }
                                        break;
                                    case Cell.Contents.KEY:
                                        {
                                            grdconMap[y + 1, x + 1].BackColor = keyColor;
                                        }
                                        break;
                                    case Cell.Contents.KITTEN:
                                        {
                                            grdconMap[y + 1, x + 1].BackColor = kittenColor;
                                        }
                                        break;
                                }

                            }
                            break;


                        #endregion


                        //  Floors - can contain Items
                        #region [ Floor Switching ]
                        case Cell.Archetypes.FLOOR:
                            {
                                //Get contents
                                Cell.Contents cont = cellGrid.CheckForItem(x, y);

                                //Switch on Contents
                                switch (cont)
                                {
                                    case Cell.Contents.NULL:
                                        {
                                            grdconMap[y + 1, x + 1].BackColor = floorColor;
                                        }
                                        break;
                                    case Cell.Contents.KEY:
                                        {
                                            grdconMap[y + 1, x + 1].BackColor = keyColor;
                                        }
                                        break;
                                    case Cell.Contents.KITTEN:
                                        {
                                            grdconMap[y + 1, x + 1].BackColor = kittenColor;
                                        }
                                        break;
                                }

                            }
                            break;
                        #endregion


                        //  Doors - have a modifier
                        #region [ Door Switching ]
                        case Cell.Archetypes.DOOR:
                            {
                                //Get Modifier
                                Cell.Modifiers mod = cellGrid.CheckDoorModifier(x, y);

                                //Switch on Modifier
                                switch (mod)
                                {
                                    case Cell.Modifiers.LOCKED:
                                        {
                                            grdconMap[y + 1, x + 1].BackColor = doorLockedColor;
                                        }
                                        break;
                                    case Cell.Modifiers.UNLOCKED:
                                        {
                                            grdconMap[y + 1, x + 1].BackColor = doorUnlockedColor;
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                            break;

                        #endregion


                        //  Stairs - have no other values
                        case Cell.Archetypes.STAIR:
                            {
                                grdconMap[y + 1, x + 1].BackColor = stairColor;
                            }
                            break;

                    }
                }
            }


            //  Set the player cell text
            grdconMap[player.YCoord + 1, player.XCoord + 1].Text = "☺";

        }


        //Simply sets everything in the map to black
        public void InitialFog()
        {
            //Get the max range of the cellGrid
            int maxRange = cellGrid.MapSize + 1;


            //For loop to process each cell in the cellGrid and set the color appropriately.
            for (int x = 1; x < maxRange; x++)
            {
                for (int y = 1; y < maxRange; y++)
                {
                    grdconMap[y, x].BackColor = fogColor;
                }
            }
        }


        //Return the fog to the area no longer revealed. - CALL AFTER THE PLAYER HAS BEEN MOVED
        internal void UpdateFog(Grid.Direction direction)
        {
            //Get the players new position
            int x = player.XCoord;
            int y = player.YCoord;

            switch (direction)
            {
                #region [ North ]
                case Grid.Direction.NORTH:
                    {
                        //Gets the lower and upper X bounds for the fog, validating for grid index.
                        //  lower X
                        int lowerX = player.XCoord - 2;
                        if (lowerX < 0)
                            lowerX = 0;
                        //  upper X
                        int upperX = player.XCoord + 2;
                        if (upperX > cellGrid.MapSize - 1)
                            upperX = cellGrid.MapSize - 1;

                        //Gets the Y coord for the line, breaking if coord is out of index
                        int YLine = player.YCoord + 3;

                        if (YLine < 0 | YLine > (cellGrid.MapSize - 1))
                        {
                            break;
                        }

                        //For-loops through each cell, turning it black.
                        for (int i = lowerX; i <= upperX; i++)
                        {
                            grdconMap[YLine + 1, i + 1].BackColor = fogColor;
                        }
                    }
                    break;
                #endregion


                #region [ South ]
                case Grid.Direction.SOUTH:
                    {
                        //Gets the lower and upper X bounds for the fog, validating for grid index.
                        //  lower X
                        int lowerX = player.XCoord - 2;
                        if (lowerX < 0)
                            lowerX = 0;
                        //  upper X
                        int upperX = player.XCoord + 2;
                        if (upperX > cellGrid.MapSize - 1)
                            upperX = cellGrid.MapSize - 1;

                        //Gets the Y coord for the line, breaking if coord is out of index
                        int YLine = player.YCoord - 3;

                        if (YLine < 0 | YLine > (cellGrid.MapSize - 1))
                        {
                            break;
                        }

                        //For-loops through each cell, turning it black.
                        for (int i = lowerX; i <= upperX; i++)
                        {
                            grdconMap[YLine + 1, i + 1].BackColor = fogColor;
                        }
                    }
                    break;
                #endregion


                #region [ East ]
                case Grid.Direction.EAST:
                    {
                        //Gets the lower and upper Y bounds for the fog, validating for grid index.
                        //  lower Y
                        int lowerY = player.YCoord - 2;
                        if (lowerY < 0)
                            lowerY = 0;
                        //  upper Y
                        int upperY = player.YCoord + 2;
                        if (upperY > cellGrid.MapSize - 1)
                            upperY = cellGrid.MapSize - 1;

                        //Gets the X coord for the line, breaking if coord is out of index
                        int XLine = player.XCoord - 3;

                        if (XLine < 0 | XLine > (cellGrid.MapSize - 1))
                        {
                            break;
                        }

                        //For-loops through each cell, turning it black.
                        for (int i = lowerY; i <= upperY; i++)
                        {
                            grdconMap[i + 1, XLine + 1].BackColor = fogColor;
                        }
                    }
                    break;
                #endregion


                #region [ West ]
                case Grid.Direction.WEST:
                    {
                        //Gets the lower and upper Y bounds for the fog, validating for grid index.
                        //  lower Y
                        int lowerY = player.YCoord - 2;
                        if (lowerY < 0)
                            lowerY = 0;
                        //  upper Y
                        int upperY = player.YCoord + 2;
                        if (upperY > cellGrid.MapSize - 1)
                            upperY = cellGrid.MapSize - 1;

                        //Gets the X coord for the line, breaking if coord is out of index
                        int XLine = player.XCoord + 3;

                        if (XLine < 0 | XLine > (cellGrid.MapSize - 1))
                        {
                            break;
                        }

                        //For-loops through each cell, turning it black.
                        for (int i = lowerY; i <= upperY; i++)
                        {
                            grdconMap[i + 1, XLine + 1].BackColor = fogColor;
                        }
                    }
                    break;
                #endregion
            }
        }



        #endregion



    }
}

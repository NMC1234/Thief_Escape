namespace Theif_Escape
{
    partial class FrmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle5 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle6 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle7 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle8 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle4 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle5 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle6 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            this.grpboxLegend = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBejeweledKitten = new System.Windows.Forms.TextBox();
            this.lblStairs = new System.Windows.Forms.Label();
            this.txtStairsUp = new System.Windows.Forms.TextBox();
            this.lblCurrentCell = new System.Windows.Forms.Label();
            this.txtCurrentCell = new System.Windows.Forms.TextBox();
            this.lblDoorOpen = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDoorLocked = new System.Windows.Forms.Label();
            this.txtDoorLocked = new System.Windows.Forms.TextBox();
            this.lblFloors = new System.Windows.Forms.Label();
            this.txtFloors = new System.Windows.Forms.TextBox();
            this.lblWall = new System.Windows.Forms.Label();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnAction6 = new System.Windows.Forms.Button();
            this.btnAction5 = new System.Windows.Forms.Button();
            this.btnUseKey = new System.Windows.Forms.Button();
            this.btnUseStairs = new System.Windows.Forms.Button();
            this.btnAction2 = new System.Windows.Forms.Button();
            this.btnPickupKey = new System.Windows.Forms.Button();
            this.grpMovement = new System.Windows.Forms.GroupBox();
            this.btnMoveWest = new System.Windows.Forms.Button();
            this.btnMoveEast = new System.Windows.Forms.Button();
            this.btnMoveSouth = new System.Windows.Forms.Button();
            this.btnMoveNorth = new System.Windows.Forms.Button();
            this.tabDialog = new System.Windows.Forms.TabControl();
            this.tabDialogs = new System.Windows.Forms.TabPage();
            this.lstDialog = new System.Windows.Forms.ListBox();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.lstInventory = new System.Windows.Forms.ListBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnSaveGame = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.grdconMap = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.grpboxLegend.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpMovement.SuspendLayout();
            this.tabDialog.SuspendLayout();
            this.tabDialogs.SuspendLayout();
            this.tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdconMap)).BeginInit();
            this.SuspendLayout();
            // 
            // grpboxLegend
            // 
            this.grpboxLegend.Controls.Add(this.textBox2);
            this.grpboxLegend.Controls.Add(this.lblKey);
            this.grpboxLegend.Controls.Add(this.txtKey);
            this.grpboxLegend.Controls.Add(this.label2);
            this.grpboxLegend.Controls.Add(this.txtBejeweledKitten);
            this.grpboxLegend.Controls.Add(this.lblStairs);
            this.grpboxLegend.Controls.Add(this.txtStairsUp);
            this.grpboxLegend.Controls.Add(this.lblCurrentCell);
            this.grpboxLegend.Controls.Add(this.txtCurrentCell);
            this.grpboxLegend.Controls.Add(this.lblDoorOpen);
            this.grpboxLegend.Controls.Add(this.textBox1);
            this.grpboxLegend.Controls.Add(this.lblDoorLocked);
            this.grpboxLegend.Controls.Add(this.txtDoorLocked);
            this.grpboxLegend.Controls.Add(this.lblFloors);
            this.grpboxLegend.Controls.Add(this.txtFloors);
            this.grpboxLegend.Controls.Add(this.lblWall);
            this.grpboxLegend.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpboxLegend.Location = new System.Drawing.Point(679, 14);
            this.grpboxLegend.Name = "grpboxLegend";
            this.grpboxLegend.Size = new System.Drawing.Size(128, 279);
            this.grpboxLegend.TabIndex = 14;
            this.grpboxLegend.TabStop = false;
            this.grpboxLegend.Text = "Legend";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DimGray;
            this.textBox2.Location = new System.Drawing.Point(6, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(21, 20);
            this.textBox2.TabIndex = 20;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(33, 203);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(31, 13);
            this.lblKey.TabIndex = 19;
            this.lblKey.Text = "- Key";
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.Color.SpringGreen;
            this.txtKey.Location = new System.Drawing.Point(6, 200);
            this.txtKey.Name = "txtKey";
            this.txtKey.ReadOnly = true;
            this.txtKey.Size = new System.Drawing.Size(21, 20);
            this.txtKey.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "- Bejeweled Kitten";
            // 
            // txtBejeweledKitten
            // 
            this.txtBejeweledKitten.BackColor = System.Drawing.Color.Purple;
            this.txtBejeweledKitten.Location = new System.Drawing.Point(6, 174);
            this.txtBejeweledKitten.Name = "txtBejeweledKitten";
            this.txtBejeweledKitten.ReadOnly = true;
            this.txtBejeweledKitten.Size = new System.Drawing.Size(21, 20);
            this.txtBejeweledKitten.TabIndex = 16;
            // 
            // lblStairs
            // 
            this.lblStairs.AutoSize = true;
            this.lblStairs.Location = new System.Drawing.Point(28, 104);
            this.lblStairs.Name = "lblStairs";
            this.lblStairs.Size = new System.Drawing.Size(39, 13);
            this.lblStairs.TabIndex = 13;
            this.lblStairs.Text = "- Stairs";
            // 
            // txtStairsUp
            // 
            this.txtStairsUp.BackColor = System.Drawing.Color.Cyan;
            this.txtStairsUp.Location = new System.Drawing.Point(6, 97);
            this.txtStairsUp.Name = "txtStairsUp";
            this.txtStairsUp.ReadOnly = true;
            this.txtStairsUp.Size = new System.Drawing.Size(21, 20);
            this.txtStairsUp.TabIndex = 12;
            // 
            // lblCurrentCell
            // 
            this.lblCurrentCell.AutoSize = true;
            this.lblCurrentCell.Location = new System.Drawing.Point(28, 22);
            this.lblCurrentCell.Name = "lblCurrentCell";
            this.lblCurrentCell.Size = new System.Drawing.Size(67, 13);
            this.lblCurrentCell.TabIndex = 11;
            this.lblCurrentCell.Text = "- Current Cell";
            // 
            // txtCurrentCell
            // 
            this.txtCurrentCell.BackColor = System.Drawing.Color.Orange;
            this.txtCurrentCell.Location = new System.Drawing.Point(6, 19);
            this.txtCurrentCell.Name = "txtCurrentCell";
            this.txtCurrentCell.ReadOnly = true;
            this.txtCurrentCell.Size = new System.Drawing.Size(21, 20);
            this.txtCurrentCell.TabIndex = 10;
            // 
            // lblDoorOpen
            // 
            this.lblDoorOpen.AutoSize = true;
            this.lblDoorOpen.Location = new System.Drawing.Point(28, 151);
            this.lblDoorOpen.Name = "lblDoorOpen";
            this.lblDoorOpen.Size = new System.Drawing.Size(85, 13);
            this.lblDoorOpen.TabIndex = 9;
            this.lblDoorOpen.Text = "- Door Unlocked";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Chocolate;
            this.textBox1.Location = new System.Drawing.Point(6, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(21, 20);
            this.textBox1.TabIndex = 8;
            // 
            // lblDoorLocked
            // 
            this.lblDoorLocked.AutoSize = true;
            this.lblDoorLocked.Location = new System.Drawing.Point(28, 126);
            this.lblDoorLocked.Name = "lblDoorLocked";
            this.lblDoorLocked.Size = new System.Drawing.Size(75, 13);
            this.lblDoorLocked.TabIndex = 7;
            this.lblDoorLocked.Text = "- Door Locked";
            // 
            // txtDoorLocked
            // 
            this.txtDoorLocked.BackColor = System.Drawing.Color.SaddleBrown;
            this.txtDoorLocked.Location = new System.Drawing.Point(6, 123);
            this.txtDoorLocked.Name = "txtDoorLocked";
            this.txtDoorLocked.ReadOnly = true;
            this.txtDoorLocked.Size = new System.Drawing.Size(21, 20);
            this.txtDoorLocked.TabIndex = 6;
            // 
            // lblFloors
            // 
            this.lblFloors.AutoSize = true;
            this.lblFloors.Location = new System.Drawing.Point(28, 74);
            this.lblFloors.Name = "lblFloors";
            this.lblFloors.Size = new System.Drawing.Size(41, 13);
            this.lblFloors.TabIndex = 3;
            this.lblFloors.Text = "- Floors";
            // 
            // txtFloors
            // 
            this.txtFloors.BackColor = System.Drawing.Color.White;
            this.txtFloors.Location = new System.Drawing.Point(6, 71);
            this.txtFloors.Name = "txtFloors";
            this.txtFloors.ReadOnly = true;
            this.txtFloors.Size = new System.Drawing.Size(21, 20);
            this.txtFloors.TabIndex = 2;
            // 
            // lblWall
            // 
            this.lblWall.AutoSize = true;
            this.lblWall.Location = new System.Drawing.Point(28, 48);
            this.lblWall.Name = "lblWall";
            this.lblWall.Size = new System.Drawing.Size(39, 13);
            this.lblWall.TabIndex = 1;
            this.lblWall.Text = "- Walls";
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnAction6);
            this.grpActions.Controls.Add(this.btnAction5);
            this.grpActions.Controls.Add(this.btnUseKey);
            this.grpActions.Controls.Add(this.btnUseStairs);
            this.grpActions.Controls.Add(this.btnAction2);
            this.grpActions.Controls.Add(this.btnPickupKey);
            this.grpActions.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpActions.Location = new System.Drawing.Point(817, 70);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(283, 142);
            this.grpActions.TabIndex = 15;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            // 
            // btnAction6
            // 
            this.btnAction6.BackColor = System.Drawing.Color.DarkGray;
            this.btnAction6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction6.Location = new System.Drawing.Point(184, 75);
            this.btnAction6.Name = "btnAction6";
            this.btnAction6.Size = new System.Drawing.Size(74, 50);
            this.btnAction6.TabIndex = 9;
            this.btnAction6.Text = "Action 6";
            this.btnAction6.UseVisualStyleBackColor = false;
            // 
            // btnAction5
            // 
            this.btnAction5.BackColor = System.Drawing.Color.DarkGray;
            this.btnAction5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction5.Location = new System.Drawing.Point(103, 75);
            this.btnAction5.Name = "btnAction5";
            this.btnAction5.Size = new System.Drawing.Size(74, 50);
            this.btnAction5.TabIndex = 8;
            this.btnAction5.Text = "Action 5";
            this.btnAction5.UseVisualStyleBackColor = false;
            // 
            // btnUseKey
            // 
            this.btnUseKey.BackColor = System.Drawing.Color.DarkGray;
            this.btnUseKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseKey.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnUseKey.Location = new System.Drawing.Point(22, 75);
            this.btnUseKey.Name = "btnUseKey";
            this.btnUseKey.Size = new System.Drawing.Size(74, 50);
            this.btnUseKey.TabIndex = 7;
            this.btnUseKey.Text = "Use Key";
            this.btnUseKey.UseVisualStyleBackColor = false;
            this.btnUseKey.Click += new System.EventHandler(this.btnUseKey_Click);
            // 
            // btnUseStairs
            // 
            this.btnUseStairs.BackColor = System.Drawing.Color.DarkGray;
            this.btnUseStairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseStairs.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnUseStairs.Location = new System.Drawing.Point(184, 19);
            this.btnUseStairs.Name = "btnUseStairs";
            this.btnUseStairs.Size = new System.Drawing.Size(74, 50);
            this.btnUseStairs.TabIndex = 6;
            this.btnUseStairs.Text = "Use Stairs";
            this.btnUseStairs.UseVisualStyleBackColor = false;
            this.btnUseStairs.Click += new System.EventHandler(this.btnUseStairs_Click);
            // 
            // btnAction2
            // 
            this.btnAction2.BackColor = System.Drawing.Color.DarkGray;
            this.btnAction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction2.Location = new System.Drawing.Point(103, 19);
            this.btnAction2.Name = "btnAction2";
            this.btnAction2.Size = new System.Drawing.Size(74, 50);
            this.btnAction2.TabIndex = 5;
            this.btnAction2.Text = "Action 2";
            this.btnAction2.UseVisualStyleBackColor = false;
            // 
            // btnPickupKey
            // 
            this.btnPickupKey.BackColor = System.Drawing.Color.DarkGray;
            this.btnPickupKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPickupKey.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnPickupKey.Location = new System.Drawing.Point(22, 19);
            this.btnPickupKey.Name = "btnPickupKey";
            this.btnPickupKey.Size = new System.Drawing.Size(74, 50);
            this.btnPickupKey.TabIndex = 4;
            this.btnPickupKey.Text = "Pickup Key";
            this.btnPickupKey.UseVisualStyleBackColor = false;
            this.btnPickupKey.Click += new System.EventHandler(this.btnPickupKey_Click);
            // 
            // grpMovement
            // 
            this.grpMovement.BackColor = System.Drawing.Color.Transparent;
            this.grpMovement.Controls.Add(this.btnMoveWest);
            this.grpMovement.Controls.Add(this.btnMoveEast);
            this.grpMovement.Controls.Add(this.btnMoveSouth);
            this.grpMovement.Controls.Add(this.btnMoveNorth);
            this.grpMovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMovement.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpMovement.Location = new System.Drawing.Point(817, 224);
            this.grpMovement.Name = "grpMovement";
            this.grpMovement.Size = new System.Drawing.Size(283, 147);
            this.grpMovement.TabIndex = 16;
            this.grpMovement.TabStop = false;
            this.grpMovement.Text = "Movement";
            // 
            // btnMoveWest
            // 
            this.btnMoveWest.BackColor = System.Drawing.Color.DarkGray;
            this.btnMoveWest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveWest.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnMoveWest.Location = new System.Drawing.Point(21, 48);
            this.btnMoveWest.Name = "btnMoveWest";
            this.btnMoveWest.Size = new System.Drawing.Size(75, 50);
            this.btnMoveWest.TabIndex = 3;
            this.btnMoveWest.Text = "West";
            this.btnMoveWest.UseVisualStyleBackColor = false;
            this.btnMoveWest.Click += new System.EventHandler(this.btnMoveWest_Click);
            // 
            // btnMoveEast
            // 
            this.btnMoveEast.BackColor = System.Drawing.Color.DarkGray;
            this.btnMoveEast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveEast.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnMoveEast.Location = new System.Drawing.Point(183, 48);
            this.btnMoveEast.Name = "btnMoveEast";
            this.btnMoveEast.Size = new System.Drawing.Size(75, 50);
            this.btnMoveEast.TabIndex = 2;
            this.btnMoveEast.Text = "East";
            this.btnMoveEast.UseVisualStyleBackColor = false;
            this.btnMoveEast.Click += new System.EventHandler(this.btnMoveEast_Click);
            // 
            // btnMoveSouth
            // 
            this.btnMoveSouth.BackColor = System.Drawing.Color.DarkGray;
            this.btnMoveSouth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveSouth.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnMoveSouth.Location = new System.Drawing.Point(102, 75);
            this.btnMoveSouth.Name = "btnMoveSouth";
            this.btnMoveSouth.Size = new System.Drawing.Size(75, 50);
            this.btnMoveSouth.TabIndex = 1;
            this.btnMoveSouth.Text = "South";
            this.btnMoveSouth.UseVisualStyleBackColor = false;
            this.btnMoveSouth.Click += new System.EventHandler(this.btnMoveSouth_Click);
            // 
            // btnMoveNorth
            // 
            this.btnMoveNorth.BackColor = System.Drawing.Color.DarkGray;
            this.btnMoveNorth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveNorth.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnMoveNorth.Location = new System.Drawing.Point(102, 19);
            this.btnMoveNorth.Name = "btnMoveNorth";
            this.btnMoveNorth.Size = new System.Drawing.Size(75, 50);
            this.btnMoveNorth.TabIndex = 0;
            this.btnMoveNorth.Text = "North";
            this.btnMoveNorth.UseVisualStyleBackColor = false;
            this.btnMoveNorth.Click += new System.EventHandler(this.btnMoveNorth_Click);
            // 
            // tabDialog
            // 
            this.tabDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDialog.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabDialog.Controls.Add(this.tabDialogs);
            this.tabDialog.Controls.Add(this.tabInventory);
            this.tabDialog.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDialog.Location = new System.Drawing.Point(679, 393);
            this.tabDialog.Name = "tabDialog";
            this.tabDialog.SelectedIndex = 0;
            this.tabDialog.Size = new System.Drawing.Size(421, 248);
            this.tabDialog.TabIndex = 17;
            // 
            // tabDialogs
            // 
            this.tabDialogs.BackColor = System.Drawing.Color.DarkKhaki;
            this.tabDialogs.Controls.Add(this.lstDialog);
            this.tabDialogs.ForeColor = System.Drawing.Color.Black;
            this.tabDialogs.Location = new System.Drawing.Point(4, 30);
            this.tabDialogs.Name = "tabDialogs";
            this.tabDialogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabDialogs.Size = new System.Drawing.Size(413, 214);
            this.tabDialogs.TabIndex = 0;
            this.tabDialogs.Text = "Dialog";
            // 
            // lstDialog
            // 
            this.lstDialog.BackColor = System.Drawing.Color.DarkKhaki;
            this.lstDialog.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDialog.FormattingEnabled = true;
            this.lstDialog.ItemHeight = 19;
            this.lstDialog.Location = new System.Drawing.Point(6, 6);
            this.lstDialog.Name = "lstDialog";
            this.lstDialog.Size = new System.Drawing.Size(407, 213);
            this.lstDialog.TabIndex = 9;
            // 
            // tabInventory
            // 
            this.tabInventory.BackColor = System.Drawing.Color.DarkKhaki;
            this.tabInventory.Controls.Add(this.lstInventory);
            this.tabInventory.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInventory.ForeColor = System.Drawing.Color.Black;
            this.tabInventory.Location = new System.Drawing.Point(4, 30);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Size = new System.Drawing.Size(413, 214);
            this.tabInventory.TabIndex = 2;
            this.tabInventory.Text = "Inventory";
            // 
            // lstInventory
            // 
            this.lstInventory.BackColor = System.Drawing.Color.DarkKhaki;
            this.lstInventory.FormattingEnabled = true;
            this.lstInventory.ItemHeight = 15;
            this.lstInventory.Location = new System.Drawing.Point(4, 4);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(409, 214);
            this.lstInventory.TabIndex = 0;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.DarkGray;
            this.btnMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMainMenu.Location = new System.Drawing.Point(1014, 12);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(82, 50);
            this.btnMainMenu.TabIndex = 18;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnSaveGame
            // 
            this.btnSaveGame.BackColor = System.Drawing.Color.DarkGray;
            this.btnSaveGame.Cursor = System.Windows.Forms.Cursors.No;
            this.btnSaveGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGame.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveGame.Location = new System.Drawing.Point(919, 12);
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.Size = new System.Drawing.Size(82, 50);
            this.btnSaveGame.TabIndex = 19;
            this.btnSaveGame.Text = "Save Game";
            this.btnSaveGame.UseVisualStyleBackColor = false;
            this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.BackColor = System.Drawing.Color.DarkGray;
            this.btnLoadGame.Cursor = System.Windows.Forms.Cursors.No;
            this.btnLoadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadGame.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLoadGame.Location = new System.Drawing.Point(831, 12);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(82, 50);
            this.btnLoadGame.TabIndex = 20;
            this.btnLoadGame.Text = "Load Game";
            this.btnLoadGame.UseVisualStyleBackColor = false;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // grdconMap
            // 
            this.grdconMap.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this.grdconMap.AllowIncreaseSmallChange = false;
            this.grdconMap.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            this.grdconMap.BackColor = System.Drawing.Color.Black;
            gridBaseStyle5.Name = "Header";
            gridBaseStyle5.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle5.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle5.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle5.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle5.StyleInfo.CellType = "Header";
            gridBaseStyle5.StyleInfo.Font.Bold = true;
            gridBaseStyle5.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle5.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle6.Name = "Standard";
            gridBaseStyle6.StyleInfo.Font.Facename = "Tahoma";
            gridBaseStyle6.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle7.Name = "Column Header";
            gridBaseStyle7.StyleInfo.BaseStyle = "Header";
            gridBaseStyle7.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle8.Name = "Row Header";
            gridBaseStyle8.StyleInfo.BaseStyle = "Header";
            gridBaseStyle8.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle8.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            this.grdconMap.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle5,
            gridBaseStyle6,
            gridBaseStyle7,
            gridBaseStyle8});
            this.grdconMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdconMap.ColCount = 24;
            this.grdconMap.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)});
            this.grdconMap.DefaultColWidth = 26;
            this.grdconMap.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Dashed;
            this.grdconMap.DefaultRowHeight = 26;
            this.grdconMap.DrawOrder = Syncfusion.Windows.Forms.Grid.GridDrawOrder.Columns;
            this.grdconMap.EnterKeyBehavior = Syncfusion.Windows.Forms.Grid.GridDirectionType.None;
            this.grdconMap.Font = new System.Drawing.Font("Arial", 15F);
            this.grdconMap.HorizontalThumbTrack = true;
            this.grdconMap.HScrollPixel = true;
            this.grdconMap.IsSpreadsheetFillSeries = false;
            this.grdconMap.Location = new System.Drawing.Point(12, 12);
            this.grdconMap.MinimumSize = new System.Drawing.Size(600, 400);
            this.grdconMap.Name = "grdconMap";
            this.grdconMap.NumberedColHeaders = false;
            this.grdconMap.NumberedRowHeaders = false;
            this.grdconMap.Properties.BackgroundColor = System.Drawing.Color.Black;
            this.grdconMap.Properties.ColHeaders = false;
            this.grdconMap.Properties.ForceImmediateRepaint = false;
            this.grdconMap.Properties.GridLineColor = System.Drawing.Color.Black;
            this.grdconMap.Properties.MarkColHeader = false;
            this.grdconMap.Properties.MarkRowHeader = false;
            this.grdconMap.Properties.RowHeaders = false;
            gridRangeStyle4.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle4.StyleInfo.Font.Bold = false;
            gridRangeStyle4.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle4.StyleInfo.Font.Italic = false;
            gridRangeStyle4.StyleInfo.Font.Size = 15F;
            gridRangeStyle4.StyleInfo.Font.Strikeout = false;
            gridRangeStyle4.StyleInfo.Font.Underline = false;
            gridRangeStyle4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle5.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle5.StyleInfo.Font.Bold = false;
            gridRangeStyle5.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle5.StyleInfo.Font.Italic = false;
            gridRangeStyle5.StyleInfo.Font.Size = 15F;
            gridRangeStyle5.StyleInfo.Font.Strikeout = false;
            gridRangeStyle5.StyleInfo.Font.Underline = false;
            gridRangeStyle5.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle6.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle6.StyleInfo.Font.Bold = false;
            gridRangeStyle6.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle6.StyleInfo.Font.Italic = false;
            gridRangeStyle6.StyleInfo.Font.Size = 15F;
            gridRangeStyle6.StyleInfo.Font.Strikeout = false;
            gridRangeStyle6.StyleInfo.Font.Underline = false;
            gridRangeStyle6.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            this.grdconMap.RangeStyles.AddRange(new Syncfusion.Windows.Forms.Grid.GridRangeStyle[] {
            gridRangeStyle4,
            gridRangeStyle5,
            gridRangeStyle6});
            this.grdconMap.ResizeColsBehavior = Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.None;
            this.grdconMap.ResizeRowsBehavior = Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.None;
            this.grdconMap.RowCount = 24;
            this.grdconMap.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 25)});
            this.grdconMap.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.grdconMap.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.grdconMap.Size = new System.Drawing.Size(629, 629);
            this.grdconMap.SmartSizeBox = false;
            this.grdconMap.SpreadsheetLikeSelection = false;
            this.grdconMap.TabIndex = 21;
            this.grdconMap.Text = "Map";
            this.grdconMap.UseRightToLeftCompatibleTextBox = true;
            this.grdconMap.VerticalThumbTrack = true;
            this.grdconMap.VScrollPixel = true;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1112, 653);
            this.Controls.Add(this.grdconMap);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btnSaveGame);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.tabDialog);
            this.Controls.Add(this.grpMovement);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpboxLegend);
            this.MinimumSize = new System.Drawing.Size(590, 430);
            this.Name = "FrmGame";
            this.Text = "Thief-Escape - Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGame_FormClosed);
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.grpboxLegend.ResumeLayout(false);
            this.grpboxLegend.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpMovement.ResumeLayout(false);
            this.tabDialog.ResumeLayout(false);
            this.tabDialogs.ResumeLayout(false);
            this.tabInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdconMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxLegend;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBejeweledKitten;
        private System.Windows.Forms.Label lblStairs;
        private System.Windows.Forms.TextBox txtStairsUp;
        private System.Windows.Forms.Label lblCurrentCell;
        private System.Windows.Forms.TextBox txtCurrentCell;
        private System.Windows.Forms.Label lblDoorOpen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDoorLocked;
        private System.Windows.Forms.TextBox txtDoorLocked;
        private System.Windows.Forms.Label lblFloors;
        private System.Windows.Forms.TextBox txtFloors;
        private System.Windows.Forms.Label lblWall;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnAction6;
        private System.Windows.Forms.Button btnAction5;
        private System.Windows.Forms.Button btnUseKey;
        private System.Windows.Forms.Button btnUseStairs;
        private System.Windows.Forms.Button btnAction2;
        private System.Windows.Forms.Button btnPickupKey;
        private System.Windows.Forms.GroupBox grpMovement;
        private System.Windows.Forms.Button btnMoveWest;
        private System.Windows.Forms.Button btnMoveEast;
        private System.Windows.Forms.Button btnMoveSouth;
        private System.Windows.Forms.Button btnMoveNorth;
        private System.Windows.Forms.TabControl tabDialog;
        private System.Windows.Forms.TabPage tabDialogs;
        private System.Windows.Forms.ListBox lstDialog;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.ListBox lstInventory;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnSaveGame;
        private System.Windows.Forms.Button btnLoadGame;
        private Syncfusion.Windows.Forms.Grid.GridControl grdconMap;
    }
}
namespace Thief_Escape
{
    partial class FormGame
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
			this.components = new System.ComponentModel.Container();
			Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle41 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
			Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle42 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
			Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle43 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
			Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle44 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
			this.lstOutput = new System.Windows.Forms.ListBox();
			this.grpMovement = new System.Windows.Forms.GroupBox();
			this.btnMoveWest = new System.Windows.Forms.Button();
			this.btnMoveEast = new System.Windows.Forms.Button();
			this.btnMoveSouth = new System.Windows.Forms.Button();
			this.btnMoveNorth = new System.Windows.Forms.Button();
			this.grpActions = new System.Windows.Forms.GroupBox();
			this.btnAction6 = new System.Windows.Forms.Button();
			this.btnAction5 = new System.Windows.Forms.Button();
			this.btnUseKey = new System.Windows.Forms.Button();
			this.btnAction3 = new System.Windows.Forms.Button();
			this.btnAction2 = new System.Windows.Forms.Button();
			this.btnPickupKey = new System.Windows.Forms.Button();
			this.btnMainMenu = new System.Windows.Forms.Button();
			this.btnSaveGame = new System.Windows.Forms.Button();
			this.btnLoadGame = new System.Windows.Forms.Button();
			this.lstDialog = new System.Windows.Forms.ListBox();
			this.grpboxLegend = new System.Windows.Forms.GroupBox();
			this.lblKey = new System.Windows.Forms.Label();
			this.txtKey = new System.Windows.Forms.TextBox();
			this.picbWallImage = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBejeweledKitten = new System.Windows.Forms.TextBox();
			this.lblStairsDown = new System.Windows.Forms.Label();
			this.txtStairsDown = new System.Windows.Forms.TextBox();
			this.lblStairsUp = new System.Windows.Forms.Label();
			this.txtStairsUp = new System.Windows.Forms.TextBox();
			this.lblCurrentCell = new System.Windows.Forms.Label();
			this.txtCurrentCell = new System.Windows.Forms.TextBox();
			this.lblDoorOpen = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lblDoorLocked = new System.Windows.Forms.Label();
			this.txtDoorLocked = new System.Windows.Forms.TextBox();
			this.lblStarting = new System.Windows.Forms.Label();
			this.txtStarting = new System.Windows.Forms.TextBox();
			this.lblFloors = new System.Windows.Forms.Label();
			this.txtFloors = new System.Windows.Forms.TextBox();
			this.lblWall = new System.Windows.Forms.Label();
			this.grdconMap = new Syncfusion.Windows.Forms.Grid.GridControl();
			this.tmrCellBlink = new System.Windows.Forms.Timer(this.components);
			this.tabDialog = new System.Windows.Forms.TabControl();
			this.tabDialogs = new System.Windows.Forms.TabPage();
			this.tabDirection = new System.Windows.Forms.TabPage();
			this.tabInventory = new System.Windows.Forms.TabPage();
			this.lstInventory = new System.Windows.Forms.ListBox();
			this.lblNumberOfKeys = new System.Windows.Forms.Label();
			this.txtNumberOfKeys = new System.Windows.Forms.TextBox();
			this.txtNumberOfKittens = new System.Windows.Forms.TextBox();
			this.lblNumberOfKittens = new System.Windows.Forms.Label();
			this.grpMovement.SuspendLayout();
			this.grpActions.SuspendLayout();
			this.grpboxLegend.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picbWallImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdconMap)).BeginInit();
			this.tabDialog.SuspendLayout();
			this.tabDialogs.SuspendLayout();
			this.tabDirection.SuspendLayout();
			this.tabInventory.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstOutput
			// 
			this.lstOutput.BackColor = System.Drawing.Color.DarkKhaki;
			this.lstOutput.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstOutput.FormattingEnabled = true;
			this.lstOutput.HorizontalScrollbar = true;
			this.lstOutput.ItemHeight = 15;
			this.lstOutput.Location = new System.Drawing.Point(0, 0);
			this.lstOutput.Name = "lstOutput";
			this.lstOutput.Size = new System.Drawing.Size(444, 259);
			this.lstOutput.TabIndex = 0;
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
			this.grpMovement.Location = new System.Drawing.Point(819, 198);
			this.grpMovement.Name = "grpMovement";
			this.grpMovement.Size = new System.Drawing.Size(283, 130);
			this.grpMovement.TabIndex = 0;
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
			this.btnMoveWest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrimaryKeyDownEvent);
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
			this.btnMoveEast.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrimaryKeyDownEvent);
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
			this.btnMoveSouth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrimaryKeyDownEvent);
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
			this.btnMoveNorth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrimaryKeyDownEvent);
			// 
			// grpActions
			// 
			this.grpActions.Controls.Add(this.btnAction6);
			this.grpActions.Controls.Add(this.btnAction5);
			this.grpActions.Controls.Add(this.btnUseKey);
			this.grpActions.Controls.Add(this.btnAction3);
			this.grpActions.Controls.Add(this.btnAction2);
			this.grpActions.Controls.Add(this.btnPickupKey);
			this.grpActions.ForeColor = System.Drawing.Color.MidnightBlue;
			this.grpActions.Location = new System.Drawing.Point(819, 63);
			this.grpActions.Name = "grpActions";
			this.grpActions.Size = new System.Drawing.Size(283, 129);
			this.grpActions.TabIndex = 1;
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
			this.btnAction6.Click += new System.EventHandler(this.btnAction6_Click);
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
			this.btnAction5.Click += new System.EventHandler(this.btnAction5_Click);
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
			this.btnUseKey.Text = "Use &Key";
			this.btnUseKey.UseVisualStyleBackColor = false;
			this.btnUseKey.Click += new System.EventHandler(this.btnUseKey_Click);
			this.btnUseKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrimaryKeyDownEvent);
			// 
			// btnAction3
			// 
			this.btnAction3.BackColor = System.Drawing.Color.DarkGray;
			this.btnAction3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAction3.Location = new System.Drawing.Point(184, 19);
			this.btnAction3.Name = "btnAction3";
			this.btnAction3.Size = new System.Drawing.Size(74, 50);
			this.btnAction3.TabIndex = 6;
			this.btnAction3.Text = "Action 3";
			this.btnAction3.UseVisualStyleBackColor = false;
			this.btnAction3.Click += new System.EventHandler(this.btnAction3_Click);
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
			this.btnAction2.Click += new System.EventHandler(this.btnAction2_Click);
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
			this.btnPickupKey.Text = "&Pickup Key";
			this.btnPickupKey.UseVisualStyleBackColor = false;
			this.btnPickupKey.Click += new System.EventHandler(this.btnPickupKey_Click);
			this.btnPickupKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrimaryKeyDownEvent);
			// 
			// btnMainMenu
			// 
			this.btnMainMenu.BackColor = System.Drawing.Color.DarkGray;
			this.btnMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMainMenu.ForeColor = System.Drawing.Color.MidnightBlue;
			this.btnMainMenu.Location = new System.Drawing.Point(844, 7);
			this.btnMainMenu.Name = "btnMainMenu";
			this.btnMainMenu.Size = new System.Drawing.Size(82, 50);
			this.btnMainMenu.TabIndex = 2;
			this.btnMainMenu.Text = "Main Menu";
			this.btnMainMenu.UseVisualStyleBackColor = false;
			this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
			this.btnMainMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrimaryKeyDownEvent);
			// 
			// btnSaveGame
			// 
			this.btnSaveGame.BackColor = System.Drawing.Color.DarkGray;
			this.btnSaveGame.Cursor = System.Windows.Forms.Cursors.No;
			this.btnSaveGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveGame.ForeColor = System.Drawing.Color.MidnightBlue;
			this.btnSaveGame.Location = new System.Drawing.Point(932, 7);
			this.btnSaveGame.Name = "btnSaveGame";
			this.btnSaveGame.Size = new System.Drawing.Size(82, 50);
			this.btnSaveGame.TabIndex = 3;
			this.btnSaveGame.Text = "Save Game";
			this.btnSaveGame.UseVisualStyleBackColor = false;
			this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
			this.btnSaveGame.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrimaryKeyDownEvent);
			// 
			// btnLoadGame
			// 
			this.btnLoadGame.BackColor = System.Drawing.Color.DarkGray;
			this.btnLoadGame.Cursor = System.Windows.Forms.Cursors.No;
			this.btnLoadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLoadGame.ForeColor = System.Drawing.Color.MidnightBlue;
			this.btnLoadGame.Location = new System.Drawing.Point(1020, 7);
			this.btnLoadGame.Name = "btnLoadGame";
			this.btnLoadGame.Size = new System.Drawing.Size(82, 50);
			this.btnLoadGame.TabIndex = 4;
			this.btnLoadGame.Text = "Load Game";
			this.btnLoadGame.UseVisualStyleBackColor = false;
			this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
			this.btnLoadGame.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrimaryKeyDownEvent);
			// 
			// lstDialog
			// 
			this.lstDialog.BackColor = System.Drawing.Color.DarkKhaki;
			this.lstDialog.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstDialog.FormattingEnabled = true;
			this.lstDialog.ItemHeight = 15;
			this.lstDialog.Location = new System.Drawing.Point(0, 3);
			this.lstDialog.Name = "lstDialog";
			this.lstDialog.Size = new System.Drawing.Size(444, 259);
			this.lstDialog.TabIndex = 9;
			// 
			// grpboxLegend
			// 
			this.grpboxLegend.Controls.Add(this.lblKey);
			this.grpboxLegend.Controls.Add(this.txtKey);
			this.grpboxLegend.Controls.Add(this.picbWallImage);
			this.grpboxLegend.Controls.Add(this.label2);
			this.grpboxLegend.Controls.Add(this.txtBejeweledKitten);
			this.grpboxLegend.Controls.Add(this.lblStairsDown);
			this.grpboxLegend.Controls.Add(this.txtStairsDown);
			this.grpboxLegend.Controls.Add(this.lblStairsUp);
			this.grpboxLegend.Controls.Add(this.txtStairsUp);
			this.grpboxLegend.Controls.Add(this.lblCurrentCell);
			this.grpboxLegend.Controls.Add(this.txtCurrentCell);
			this.grpboxLegend.Controls.Add(this.lblDoorOpen);
			this.grpboxLegend.Controls.Add(this.textBox1);
			this.grpboxLegend.Controls.Add(this.lblDoorLocked);
			this.grpboxLegend.Controls.Add(this.txtDoorLocked);
			this.grpboxLegend.Controls.Add(this.lblStarting);
			this.grpboxLegend.Controls.Add(this.txtStarting);
			this.grpboxLegend.Controls.Add(this.lblFloors);
			this.grpboxLegend.Controls.Add(this.txtFloors);
			this.grpboxLegend.Controls.Add(this.lblWall);
			this.grpboxLegend.ForeColor = System.Drawing.Color.MidnightBlue;
			this.grpboxLegend.Location = new System.Drawing.Point(650, 12);
			this.grpboxLegend.Name = "grpboxLegend";
			this.grpboxLegend.Size = new System.Drawing.Size(128, 279);
			this.grpboxLegend.TabIndex = 6;
			this.grpboxLegend.TabStop = false;
			this.grpboxLegend.Text = "Legend";
			// 
			// lblKey
			// 
			this.lblKey.AutoSize = true;
			this.lblKey.Location = new System.Drawing.Point(28, 255);
			this.lblKey.Name = "lblKey";
			this.lblKey.Size = new System.Drawing.Size(31, 13);
			this.lblKey.TabIndex = 19;
			this.lblKey.Text = "- Key";
			// 
			// txtKey
			// 
			this.txtKey.BackColor = System.Drawing.Color.SpringGreen;
			this.txtKey.Location = new System.Drawing.Point(6, 252);
			this.txtKey.Name = "txtKey";
			this.txtKey.ReadOnly = true;
			this.txtKey.Size = new System.Drawing.Size(21, 20);
			this.txtKey.TabIndex = 18;
			// 
			// picbWallImage
			// 
			this.picbWallImage.Image = global::Thief_Escape.Properties.Resources.CellWallImage;
			this.picbWallImage.Location = new System.Drawing.Point(6, 45);
			this.picbWallImage.Name = "picbWallImage";
			this.picbWallImage.Size = new System.Drawing.Size(21, 20);
			this.picbWallImage.TabIndex = 14;
			this.picbWallImage.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 229);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "- Bejeweled Kitten";
			// 
			// txtBejeweledKitten
			// 
			this.txtBejeweledKitten.BackColor = System.Drawing.Color.Purple;
			this.txtBejeweledKitten.Location = new System.Drawing.Point(6, 226);
			this.txtBejeweledKitten.Name = "txtBejeweledKitten";
			this.txtBejeweledKitten.ReadOnly = true;
			this.txtBejeweledKitten.Size = new System.Drawing.Size(21, 20);
			this.txtBejeweledKitten.TabIndex = 16;
			// 
			// lblStairsDown
			// 
			this.lblStairsDown.AutoSize = true;
			this.lblStairsDown.Location = new System.Drawing.Point(28, 203);
			this.lblStairsDown.Name = "lblStairsDown";
			this.lblStairsDown.Size = new System.Drawing.Size(83, 13);
			this.lblStairsDown.TabIndex = 15;
			this.lblStairsDown.Text = "- STAIRS Down";
			// 
			// txtStairsDown
			// 
			this.txtStairsDown.BackColor = System.Drawing.Color.Salmon;
			this.txtStairsDown.Location = new System.Drawing.Point(6, 200);
			this.txtStairsDown.Name = "txtStairsDown";
			this.txtStairsDown.ReadOnly = true;
			this.txtStairsDown.Size = new System.Drawing.Size(21, 20);
			this.txtStairsDown.TabIndex = 14;
			// 
			// lblStairsUp
			// 
			this.lblStairsUp.AutoSize = true;
			this.lblStairsUp.Location = new System.Drawing.Point(28, 177);
			this.lblStairsUp.Name = "lblStairsUp";
			this.lblStairsUp.Size = new System.Drawing.Size(69, 13);
			this.lblStairsUp.TabIndex = 13;
			this.lblStairsUp.Text = "- STAIRS Up";
			// 
			// txtStairsUp
			// 
			this.txtStairsUp.BackColor = System.Drawing.Color.Cyan;
			this.txtStairsUp.Location = new System.Drawing.Point(6, 174);
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
			this.lblDoorOpen.Size = new System.Drawing.Size(94, 13);
			this.lblDoorOpen.TabIndex = 9;
			this.lblDoorOpen.Text = "- DOOR Unlocked";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Blue;
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
			this.lblDoorLocked.Size = new System.Drawing.Size(84, 13);
			this.lblDoorLocked.TabIndex = 7;
			this.lblDoorLocked.Text = "- DOOR Locked";
			// 
			// txtDoorLocked
			// 
			this.txtDoorLocked.BackColor = System.Drawing.Color.Red;
			this.txtDoorLocked.Location = new System.Drawing.Point(6, 123);
			this.txtDoorLocked.Name = "txtDoorLocked";
			this.txtDoorLocked.ReadOnly = true;
			this.txtDoorLocked.Size = new System.Drawing.Size(21, 20);
			this.txtDoorLocked.TabIndex = 6;
			// 
			// lblStarting
			// 
			this.lblStarting.AutoSize = true;
			this.lblStarting.Location = new System.Drawing.Point(28, 100);
			this.lblStarting.Name = "lblStarting";
			this.lblStarting.Size = new System.Drawing.Size(55, 13);
			this.lblStarting.TabIndex = 5;
			this.lblStarting.Text = "- Start Cell";
			// 
			// txtStarting
			// 
			this.txtStarting.BackColor = System.Drawing.Color.DarkGreen;
			this.txtStarting.Location = new System.Drawing.Point(6, 97);
			this.txtStarting.Name = "txtStarting";
			this.txtStarting.ReadOnly = true;
			this.txtStarting.Size = new System.Drawing.Size(21, 20);
			this.txtStarting.TabIndex = 4;
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
			// grdconMap
			// 
			this.grdconMap.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
			this.grdconMap.AllowIncreaseSmallChange = false;
			this.grdconMap.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
			this.grdconMap.BackColor = System.Drawing.Color.Black;
			gridBaseStyle41.Name = "Header";
			gridBaseStyle41.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
			gridBaseStyle41.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
			gridBaseStyle41.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
			gridBaseStyle41.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
			gridBaseStyle41.StyleInfo.CellType = "Header";
			gridBaseStyle41.StyleInfo.Font.Bold = true;
			gridBaseStyle41.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
			gridBaseStyle41.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
			gridBaseStyle42.Name = "Standard";
			gridBaseStyle42.StyleInfo.Font.Facename = "Tahoma";
			gridBaseStyle42.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
			gridBaseStyle43.Name = "Column Header";
			gridBaseStyle43.StyleInfo.BaseStyle = "Header";
			gridBaseStyle43.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
			gridBaseStyle44.Name = "Row Header";
			gridBaseStyle44.StyleInfo.BaseStyle = "Header";
			gridBaseStyle44.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
			gridBaseStyle44.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
			this.grdconMap.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle41,
            gridBaseStyle42,
            gridBaseStyle43,
            gridBaseStyle44});
			this.grdconMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grdconMap.ColCount = 24;
			this.grdconMap.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)});
			this.grdconMap.DefaultColWidth = 26;
			this.grdconMap.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
			this.grdconMap.DefaultRowHeight = 26;
			this.grdconMap.DragSelectedCellsMouseButtonsMask = System.Windows.Forms.MouseButtons.None;
			this.grdconMap.DrawOrder = Syncfusion.Windows.Forms.Grid.GridDrawOrder.Columns;
			this.grdconMap.EnterKeyBehavior = Syncfusion.Windows.Forms.Grid.GridDirectionType.None;
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
			this.grdconMap.Properties.DisplayHorzLines = false;
			this.grdconMap.Properties.DisplayVertLines = false;
			this.grdconMap.Properties.ForceImmediateRepaint = false;
			this.grdconMap.Properties.MarkColHeader = false;
			this.grdconMap.Properties.MarkRowHeader = false;
			this.grdconMap.Properties.RowHeaders = false;
			this.grdconMap.ResizeColsBehavior = Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.None;
			this.grdconMap.ResizeRowsBehavior = Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.None;
			this.grdconMap.RowCount = 24;
			this.grdconMap.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 25)});
			this.grdconMap.SelectCellsMouseButtonsMask = System.Windows.Forms.MouseButtons.None;
			this.grdconMap.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
			this.grdconMap.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
			this.grdconMap.Size = new System.Drawing.Size(632, 629);
			this.grdconMap.SmartSizeBox = false;
			this.grdconMap.SpreadsheetLikeSelection = false;
			this.grdconMap.TabIndex = 7;
			this.grdconMap.Text = "Map";
			this.grdconMap.UnHideColsOnDblClick = false;
			this.grdconMap.UseRightToLeftCompatibleTextBox = true;
			this.grdconMap.VerticalThumbTrack = true;
			this.grdconMap.VScrollPixel = true;
			this.grdconMap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrimaryKeyDownEvent);
			// 
			// tmrCellBlink
			// 
			this.tmrCellBlink.Enabled = true;
			this.tmrCellBlink.Interval = 500;
			this.tmrCellBlink.Tick += new System.EventHandler(this.tmrCellBlink_Tick);
			// 
			// tabDialog
			// 
			this.tabDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tabDialog.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.tabDialog.Controls.Add(this.tabDialogs);
			this.tabDialog.Controls.Add(this.tabDirection);
			this.tabDialog.Controls.Add(this.tabInventory);
			this.tabDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabDialog.Location = new System.Drawing.Point(650, 334);
			this.tabDialog.Name = "tabDialog";
			this.tabDialog.SelectedIndex = 0;
			this.tabDialog.Size = new System.Drawing.Size(452, 307);
			this.tabDialog.TabIndex = 5;
			// 
			// tabDialogs
			// 
			this.tabDialogs.BackColor = System.Drawing.Color.DarkKhaki;
			this.tabDialogs.Controls.Add(this.lstDialog);
			this.tabDialogs.ForeColor = System.Drawing.Color.Black;
			this.tabDialogs.Location = new System.Drawing.Point(4, 28);
			this.tabDialogs.Name = "tabDialogs";
			this.tabDialogs.Padding = new System.Windows.Forms.Padding(3);
			this.tabDialogs.Size = new System.Drawing.Size(444, 275);
			this.tabDialogs.TabIndex = 0;
			this.tabDialogs.Text = "Dialog";
			// 
			// tabDirection
			// 
			this.tabDirection.BackColor = System.Drawing.Color.DarkKhaki;
			this.tabDirection.Controls.Add(this.lstOutput);
			this.tabDirection.ForeColor = System.Drawing.Color.Black;
			this.tabDirection.Location = new System.Drawing.Point(4, 28);
			this.tabDirection.Name = "tabDirection";
			this.tabDirection.Padding = new System.Windows.Forms.Padding(3);
			this.tabDirection.Size = new System.Drawing.Size(444, 275);
			this.tabDirection.TabIndex = 1;
			this.tabDirection.Text = "Directional Help";
			// 
			// tabInventory
			// 
			this.tabInventory.BackColor = System.Drawing.Color.DarkKhaki;
			this.tabInventory.Controls.Add(this.txtNumberOfKittens);
			this.tabInventory.Controls.Add(this.lblNumberOfKittens);
			this.tabInventory.Controls.Add(this.txtNumberOfKeys);
			this.tabInventory.Controls.Add(this.lblNumberOfKeys);
			this.tabInventory.Controls.Add(this.lstInventory);
			this.tabInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabInventory.ForeColor = System.Drawing.Color.Black;
			this.tabInventory.Location = new System.Drawing.Point(4, 28);
			this.tabInventory.Name = "tabInventory";
			this.tabInventory.Size = new System.Drawing.Size(444, 275);
			this.tabInventory.TabIndex = 2;
			this.tabInventory.Text = "Inventory";
			// 
			// lstInventory
			// 
			this.lstInventory.BackColor = System.Drawing.Color.DarkKhaki;
			this.lstInventory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstInventory.FormattingEnabled = true;
			this.lstInventory.HorizontalScrollbar = true;
			this.lstInventory.ItemHeight = 15;
			this.lstInventory.Location = new System.Drawing.Point(0, 27);
			this.lstInventory.Name = "lstInventory";
			this.lstInventory.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.lstInventory.Size = new System.Drawing.Size(444, 244);
			this.lstInventory.TabIndex = 0;
			// 
			// lblNumberOfKeys
			// 
			this.lblNumberOfKeys.AutoSize = true;
			this.lblNumberOfKeys.Location = new System.Drawing.Point(315, 6);
			this.lblNumberOfKeys.Name = "lblNumberOfKeys";
			this.lblNumberOfKeys.Size = new System.Drawing.Size(99, 16);
			this.lblNumberOfKeys.TabIndex = 1;
			this.lblNumberOfKeys.Text = "Total # of Keys:";
			// 
			// txtNumberOfKeys
			// 
			this.txtNumberOfKeys.BackColor = System.Drawing.Color.DarkGray;
			this.txtNumberOfKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumberOfKeys.ForeColor = System.Drawing.Color.Black;
			this.txtNumberOfKeys.Location = new System.Drawing.Point(410, 3);
			this.txtNumberOfKeys.Name = "txtNumberOfKeys";
			this.txtNumberOfKeys.ReadOnly = true;
			this.txtNumberOfKeys.Size = new System.Drawing.Size(31, 23);
			this.txtNumberOfKeys.TabIndex = 2;
			this.txtNumberOfKeys.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtNumberOfKittens
			// 
			this.txtNumberOfKittens.BackColor = System.Drawing.Color.DarkGray;
			this.txtNumberOfKittens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumberOfKittens.ForeColor = System.Drawing.Color.Black;
			this.txtNumberOfKittens.Location = new System.Drawing.Point(241, 3);
			this.txtNumberOfKittens.Name = "txtNumberOfKittens";
			this.txtNumberOfKittens.ReadOnly = true;
			this.txtNumberOfKittens.Size = new System.Drawing.Size(31, 23);
			this.txtNumberOfKittens.TabIndex = 4;
			this.txtNumberOfKittens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblNumberOfKittens
			// 
			this.lblNumberOfKittens.AutoSize = true;
			this.lblNumberOfKittens.Location = new System.Drawing.Point(72, 6);
			this.lblNumberOfKittens.Name = "lblNumberOfKittens";
			this.lblNumberOfKittens.Size = new System.Drawing.Size(175, 16);
			this.lblNumberOfKittens.TabIndex = 3;
			this.lblNumberOfKittens.Text = "Total # of Bejeweled Kittens:";
			// 
			// FormGame
			// 
			this.AcceptButton = this.btnLoadGame;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.DarkKhaki;
			this.CancelButton = this.btnMainMenu;
			this.ClientSize = new System.Drawing.Size(1112, 653);
			this.Controls.Add(this.tabDialog);
			this.Controls.Add(this.grpboxLegend);
			this.Controls.Add(this.grdconMap);
			this.Controls.Add(this.btnLoadGame);
			this.Controls.Add(this.btnSaveGame);
			this.Controls.Add(this.btnMainMenu);
			this.Controls.Add(this.grpActions);
			this.Controls.Add(this.grpMovement);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(590, 430);
			this.Name = "FormGame";
			this.Text = "Game Screen";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGame_FormClosed);
			this.Load += new System.EventHandler(this.FormGamePlay_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrimaryKeyDownEvent);
			this.grpMovement.ResumeLayout(false);
			this.grpActions.ResumeLayout(false);
			this.grpboxLegend.ResumeLayout(false);
			this.grpboxLegend.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picbWallImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdconMap)).EndInit();
			this.tabDialog.ResumeLayout(false);
			this.tabDialogs.ResumeLayout(false);
			this.tabDirection.ResumeLayout(false);
			this.tabInventory.ResumeLayout(false);
			this.tabInventory.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.GroupBox grpMovement;
        private System.Windows.Forms.Button btnMoveWest;
        private System.Windows.Forms.Button btnMoveEast;
        private System.Windows.Forms.Button btnMoveSouth;
        private System.Windows.Forms.Button btnMoveNorth;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnAction6;
        private System.Windows.Forms.Button btnAction5;
        private System.Windows.Forms.Button btnUseKey;
        private System.Windows.Forms.Button btnAction3;
        private System.Windows.Forms.Button btnAction2;
        private System.Windows.Forms.Button btnPickupKey;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnSaveGame;
		private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.ListBox lstDialog;
		private System.Windows.Forms.GroupBox grpboxLegend;
		private System.Windows.Forms.Label lblStairsUp;
		private System.Windows.Forms.TextBox txtStairsUp;
		private System.Windows.Forms.Label lblCurrentCell;
		private System.Windows.Forms.TextBox txtCurrentCell;
		private System.Windows.Forms.Label lblDoorOpen;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblDoorLocked;
		private System.Windows.Forms.TextBox txtDoorLocked;
		private System.Windows.Forms.Label lblStarting;
		private System.Windows.Forms.TextBox txtStarting;
		private System.Windows.Forms.Label lblFloors;
		private System.Windows.Forms.TextBox txtFloors;
		private System.Windows.Forms.Label lblWall;
		private Syncfusion.Windows.Forms.Grid.GridControl grdconMap;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBejeweledKitten;
		private System.Windows.Forms.Label lblStairsDown;
		private System.Windows.Forms.TextBox txtStairsDown;
		private System.Windows.Forms.Timer tmrCellBlink;
		private System.Windows.Forms.PictureBox picbWallImage;
        private System.Windows.Forms.TabControl tabDialog;
        private System.Windows.Forms.TabPage tabDialogs;
        private System.Windows.Forms.TabPage tabDirection;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.ListBox lstInventory;
		private System.Windows.Forms.Label lblKey;
		private System.Windows.Forms.TextBox txtKey;
		private System.Windows.Forms.TextBox txtNumberOfKittens;
		private System.Windows.Forms.Label lblNumberOfKittens;
		private System.Windows.Forms.TextBox txtNumberOfKeys;
		private System.Windows.Forms.Label lblNumberOfKeys;
    }
}
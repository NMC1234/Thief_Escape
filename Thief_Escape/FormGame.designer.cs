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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
			this.lstOutput = new System.Windows.Forms.ListBox();
			this.grpMovement = new System.Windows.Forms.GroupBox();
			this.btnMoveWest = new System.Windows.Forms.Button();
			this.btnMoveEast = new System.Windows.Forms.Button();
			this.btnMoveSouth = new System.Windows.Forms.Button();
			this.btnMoveNorth = new System.Windows.Forms.Button();
			this.grpActions = new System.Windows.Forms.GroupBox();
			this.btnAction6 = new System.Windows.Forms.Button();
			this.btnAction5 = new System.Windows.Forms.Button();
			this.btnAction4 = new System.Windows.Forms.Button();
			this.btnAction3 = new System.Windows.Forms.Button();
			this.btnAction2 = new System.Windows.Forms.Button();
			this.btnAction1 = new System.Windows.Forms.Button();
			this.btnMainMenu = new System.Windows.Forms.Button();
			this.btnSaveGame = new System.Windows.Forms.Button();
			this.btnLoadGame = new System.Windows.Forms.Button();
			this.lblMenuHover = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lstDialog = new System.Windows.Forms.ListBox();
			this.lblDialog = new System.Windows.Forms.Label();
			this.grpboxLegend = new System.Windows.Forms.GroupBox();
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
			this.txtWalls = new System.Windows.Forms.TextBox();
			this.grdconMap = new Syncfusion.Windows.Forms.Grid.GridControl();
			this.tmrCellBlink = new System.Windows.Forms.Timer(this.components);
			this.grpMovement.SuspendLayout();
			this.grpActions.SuspendLayout();
			this.grpboxLegend.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdconMap)).BeginInit();
			this.SuspendLayout();
			// 
			// lstOutput
			// 
			this.lstOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lstOutput.BackColor = System.Drawing.Color.Silver;
			this.lstOutput.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstOutput.FormattingEnabled = true;
			this.lstOutput.ItemHeight = 19;
			this.lstOutput.Location = new System.Drawing.Point(483, 691);
			this.lstOutput.Name = "lstOutput";
			this.lstOutput.Size = new System.Drawing.Size(442, 156);
			this.lstOutput.TabIndex = 0;
			// 
			// grpMovement
			// 
			this.grpMovement.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.grpMovement.Controls.Add(this.btnMoveWest);
			this.grpMovement.Controls.Add(this.btnMoveEast);
			this.grpMovement.Controls.Add(this.btnMoveSouth);
			this.grpMovement.Controls.Add(this.btnMoveNorth);
			this.grpMovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpMovement.Location = new System.Drawing.Point(642, 519);
			this.grpMovement.Name = "grpMovement";
			this.grpMovement.Size = new System.Drawing.Size(283, 147);
			this.grpMovement.TabIndex = 1;
			this.grpMovement.TabStop = false;
			this.grpMovement.Text = "Movement";
			// 
			// btnMoveWest
			// 
			this.btnMoveWest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoveWest.BackgroundImage")));
			this.btnMoveWest.Location = new System.Drawing.Point(21, 48);
			this.btnMoveWest.Name = "btnMoveWest";
			this.btnMoveWest.Size = new System.Drawing.Size(75, 50);
			this.btnMoveWest.TabIndex = 3;
			this.btnMoveWest.Text = "West";
			this.btnMoveWest.UseVisualStyleBackColor = true;
			this.btnMoveWest.Click += new System.EventHandler(this.btnMoveWest_Click);
			// 
			// btnMoveEast
			// 
			this.btnMoveEast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoveEast.BackgroundImage")));
			this.btnMoveEast.Location = new System.Drawing.Point(183, 48);
			this.btnMoveEast.Name = "btnMoveEast";
			this.btnMoveEast.Size = new System.Drawing.Size(75, 50);
			this.btnMoveEast.TabIndex = 2;
			this.btnMoveEast.Text = "East";
			this.btnMoveEast.UseVisualStyleBackColor = true;
			this.btnMoveEast.Click += new System.EventHandler(this.btnMoveEast_Click);
			// 
			// btnMoveSouth
			// 
			this.btnMoveSouth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoveSouth.BackgroundImage")));
			this.btnMoveSouth.Location = new System.Drawing.Point(102, 75);
			this.btnMoveSouth.Name = "btnMoveSouth";
			this.btnMoveSouth.Size = new System.Drawing.Size(75, 50);
			this.btnMoveSouth.TabIndex = 1;
			this.btnMoveSouth.Text = "South";
			this.btnMoveSouth.UseVisualStyleBackColor = true;
			this.btnMoveSouth.Click += new System.EventHandler(this.btnMoveSouth_Click);
			// 
			// btnMoveNorth
			// 
			this.btnMoveNorth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoveNorth.BackgroundImage")));
			this.btnMoveNorth.Location = new System.Drawing.Point(102, 19);
			this.btnMoveNorth.Name = "btnMoveNorth";
			this.btnMoveNorth.Size = new System.Drawing.Size(75, 50);
			this.btnMoveNorth.TabIndex = 0;
			this.btnMoveNorth.Text = "North";
			this.btnMoveNorth.UseVisualStyleBackColor = true;
			this.btnMoveNorth.Click += new System.EventHandler(this.btnMoveNorth_Click);
			// 
			// grpActions
			// 
			this.grpActions.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.grpActions.Controls.Add(this.btnAction6);
			this.grpActions.Controls.Add(this.btnAction5);
			this.grpActions.Controls.Add(this.btnAction4);
			this.grpActions.Controls.Add(this.btnAction3);
			this.grpActions.Controls.Add(this.btnAction2);
			this.grpActions.Controls.Add(this.btnAction1);
			this.grpActions.Location = new System.Drawing.Point(16, 519);
			this.grpActions.Name = "grpActions";
			this.grpActions.Size = new System.Drawing.Size(283, 142);
			this.grpActions.TabIndex = 2;
			this.grpActions.TabStop = false;
			this.grpActions.Text = "Actions";
			// 
			// btnAction6
			// 
			this.btnAction6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAction6.BackgroundImage")));
			this.btnAction6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAction6.Location = new System.Drawing.Point(184, 75);
			this.btnAction6.Name = "btnAction6";
			this.btnAction6.Size = new System.Drawing.Size(74, 50);
			this.btnAction6.TabIndex = 9;
			this.btnAction6.Text = "Show Map";
			this.btnAction6.UseVisualStyleBackColor = true;
			this.btnAction6.Click += new System.EventHandler(this.btnAction6_Click);
			// 
			// btnAction5
			// 
			this.btnAction5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAction5.BackgroundImage")));
			this.btnAction5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAction5.Location = new System.Drawing.Point(103, 75);
			this.btnAction5.Name = "btnAction5";
			this.btnAction5.Size = new System.Drawing.Size(74, 50);
			this.btnAction5.TabIndex = 8;
			this.btnAction5.Text = "Action 5";
			this.btnAction5.UseVisualStyleBackColor = true;
			this.btnAction5.Click += new System.EventHandler(this.btnAction5_Click);
			// 
			// btnAction4
			// 
			this.btnAction4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAction4.BackgroundImage")));
			this.btnAction4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAction4.Location = new System.Drawing.Point(22, 75);
			this.btnAction4.Name = "btnAction4";
			this.btnAction4.Size = new System.Drawing.Size(74, 50);
			this.btnAction4.TabIndex = 7;
			this.btnAction4.Text = "Action 4";
			this.btnAction4.UseVisualStyleBackColor = true;
			this.btnAction4.Click += new System.EventHandler(this.btnAction4_Click);
			// 
			// btnAction3
			// 
			this.btnAction3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAction3.BackgroundImage")));
			this.btnAction3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAction3.Location = new System.Drawing.Point(184, 19);
			this.btnAction3.Name = "btnAction3";
			this.btnAction3.Size = new System.Drawing.Size(74, 50);
			this.btnAction3.TabIndex = 6;
			this.btnAction3.Text = "Action 3";
			this.btnAction3.UseVisualStyleBackColor = true;
			this.btnAction3.Click += new System.EventHandler(this.btnAction3_Click);
			// 
			// btnAction2
			// 
			this.btnAction2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAction2.BackgroundImage")));
			this.btnAction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAction2.Location = new System.Drawing.Point(103, 19);
			this.btnAction2.Name = "btnAction2";
			this.btnAction2.Size = new System.Drawing.Size(74, 50);
			this.btnAction2.TabIndex = 5;
			this.btnAction2.Text = "Action 2";
			this.btnAction2.UseVisualStyleBackColor = true;
			this.btnAction2.Click += new System.EventHandler(this.btnAction2_Click);
			// 
			// btnAction1
			// 
			this.btnAction1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAction1.BackgroundImage")));
			this.btnAction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAction1.Location = new System.Drawing.Point(22, 19);
			this.btnAction1.Name = "btnAction1";
			this.btnAction1.Size = new System.Drawing.Size(74, 50);
			this.btnAction1.TabIndex = 4;
			this.btnAction1.Text = "Action 1";
			this.btnAction1.UseVisualStyleBackColor = true;
			this.btnAction1.Click += new System.EventHandler(this.btnAction1_Click);
			// 
			// btnMainMenu
			// 
			this.btnMainMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnMainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMainMenu.BackgroundImage")));
			this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMainMenu.Location = new System.Drawing.Point(436, 533);
			this.btnMainMenu.Name = "btnMainMenu";
			this.btnMainMenu.Size = new System.Drawing.Size(82, 50);
			this.btnMainMenu.TabIndex = 4;
			this.btnMainMenu.Text = "Main Menu";
			this.btnMainMenu.UseVisualStyleBackColor = true;
			this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
			this.btnMainMenu.MouseLeave += new System.EventHandler(this.btnMainMenu_MouseLeave);
			this.btnMainMenu.MouseHover += new System.EventHandler(this.btnMainMenu_MouseHover);
			// 
			// btnSaveGame
			// 
			this.btnSaveGame.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSaveGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveGame.BackgroundImage")));
			this.btnSaveGame.Cursor = System.Windows.Forms.Cursors.No;
			this.btnSaveGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveGame.Location = new System.Drawing.Point(395, 589);
			this.btnSaveGame.Name = "btnSaveGame";
			this.btnSaveGame.Size = new System.Drawing.Size(82, 50);
			this.btnSaveGame.TabIndex = 5;
			this.btnSaveGame.Text = "Save Game";
			this.btnSaveGame.UseVisualStyleBackColor = true;
			this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
			this.btnSaveGame.MouseLeave += new System.EventHandler(this.btnSaveGame_MouseLeave);
			this.btnSaveGame.MouseHover += new System.EventHandler(this.btnSaveGame_MouseHover);
			// 
			// btnLoadGame
			// 
			this.btnLoadGame.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnLoadGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoadGame.BackgroundImage")));
			this.btnLoadGame.Cursor = System.Windows.Forms.Cursors.No;
			this.btnLoadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLoadGame.Location = new System.Drawing.Point(483, 589);
			this.btnLoadGame.Name = "btnLoadGame";
			this.btnLoadGame.Size = new System.Drawing.Size(82, 50);
			this.btnLoadGame.TabIndex = 6;
			this.btnLoadGame.Text = "Load Game";
			this.btnLoadGame.UseVisualStyleBackColor = true;
			this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
			this.btnLoadGame.MouseLeave += new System.EventHandler(this.btnLoadGame_MouseLeave);
			this.btnLoadGame.MouseHover += new System.EventHandler(this.btnLoadGame_MouseHover);
			// 
			// lblMenuHover
			// 
			this.lblMenuHover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMenuHover.AutoSize = true;
			this.lblMenuHover.Location = new System.Drawing.Point(703, 65);
			this.lblMenuHover.Name = "lblMenuHover";
			this.lblMenuHover.Size = new System.Drawing.Size(0, 13);
			this.lblMenuHover.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(480, 664);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 24);
			this.label1.TabIndex = 8;
			this.label1.Text = "Directional Help";
			// 
			// lstDialog
			// 
			this.lstDialog.BackColor = System.Drawing.Color.Silver;
			this.lstDialog.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstDialog.FormattingEnabled = true;
			this.lstDialog.ItemHeight = 19;
			this.lstDialog.Location = new System.Drawing.Point(12, 691);
			this.lstDialog.Name = "lstDialog";
			this.lstDialog.Size = new System.Drawing.Size(441, 156);
			this.lstDialog.TabIndex = 9;
			// 
			// lblDialog
			// 
			this.lblDialog.AutoSize = true;
			this.lblDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDialog.Location = new System.Drawing.Point(12, 664);
			this.lblDialog.Name = "lblDialog";
			this.lblDialog.Size = new System.Drawing.Size(63, 24);
			this.lblDialog.TabIndex = 10;
			this.lblDialog.Text = "Dialog";
			// 
			// grpboxLegend
			// 
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
			this.grpboxLegend.Controls.Add(this.txtWalls);
			this.grpboxLegend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.grpboxLegend.Location = new System.Drawing.Point(797, 12);
			this.grpboxLegend.Name = "grpboxLegend";
			this.grpboxLegend.Size = new System.Drawing.Size(128, 252);
			this.grpboxLegend.TabIndex = 13;
			this.grpboxLegend.TabStop = false;
			this.grpboxLegend.Text = "Legend";
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
			this.lblStairsDown.Size = new System.Drawing.Size(70, 13);
			this.lblStairsDown.TabIndex = 15;
			this.lblStairsDown.Text = "- Stairs Down";
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
			this.lblStairsUp.Size = new System.Drawing.Size(56, 13);
			this.lblStairsUp.TabIndex = 13;
			this.lblStairsUp.Text = "- Stairs Up";
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
			this.lblDoorOpen.Size = new System.Drawing.Size(85, 13);
			this.lblDoorOpen.TabIndex = 9;
			this.lblDoorOpen.Text = "- Door Unlocked";
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
			this.lblDoorLocked.Size = new System.Drawing.Size(75, 13);
			this.lblDoorLocked.TabIndex = 7;
			this.lblDoorLocked.Text = "- Door Locked";
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
			// txtWalls
			// 
			this.txtWalls.BackColor = System.Drawing.Color.DarkGray;
			this.txtWalls.Location = new System.Drawing.Point(6, 45);
			this.txtWalls.Name = "txtWalls";
			this.txtWalls.ReadOnly = true;
			this.txtWalls.Size = new System.Drawing.Size(21, 20);
			this.txtWalls.TabIndex = 0;
			// 
			// grdconMap
			// 
			this.grdconMap.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
			this.grdconMap.AllowIncreaseSmallChange = false;
			this.grdconMap.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
			this.grdconMap.BackColor = System.Drawing.Color.Black;
			this.grdconMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grdconMap.ColCount = 20;
			this.grdconMap.DefaultColWidth = 30;
			this.grdconMap.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
			this.grdconMap.DefaultRowHeight = 30;
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
			this.grdconMap.Properties.ForceImmediateRepaint = false;
			this.grdconMap.Properties.MarkColHeader = false;
			this.grdconMap.Properties.MarkRowHeader = false;
			this.grdconMap.Properties.RowHeaders = false;
			this.grdconMap.ResizeColsBehavior = Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.None;
			this.grdconMap.ResizeRowsBehavior = Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.None;
			this.grdconMap.RowCount = 18;
			this.grdconMap.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
			this.grdconMap.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
			this.grdconMap.Size = new System.Drawing.Size(756, 468);
			this.grdconMap.SmartSizeBox = false;
			this.grdconMap.SpreadsheetLikeSelection = false;
			this.grdconMap.TabIndex = 12;
			this.grdconMap.Text = "Map";
			this.grdconMap.UseRightToLeftCompatibleTextBox = true;
			this.grdconMap.VerticalThumbTrack = true;
			this.grdconMap.VScrollPixel = true;
			// 
			// tmrCellBlink
			// 
			this.tmrCellBlink.Enabled = true;
			this.tmrCellBlink.Interval = 500;
			this.tmrCellBlink.Tick += new System.EventHandler(this.tmrCellBlink_Tick);
			// 
			// FormGame
			// 
			this.AcceptButton = this.btnLoadGame;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(937, 859);
			this.Controls.Add(this.grpboxLegend);
			this.Controls.Add(this.grdconMap);
			this.Controls.Add(this.lblDialog);
			this.Controls.Add(this.lstDialog);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblMenuHover);
			this.Controls.Add(this.btnLoadGame);
			this.Controls.Add(this.btnSaveGame);
			this.Controls.Add(this.btnMainMenu);
			this.Controls.Add(this.grpActions);
			this.Controls.Add(this.grpMovement);
			this.Controls.Add(this.lstOutput);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(590, 430);
			this.Name = "FormGame";
			this.Text = "Game Screen";
			this.Load += new System.EventHandler(this.FormGamePlay_Load);
			this.grpMovement.ResumeLayout(false);
			this.grpActions.ResumeLayout(false);
			this.grpboxLegend.ResumeLayout(false);
			this.grpboxLegend.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdconMap)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
        private System.Windows.Forms.Button btnAction4;
        private System.Windows.Forms.Button btnAction3;
        private System.Windows.Forms.Button btnAction2;
        private System.Windows.Forms.Button btnAction1;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnSaveGame;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Label lblMenuHover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDialog;
        private System.Windows.Forms.Label lblDialog;
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
		private System.Windows.Forms.TextBox txtWalls;
		private Syncfusion.Windows.Forms.Grid.GridControl grdconMap;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBejeweledKitten;
		private System.Windows.Forms.Label lblStairsDown;
		private System.Windows.Forms.TextBox txtStairsDown;
		private System.Windows.Forms.Timer tmrCellBlink;
    }
}
namespace Thief_Escape
{
	partial class FormMainMenu
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
			if(disposing && (components != null))
			{
				components.Dispose( );
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
			this.btnLoadGame = new System.Windows.Forms.Button();
			this.btnSaveGame = new System.Windows.Forms.Button();
			this.btnMainMenu = new System.Windows.Forms.Button();
			this.picbThiefEscapePic = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picbThiefEscapePic)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLoadGame
			// 
			this.btnLoadGame.BackColor = System.Drawing.Color.DarkGray;
			this.btnLoadGame.Cursor = System.Windows.Forms.Cursors.No;
			this.btnLoadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLoadGame.ForeColor = System.Drawing.Color.MidnightBlue;
			this.btnLoadGame.Location = new System.Drawing.Point(266, 385);
			this.btnLoadGame.Name = "btnLoadGame";
			this.btnLoadGame.Size = new System.Drawing.Size(82, 50);
			this.btnLoadGame.TabIndex = 9;
			this.btnLoadGame.Text = "Load Game";
			this.btnLoadGame.UseVisualStyleBackColor = false;
			this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
			// 
			// btnSaveGame
			// 
			this.btnSaveGame.BackColor = System.Drawing.Color.DarkGray;
			this.btnSaveGame.Cursor = System.Windows.Forms.Cursors.No;
			this.btnSaveGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveGame.ForeColor = System.Drawing.Color.MidnightBlue;
			this.btnSaveGame.Location = new System.Drawing.Point(525, 385);
			this.btnSaveGame.Name = "btnSaveGame";
			this.btnSaveGame.Size = new System.Drawing.Size(82, 50);
			this.btnSaveGame.TabIndex = 8;
			this.btnSaveGame.Text = "Exit   Game";
			this.btnSaveGame.UseVisualStyleBackColor = false;
			this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
			// 
			// btnMainMenu
			// 
			this.btnMainMenu.BackColor = System.Drawing.Color.DarkGray;
			this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMainMenu.ForeColor = System.Drawing.Color.MidnightBlue;
			this.btnMainMenu.Location = new System.Drawing.Point(12, 385);
			this.btnMainMenu.Name = "btnMainMenu";
			this.btnMainMenu.Size = new System.Drawing.Size(82, 50);
			this.btnMainMenu.TabIndex = 7;
			this.btnMainMenu.Text = "New Game";
			this.btnMainMenu.UseVisualStyleBackColor = false;
			this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
			// 
			// picbThiefEscapePic
			// 
			this.picbThiefEscapePic.BackColor = System.Drawing.Color.White;
			this.picbThiefEscapePic.Image = global::Thief_Escape.Properties.Resources.ThiefEscapeOpeningPicture;
			this.picbThiefEscapePic.InitialImage = null;
			this.picbThiefEscapePic.Location = new System.Drawing.Point(12, 12);
			this.picbThiefEscapePic.Name = "picbThiefEscapePic";
			this.picbThiefEscapePic.Size = new System.Drawing.Size(595, 367);
			this.picbThiefEscapePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picbThiefEscapePic.TabIndex = 10;
			this.picbThiefEscapePic.TabStop = false;
			// 
			// FormMainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkKhaki;
			this.ClientSize = new System.Drawing.Size(620, 445);
			this.Controls.Add(this.picbThiefEscapePic);
			this.Controls.Add(this.btnLoadGame);
			this.Controls.Add(this.btnSaveGame);
			this.Controls.Add(this.btnMainMenu);
			this.Name = "FormMainMenu";
			this.Text = "FormMainMenu";
			((System.ComponentModel.ISupportInitialize)(this.picbThiefEscapePic)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnLoadGame;
		private System.Windows.Forms.Button btnSaveGame;
		private System.Windows.Forms.Button btnMainMenu;
		private System.Windows.Forms.PictureBox picbThiefEscapePic;
	}
}
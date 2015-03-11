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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.picbThiefEscapePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbThiefEscapePic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadGame.BackColor = System.Drawing.Color.DarkGray;
            this.btnLoadGame.Cursor = System.Windows.Forms.Cursors.No;
            this.btnLoadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadGame.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLoadGame.Location = new System.Drawing.Point(258, 385);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(111, 50);
            this.btnLoadGame.TabIndex = 9;
            this.btnLoadGame.Text = "&Load Game";
            this.btnLoadGame.UseVisualStyleBackColor = false;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.DarkGray;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.No;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Location = new System.Drawing.Point(503, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 50);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit   Game";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNew.BackColor = System.Drawing.Color.DarkGray;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNew.Location = new System.Drawing.Point(12, 385);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(111, 50);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "&New Game";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // picbThiefEscapePic
            // 
            this.picbThiefEscapePic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picbThiefEscapePic.BackColor = System.Drawing.Color.White;
            this.picbThiefEscapePic.Image = global::Thief_Escape.Properties.Resources.ThiefEscapeOpeningPicture;
            this.picbThiefEscapePic.InitialImage = null;
            this.picbThiefEscapePic.Location = new System.Drawing.Point(12, 12);
            this.picbThiefEscapePic.Name = "picbThiefEscapePic";
            this.picbThiefEscapePic.Size = new System.Drawing.Size(604, 367);
            this.picbThiefEscapePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbThiefEscapePic.TabIndex = 10;
            this.picbThiefEscapePic.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.AcceptButton = this.btnLoadGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(629, 445);
            this.Controls.Add(this.picbThiefEscapePic);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNew);
            this.Name = "FormMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbThiefEscapePic)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnLoadGame;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.PictureBox picbThiefEscapePic;
	}
}
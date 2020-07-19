namespace Snake_game
{
    partial class GameMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMenu));
            this.panelGameMenu = new System.Windows.Forms.Panel();
            this.pbFoodColor = new System.Windows.Forms.PictureBox();
            this.pbTailColor = new System.Windows.Forms.PictureBox();
            this.pbHeadColor = new System.Windows.Forms.PictureBox();
            this.pbFoodFill = new System.Windows.Forms.PictureBox();
            this.pbTailFill = new System.Windows.Forms.PictureBox();
            this.pbHeadFill = new System.Windows.Forms.PictureBox();
            this.pbFoodBorder = new System.Windows.Forms.PictureBox();
            this.pbTailBorder = new System.Windows.Forms.PictureBox();
            this.pbHeadBorder = new System.Windows.Forms.PictureBox();
            this.labelFoodColor = new System.Windows.Forms.Label();
            this.labelFoodFill = new System.Windows.Forms.Label();
            this.labelTailColor = new System.Windows.Forms.Label();
            this.labelTailFill = new System.Windows.Forms.Label();
            this.labelFoodBorder = new System.Windows.Forms.Label();
            this.labelHeadColor = new System.Windows.Forms.Label();
            this.labelTailBorder = new System.Windows.Forms.Label();
            this.labelHeadFill = new System.Windows.Forms.Label();
            this.labelHeadBorder = new System.Windows.Forms.Label();
            this.labelSettings = new System.Windows.Forms.Label();
            this.bttnExit = new System.Windows.Forms.Button();
            this.bttnStartGame = new System.Windows.Forms.Button();
            this.pictureSnake = new System.Windows.Forms.PictureBox();
            this.labelLogo = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panelGameMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTailColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeadColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodFill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTailFill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeadFill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTailBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeadBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSnake)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGameMenu
            // 
            this.panelGameMenu.BackColor = System.Drawing.Color.LightGreen;
            this.panelGameMenu.Controls.Add(this.pbFoodColor);
            this.panelGameMenu.Controls.Add(this.pbTailColor);
            this.panelGameMenu.Controls.Add(this.pbHeadColor);
            this.panelGameMenu.Controls.Add(this.pbFoodFill);
            this.panelGameMenu.Controls.Add(this.pbTailFill);
            this.panelGameMenu.Controls.Add(this.pbHeadFill);
            this.panelGameMenu.Controls.Add(this.pbFoodBorder);
            this.panelGameMenu.Controls.Add(this.pbTailBorder);
            this.panelGameMenu.Controls.Add(this.pbHeadBorder);
            this.panelGameMenu.Controls.Add(this.labelFoodColor);
            this.panelGameMenu.Controls.Add(this.labelFoodFill);
            this.panelGameMenu.Controls.Add(this.labelTailColor);
            this.panelGameMenu.Controls.Add(this.labelTailFill);
            this.panelGameMenu.Controls.Add(this.labelFoodBorder);
            this.panelGameMenu.Controls.Add(this.labelHeadColor);
            this.panelGameMenu.Controls.Add(this.labelTailBorder);
            this.panelGameMenu.Controls.Add(this.labelHeadFill);
            this.panelGameMenu.Controls.Add(this.labelHeadBorder);
            this.panelGameMenu.Controls.Add(this.labelSettings);
            this.panelGameMenu.Controls.Add(this.bttnExit);
            this.panelGameMenu.Controls.Add(this.bttnStartGame);
            this.panelGameMenu.Controls.Add(this.pictureSnake);
            this.panelGameMenu.Controls.Add(this.labelLogo);
            this.panelGameMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGameMenu.Location = new System.Drawing.Point(0, 0);
            this.panelGameMenu.Name = "panelGameMenu";
            this.panelGameMenu.Size = new System.Drawing.Size(974, 929);
            this.panelGameMenu.TabIndex = 0;
            // 
            // pbFoodColor
            // 
            this.pbFoodColor.Location = new System.Drawing.Point(896, 378);
            this.pbFoodColor.Name = "pbFoodColor";
            this.pbFoodColor.Size = new System.Drawing.Size(40, 40);
            this.pbFoodColor.TabIndex = 6;
            this.pbFoodColor.TabStop = false;
            this.pbFoodColor.Paint += new System.Windows.Forms.PaintEventHandler(this.pbFoodColor_Paint);
            // 
            // pbTailColor
            // 
            this.pbTailColor.Location = new System.Drawing.Point(560, 378);
            this.pbTailColor.Name = "pbTailColor";
            this.pbTailColor.Size = new System.Drawing.Size(40, 40);
            this.pbTailColor.TabIndex = 6;
            this.pbTailColor.TabStop = false;
            this.pbTailColor.Paint += new System.Windows.Forms.PaintEventHandler(this.pbTailColor_Paint);
            // 
            // pbHeadColor
            // 
            this.pbHeadColor.BackColor = System.Drawing.Color.Transparent;
            this.pbHeadColor.Location = new System.Drawing.Point(228, 378);
            this.pbHeadColor.Name = "pbHeadColor";
            this.pbHeadColor.Size = new System.Drawing.Size(40, 40);
            this.pbHeadColor.TabIndex = 6;
            this.pbHeadColor.TabStop = false;
            this.pbHeadColor.Paint += new System.Windows.Forms.PaintEventHandler(this.pbHeadColor_Paint);
            // 
            // pbFoodFill
            // 
            this.pbFoodFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pbFoodFill.Location = new System.Drawing.Point(896, 338);
            this.pbFoodFill.Name = "pbFoodFill";
            this.pbFoodFill.Size = new System.Drawing.Size(40, 40);
            this.pbFoodFill.TabIndex = 6;
            this.pbFoodFill.TabStop = false;
            this.pbFoodFill.Click += new System.EventHandler(this.pbFoodFill_Click);
            // 
            // pbTailFill
            // 
            this.pbTailFill.BackColor = System.Drawing.Color.Yellow;
            this.pbTailFill.Location = new System.Drawing.Point(560, 338);
            this.pbTailFill.Name = "pbTailFill";
            this.pbTailFill.Size = new System.Drawing.Size(40, 40);
            this.pbTailFill.TabIndex = 6;
            this.pbTailFill.TabStop = false;
            this.pbTailFill.Click += new System.EventHandler(this.pbTailFill_Click);
            // 
            // pbHeadFill
            // 
            this.pbHeadFill.BackColor = System.Drawing.Color.Red;
            this.pbHeadFill.Location = new System.Drawing.Point(228, 338);
            this.pbHeadFill.Name = "pbHeadFill";
            this.pbHeadFill.Size = new System.Drawing.Size(40, 40);
            this.pbHeadFill.TabIndex = 6;
            this.pbHeadFill.TabStop = false;
            this.pbHeadFill.Click += new System.EventHandler(this.pbHeadFill_Click);
            // 
            // pbFoodBorder
            // 
            this.pbFoodBorder.BackColor = System.Drawing.Color.Teal;
            this.pbFoodBorder.Location = new System.Drawing.Point(896, 300);
            this.pbFoodBorder.Name = "pbFoodBorder";
            this.pbFoodBorder.Size = new System.Drawing.Size(40, 40);
            this.pbFoodBorder.TabIndex = 6;
            this.pbFoodBorder.TabStop = false;
            this.pbFoodBorder.Click += new System.EventHandler(this.pbFoodBorder_Click);
            // 
            // pbTailBorder
            // 
            this.pbTailBorder.BackColor = System.Drawing.Color.Black;
            this.pbTailBorder.Location = new System.Drawing.Point(560, 300);
            this.pbTailBorder.Name = "pbTailBorder";
            this.pbTailBorder.Size = new System.Drawing.Size(40, 40);
            this.pbTailBorder.TabIndex = 6;
            this.pbTailBorder.TabStop = false;
            this.pbTailBorder.Click += new System.EventHandler(this.pbTailBorder_Click);
            // 
            // pbHeadBorder
            // 
            this.pbHeadBorder.BackColor = System.Drawing.Color.Black;
            this.pbHeadBorder.Location = new System.Drawing.Point(228, 300);
            this.pbHeadBorder.Name = "pbHeadBorder";
            this.pbHeadBorder.Size = new System.Drawing.Size(40, 40);
            this.pbHeadBorder.TabIndex = 6;
            this.pbHeadBorder.TabStop = false;
            this.pbHeadBorder.Click += new System.EventHandler(this.pbHeadBorder_Click);
            // 
            // labelFoodColor
            // 
            this.labelFoodColor.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFoodColor.Location = new System.Drawing.Point(680, 378);
            this.labelFoodColor.Name = "labelFoodColor";
            this.labelFoodColor.Size = new System.Drawing.Size(210, 40);
            this.labelFoodColor.TabIndex = 5;
            this.labelFoodColor.Text = "Food color:";
            this.labelFoodColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFoodFill
            // 
            this.labelFoodFill.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFoodFill.Location = new System.Drawing.Point(680, 338);
            this.labelFoodFill.Name = "labelFoodFill";
            this.labelFoodFill.Size = new System.Drawing.Size(210, 40);
            this.labelFoodFill.TabIndex = 5;
            this.labelFoodFill.Text = "Food fill:";
            this.labelFoodFill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTailColor
            // 
            this.labelTailColor.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTailColor.Location = new System.Drawing.Point(344, 378);
            this.labelTailColor.Name = "labelTailColor";
            this.labelTailColor.Size = new System.Drawing.Size(210, 40);
            this.labelTailColor.TabIndex = 5;
            this.labelTailColor.Text = "Tail color:";
            this.labelTailColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTailFill
            // 
            this.labelTailFill.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTailFill.Location = new System.Drawing.Point(344, 338);
            this.labelTailFill.Name = "labelTailFill";
            this.labelTailFill.Size = new System.Drawing.Size(210, 40);
            this.labelTailFill.TabIndex = 5;
            this.labelTailFill.Text = "Tail fill:";
            this.labelTailFill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFoodBorder
            // 
            this.labelFoodBorder.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFoodBorder.Location = new System.Drawing.Point(680, 300);
            this.labelFoodBorder.Name = "labelFoodBorder";
            this.labelFoodBorder.Size = new System.Drawing.Size(220, 40);
            this.labelFoodBorder.TabIndex = 5;
            this.labelFoodBorder.Text = "Food border:";
            this.labelFoodBorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHeadColor
            // 
            this.labelHeadColor.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeadColor.Location = new System.Drawing.Point(12, 378);
            this.labelHeadColor.Name = "labelHeadColor";
            this.labelHeadColor.Size = new System.Drawing.Size(210, 40);
            this.labelHeadColor.TabIndex = 5;
            this.labelHeadColor.Text = "Head color:";
            this.labelHeadColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTailBorder
            // 
            this.labelTailBorder.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTailBorder.Location = new System.Drawing.Point(344, 300);
            this.labelTailBorder.Name = "labelTailBorder";
            this.labelTailBorder.Size = new System.Drawing.Size(210, 40);
            this.labelTailBorder.TabIndex = 5;
            this.labelTailBorder.Text = "Tail border:";
            this.labelTailBorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHeadFill
            // 
            this.labelHeadFill.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeadFill.Location = new System.Drawing.Point(12, 338);
            this.labelHeadFill.Name = "labelHeadFill";
            this.labelHeadFill.Size = new System.Drawing.Size(210, 40);
            this.labelHeadFill.TabIndex = 5;
            this.labelHeadFill.Text = "Head fill:";
            this.labelHeadFill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHeadBorder
            // 
            this.labelHeadBorder.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeadBorder.Location = new System.Drawing.Point(12, 300);
            this.labelHeadBorder.Name = "labelHeadBorder";
            this.labelHeadBorder.Size = new System.Drawing.Size(220, 40);
            this.labelHeadBorder.TabIndex = 5;
            this.labelHeadBorder.Text = "Head border:";
            this.labelHeadBorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSettings.Location = new System.Drawing.Point(400, 225);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(149, 45);
            this.labelSettings.TabIndex = 4;
            this.labelSettings.Text = "Settings";
            // 
            // bttnExit
            // 
            this.bttnExit.BackColor = System.Drawing.Color.Transparent;
            this.bttnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bttnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bttnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExit.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnExit.Location = new System.Drawing.Point(652, 125);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(310, 100);
            this.bttnExit.TabIndex = 3;
            this.bttnExit.Text = "Exit Game";
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // bttnStartGame
            // 
            this.bttnStartGame.BackColor = System.Drawing.Color.Transparent;
            this.bttnStartGame.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bttnStartGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bttnStartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnStartGame.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnStartGame.Location = new System.Drawing.Point(12, 125);
            this.bttnStartGame.Name = "bttnStartGame";
            this.bttnStartGame.Size = new System.Drawing.Size(310, 100);
            this.bttnStartGame.TabIndex = 2;
            this.bttnStartGame.Text = "Start Game";
            this.bttnStartGame.UseVisualStyleBackColor = false;
            this.bttnStartGame.Click += new System.EventHandler(this.bttnStartGame_Click);
            // 
            // pictureSnake
            // 
            this.pictureSnake.Image = global::Snake_game.Properties.Resources.SnakeForMenu;
            this.pictureSnake.Location = new System.Drawing.Point(3, 568);
            this.pictureSnake.Name = "pictureSnake";
            this.pictureSnake.Size = new System.Drawing.Size(731, 358);
            this.pictureSnake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSnake.TabIndex = 1;
            this.pictureSnake.TabStop = false;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Comic Sans MS", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.Location = new System.Drawing.Point(247, 9);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(487, 104);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "Snake Game";
            // 
            // colorDialog
            // 
            this.colorDialog.Color = System.Drawing.Color.Red;
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 929);
            this.Controls.Add(this.panelGameMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake game";
            this.panelGameMenu.ResumeLayout(false);
            this.panelGameMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTailColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeadColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodFill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTailFill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeadFill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTailBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeadBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSnake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGameMenu;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button bttnStartGame;
        private System.Windows.Forms.PictureBox pictureSnake;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.PictureBox pbHeadColor;
        private System.Windows.Forms.PictureBox pbHeadFill;
        private System.Windows.Forms.PictureBox pbHeadBorder;
        private System.Windows.Forms.Label labelHeadColor;
        private System.Windows.Forms.Label labelHeadFill;
        private System.Windows.Forms.Label labelHeadBorder;
        private System.Windows.Forms.PictureBox pbFoodColor;
        private System.Windows.Forms.PictureBox pbTailColor;
        private System.Windows.Forms.PictureBox pbFoodFill;
        private System.Windows.Forms.PictureBox pbTailFill;
        private System.Windows.Forms.PictureBox pbFoodBorder;
        private System.Windows.Forms.PictureBox pbTailBorder;
        private System.Windows.Forms.Label labelFoodColor;
        private System.Windows.Forms.Label labelFoodFill;
        private System.Windows.Forms.Label labelTailColor;
        private System.Windows.Forms.Label labelTailFill;
        private System.Windows.Forms.Label labelFoodBorder;
        private System.Windows.Forms.Label labelTailBorder;
    }
}
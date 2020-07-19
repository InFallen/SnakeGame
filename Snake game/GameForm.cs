using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_game
{
    public partial class GameForm : Form
    {
        Game game;
        Panel escMenu;
        Button bttnResumeGame;
        Button bttnExitGame;

        bool endGame;
        public GameForm(Game game)
        {
            InitializeComponent();
            this.game = game;

            escMenu = new Panel();
            escMenu.Visible = false;
            escMenu.Size = new Size(150, 150);
            escMenu.Location = new Point(175, 175);
            escMenu.BackColor = Color.MediumAquamarine;
            escMenu.Enabled = true;

            bttnResumeGame = new Button();
            bttnResumeGame.Size = new Size(escMenu.Width - 6, 50);
            bttnResumeGame.Location = new Point(3, 15);
            bttnResumeGame.Text = "Resume game";
            bttnResumeGame.Click += new EventHandler(bttnResumeGame_Click);

            bttnExitGame = new Button();
            bttnExitGame.Size = new Size(escMenu.Width - 6, 50);
            bttnExitGame.Location = new Point(3, escMenu.Height - bttnExitGame.Height - 15);
            bttnExitGame.Text = "Exit game";
            bttnExitGame.Click += new EventHandler(bttnExitGame_Click);

            bttnResumeGame.BackColor = bttnExitGame.BackColor = Color.CadetBlue;
            bttnResumeGame.Font = bttnExitGame.Font = new Font("Microsoft YaHei", 12.0F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            bttnResumeGame.TextAlign = bttnExitGame.TextAlign = ContentAlignment.MiddleCenter;

            Controls.Add(escMenu);
            escMenu.Controls.Add(bttnExitGame);
            escMenu.Controls.Add(bttnResumeGame);


            endGame = false;
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(game.Snake.Head.FillColor, game.Snake.Head.X, game.Snake.Head.Y, game.Snake.Head.Width, game.Snake.Head.Height);
            e.Graphics.DrawRectangle(game.Snake.Head.BorderColor, game.Snake.Head.X + 1, game.Snake.Head.Y + 1, game.Snake.Head.Width - 2, game.Snake.Head.Height - 2);

            for (int i = 0; i < game.Snake.Tail.Length; i++)
            {
                e.Graphics.FillRectangle(game.Snake.Tail[i].FillColor, game.Snake.Tail[i].X, game.Snake.Tail[i].Y, game.Snake.Tail[i].Width, game.Snake.Tail[i].Height);
                e.Graphics.DrawRectangle(game.Snake.Tail[i].BorderColor, game.Snake.Tail[i].X + 1, game.Snake.Tail[i].Y + 1, game.Snake.Tail[i].Width - 2, game.Snake.Tail[i].Height - 2);
            }

            for (int i = 0; i < game.Food.Length; i++)
            {
                e.Graphics.FillRectangle(game.Food[i].FillColor, game.Food[i].X, game.Food[i].Y, game.Food[i].Width, game.Food[i].Height);
                e.Graphics.DrawRectangle(game.Food[i].BorderColor, game.Food[i].X + 1, game.Food[i].Y + 1, game.Food[i].Width - 2, game.Food[i].Height - 2);
            }

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (!endGame)
            {
                game.Snake.Move(game.Direction, this, ref endGame);
                game.SnakeEat();
                Refresh();
            }
            else
            {
                gameTimer.Enabled = false;
            }
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && game.Direction != Direction.Down)
            {
                game.Direction = Direction.Up;
            }
            if (e.KeyCode == Keys.Right && game.Direction != Direction.Left)
            {
                game.Direction = Direction.Right;
            }
            if (e.KeyCode == Keys.Down && game.Direction != Direction.Up)
            {
                game.Direction = Direction.Down;
            }
            if (e.KeyCode == Keys.Left && game.Direction != Direction.Right)
            {
                game.Direction = Direction.Left;
            }
            if (e.KeyCode == Keys.Escape)
            {
                gameTimer.Enabled = !gameTimer.Enabled;
                escMenu.Visible = !escMenu.Visible;
            }
        }
        
        public void bttnResumeGame_Click(object sender, EventArgs e)
        {
            escMenu.Visible = !escMenu.Visible;
            gameTimer.Enabled = !gameTimer.Enabled;
            KeyPreview = true;
        }

        public void bttnExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form gameMenu = Application.OpenForms[0];
            gameMenu.Show(); 
        }


    }
}

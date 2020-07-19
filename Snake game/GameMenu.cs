using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_game
{
    public partial class GameMenu : Form
    {
        Game game;
        Pen penHeadBorder, penTailBorder, penFoodBorder;
        SolidBrush brushHeadFill, brushTailFill, brushFoodFill;

        public GameMenu()
        {
            InitializeComponent();
            colorDialog.FullOpen = true;
            brushHeadFill = new SolidBrush(pbHeadFill.BackColor);
            penHeadBorder = new Pen(pbHeadBorder.BackColor, 2);
            brushTailFill = new SolidBrush(pbTailFill.BackColor);
            penTailBorder = new Pen(pbTailBorder.BackColor, 2);
            brushFoodFill = new SolidBrush(pbFoodFill.BackColor);
            penFoodBorder = new Pen(pbFoodBorder.BackColor, 2);
        }

        private void pbHeadBorder_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (colorDialog.Color == Color.White) return;
                pbHeadBorder.BackColor = colorDialog.Color;
                penHeadBorder.Color = colorDialog.Color;
                Refresh();
                return;
            }
        }

        private void pbHeadFill_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (colorDialog.Color == Color.White) return;
                pbHeadFill.BackColor = colorDialog.Color;
                brushHeadFill.Color = colorDialog.Color;
                Refresh();
                return;
            }
        }

        private void pbHeadColor_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(brushHeadFill, 0, 0, pbHeadColor.Width, pbHeadColor.Height);
            e.Graphics.DrawRectangle(penHeadBorder, 0 + 1, 0 + 1, pbHeadColor.Width - 2, pbHeadColor.Height - 2);
        }

        private void pbTailBorder_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (colorDialog.Color == Color.White) return;
                pbTailBorder.BackColor = colorDialog.Color;
                penTailBorder.Color = colorDialog.Color;
                Refresh();
                return;
            }
        }

        private void pbTailFill_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (colorDialog.Color == Color.White) return;
                pbTailFill.BackColor = colorDialog.Color;
                brushTailFill.Color = colorDialog.Color;
                Refresh();
                return;
            }
        }

        private void pbTailColor_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(brushTailFill, 0, 0, pbTailColor.Width, pbTailColor.Height);
            e.Graphics.DrawRectangle(penTailBorder, 0 + 1, 0 + 1, pbTailColor.Width - 2, pbTailColor.Height - 2);
        }

        private void pbFoodBorder_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (colorDialog.Color == Color.White) return;
                pbFoodBorder.BackColor = colorDialog.Color;
                penFoodBorder.Color = colorDialog.Color;
                Refresh();
                return;
            }
        }

        private void pbFoodFill_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (colorDialog.Color == Color.White) return;
                pbFoodFill.BackColor = colorDialog.Color;
                brushFoodFill.Color = colorDialog.Color;
                Refresh();
                return;
            }
        }

        private void pbFoodColor_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(brushFoodFill, 0, 0, pbFoodColor.Width, pbFoodColor.Height);
            e.Graphics.DrawRectangle(penFoodBorder, 0 + 1, 0 + 1, pbFoodColor.Width - 2, pbFoodColor.Height - 2);
        }
        private void bttnStartGame_Click(object sender, EventArgs e)
        {
            game = new Game(brushHeadFill, penHeadBorder, brushTailFill, penTailBorder, brushFoodFill, penFoodBorder, 3, this);
            GameForm gameForm = new GameForm(game);
            gameForm.Show();
            this.Hide();
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

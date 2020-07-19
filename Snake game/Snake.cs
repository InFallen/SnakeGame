using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_game
{
    public class Snake
    {
        public Cell Head { get; private set; }
        public Cell[] Tail { get; private set; }

        public Snake(int startX, int startY, int width, int height, int tailLength, SolidBrush headFill, Pen headBorder, SolidBrush tailFill, Pen tailBorder)
        {
            Head = new Cell(startX, startY, width, height, headFill, headBorder);
            Tail = CreateTail(tailLength, tailFill, tailBorder);
        }

        #region Public methods
        public void Move(Direction direction, GameForm gameForm, ref bool endGame)
        {
            for (int i = Tail.Length - 1; i > 0; i--)
            {
                Tail[i] = new Cell(Tail[i - 1].X, Tail[i - 1].Y, Tail[i - 1].Width, Tail[i - 1].Height, Tail[i].FillColor, Tail[i].BorderColor);
            }
            Tail[0] = new Cell(Head.X, Head.Y, Head.Width, Head.Height, Tail[0].FillColor, Tail[0].BorderColor);
            Head.ChangeCoordinates(direction, gameForm);

            for (int i = 0; i < Tail.Length; i++)
            {
                if (Head.X == Tail[i].X && Head.Y == Tail[i].Y)
                {
                    endGame = true;
                    return;
                }
            }
        }

        public void AddTail()
        {
            Cell[] newTail = new Cell[Tail.Length + 1];
            for(int i = 0; i < Tail.Length; i++)
            {
                newTail[i] = Tail[i];
            }
            newTail[newTail.Length - 1] = new Cell(Tail[Tail.Length - 1].X, Tail[Tail.Length - 1].Y, Tail[Tail.Length - 1].Width, Tail[Tail.Length - 1].Height, Tail[Tail.Length - 1].FillColor, Tail[Tail.Length - 1].BorderColor);
            Tail = newTail;
        }
        #endregion

        #region Private methods
        private Cell[] CreateTail(int tailLength, SolidBrush tailFill, Pen tailBorder)
        {

            Cell[] tail = new Cell[tailLength];
            for (int i = 0; i < tail.Length; i++)
            {
                tail[i] = new Cell(Head.X - Head.Width * (1 + i), Head.Y, Head.Width, Head.Height, tailFill, tailBorder);
            }

            return tail;
        }

       
        #endregion
    }
}

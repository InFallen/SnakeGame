using System.Drawing;

namespace Snake_game
{
    public class Cell
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; }
        public int Height { get; }

        public Pen BorderColor { get; }
        public SolidBrush FillColor { get; }

        #region Public Methods
        public Cell(int x, int y, int width, int height, SolidBrush fillColor, Pen borderColor)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            FillColor = fillColor;
            BorderColor = borderColor;
        }

        public void ChangeCoordinates(Direction direction, GameForm gameForm)
        {
            switch (direction)
            {
                case Direction.Up:
                    X += 0; Y += -Height;
                    if (Y <  0) Y = gameForm.Height - 20;
                    break;
                case Direction.Right:
                    X += Width; Y += 0;
                    if (X >= gameForm.Width) X = 0;
                    break;
                case Direction.Down:
                    X += 0; Y += Height;
                    if (Y >= gameForm.Height) Y = 0;
                    break;
                case Direction.Left:
                    X += -Width; Y += 0;
                    if (X < 0) X = gameForm.Width - 20;
                    break;
            }

            //return new Cell(X, Y, Width, Height, FillColor);
        }
        #endregion
    }
}

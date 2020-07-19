using System;
using System.Drawing;

namespace Snake_game
{
    public class Game
    {
        public Direction Direction;
        public Rectangle rHead;
        public Rectangle[] rFood;
        private static Random _random;
        private int _widthGameForm;
        private int _heightGameForm;

        public Snake Snake { get; }
        public Cell[] Food { get; }
        public Game(SolidBrush headFill, Pen headBorder,   SolidBrush tailFill, Pen tailBorder, SolidBrush foodFill, Pen foodBorder, int foodCount, GameMenu gameMenu)
        {
            _random = new Random();
            _widthGameForm = gameMenu.Width;
            _heightGameForm = gameMenu.Height;
            Direction = Direction.Right;
            Snake = new Snake(100, 100, 20, 20, 3, headFill, headBorder, tailFill, tailBorder);
            Food = CreateFood(foodFill, foodBorder, foodCount);
            rHead = new Rectangle(Snake.Head.X, Snake.Head.Y, Snake.Head.Width, Snake.Head.Height);
            rFood = new Rectangle[foodCount];
            for (int i = 0; i < rFood.Length; i++)
            {
                rFood[i] = new Rectangle(Food[i].X, Food[i].Y, Food[i].Width, Food[i].Height);
            }
        }



        private Cell CreateFood(Cell cell)
        {
            int x, y;
            while(true)
            {
                x = _random.Next(20, _widthGameForm - 40);
                y = _random.Next(20, _heightGameForm - 40);
                if (x % 20 == 0 && y % 20 == 0) break;
            }

            return new Cell(x, y, cell.Width, cell.Height, cell.FillColor, cell.BorderColor);
        }

        private Cell[] CreateFood(SolidBrush foodFill, Pen foodBorder, int foodCount)
        {
            int x, y;
            Cell[] food = new Cell[foodCount];
            for (int i = 0; i < food.Length; i++)
            {
                while (true)
                {
                    x = _random.Next(20, _widthGameForm - 40);
                    y = _random.Next(20, _heightGameForm - 40);
                    if (x % 20 == 0 && y % 20 == 0) break;
                }
                food[i] = new Cell(x, y, Snake.Head.Width, Snake.Head.Height, foodFill, foodBorder);
            }

            return food;
        }

        public void SnakeEat()
        {
            rHead = new Rectangle(Snake.Head.X, Snake.Head.Y, Snake.Head.Width, Snake.Head.Height);
            for (int i = 0; i < rFood.Length; i++)
            {
                if (rHead.IntersectsWith(rFood[i]))
                {
                    Food[i] = CreateFood(Food[i]);
                    rFood[i] = new Rectangle(Food[i].X, Food[i].Y, Food[i].Width, Food[i].Height);
                    Snake.AddTail();
                }
            }
        }
    }
}

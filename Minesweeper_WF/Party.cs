using System;
using System.Collections.Generic;

namespace Minesweeper_WF
{
    class Party : IModel
    {
        DateTime date;
        public sbyte mode;
        int fieldWidth;
        int fieldHeight;
        int flagCounter;
        int bombAmount;
        DateTime duration;
        //public Bot bot;
        //public User user;
        private int[,] bombField;
        internal int[,] exploredField;
        //private List<(char, int, int)> history;
        private List<(int, int)> bombCells;

        public event Action Changed;
        public Party(string path) { }
        public Party(sbyte mode, int width, int height, int bombAmount)
        {
            this.date = DateTime.Now;
            this.mode = mode;
            this.fieldWidth = width;
            this.fieldHeight = height;
            this.bombAmount = bombAmount;
            this.flagCounter = 0;
            this.duration = new DateTime();

            //Spawn Bombs
            this.bombCells = new List<(int, int)>();
            SpawnBombs();
            this.bombField = new int[width, height];
            this.exploredField = new int[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    exploredField[i, j] = -2;
                }
            }
            FillField();

            //Players
            //this.user = new User();
            //this.bot = new Bot();
        }
        public void ClearViews()
        {
            this.Changed = null;
        }
        public Party(sbyte mode, int width, int height) : this(mode, width, height, CalcBombAmount(mode, width, height)) { }
        public Party(sbyte mode) : this(mode, defSettings[CM(mode), 0], defSettings[CM(mode), 1], defSettings[CM(mode), 2]) { }
        public int W { get => fieldWidth; }
        public int H { get => fieldHeight; }
        public int FlagCounter { get => flagCounter; }
        public int BombAmount { get => bombAmount; }
        public int Duration { get => (int) ((DateTime.Now).Subtract(date)).TotalSeconds ; }
        //public void RecoverField() { }
        public void GetMap() { }
        //public void SaveParty() { }
        bool Finished = false;


        // int 0,16; exp 0,21 
        private static int CalcBombAmount(sbyte mode, int width, int height)
        {
            return mode switch
            {
                1 => (int)(0.15 * width * height),
                2 => (int)(0.16 * width * height),
                3 => (int)(0.20 * width * height),
                _ => (int)(0.15 * width * height),
            };
        }
        //Beginner (8x8, 10 mines), Intermediate (16x16, 40 mines) and Expert (30x16, 99 mines)
        private static readonly int[,] defSettings = { { 9, 9, 10 }, { 16, 16, 40 }, { 30, 16, 99 } };

        //ClipGameMode
        private static sbyte CM(sbyte mode)
        {
            return (sbyte)(mode < 0 ? 0 : (mode > 2 ? 2 : mode));
        }

        private int GetNearBombAmount(int i, int j)
        {
            int bombAm = 0;
            for (int dx = -1; dx < 2; dx++)
            {
                for (int dy = -1; dy < 2; dy++)
                {
                    int x = i + dx, y = j + dy;
                    if ((x < 0) || (y < 0) || (x >= fieldWidth) || (y >= fieldHeight))
                    {
                        continue;
                    }
                    if (bombField[x, y] == -1)
                    {
                        bombAm++;
                    }
                }
            }
            return bombAm;
        }

        private void SpawnBombs()
        {
            Random rand = new Random();
            for (int i = 0; i < bombAmount; i++)
            {
                (int, int) b = (rand.Next(fieldWidth), rand.Next(fieldHeight));
                while (bombCells.Contains(b))
                {
                    b = (rand.Next(fieldWidth), rand.Next(fieldHeight));
                }
                bombCells.Add(b);
            }
        }

        private void FillField()
        {
            /*
            -4      mark
            -3      flag
            -2      closed
            -1      bomb
            0-8     empty, amount of bombs around
            */
            foreach (var b in bombCells)
            {
                bombField[b.Item1, b.Item2] = -1;
            }
            for (int i = 0; i < fieldWidth; i++)
            {
                for (int j = 0; j < fieldHeight; j++)
                {
                    bombField[i, j] = (bombCells.Contains((i, j)) ? -1 : GetNearBombAmount(i, j));
                }
            }
        }

        public int Status
        {
            get
            {
                bool hasWon = true;
                for (int i = 0; i < fieldWidth; i++)
                {
                    for (int j = 0; j < fieldHeight; j++)
                    {
                        if (exploredField[i, j] == -5)
                        {
                            return -1;
                        }
                        if (exploredField[i, j] == -1)
                        {
                            return -1;
                        }
                        hasWon = hasWon && (((exploredField[i, j] < -1) && (bombField[i, j] == -1)) || (exploredField[i, j] >= 0));
                    }
                }
                return (hasWon ? 1 : 0);
            }
        }

        public void BFSOpenCell(int i, int j)
        {
            if ((exploredField[i, j] == -3) || (exploredField[i, j] == -4))
            {
                return;
            }
            var queueToOpen = new Queue<(int, int)>();
            exploredField[i, j] = bombField[i, j];
            if (exploredField[i, j] == -1)
            {   
                ShowAllBombs();
            }
            if (Changed != null) Changed();
            if (exploredField[i, j] != 0) { return; }
            queueToOpen.Enqueue((i, j));
            while (queueToOpen.Count > 0)
            {
                var cell = queueToOpen.Dequeue();
                for (int dx = -1; dx < 2; dx++)
                {
                    for (int dy = -1; dy < 2; dy++)
                    {
                        int x = cell.Item1 + dx, y = cell.Item2 + dy;
                        if (((x < 0) || (y < 0) || (x >= fieldWidth) || (y >= fieldHeight)) || ((dx == 0) && (dy == 0)))
                        {
                            continue;
                        }
                        if (exploredField[x, y] < 0)
                        {
                            exploredField[x, y] = bombField[x, y];
                            if (exploredField[x, y] == 0)
                            {
                                queueToOpen.Enqueue((x, y));
                            }
                        }
                    }
                }
            }
            if (Changed != null) Changed();
        }

        public void ShowAllBombs()
        {
            foreach (var b in bombCells)
            {
                if (exploredField[b.Item1, b.Item2] == -2)
                {
                    exploredField[b.Item1, b.Item2] = -5;
                }
            }
        }

        public void PutFlag(int i, int j)
        {
            if (exploredField[i, j] < -1)
            {
                if (exploredField[i, j] == -4)
                {
                    PutMark(i, j);
                }
                exploredField[i, j] = -5 - exploredField[i, j];
                if (exploredField[i, j] == -3)
                {
                    flagCounter++;
                }
                else
                {
                    flagCounter--;
                }
                if (Changed != null) Changed();
            }
        }
        public void PutMark(int i, int j)
        {
            if (exploredField[i, j] < -1)
            {
                if (exploredField[i, j] == -3)
                {
                    PutFlag(i, j);
                }
                exploredField[i, j] = -6 - exploredField[i, j];
                if (Changed != null) Changed();
            }
        }
        string ConvertIntStatusToStr(int st)
        {
            string cell;
            switch (st)
            {
                case -5:
                    cell = "+";
                    break;
                case -4:
                    cell = "?";
                    break;
                case -3:
                    cell = "F";
                    break;
                case -2:
                    cell = "#";
                    break;
                case -1:
                    cell = "*";
                    break;
                default:
                    cell = st + "";
                    break;
            }
            return cell;
        }
        public bool IsCellClosed(int i, int j)
        {
            return (exploredField[i, j] == -2);
        }
        public bool IsCellFlaged(int i, int j)
        {
            return (exploredField[i, j] == -3);
        }
        public bool IsCellMarked(int i, int j)
        {
            return (exploredField[i, j] == -4);
        }
        public string GetCellStr(int i, int j)
        {
            if ((i < 0 || i >= W) || (j < 0 || j >= H))
            {
                return " ";
            }
            return ConvertIntStatusToStr(exploredField[i, j]);
        }

        /*public void ShowField()
        {
            Console.WriteLine();
            for (int i = 0; i < fieldWidth; i++)
            {
                for (int j = 0; j < fieldHeight; j++)
                {
                    Console.Write(GetCellStr(i, j));
                }
                Console.WriteLine();
            }
        }*/
        /*public void PlayParty()
        {
            ShowField();

            while (this.Status == 0)
            {
                user.MakeTurn(this);
                ShowField();
            }
            if (this.Status == 1)
            {
                Console.WriteLine(":)");
            }
            else
            {
                Console.WriteLine(":(");
            }
        }*/

    }
}

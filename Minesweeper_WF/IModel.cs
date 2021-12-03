using System;

namespace Minesweeper_WF
{
    public interface IModel
    {
        public int W { get; }
        public int H { get; }
        public int FlagCounter { get; }
        public int BombAmount { get; }
        public int Duration { get; }
        public int Status { get; }
        public bool IsCellClosed(int i, int j);
        public bool IsCellFlaged(int i, int j);
        public bool IsCellMarked(int i, int j);
        string GetCellStr(int i, int j);
        public event Action Changed;
        public void ClearViews();
        public void ShowAllBombs();
        public void BFSOpenCell(int i, int j);
        public void PutFlag(int i, int j);
        public void PutMark(int i, int j);
    }
}

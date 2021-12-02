using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_WF
{
    public interface IModel
    {
        public int W { get; }
        public int H { get; }
        string GetCellStatus(int i, int j);
        public event Action Changed;
        public void BFSOpenCell(int i, int j);
        public void PutFlag(int i, int j);
    }
}

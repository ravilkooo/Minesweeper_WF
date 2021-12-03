using System.Collections.Generic;

namespace Minesweeper_WF
{
    class Bot : Player
    {
        private Queue<string> actionQueue;

        public override void MakeTurn(Party party) { }
        public void ClearActionQueue()
        {
            this.actionQueue.Clear();
        }
    }
}

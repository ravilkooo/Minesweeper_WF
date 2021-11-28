using System;
using System.Collections.Generic;
using System.Text;

namespace Course_work_3sem
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

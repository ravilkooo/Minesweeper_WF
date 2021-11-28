using System;
using System.Collections.Generic;
using System.Text;

namespace Minesweeper_WF
{
    class User : Player
    {
        public override void MakeTurn(Party party) {
            string s = Console.ReadLine();
            var args = s.Split(' ');
            string action = args[0];
            if (action.Equals("Open"))
            {
                int i = int.Parse(args[1]);
                int j = int.Parse(args[2]);
                party.BFSOpenCell(i, j);
            }
            else if (action.Equals("Flag"))
            {
                int i = int.Parse(args[1]);
                int j = int.Parse(args[2]);
                party.PutFlag(i, j);
            }
            else if (action.Equals("Mark"))
            {
                int i = int.Parse(args[1]);
                int j = int.Parse(args[2]);
                party.PutMark(i, j);
            }
        }
        public User() { }
    }
}

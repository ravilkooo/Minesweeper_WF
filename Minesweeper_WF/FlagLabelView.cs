using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_WF
{
    public class FlagLabelView : Label, IView
    {
        public IModel Model { get; set; }
        public void UpdateView()
        {
            this.Text = $"{Model.BombAmount - Model.FlagCounter}";
        }
    }
}

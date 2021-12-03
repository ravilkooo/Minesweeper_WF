using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_WF
{
    class StatusView : PictureBox, IView
    {
        public IModel Model { get; set; }

        public void UpdateView()
        {
            switch (Model.Status)
            {
                case 0:
                    this.Image = global::Minesweeper_WF.Properties.Resources.alive;
                    break;
                case -1:
                    this.Image = global::Minesweeper_WF.Properties.Resources.loose;
                    break;
                case 1:
                    this.Image = global::Minesweeper_WF.Properties.Resources.won;
                    break;
                default:
                    break;
            }
        }
    }
}

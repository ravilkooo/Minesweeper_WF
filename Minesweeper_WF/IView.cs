using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_WF
{
    public interface IView
    {
        IModel Model { get; set; }
        void UpdateView();
    }
}

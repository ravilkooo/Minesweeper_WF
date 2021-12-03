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

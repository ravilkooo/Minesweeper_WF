namespace Minesweeper_WF
{
    public interface IView
    {
        IModel Model { get; set; }
        void UpdateView();
    }
}

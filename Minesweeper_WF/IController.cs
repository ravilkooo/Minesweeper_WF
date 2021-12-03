namespace Minesweeper_WF
{
    public interface IController
    {
        IModel Model { get; set; }
        void AddView(IView v);
        public void StartModel(sbyte mode, int width, int height);
    }
}

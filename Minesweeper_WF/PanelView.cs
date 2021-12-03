using System.Windows.Forms;

namespace Minesweeper_WF
{
    public delegate void CellClick(object sender, MouseEventArgs e);
    public class PanelView : Panel, IView
    {
        IModel model;
        int fieldWidth = 0, fieldHeight = 0;
        CellView[,] cellViewsArr = null;
        public event CellClick CellClicked;

        public IModel Model
        {
            get => model;
            set
            {
                if (value == null)
                {
                    model = null;
                    if (cellViewsArr != null)
                    {
                        this.Controls.Clear();
                        for (int i = 0; i < fieldWidth; i++)
                        {
                            for (int j = 0; j < fieldHeight; j++)
                            {
                                cellViewsArr[i, j] = null;
                            }
                        }
                        this.fieldWidth = 0;
                        this.fieldHeight = 0;
                        cellViewsArr = null;
                    }
                    return;
                }
                if (cellViewsArr != null)
                {
                    this.Controls.Clear();
                    for (int i = 0; i < fieldWidth; i++)
                    {
                        for (int j = 0; j < fieldHeight; j++)
                        {
                            cellViewsArr[i, j] = null;
                        }
                    }
                    this.fieldWidth = 0;
                    this.fieldHeight = 0;
                    cellViewsArr = null;
                }
                this.Controls.Clear();
                model = value;
                this.fieldWidth = value.W;
                this.fieldHeight = value.H;
                this.cellViewsArr = null;
                this.cellViewsArr = new CellView[fieldWidth, fieldHeight];
                for (int i = 0; i < fieldWidth; i++)
                {
                    for (int j = 0; j < fieldHeight; j++)
                    {

                        cellViewsArr[i, j] = new CellView(i, j);
                        ((System.ComponentModel.ISupportInitialize)(cellViewsArr[i, j])).BeginInit();
                        cellViewsArr[i, j].Init();
                        cellViewsArr[i, j].Model = value;
                        //cellViewsArr[i, j].MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
                        //cellViewsArr[i, j].MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
                        cellViewsArr[i, j].MouseClick += new System.Windows.Forms.MouseEventHandler(this.CellClicked);
                        this.Controls.Add(cellViewsArr[i, j]);
                        ((System.ComponentModel.ISupportInitialize)(cellViewsArr[i, j])).EndInit();
                    }
                }
            }
        }
        public void ClearEvents()
        {
            this.CellClicked = null;
        }
        public PanelView()
        {
            this.DoubleBuffered = true;
            this.AutoSize = true;
            this.Anchor = AnchorStyles.Top;
        }
        /*public void CellClick(object sender, MouseEventArgs e)
        {
            
            int i = (((CellView)((PictureBox)sender)).I);
            int j = (((CellView)((PictureBox)sender)).J);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Model.BFSOpenCell(i, j);
            }
            else
            {
                this.Model.PutFlag(i, j);
            }
        }*/
        public void UpdateView()
        {
            for (int i = 0; i < fieldWidth; i++)
            {
                for (int j = 0; j < fieldHeight; j++)
                {
                    cellViewsArr[i, j].UpdateView();
                }
            }
            this.Invalidate();
        }

        /*protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            if (Model == null) return;
            foreach (Node n in Model.AllNodes)
            {
                //если вес отрицательный, то рисуем черным
                Pen p = new Pen(Color.FromArgb(255, n.Value, n.Value, n.Value), 2);
                g.DrawEllipse(p, n.X * 10, n.Y * 10, 8, 8);
            }
            g.FillEllipse(Brushes.Red, Model.A_X*10, Model.A_Y*10, 8, 8);
        }*/
    }
}

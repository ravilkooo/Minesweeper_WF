using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_WF
{
    public delegate void Clicked(int x, int y);
    public class PanelView : Panel, IView
    {
        IModel model;
        int fieldWidth, fieldHeight;
        CellView[,] cellViewsArr;
        // public event Clicked CellClicked;

        public IModel Model {
            get => model;
            set
            {
                if (value == null) return;
                model = value;
                this.fieldWidth = value.W;
                this.fieldHeight = value.H;
                this.cellViewsArr = new CellView[fieldHeight, fieldWidth];
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
                        cellViewsArr[i, j].MouseClick += new System.Windows.Forms.MouseEventHandler(this.CellClick);
                        this.Controls.Add(cellViewsArr[i, j]);
                        ((System.ComponentModel.ISupportInitialize)(cellViewsArr[i, j])).EndInit();
                    }
                }
            }
        }

        public PanelView()
        {
            this.DoubleBuffered = true;
            this.AutoSize = true;
            this.Anchor = AnchorStyles.Top;
        }
        public void CellClick(object sender, MouseEventArgs e)
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
        }
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

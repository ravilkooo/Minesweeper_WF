using System.Windows.Forms;

namespace Minesweeper_WF
{
    class CellView : PictureBox, IView
    {
        int i, j;
        IModel model;
        string status = "";

        public IModel Model
        {
            get => model;
            set
            {
                if (value == null) return;
                model = value;
            }
        }

        public int I { get => i; }
        public int J { get => j; }

        public CellView(int i, int j)
        {
            this.i = i; this.j = j;
        }
        public void UpdateView()
        {
            string value = model.GetCellStr(i, j);
            if (value != this.status)
            {
                switch (value)
                {
                    case "+":
                        this.Image = global::Minesweeper_WF.Properties.Resources.b;
                        break;
                    case "?":
                        this.Image = global::Minesweeper_WF.Properties.Resources.m;
                        break;
                    case "F":
                        this.Image = global::Minesweeper_WF.Properties.Resources.f;
                        break;
                    case "#":
                        this.Image = global::Minesweeper_WF.Properties.Resources.cl;
                        break;
                    case "*":
                        this.Image = global::Minesweeper_WF.Properties.Resources.exp_b;
                        break;
                    case "0":
                        this.Image = global::Minesweeper_WF.Properties.Resources._0;
                        break;
                    case "1":
                        this.Image = global::Minesweeper_WF.Properties.Resources._1;
                        break;
                    case "2":
                        this.Image = global::Minesweeper_WF.Properties.Resources._2;
                        break;
                    case "3":
                        this.Image = global::Minesweeper_WF.Properties.Resources._3;
                        break;
                    case "4":
                        this.Image = global::Minesweeper_WF.Properties.Resources._4;
                        break;
                    case "5":
                        this.Image = global::Minesweeper_WF.Properties.Resources._5;
                        break;
                    case "6":
                        this.Image = global::Minesweeper_WF.Properties.Resources._6;
                        break;
                    case "7":
                        this.Image = global::Minesweeper_WF.Properties.Resources._7;
                        break;
                    case "8":
                        this.Image = global::Minesweeper_WF.Properties.Resources._8;
                        break;
                    default:
                        this.Image = global::Minesweeper_WF.Properties.Resources._0;
                        break;
                }
                this.status = value;
            }
        }
        public void Init()
        {
            this.Image = global::Minesweeper_WF.Properties.Resources.cl;
            this.Location = new System.Drawing.Point(i * 32, j * 32);
            this.Size = new System.Drawing.Size(32, 32);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TabIndex = 10 + 10 * i + j;
            this.TabStop = false;
        }
    }
}

using System;
using System.Windows.Forms;

namespace Minesweeper_WF
{
    public partial class MainForm : Form, IController
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartModel(0, 9, 9);
        }
        public void StartModel(sbyte mode, int width, int height)
        {
            Model = null;
            Model = new Party(mode, width, height);
            panelView1.CellClicked += panelView1_CellAction;
            AddView(panelView1);
            AddView(flagLabelView1);
            AddView(timerLabelView1);
            AddView(statusView1);
            panelView1.UpdateView();
            flagLabelView1.UpdateView();
            timerLabelView1.UpdateView();
            statusView1.UpdateView();
            debug.Text = $"{panelView1.Width}, {panelView1.Height}";
        }
        public IModel Model { get; set; }
        public void AddView(IView v)
        {
            v.Model = this.Model;
            Model.Changed += new Action(v.UpdateView);
        }
        
        /*
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (((CellView)((PictureBox)sender)).IsClosed)
            {
                ((PictureBox)sender).Image = global::Minesweeper_WF.Properties.Resources.hov;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (((CellView)((PictureBox)sender)).IsClosed)
            {
                ((PictureBox)sender).Image = global::Minesweeper_WF.Properties.Resources.cl;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (((CellView)((PictureBox)sender)).IsClosed)
            {
                ((PictureBox)sender).Image = global::Minesweeper_WF.Properties.Resources._0;
                ((CellView)((PictureBox)sender)).IsClosed = false;
            }
        }*/

        private void продолжитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (Model.Status == 0)
            {
                timerLabelView1.UpdateView();
            }
        }

        private void x9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartModel(0, 9, 9);
        }

        private void x16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartModel(0, 16, 16);
        }

        private void x19ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartModel(0, 30, 16);
        }
        private void любительToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void x9ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StartModel(1, 9, 9);
        }
        private void x16ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StartModel(1, 16, 16);
        }
        private void x19ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StartModel(1, 30, 16);
        }
        private void x9ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StartModel(2, 9, 9);
        }
        private void x16ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StartModel(2, 16, 16);
        }
        private void x19ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StartModel(2, 30, 16);
        }

        private void panelView1_CellAction(object sender, MouseEventArgs e)
        {
            int i = (((CellView)((PictureBox)sender)).I);
            int j = (((CellView)((PictureBox)sender)).J);
            debug.Text = $"{Model.Status}";
            if (Model.Status == 0)
            {
                debug.Text = $"{i}, {j}";
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    if (Model.IsCellClosed(i, j))
                    {
                        Model.BFSOpenCell(i, j);
                    }
                }
                else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    if (Model.IsCellClosed(i, j))
                    {
                        Model.PutFlag(i, j);
                    }
                    else
                    {
                        Model.PutMark(i, j);
                    }
                }
            }
        }

        private void flagLabelView1_Click(object sender, EventArgs e)
        {

        }
    }
}

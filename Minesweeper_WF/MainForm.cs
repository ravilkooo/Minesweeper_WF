using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_WF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var buttonsArr = new CellControl[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    buttonsArr[i, j] = new CellControl(i, j);
                    ((System.ComponentModel.ISupportInitialize)(buttonsArr[i, j])).BeginInit();
                    buttonsArr[i, j].Init();
                    buttonsArr[i, j].MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
                    buttonsArr[i, j].MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
                    buttonsArr[i, j].Click += new System.EventHandler(this.pictureBox1_Click);
                    this.cellsPanel.Controls.Add(buttonsArr[i, j]);
                    ((System.ComponentModel.ISupportInitialize)(buttonsArr[i, j])).EndInit();
                }
            }
        }



        private void x19ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (((CellControl)((PictureBox)sender)).IsClosed)
            {
                ((PictureBox)sender).Image = global::Minesweeper_WF.Properties.Resources.hov;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (((CellControl)((PictureBox)sender)).IsClosed)
            {
                ((PictureBox)sender).Image = global::Minesweeper_WF.Properties.Resources.cl;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (((CellControl)((PictureBox)sender)).IsClosed)
            {
                ((PictureBox)sender).Image = global::Minesweeper_WF.Properties.Resources._0;
                ((CellControl)((PictureBox)sender)).IsClosed = false;
            }
        }

        private void продолжитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

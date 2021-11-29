using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_WF
{
    class CellControl : PictureBox
    {
        public bool IsClosed = true;
        int i, j;
        public CellControl(int i, int j)
        {
            this.i = i; this.j = j;
        }

        public void Init()
        {
            //((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.Image = global::Minesweeper_WF.Properties.Resources.cl;
            this.Location = new System.Drawing.Point(i * 32, j * 32);
            this.Size = new System.Drawing.Size(32, 32);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TabIndex = 10 + 10 * i + j;
            this.TabStop = false;
            this.IsClosed = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSplash : Form
    {
        int move;
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timer1.Start();
            move = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelSilde.Left += 3;
            if (panelSilde.Left > 435)
            {
                panelSilde.Left = 0;
            }
            if (panelSilde.Left < 0)
            {
                move = 2;
            }
        }
    }
}

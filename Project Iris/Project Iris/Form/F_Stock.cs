using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Iris
{
    public partial class F_Stock : Form
    {
        public F_Stock()
        {
            InitializeComponent();
        }

        private void buttonBacc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

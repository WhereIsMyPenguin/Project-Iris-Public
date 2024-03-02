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
    public partial class F_Hattyu : Form
    {
        public F_Hattyu()
        {
            InitializeComponent();
        }

        private void AddUserControl(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            DisplayPanel.Controls.Clear();
            DisplayPanel.Controls.Add(control);
            control.BringToFront();
        }

        private void SwtichMenu(int menuID)
        {
            if (menuID == 0)
            {
                panelHattyu.BackColor = Color.DarkBlue;
                panelWarehousing.BackColor = Color.DarkSlateBlue;
                panelHattyu.Padding = new Padding(0, 0, 0, 15);
                buttonHattyu.Padding = new Padding(0, 15, 0, 0);
                panelWarehousing.Padding = new Padding(0, 0, 0, 0);
                buttonHattyu.Padding = new Padding(0, 0, 0, 0);
            }
            else
            {
                panelHattyu.BackColor = Color.DarkBlue;
                panelWarehousing.BackColor = Color.DarkSlateBlue;
                panelWarehousing.Padding = new Padding(0, 0, 0, 15);
                buttonWarehousing.Padding = new Padding(0, 15, 0, 0);
                panelHattyu.Padding = new Padding(0, 0, 0, 0);
                buttonWarehousing.Padding = new Padding(0, 0, 0, 0);
            }
        }

        private void IHaveTheControl(string WhatControl)
        {
            switch (WhatControl)
            {
                case "":
                    AddUserControl(new U_Hattyu());
                    break;
                case "Hattyu":
                    AddUserControl(new U_Hattyu());
                    break;
                case "Warehousing":
                    AddUserControl(new U_Warehousing());
                    break;
            }
        }

        private void buttonBacc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_Hattyu_Load(object sender,EventArgs e)
        {
            panelHattyu.BackColor = Color.Coral;
            panelHattyu.Padding = new Padding(0, 0, 0, 5);
            buttonHattyu.Padding = new Padding(0, 5, 0, 0);
            panelWarehousing.BackColor = Color.DarkSlateBlue;
            panelWarehousing.Padding = new Padding(0, 0, 0, 0);
            buttonWarehousing.Padding = new Padding(0, 0, 0, 0);
            IHaveTheControl("");
        }

        private void buttonHattyu_Click(object sender, EventArgs e)
        {
            SwtichMenu(0);
            IHaveTheControl("Hattyu");
        }

        private void buttonWarehousing_Click(object sender, EventArgs e)
        {
            SwtichMenu(1);
            IHaveTheControl("Warehousing");
        }
    }
}

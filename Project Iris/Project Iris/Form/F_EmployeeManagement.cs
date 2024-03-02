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
    public partial class F_EmployeeManagement : Form
    {
        public F_EmployeeManagement()
        {
            InitializeComponent();
        }

        private void buttonBacc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUserControl(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            DisplayPanel.Controls.Clear();
            DisplayPanel.Controls.Add(control);
            control.BringToFront();
        }

        private void F_EmployeeManagement_Load(object sender, EventArgs e)
        {
            panelEmployee.BackColor = Color.Coral;
            panelEmployee.Padding = new Padding(0, 0, 0, 15);
            buttonEmployee.Padding = new Padding(0, 15, 0, 0);
            panelPosition.BackColor = Color.MediumSlateBlue;
            panelPosition.Padding = new Padding(0, 0, 0, 0);
            buttonPosition.Padding = new Padding(0, 0, 0, 0);
            IHaveTheControl("");
        }
        private void SwitchMenu(int menuID)
        {
            if(menuID == 0)
            {
                panelEmployee.BackColor = Color.Coral;
                panelPosition.BackColor = Color.MediumSlateBlue;
                panelEmployee.Padding = new Padding(0, 0, 0, 15);
                buttonEmployee.Padding = new Padding(0, 15, 0, 0);
                panelPosition.Padding = new Padding(0, 0, 0, 0);
                buttonPosition.Padding = new Padding(0, 0, 0, 0);
            }
            else
            {
                panelEmployee.BackColor = Color.MediumSlateBlue;
                panelPosition.BackColor = Color.DarkSlateBlue;
                panelPosition.Padding = new Padding(0, 0, 0, 15);
                buttonPosition.Padding = new Padding(0, 15, 0, 0);
                panelEmployee.Padding = new Padding(0, 0, 0, 0);
                buttonEmployee.Padding = new Padding(0, 0, 0, 0);
            }
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            SwitchMenu(0);
            IHaveTheControl("Employee");
        }

        private void buttonPosition_Click(object sender, EventArgs e)
        {
            SwitchMenu(1);
            IHaveTheControl("Position");
        }
        private void IHaveTheControl(string WhatControl)
        {
            switch(WhatControl)
            {
                case "": AddUserControl(new U_Employee());
                    break;
                case "Employee":AddUserControl(new U_Employee());
                    break;
                case "Position":AddUserControl(new U_Position());
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

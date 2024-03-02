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
    public partial class F_ProductManagement : Form
    {
        public F_ProductManagement()
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

        private void F_ProductManagement_Load(object sender, EventArgs e)
        {
            panelProduct.BackColor = Color.Coral;
            panelProduct.Padding = new Padding(0, 0, 0, 15);
            buttonProduct.Padding = new Padding(0, 15, 0, 0);
            panelClassify.BackColor = Color.MediumSlateBlue;
            panelClassify.Padding = new Padding(0, 0, 0, 0);
            buttonClassify.Padding = new Padding(0, 0, 0, 0);
            IHaveTheControl("");
        }
        private void SwitchMenu(int menuID)
        {
            if (menuID == 0)
            {
                panelProduct.BackColor = Color.Coral;
                panelClassify.BackColor = Color.MediumSlateBlue;
                panelProduct.Padding = new Padding(0, 0, 0, 15);
                buttonProduct.Padding = new Padding(0, 15, 0, 0);
                panelClassify.Padding = new Padding(0, 0, 0, 0);
                buttonClassify.Padding = new Padding(0, 0, 0, 0);
            }
            else
            {
                panelProduct.BackColor = Color.MediumSlateBlue;
                panelClassify.BackColor = Color.DarkSlateBlue;
                panelClassify.Padding = new Padding(0, 0, 0, 15);
                buttonClassify.Padding = new Padding(0, 15, 0, 0);
                panelProduct.Padding = new Padding(0, 0, 0, 0);
                buttonProduct.Padding = new Padding(0, 0, 0, 0);
            }
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            SwitchMenu(0);
            IHaveTheControl("Product");
        }

        private void buttonClassify_Click(object sender, EventArgs e)
        {
            SwitchMenu(1);
            IHaveTheControl("Classify");
        }
        private void IHaveTheControl(string WhatControl)
        {
            switch (WhatControl)
            {
                case "":
                    AddUserControl(new U_Product());
                    break;
                case "Product":
                    AddUserControl(new U_Product());
                    break;
                case "Classify":
                    AddUserControl(new U_Classify());
                    break;
            }
        }
    }
}

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
    public partial class ButtonCheckBox : CheckBox
    {
        string temp;
        string str = "checkBox1";
        public String CheckBoxText
        {
            get { return str; }
            set { str = value; this.Text = str; temp = str; Invalidate(); }
        }
        public ButtonCheckBox()
        {
            InitializeComponent();
            this.MinimumSize = new Size(245, 45);
            temp = this.Text;
            this.FlatStyle = FlatStyle.Flat;
            this.Appearance = Appearance.Button;
        }
        private void checkBox_Checked(object sender, EventArgs e)
        {
            if(this.Checked)
            { this.Text = "✔ " + str; this.TextAlign = ContentAlignment.MiddleLeft; }
            else
            { this.Text = temp; this.TextAlign = ContentAlignment.MiddleCenter; }
        }
    }
}

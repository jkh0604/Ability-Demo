using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControl1;
using UserControl2;


namespace AbilityDemo
{
    public partial class Ability_Demo : Form
    {
        public Ability_Demo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "Add UC1")
            {
                btn1.Text = "Remove UC1";
                UC1 uc1 = new UC1();
                panel1.Controls.Add(uc1);
            }
            else if (btn1.Text == "Remove UC1")
            {
                btn1.Text = "Add UC1";
                panel1.Controls.Clear();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "Add UC2")
            {
                btn2.Text = "Remove UC2";
                UC2 uc2 = new UC2();
                panel2.Controls.Add(uc2);
            }
            else if (btn2.Text == "Remove UC2")
            {
                btn2.Text = "Add UC2";
                panel2.Controls.Clear();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //UC1 uc1 = new UC1();
            //panel1.Controls.Add(uc1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

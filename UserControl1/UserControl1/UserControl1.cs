using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl1
{
    public partial class UC1: UserControl
    {
        public UC1()
        {
            InitializeComponent();
        }

        private void UC1_Load(object sender, EventArgs e)
        {
            label.Text = "User Control 1";
            this.Dock = DockStyle.Fill;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

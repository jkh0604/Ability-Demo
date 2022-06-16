using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl2
{
    public partial class UC2: UserControl
    {
        public UC2()
        {
            InitializeComponent();
        }

        private void UC2_Load(object sender, EventArgs e)
        {
            label.Text = "User Control 2";
            this.Dock = DockStyle.Fill;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

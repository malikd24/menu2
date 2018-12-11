using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dash
{
    public partial class pic2 : Form
    {
        public pic2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            this.Close();
            dasboard1 dashboard1 = new dasboard1();
            dashboard1.ShowDialog();
        }
    }
}

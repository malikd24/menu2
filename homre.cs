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
    public partial class homre : Form
    {
        public homre()
        {
            InitializeComponent();
        }

        private void Form1_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard dashboard2 = new dashboard();
            dashboard2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            dasboard1 dashboard = new dasboard1();
            dashboard.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            userInfo userInfo = new userInfo();
            userInfo.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            faceDetection detection = new faceDetection();
            detection.ShowDialog();
        }
    }

    
}

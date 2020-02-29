using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            InfixToPostfix infix = new InfixToPostfix();
            infix.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            TowerOfHanoi TOH = new TowerOfHanoi();
            TOH.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            BracketBalancer BB = new BracketBalancer();
            BB.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

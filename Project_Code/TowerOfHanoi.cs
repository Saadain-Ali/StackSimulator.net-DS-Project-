using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Code
{
    public partial class TowerOfHanoi : Form
    {
        public TowerOfHanoi()
        {
            InitializeComponent();
        }

        private void TowerOfHanoi_Load(object sender, EventArgs e)
        {

        }


        int Count = 1;
        public void solveTowers(int n, Button Left, Button Right, Button Middle, FlowLayoutPanel L, FlowLayoutPanel M, FlowLayoutPanel R)
        {
            if (n > 0)
            {

                solveTowers(n - 1, Left, Middle, Right, L, R, M);
                TextBox TempBox = new TextBox();
                TempBox.Name = Count.ToString();
                flowLayoutPanel2.Controls.Add(TempBox);
                TempBox.Text = ("Move disk from " + L.Name + ' ' + R.Name);

                R.Controls.Add((Control)Left);

                //L.Controls.RemoveAt(n);
                solveTowers(n - 1, Left, Middle, Right, L, R, M);


            }
        }

        public void solveTowers(int n, FlowLayoutPanel L, FlowLayoutPanel R, FlowLayoutPanel M)
        {
            if (n > 0)
            {

                solveTowers(n - 1, L, M, R);
                TextBox TempBox = new TextBox();
                TempBox.Name = Count.ToString();
                flowLayoutPanel2.Controls.Add(TempBox);
                TempBox.Text = ("Move disk from " + L.Name + ' ' + R.Name);

                R.Controls.Add(L.Controls[L.Controls.Count - 1]);
                //L.Controls.RemoveAt(n);
                this.Refresh();
                Thread.Sleep(1000);
                solveTowers(n - 1, M, R, L);

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _clock_Tick(object sender, EventArgs e)
        {

            int totalDisks = int.Parse(Disk_num.Text); // number of disks
            DiskGenrator(totalDisks);
            Thread.Sleep(1000);
            solveTowers(totalDisks, a, c, b);
            _clock.Stop();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear(); //clears 4th panel
            c.Controls.Clear(); // ..clear 3rd panel
            if (isvalid(Disk_num.Text))
            {
                if (int.Parse(Disk_num.Text) <= 5)
                {
                    _clock.Start();
                }
                else MessageBox.Show("Max 5 disks are allowed");
            }
            else
            {
                MessageBox.Show("Invalid Value");
                Disk_num.Text = "";
            }
            
            
           
        }


        private bool isvalid(string data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (!((data[i] <= '9' && data[i] >= '0')))
                {
                    return false;
                }
            }
            return true;
        }

        public void DiskGenrator(int n)
        {
            int width = 136;
            int breath = 30;
            int margin = 0;
            for (int i = n; i >= 1; i--)
            {
                Button btn = new Button();
                btn.BackColor = Color.Red;
                btn.Name = i.ToString();
                btn.Text = i.ToString();
                btn.Size = new Size(width, breath);
                btn.Margin = new Padding(margin, 0, 0, 0);
                Random randonGen = new Random();
                Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));
                btn.BackColor = randomColor;
                a.Controls.Add(btn);
                Thread.Sleep(1000);
                this.Refresh();
                width -= 15;
                margin += 8;
            }
        }

        private void c_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form1 _form1 = new Form1();
            _form1.Show();
            this.Close();

        }

    }
}

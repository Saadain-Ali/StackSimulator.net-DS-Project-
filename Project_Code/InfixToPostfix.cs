using Bunifu.Framework.UI;
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
    public partial class InfixToPostfix : Form
    {
        public InfixToPostfix()
        {
            InitializeComponent();
        }

        private void InfixToPostfix_Load(object sender, EventArgs e)
        {

        }

        int delay;
        //////==============================CODE===================================/////
        public bool PolishNotation(ref string infix, out string postfix)
        {

            int prio = 0;
            postfix = "";
            infix += "  ";
            Stack<string> s1 = new Stack<string>();
            for (int i = 0; i < infix.Length; i++)
            {
                //charColorChange(i);
                richTextBox1.Select(0, richTextBox1.Text.Length - 1);
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.Select(0, richTextBox1.Text.Length - 1);
                richTextBox1.SelectionBackColor = Color.White;
                richTextBox1.Select(i, 1);
                richTextBox1.SelectionColor = Color.White;
                richTextBox1.Select(i, 1);
                richTextBox1.SelectionBackColor = Color.Red;
                //= Color.Red;
                string ch = "";
                if (infix[i + 1] <= '9' && infix[i + 1] >= '0' && infix[i] <= '9' && infix[i] >= '0')
                {
                    ch += infix[i];
                    ch += infix[i + 1];
                    i++;
                }
                else ch = infix[i].ToString();
                if (ch == "+" || ch == "-" || ch == "*" || ch == "/")
                {
                    //current value//
                    Bunifu.Framework.UI.BunifuThinButton2 btn = buttonCreator();
                    btn.ButtonText = (ch).ToString();
                    flowLayoutPanel2.Controls.Add(btn);
                    /////////////////////////////

                    if (s1.Count <= 0)
                    {
                        pushVis(ch, Stack1);
                        Thread.Sleep(delay);
                        s1.Push(ch);
                        this.Refresh();
                    }
                    else
                    {
                        if (s1.Peek() == "*" || s1.Peek() == "/")
                        {
                            //Button b1 = flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1] as Button;
                            //b1.BackColor = Color.Red;
                            prio = 1;
                        }
                        else
                            prio = 0;

                        if (prio == 1)
                        {
                            if (ch == "+" || ch == "-")
                            {
                                pushVis(s1.Peek(), finalpanel);
                                this.Refresh();
                                Thread.Sleep(delay);
                                popVis();
                                this.Refresh();
                               

                                postfix += s1.Pop();

                                i--;
                            }
                            else
                            {

                                pushVis(s1.Peek(), finalpanel);
                                this.Refresh();
                                Thread.Sleep(delay);
                                popVis();
                                
                                
                                postfix += s1.Pop();
                                i--;
                            }
                        }
                        else // IF PRIORITY IS = 0
                        {
                            if (ch == "+" || ch == "-")
                            {
                                if (s1.Peek() == "+" || s1.Peek() == "-")
                                {
                                    pushVis(s1.Peek(), finalpanel);
                                    this.Refresh();
                                    Thread.Sleep(delay);
                                    popVis();   
                                }

                                pushVis(ch, Stack1);
                                this.Refresh();
                                Thread.Sleep(delay);

                                // Button b = Stack1.Controls[Stack1.Controls.Count - 1] as Button;
                              //  BunifuThinButton2 b = Stack1.Controls[Stack1.Controls.Count - 1] as BunifuThinButton2;
                                //b.BackColor = Color.Teal;

                                // Thread.Sleep(delay);
                               // this.Refresh();
                                // popVis();
                                postfix += s1.Pop();
                                //popVis();

                                s1.Push(ch);


                            }
                            else
                            {

                                s1.Push(ch);
                                pushVis(ch, Stack1);
                                // Thread.Sleep(600);
                                this.Refresh();
                                Thread.Sleep(delay);
                            }
                        }
                    }
                }
                else
                {
                    pushVis(ch, finalpanel);
                    Thread.Sleep(1000);
                    this.Refresh();
                    Thread.Sleep(delay);

                    //popVis();

                    postfix += ch;
                }
                flowLayoutPanel2.Controls.Clear();
                if (infix[i + 1].ToString() == " ")
                    break;
            }
            int len = s1.Count;
            for (int j = 0; j < len; j++)
            {

                pushVis(s1.Peek(), finalpanel);
                postfix += s1.Pop();
                popVis();
                //Thread.Sleep(delay);
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            finalpanel.Controls.Clear();
            PostFixBox.Text = "";

            String postfix;
            String infix = "";

            if (richTextBox1.Text == "") MessageBox.Show("Please enter a value");
            else
            {
                infix = richTextBox1.Text;
                if (!isvalid(richTextBox1.Text)) MessageBox.Show("Please enter correct value");
                else
                {

                    if (delaybox.Text == "" || int.Parse(delaybox.Text) < 1000 || int.Parse(delaybox.Text) > 3000)
                        delaybox.Text = "1000";

                    delay = int.Parse(delaybox.Text);
                    if (PolishNotation(ref infix, out postfix))
                    {
                        PostFixBox.AppendText(postfix);
                    }
                }
            }
        }

        private bool isvalid( string data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (!(data[i] == '+' || data[i] == '-' || data[i] == '/' || data[i] == '*' || (data[i] <= '9' && data[i] >= '0')))
                {
                    return false;
                }
            }
            return true;
        }





        public void pushVis(string data, Panel panel)
        {

            
            Bunifu.Framework.UI.BunifuThinButton2 btn = buttonCreator();
            btn.ButtonText = (data).ToString();
            panel.Controls.Add(btn);
            this.Refresh();
            finalpanel.Refresh();
        }

        public void popVis()
        {
            Thread.Sleep(delay);
            this.Refresh();
          
            Bunifu.Framework.UI.BunifuThinButton2 btn = new Bunifu.Framework.UI.BunifuThinButton2();

            btn = Stack1.Controls[Stack1.Controls.Count - 1] as Bunifu.Framework.UI.BunifuThinButton2;
          
            Stack1.Controls.Remove(btn);
            btn.BackColor = Color.Red;
            Thread.Sleep(delay);
            this.Refresh();
        }




        public void charColorChange(int ind)
        {
            //char select = i;
            //int index = richTextBox1.Text.IndexOf(i);
            int length = richTextBox1.Text.Length;
            richTextBox1.Select(ind, length);
            richTextBox1.SelectionBackColor = Color.Red;

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public BunifuThinButton2 buttonCreator()
        {
            BunifuThinButton2 bunifuThinButton21 = new BunifuThinButton2();
            bunifuThinButton21.ActiveCornerRadius = 20;
            bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Transparent;
            bunifuThinButton21.ActiveForecolor = System.Drawing.Color.DimGray;
            bunifuThinButton21.ActiveBorderThickness = 1;
            bunifuThinButton21.ActiveLineColor = System.Drawing.Color.OrangeRed;
            bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            bunifuThinButton21.ButtonText = "+";
            bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            bunifuThinButton21.Font = new System.Drawing.Font("Digitalt", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            bunifuThinButton21.IdleBorderThickness = 2;
            bunifuThinButton21.IdleCornerRadius = 20;
            bunifuThinButton21.IdleFillColor = System.Drawing.Color.LightGray;
            bunifuThinButton21.IdleForecolor = System.Drawing.Color.DimGray;
            bunifuThinButton21.IdleLineColor = System.Drawing.Color.RosyBrown;
            bunifuThinButton21.Location = new System.Drawing.Point(74, 88);
            bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            bunifuThinButton21.Name = "bunifuThinButton21";
            bunifuThinButton21.Size = new System.Drawing.Size(117, 69);
            bunifuThinButton21.TabIndex = 0;
            bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            return bunifuThinButton21;
        }

        private void PostFixBox_TextChanged(object sender, EventArgs e)
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

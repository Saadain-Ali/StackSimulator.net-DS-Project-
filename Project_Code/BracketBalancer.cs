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
    public partial class BracketBalancer : Form
    {
        public BracketBalancer()
        {
            InitializeComponent();
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form1 _form1 = new Form1();
            _form1.Show();
            this.Close();
        }


        ///======  Button Click ============//
        int count = 0;

        private void InpBtn_Click(object sender, EventArgs e)
        {
            FinalShowPanel.Controls.Clear();
            StackePnl.Controls.Clear();
            if (InputCheck(inpbox.Text))
            {
                BracketBalancers(inpbox.Text);
            }
            else
            {
                inpbox.Text = "";
                MessageBox.Show("Please Enter Correct value");
            }
        }





        ///===================================================CODE=============================================================//
        bool check = false; /// check for Final msg
        public void BracketBalancers(string inp)
        {
            Stack<char> stk = new Stack<char>(); //stack of Char Data Type
            for (int i = 0; i < inp.Length; i++)
            {

                if (inp[i] == '[' || inp[i] == '(' || inp[i] == '{')
                {
                    stk.Push((inp[i]));
                    push(inp[i], StackePnl);     /// Push brackets in to stacks//
                    Thread.Sleep(1000);
                    this.Refresh();
                }
                else if ((inp[i] == ']' || inp[i] == ')' || inp[i] == '}') && stk.Count() == 0) /// Checking if the very first value is a Closing Bracket or opening
                {
                    push(inp[i], TempStk);
                    Button Bt = (TempStk.Controls[TempStk.Controls.Count - 1]) as Button;
                    Bt.BackColor = Color.Red;
                    push(inp[i], FinalShowPanel);
                    MessageBox.Show("Brackets are unbalanced because there is no element to compare '" + inp[i] + "' to!!");
                    TempStk.Controls.Remove(TempStk.Controls[TempStk.Controls.Count - 1]);
                    check = false;
                    break;
                }
                else if (matcinpair(Convert.ToChar(stk.Peek()), inp[i]) == true) // Call the matching function
                {
                    stk.Pop();


                    push(inp[i], TempStk);
                    Thread.Sleep(1000);         // First push into temp stack to show the value
                    this.Refresh();



                    Button StackFirstValue = (StackePnl.Controls[StackePnl.Controls.Count - 1]) as Button;
                    Button TempStackFirstValue = (TempStk.Controls[TempStk.Controls.Count - 1]) as Button;


                    Thread.Sleep(1000);


                    //==Random Color Generator========//
                    Button[] arr = { StackFirstValue, TempStackFirstValue };
                    Random randonGen = new Random();
                    Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));
                    foreach (Button item in arr)
                    {
                        item.BackColor = randomColor;
                    }
                    this.Refresh();



                    Thread.Sleep(1000);
                    this.Refresh();


                    FinalShowPanel.Controls.Add(StackFirstValue); /// Opening Bracket

                    Linker(); // Linker between two brackets




                    FinalShowPanel.Controls.Add(TempStackFirstValue);    ///======Closing Bracket/////



                    Thread.Sleep(1000);
                    this.Refresh();
                    check = true;

                }
                //else if (stk.Count >= 0 && i == (inp.Length-1))
                //{
                //    check = false;
                //}
                else
                {
                    MessageBox.Show("Brackets are unbalanced because " + inp[i] + " doesn't match the top bracket i.e " + stk.Peek());
                    check = false;
                    break;
                }
            }
            if (check && !(stk.Count > 0))
                MessageBox.Show("Brackets are Balanced");
            else
            {
                MessageBox.Show("Brackets are Unbalanced");
            }
        }

        private void Linker()
        {
            Button btn = new Button();
            btn.Name = count.ToString();
            //btn.Text = "<===================>";
            btn.Image = Image.FromFile(@"../../arrow.png");
            btn.Size = new Size(173, 49);
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.Azure;
            FinalShowPanel.Controls.Add(btn);
        }

        //function to match the brackets
        static bool matcinpair(char top, char inp)
        {
            if (top == null)
                return false;
            else if (top == '[' && inp == ']')
                return true;
            else if (top == '{' && inp == '}')
                return true;
            else if (top == '(' && inp == ')')
                return true;

            return false;

        }




        //===============================================END===================================================================///




        //Function to print the stack
        static void stkPrint(Stack<char> stack)
        {

            foreach (char item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n");
        }




        //===Push===Buttons=//

        public void push(char data, FlowLayoutPanel stk)
        {
            Button btn = new Button();
            btn.Name = count.ToString();
            btn.Text = data.ToString();
            btn.Size = new Size(173, 49);
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.Azure;
            btn.ForeColor = Color.SeaGreen;
            btn.Font = new System.Drawing.Font("Digitalt", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stk.Controls.Add(btn);
            Thread.Sleep(1000);
            this.Refresh();
        }





        //======================POP ===============Buttons ==============================///
        public void pop(Button btn)
        {
            btn.BackColor = Color.YellowGreen;
            this.Refresh();
            Thread.Sleep(1200);
            TempStk.Controls.Add(StackePnl.Controls[StackePnl.Controls.Count - 1]);
            btn.BackColor = Color.Green;
        }





        ///=====================Input Checker=========================//
        private bool InputCheck(string p)
        {
            bool ans = true;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == '{' || p[i] == '}' || p[i] == '[' || p[i] == ']' || p[i] == '(' || p[i] == ')')
                {
                    ans = true;
                }
                else
                {
                    return false;
                }
            }
            return ans;
        }
    }
}

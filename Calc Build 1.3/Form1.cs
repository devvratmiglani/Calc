using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        int s;
        int NoTwoOperator()
        {
            if (Display.Text.Length < 1)
            {
                label2.Text = "Missing Operand";
                label2.Visible = true;
                return 2;
            }
            char lastElement = Display.Text[Display.Text.Length - 1];
            
            if( lastElement == '+' ||
                lastElement == '-' ||
                lastElement == '*' ||
                lastElement == '/' ||
                lastElement == '.' ||
                lastElement == '%' ) { return 0; }
            else { return 1; }
        
            
        }

        string result="";
        int num = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            s = Display.SelectionStart;
            //Display.Text = Display.Text + 1;
            Display.Text = Display.Text.Insert(Display.SelectionStart, Convert.ToString(1));
            Display.SelectionStart = s + 1;
            Display.ScrollToCaret();
            label3.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Display.Text = Display.Text + 2;
            s = Display.SelectionStart;
            Display.Text = Display.Text.Insert(Display.SelectionStart, Convert.ToString(2));
            Display.SelectionStart = s + 1;
            Display.ScrollToCaret();
            label3.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Display.Text = Display.Text + 3;
            s = Display.SelectionStart;
            Display.Text = Display.Text.Insert(Display.SelectionStart, Convert.ToString(3));
            Display.SelectionStart = s + 1;
            Display.ScrollToCaret();
            label3.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Display.Text = Display.Text + 4;
            s = Display.SelectionStart;
            Display.Text = Display.Text.Insert(Display.SelectionStart, Convert.ToString(4));
            Display.SelectionStart = s + 1; 
            Display.ScrollToCaret();
            label3.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Display.Text = Display.Text + 5;
            s = Display.SelectionStart;
            Display.Text = Display.Text.Insert(Display.SelectionStart, Convert.ToString(5));
            Display.SelectionStart = s + 1;
            Display.ScrollToCaret();
            label3.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Display.Text = Display.Text + 6;
            s = Display.SelectionStart;
            Display.Text = Display.Text.Insert(Display.SelectionStart, Convert.ToString(6));
            Display.SelectionStart = s + 1;
            Display.ScrollToCaret();
            label3.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Display.Text = Display.Text + 7;
            s = Display.SelectionStart;
            Display.Text = Display.Text.Insert(Display.SelectionStart, Convert.ToString(7));
            Display.SelectionStart = s + 1;
            Display.ScrollToCaret();
            label3.Focus();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Display.Text = Display.Text + 8;
            s = Display.SelectionStart;
            Display.Text = Display.Text.Insert(Display.SelectionStart, Convert.ToString(8));
            Display.SelectionStart = s + 1;
            Display.ScrollToCaret();
            label3.Focus();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Display.Text = Display.Text + 9;
            s = Display.SelectionStart;
            Display.Text = Display.Text.Insert(Display.SelectionStart, Convert.ToString(9));
            Display.SelectionStart = s + 1;
            Display.ScrollToCaret();
            label3.Focus();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            //Display.Text = Display.Text + 0;
            s = Display.SelectionStart;
            Display.Text = Display.Text.Insert(Display.SelectionStart, Convert.ToString(0));
            Display.SelectionStart = s + 1;
            Display.ScrollToCaret();
            label3.Focus();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            num = Display.Text.Length - 1;
            if (NoTwoOperator()==0)
            {
                Display.Text = Display.Text.Remove(num);
                Display.Text = Display.Text + "+";
            }
            else if(NoTwoOperator()==1)
            {
                Display.Text = Display.Text + "+";
            }

            Display.Select(Display.Text.Length, 0);
            Display.ScrollToCaret();
            label3.Focus();
        }

        private void buttonsub_Click(object sender, EventArgs e)
        {
            num = Display.Text.Length - 1;
            if (NoTwoOperator() == 0)
            {
                Display.Text = Display.Text.Remove(num);
                Display.Text = Display.Text + "-";
            }
            else if (NoTwoOperator() == 1)
            {
                Display.Text = Display.Text + "-";
            }

            Display.Select(Display.Text.Length, 0);
            Display.ScrollToCaret();
            label3.Focus();
        }

        private void buttonmul_Click(object sender, EventArgs e)
        {
            num = Display.Text.Length - 1;
            if (NoTwoOperator() == 0)
            {
                Display.Text = Display.Text.Remove(num);
                Display.Text = Display.Text + "*";
            }
            else if (NoTwoOperator() == 1)
            {
                Display.Text = Display.Text + "*";

            }

            Display.Select(Display.Text.Length, 0);
            Display.ScrollToCaret();
            label3.Focus();
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            num = Display.Text.Length - 1;
            if (NoTwoOperator() == 0)
            {
                Display.Text = Display.Text.Remove(num);
                Display.Text = Display.Text + "/";
            }
            else if (NoTwoOperator() == 1)
            {
                Display.Text = Display.Text + "/";
            }

            Display.Select(Display.Text.Length, 0);
            Display.ScrollToCaret();
            label3.Focus();
        }

        private void buttoneq_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            bool check = true;
            if(Display.Text.Length <1)
            {
                label2.Text = "No Expression";
                label2.Visible=true;
                check = false;

            }
            else if (Display.Text.Contains('/') && Display.Text.Contains('%')) 
            {
                label2.Text = "Cannot use Division and Modulus Together";
                label2.Visible = true;

            }
            else if(NoTwoOperator()==0)
            {
                label2.Text = "Missing Operand";
                label2.Visible=true;
            }
            
            else if (Display.Text.Contains('.') && Display.Text.Contains('%'))
            {
                label2.Text = "Remainder is limited to Integer Data Type only";
                label2.Visible = true;
                
            }
            else if (Display.Text.Contains('.') || Display.Text.Contains("%"))
            {
                result = Display.Text;
                try
                {
                Display.Text = Convert.ToString((new DataTable().Compute(result, null)));
                }
                catch (OverflowException ep)
                {
                    label2.Visible = true;
                    label2.Text = "Value Too Large";
                }
                catch (DivideByZeroException ep)
                {
                    label2.Visible = true;
                    label2.Text = "Cannot divide by zero";
                }
            }
            else
            {
                result = "1.0*"+Display.Text;
                try
                {
                    Display.Text = Convert.ToString((new DataTable().Compute(result, null)));
                }
                catch (DivideByZeroException ep)
                {
                    label2.Visible = true;
                    label2.Text = "Cannot divide by zero";
                }
            }

            if (check)
            {
                num = Display.Text.Length - 1;
                try
                {
                    if (Display.Text[num] == '0' && Display.Text[num - 1] == '.')
                    {
                        Display.Text = Display.Text.Remove(num);
                        Display.Text = Display.Text.Remove(num - 1);
                    }
                }
                catch(Exception ex) 
                { 
                
                }
            }
            Display.Select(Display.Text.Length, 0);
            label3.Focus();

        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            if (Display.SelectionStart < 1)
            {
                num = Display.Text.Length - 1;
                if (num > -1)
                {
                    Display.Text = Display.Text.Remove(num);
                }
            }

            else
            {
                int s = Display.SelectionStart-1;
                Display.Text=Display.Text.Remove(s,1);
                Display.SelectionStart = s;
                Display.Focus();

            }
            Display.ScrollToCaret();
            label3.Focus();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Developed by Devvrat Ajay Miglani");
            label1.Visible = true;
            label3.Focus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Display.Clear();
            label3.Focus();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num = Display.Text.Length - 1;
            if (NoTwoOperator() == 0)
            {
                Display.Text = Display.Text.Remove(num);
                Display.Text = Display.Text + "%";
            }
            else if (NoTwoOperator() == 1)
            {
                Display.Text = Display.Text + "%";
            }

            Display.Select(Display.Text.Length, 0);
            Display.ScrollToCaret();
            label3.Focus();
        }

        private void buttonpnt_Click(object sender, EventArgs e)
        {
            num = Display.Text.Length - 1;
            if (NoTwoOperator() == 0)
            {
                Display.Text = Display.Text.Remove(num);
                Display.Text = Display.Text + ".";
            }
            else if (NoTwoOperator() == 1)
            {
                Display.Text = Display.Text + ".";
            }

            Display.Select(Display.Text.Length, 0);
            Display.ScrollToCaret();
            label3.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.Handled = true;
                    buttoneq.PerformClick();
                    break;
                case Keys.NumPad9://Num9
                    e.Handled = true;
                    button9.PerformClick();
                    break;
                case Keys.D9:
                    e.Handled = true;
                    button9.PerformClick();
                    break;
                case Keys.NumPad8:
                    e.Handled = true;
                    button8.PerformClick();
                    break;
                case Keys.D8:
                    e.Handled = true;
                    button8.PerformClick();
                    break;
                case Keys.NumPad7:
                    e.Handled = true;
                    button7.PerformClick();
                    break;
                case Keys.D7:
                    e.Handled = true;
                    button7.PerformClick();
                    break;
                case Keys.NumPad6:
                    e.Handled = true;
                    button6.PerformClick();
                    break;
                case Keys.D6:
                    e.Handled = true;
                    button6.PerformClick();
                    break;
                case Keys.NumPad5:
                    e.Handled = true;
                    button5.PerformClick();
                    break;
                case Keys.D5:
                    e.Handled = true;
                    button5.PerformClick();
                    break;
                case Keys.NumPad4:
                    e.Handled = true;
                    button4.PerformClick();
                    break;
                case Keys.D4:
                    e.Handled = true;
                    button4.PerformClick();
                    break;
                case Keys.NumPad3:
                    e.Handled = true;
                    button3.PerformClick();
                    break;
                case Keys.D3:
                    e.Handled = true;
                    button3.PerformClick();
                    break;
                case Keys.NumPad2:
                    e.Handled = true;
                    button2.PerformClick();
                    break;
                case Keys.D2:
                    e.Handled = true;
                    button2.PerformClick();
                    break;
                case Keys.NumPad1:
                    e.Handled = true;
                    button1.PerformClick();
                    break;
                case Keys.D1:
                    e.Handled = true;
                    button1.PerformClick();
                    break;
                case Keys.NumPad0:
                    e.Handled = true;
                    button0.PerformClick();
                    break;
                case Keys.D0://Num0
                    e.Handled = true;
                    button0.PerformClick();
                    break;
                case Keys.Add:
                    e.Handled = true;
                    buttonadd.PerformClick();
                    break;
                case Keys.Subtract:
                    e.Handled = true;
                    buttonsub.PerformClick();
                    break;
                case Keys.Multiply:
                    e.Handled = true;
                    buttonmul.PerformClick();
                    break;
                case Keys.Divide:
                    e.Handled = true;
                    buttondiv.PerformClick();
                    break;
                case Keys.R:
                    e.Handled = true;
                    button12.PerformClick();
                    break;
                
                //case Keys.Return:
                  //e.Handled = true;
                   //buttoneq.PerformClick();
                    //break;
                case Keys.OemPeriod:
                    e.Handled = true;
                    buttonpnt.PerformClick();
                    break;
                case Keys.Decimal:
                    e.Handled = true;
                    buttonpnt.PerformClick();
                    break;
                case Keys.Back:
                    e.Handled = true;
                    buttonback.PerformClick();
                    break;
                case Keys.Delete:
                    e.Handled = true;
                    button11.PerformClick();
                    break;
                
            }
        }
    }
}

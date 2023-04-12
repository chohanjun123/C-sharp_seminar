using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 세미나_시험대비_문제2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = int.Parse(textBox3.Text);

                label4.Text = "";
                label5.Text = "더한값: ";
                label6.Text = "곱한값: ";

                int j = 0;
                int k = 1;

                if (a >= 1 && a <= 20 && b >= 1 && b <= 20 && c <= b - a)
                {

                    if (c != 0)
                    {


                        for (int i = a; i <= b; i += c)
                        {
                            label5.Text += i + " + ";
                            label6.Text += i + " * ";



                            j += i;
                            k *= i;
                        }


                        label5.Text = label5.Text.Trim( );
                        label5.Text = label5.Text.TrimEnd('+');
                        label6.Text = label5.Text.Trim( );
                        label6.Text = label5.Text.TrimEnd('+');

                        label4.Text = a + " 부터 " + b + " 까지 증가값 " + c + "로";
                        label5.Text = label5.Text + " = " + j;
                        label6.Text = label6.Text + " = " + k;

                    }

                    else if (c == 0)
                    {
                        label4.Text = a + " 부터 " + b + " 까지 증가값 " + c + "로";
                        label5.Text = label5.Text + "infinity";
                        label6.Text = label6.Text + "infinity";

                    }

                }
                else
                {
                    label4.Text = "1부터 20사이의 수를 입력하세요";
                }

            }
            catch (Exception ex)
            {
                label4.Text = ex.Message;
            }

        }
    }
}

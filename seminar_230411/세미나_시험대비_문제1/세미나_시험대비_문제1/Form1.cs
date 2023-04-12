using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 세미나_시험대비_문제1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                label2.Text = "";

                if (a >= 0 && a <= 100 && a % 10 == 0 || a % 10 == 1)
                {



                        for (int i = 1; i <= a; i++)
                        {

                            if (i % 2 == 0)
                            {
                                label2.Text += i + ", ";


                            }

                            if (i % 20 == 0)
                            {
                                label2.Text += "\n";
                            }

                            
                        }
                    
                    
                }
                else
                {
                    label2.Text = "100이하의 양의 정수를 입력해주세요";
                }



            }

            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }
    }
}

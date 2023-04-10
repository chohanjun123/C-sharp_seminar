using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 세미나_3번_짝수찾기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {



                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = 0;
                label1.Text = "";

                for (int i = b; i <= a; i += b)
                {
                    label1.Text += i + " ";

                    c++;

                    if (i % 5 == 0)
                    {
                        label1.Text += "\n";
                    }

                    label2.Text = c + "개 입니다.";

                }

            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
                label2.Text = ex.Message;
            }



        }
    }
}

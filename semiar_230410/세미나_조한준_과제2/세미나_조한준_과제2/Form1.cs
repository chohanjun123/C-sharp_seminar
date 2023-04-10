using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 세미나_조한준_과제2
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


                for (int i = 2; i <= a; i++)
                {
                  
                    label2.Text = label2.Text += "<" + i + "단>" + "\n";
                    
                    for (int j = 1; j <= 9; j++)
                    {
                       
                        label2.Text += i + "X" + j + "=" + i * j + "\n" ;

                    }

                    label2.Text = label2.Text += "\n";
                }
               
                if (a < 1 || a > 9)
                {
                    label2.Text = "1부터 9까지의 수를 입력하세요";
                }



            }

            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }


            
            

        }
    }
}

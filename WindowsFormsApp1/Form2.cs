using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "customer")
            {
                if (textBox2.Text == "admin")
                {
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                    
                }

            }
            if (textBox1.Text == "manager")
            {
                if (textBox2.Text == "admin")
                {
                    Form3 f3 = new Form3();
                    f3.ShowDialog();

                }

            }
            if (textBox1.Text == "working")
            {
                if (textBox2.Text == "admin")
                {
                    Form4 f4 = new Form4();
                    f4.ShowDialog();

                }

            }
            if (textBox1.Text == "director")
            {
                if (textBox2.Text == "admin")
                {
                    Form5 f5 = new Form5();
                    f5.ShowDialog();

                }

            }
            else
                MessageBox.Show("Не правильный логин или пароль");
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

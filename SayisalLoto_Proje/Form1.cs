using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayisalLoto_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            int dogru = 0;

            Random rnd = new Random();
            int s1, s2, s3, s4, s5;
            s1 = rnd.Next(1, 6);
            s2 = rnd.Next(1, 6);
            s3 = rnd.Next(1, 6);
            s4 = rnd.Next(1, 6);
            s5 = rnd.Next(1, 6);
            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();
            label5.Text = s5.ToString();

            // Sayı 1
            if (textBox1.Text == label1.Text)
            {
                textBox1.BackColor = Color.Green;
                dogru++;
                label6.Text = dogru.ToString();
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            // Sayı 2
            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.Green;
                dogru++;
                label6.Text = dogru.ToString();
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            // Sayı 3
            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.Green;
                dogru++;
                label6.Text = dogru.ToString();
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            // Sayı 4
            if (textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.Green;
                dogru++;
                label6.Text = dogru.ToString();
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }

            // Sayı 5
            if (textBox5.Text == label5.Text)
            {
                textBox5.BackColor = Color.Green;
                dogru++;
                label6.Text = dogru.ToString();
            }
            else
            {
                textBox5.BackColor = Color.Red;
            }

            if(dogru <= 2)
            {
                MessageBox.Show("Maalesef kaybettiniz, lütfen tekrar deneyiniz!");
                label6.Text = "00";
            }
            else
            {
                MessageBox.Show("Tebrikler, kazandınız!");
            }
        }
    }
}

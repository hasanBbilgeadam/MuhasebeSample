using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            textBox1.Name = "0";
            textBox2.Name = "1";
            textBox3.Name = "2";
            textBox4.Name = "3";
        }


        string hedef = "masa";
        private void button1_Click(object sender, EventArgs e)
        {

            var harfler = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            int x = 0;
            int y = 0;

            Button[,] arr = new Button[8, 8];


            for (int i = 0; i < 8; i++)
            {
                for (int j = 0, k = 8; j < 8; j++, k--)
                {
                    var btn = arr[i, j] = new();
                    btn.Location = new Point(x, y);
                    btn.Width = 50;
                    btn.Height = 50;
                    btn.Name = harfler[i] + " " + k;
                    btn.Text = harfler[i].ToString().ToUpper() + " " + k;
                    btn.Click += ButtonKordinat;
                    btn.BackColor = ((i + j) % 2 == 0) ? Color.White : Color.Black;
                    btn.ForeColor = ((i + j) % 2 == 0) ? Color.Black : Color.White;
                    this.Controls.Add(btn);
                    x += 52;

                }
                x = 0;
                y += 52;
            }

        }

        private void ButtonKordinat(object sender, EventArgs e)
        {
            var btn = sender as Button;

            MessageBox.Show(btn.Name);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            var tb = sender as TextBox;
            if (tb.Text == string.Empty)
            {
                return;
            }

            if (tb.Text == hedef[int.Parse(tb.Name)].ToString())
            {
                MessageBox.Show("doğru");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

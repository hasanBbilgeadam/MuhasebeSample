using System.DirectoryServices.ActiveDirectory;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {



            var message = "merhaba " + txtName.Text;

            MessageBox.Show(message);

        }


        private void btn1_MouseHover(object sender, EventArgs e)
        {

            var btn = sender as Button;




            btn.BackColor = Color.Blue;




        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;

            btn.BackColor = SystemColors.Control;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var str = "";
            if (checkBox1.Checked)
            {
                str += "birinci seçildi ";
            }
            if (checkBox2.Checked)
            {
                str += "ikinicisi seçildi";
            }

            MessageBox.Show(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var str = "";
            if (radioButton1.Checked)
            {
                str = "birinci";
            }
            if (radioButton2.Checked)
            {
                str = "ikinicis";
            }
            if (radioButton3.Checked)
            {
                str = "üçüncüsü";
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            MessageBox.Show(str);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("içerik", "baþlýk", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error); 


        }
    }
}

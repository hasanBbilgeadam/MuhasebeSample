namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            ++count;

            listBox1.Items.Insert(0, count);

           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

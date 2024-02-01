namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            var result =  File.ReadAllLines("config.txt");


            var temp = "";
            foreach (var item in result)
            {
                temp += item;
            }

            MessageBox.Show(temp);



            Console.WriteLine();

            //var cd =  colorDialog1.ShowDialog();

            //if (cd == DialogResult.OK)
            //{

            //var color =  colorDialog1.Color.ToArgb();

            //MessageBox.Show(color.ToString());

            //    this.BackColor = Color.FromArgb(color);

            //}
            //var userResponse =  MessageBox.Show("devam etmek istiyor musun ", "cevap", MessageBoxButtons.OKCancel);

            // if (DialogResult.OK == userResponse)
            // {
            //     MessageBox.Show("devam ediliyor");
            // }
            // else
            // {
            //     MessageBox.Show("iþlem iptal");
            // }

            //var result = openFileDialog1.ShowDialog();

            //if (result == DialogResult.OK)
            //{
            //    MessageBox.Show(openFileDialog1.FileName);
            //}

        }
    }
}

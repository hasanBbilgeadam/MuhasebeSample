namespace WinFormsApp6
{
    public partial class Form1 : Form
    {

        private string defaultConfigValues =
            "FormText|form1" + Environment.NewLine +
            "FormBackColor|-123123" + Environment.NewLine +
            "FormForeColor|-123123";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //if (File.Exists("config.txt"))
            //{
            //    var data = File.ReadAllLines("config.txt");
            //    SetConfigurations(data);
            //}
            //else
            //{


            //    File.WriteAllText("config.txt", defaultConfigValues);

            //    var data = File.ReadAllLines("config.txt");
            //    SetConfigurations(data);
            //}

        }
        private void SetConfigurations(string[] configs)
        {

            try
            {
                this.Text = configs[0].Split('|')[1];
                this.BackColor = Color.FromArgb(int.Parse(configs[1].Split('|')[1]));
                this.ForeColor = Color.FromArgb(int.Parse(configs[2].Split('|')[1]));

            }
            catch (Exception)
            {
                MessageBox.Show("bir hata meydana geldi varsayýlan ayarlar yükleniyor ");


                var arr = defaultConfigValues.Split(Environment.NewLine);


                this.Text = arr[0].Split('|')[1];
                this.BackColor = Color.FromArgb(int.Parse(arr[1].Split('|')[1]));
                this.ForeColor = Color.FromArgb(int.Parse(arr[2].Split('|')[1]));


            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            var response = colorDialog1.ShowDialog();

            if (response == DialogResult.OK)
            {
               var renk =   colorDialog1.Color.ToArgb();

                MessageBox.Show(renk.ToString());
            }
        }
    }
}

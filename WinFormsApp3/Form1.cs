namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        List<Person> People = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Person person = new Person();

            //se�ti�i renkler

            if (chK�rm�z�.Checked)
                person.Color.Add("k�rm�z�");
            if (chMavi.Checked)
                person.Color.Add("mavi");
            if (chMor.Checked)
                person.Color.Add("mor");
            if (chTuruncu.Checked)
                person.Color.Add("turuncu");
            if (chSar�.Checked)
                person.Color.Add("sar�");


            //cinsiyet

            if (rdErkek.Checked)
                person.Gender = "erkek";
            if (rdKad�n.Checked)
                person.Gender = "kad�n";



            person.Name = txtName.Text;
            person.SurName = txtSurname.Text;
            person.Age = int.Parse(txtAge.Text);


            People.Add(person);
            var temp = "";
            person.Color.ForEach(x => temp += (" " + x));
            var info = @$"ad� : {person.Name}{System.Environment.NewLine}soyad� : {person.SurName}{System.Environment.NewLine}ya� : {person.Age}{System.Environment.NewLine}renkler : {temp}";

            MessageBox.Show(info, "bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);


            ResetAlControls();


        }

        private void ResetAlControls()
        {
            chK�rm�z�.Checked = false;
            chMavi.Checked = false;
            chMor.Checked = false;
            chSar�.Checked = false;
            chTuruncu.Checked = false;

            rdErkek.Checked = false;
            rdKad�n.Checked = false;

            txtAge.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtName.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var lb = sender as ListBox;

            var data = (string)lb.SelectedItem;

            if (data == string.Empty)
            {
                return;
            }

            var id = int.Parse(data.Split(" ")[0]);


            foreach (var item in People)
            {
                if (item.Id == id)
                {



                    FrmInfo frm = new();

                    frm.Person = item;

                    frm.Show();


                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            listBox1.Items.Clear();


            foreach (var item in People)
            {
                listBox1.Items.Add(item.Id + " " + item.Name + " " + item.SurName);
            }
        }
    }

    public class Person
    {

        public Person()
        {
            Id = new Random().Next(100, 10000000);

        }
        public int Id { get; set; }
        public List<string> Color { get; set; } = new();
        public String Gender { get; set; }
        public String Name { get; set; }
        public String SurName { get; set; }
        public int Age { get; set; }

    }

}

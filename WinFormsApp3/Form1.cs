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

            //seçtiði renkler

            if (chKýrmýzý.Checked)
                person.Color.Add("kýrmýzý");
            if (chMavi.Checked)
                person.Color.Add("mavi");
            if (chMor.Checked)
                person.Color.Add("mor");
            if (chTuruncu.Checked)
                person.Color.Add("turuncu");
            if (chSarý.Checked)
                person.Color.Add("sarý");


            //cinsiyet

            if (rdErkek.Checked)
                person.Gender = "erkek";
            if (rdKadýn.Checked)
                person.Gender = "kadýn";



            person.Name = txtName.Text;
            person.SurName = txtSurname.Text;
            person.Age = int.Parse(txtAge.Text);


            People.Add(person);
            var temp = "";
            person.Color.ForEach(x => temp += (" " + x));
            var info = @$"adý : {person.Name}{System.Environment.NewLine}soyadý : {person.SurName}{System.Environment.NewLine}yaþ : {person.Age}{System.Environment.NewLine}renkler : {temp}";

            MessageBox.Show(info, "bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);


            ResetAlControls();


        }

        private void ResetAlControls()
        {
            chKýrmýzý.Checked = false;
            chMavi.Checked = false;
            chMor.Checked = false;
            chSarý.Checked = false;
            chTuruncu.Checked = false;

            rdErkek.Checked = false;
            rdKadýn.Checked = false;

            txtAge.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtName.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();


            foreach (var item in People)
            {
                listBox1.Items.Add(item.Name + " " + item.SurName);
            }
        }
    }

    public class Person
    {

        public List<string> Color { get; set; } = new();
        public String Gender { get; set; }
        public String Name { get; set; }
        public String SurName { get; set; }
        public int Age { get; set; }

    }

}

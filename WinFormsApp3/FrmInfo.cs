using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class FrmInfo : Form
    {
        public Person Person { get; set; }
        public FrmInfo()
        {
            InitializeComponent();
        }

        private void FrmInfo_Load(object sender, EventArgs e)
        {


            label1.Text = " ";
            label1.Text +="Id :"+Person.Id+"\n";
            label1.Text +="Adı :"+Person.Name+"\n";
            label1.Text +="Soyad :"+Person.SurName+"\n";
            label1.Text +="Yaş :"+Person.Age+"\n";
            label1.Text +="fav rekler :"+string.Join( ' ',Person.Color);



        }
    }
}

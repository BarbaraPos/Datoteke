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

namespace Datoteke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string linija;
            linija = txtIme.Text+"|"+txtPrezime.Text+"|"+txtIndeks.Text;
            StreamWriter sw = new StreamWriter("studenti.txt", true);
            sw.WriteLine(linija);
            sw.Close();
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtIndeks.Text = "";
            MessageBox.Show("Podaci su snimljeni u datoteku studenti.txt");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string linija;
            StreamReader sr = new StreamReader("studenti.txt");
            linija=sr.ReadLine();
            List<string> lstStud = new List<string>();
            while (linija != null)
            {
                linija=linija.Replace("|", " ");
                lstStud.Add(linija);
                linija = sr.ReadLine();
            }
            lstStudenti.DataSource = lstStud;
            sr.Close();

        }
    }
}

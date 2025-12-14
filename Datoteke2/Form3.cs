using Datoteke2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Datoteke2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ucenici.Items.Clear();
            string odabraniRazred = comboBox1.Text;
            if (!File.Exists("imena.txt"))
            {
                MessageBox.Show("imena.txt ne postoji");
                return;
            }
            string line;
            StreamReader sr = new StreamReader("imena.txt");
            while ((line =sr.ReadLine()) != null)
            {
                List<string> parts = line.Split('|').ToList();
                if (odabraniRazred == null)
                {
                    Ucenici.Items.Add(line.Replace("|"," "));
                }
                else if (parts[2] == odabraniRazred)
                {
                    Ucenici.Items.Add(line);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ucenici.Items.Clear();
        }
    }
}

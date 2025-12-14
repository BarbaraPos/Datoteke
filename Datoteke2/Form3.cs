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
            string odabraniRazred = comboBox1.SelectedItem as string;
            if (!File.Exists("imena.txt"))
            {
                MessageBox.Show("imena.txt ne postoji");
                return;
            }
            string line;
            StreamReader sr = new StreamReader("imena.txt");
            line = sr.ReadLine();
            List<string> lines = new List<string>();
            while (line != null)
            {
                lines.Add(line);
            }
            for (int i = 0; i < lines.Count; i++)
            {
                List<string> parts = lines[i].Split('|').ToList();
                if (parts[2] == odabraniRazred)
                {
                    Ucenici.Items.Add(lines[i]);
                }
                else if(odabraniRazred==null)
                {
                    Ucenici.Items.Add(lines[i]);
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

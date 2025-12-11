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
            string line;
            StreamReader sr = new StreamReader("imena.txt");
            line = sr.ReadLine();
            List<string> lines = new List<string>();
            while (line != null)
            {
                line=line.Replace("|", " ");
                lines.Add(line);
                line = sr.ReadLine();
            }
            for (int i = 0; i < lines.Count; i++)
            {
                
            }

        }
    }
}

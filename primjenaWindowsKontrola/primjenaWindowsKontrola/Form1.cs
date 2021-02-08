using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primjenaWindowsKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Notepad")
            {
                System.Diagnostics.Process.Start(@"C:\Windows\System32\Notepad.exe");
            }

            if (comboBox1.Text == "Paint")
            {
                System.Diagnostics.Process.Start(@"C:\Windows\System32\mspaint.exe");
            }
        }
    }
}

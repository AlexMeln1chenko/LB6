using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder(textBox1.Text);
            StringBuilder num = new StringBuilder();
            StringBuilder znak = new StringBuilder();
            int i = 0;
            while(i < s.Length)
            {
                if (s[i] == '0' || s[i] == '1' || s[i] == '2' || s[i] == '3' || s[i] == '4' || s[i] == '5' || s[i] == '6' || s[i] == '7' || s[i] == '8' || s[i] == '9')
                {
                    num.Append(s[i]);
                    s.Remove(i, 1);
                }
                else
                    i++;
        }
            i = 0;
            while (i < s.Length)
            {
                if (s[i] == ',' || s[i] == '.' || s[i] == ';' || s[i] == ':' || s[i] == '!' || s[i] == '?' || s[i] == '"')
                {
                    znak.Append(s[i]);
                    s.Remove(i, 1);
                }
                else
                    i++;
        }
            listBox1.Items.Add(num);
            listBox1.Items.Add(znak);
            listBox1.Items.Add(s);
        }
    }
}

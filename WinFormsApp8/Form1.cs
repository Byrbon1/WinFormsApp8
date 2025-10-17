using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fn, fam, name;
            int L, n;
            fn = textBox1.Text;
            n = fn.IndexOf(" ");
            L = fn.Length;
            fam = fn.Substring(0, n);
            name = fn.Substring(n + 1, L - n - 1);
            textBox2.Text = fam;
            textBox3.Text = name;
        }
    }
}
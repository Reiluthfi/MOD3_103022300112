using System.Diagnostics;

namespace MOD3_103022300112
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            textBox1.Text = a + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string b = textBox1.Text;
            textBox1.Text = b + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string c = textBox1.Text;
            textBox1.Text = c + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string d = textBox1.Text;
            textBox1.Text = d + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string j = textBox1.Text;
            textBox1.Text = j + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string f = textBox1.Text;
            textBox1.Text = f + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string g = textBox1.Text;
            textBox1.Text = g + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string h = textBox1.Text;
            textBox1.Text = h + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string i = textBox1.Text;
            textBox1.Text = i + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string j = textBox1.Text;
            textBox1.Text = j + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text ;
            textBox1.Text = s + "+";
            int l = int.Parse(textBox1.Text);
            textBox1.Text = "";
            int m = int.Parse(textBox1.Text);
            textBox1.Text = "";

        }
        private void button12_Click(object sender, EventArgs e,int l,int m)
        {
            int p =  l + m;
            textBox1.Text = p.ToString();

        }
    }
}

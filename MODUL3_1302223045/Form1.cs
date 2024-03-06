namespace MODUL3_1302223045
{
    public partial class Form1 : Form
    {
        int conv;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "1";
            label1.Text = label1.Text + button1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "3";
            label1.Text = label1.Text + button3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "2";
            label1.Text = label1.Text + button2.Text;
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            conv = Int32.Parse(label1.Text);
            label1.Text = " ";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            int sum = conv + Int32.Parse(label1.Text);
            label1.Text = Convert.ToString(sum);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "4";
            label1.Text = label1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "5";
            label1.Text = label1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "6";
            label1.Text = label1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "7";
            label1.Text = label1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "8";
            label1.Text = label1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "9";
            label1.Text = label1.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = "0";
            label1.Text = label1.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
        }
    }
}

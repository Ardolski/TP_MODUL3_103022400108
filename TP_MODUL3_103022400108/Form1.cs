namespace TP_MODUL3_103022400108
{
    public partial class Form1 : Form
    {
        double angka1 = 0;
        string operasi = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            angka1 = Convert.ToDouble(lblOutput.Text);
            operasi = "+";
            lblOutput.Text += "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string[] bagian = lblOutput.Text.Split('+');
            double angka2 = Convert.ToDouble(bagian[1]);

            double hasil = angka1 + angka2;

            lblOutput.Text += "=" + hasil.ToString();

        }
    }
}

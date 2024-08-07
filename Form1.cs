namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            double firstInput = Convert.ToDouble(FirstNumText.Text);
            double secondInput = Convert.ToDouble(SecondNumText.Text);

            double output = firstInput + secondInput;

            OutputNumText.Text = output.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double firstInput = Convert.ToDouble(FirstNumText.Text);
            double secondInput = Convert.ToDouble(SecondNumText.Text);

            double output = firstInput - secondInput;

            OutputNumText.Text = output.ToString();
        }

        private void label2_Click(object sender, EventArgs e) { 
        }

        private void MulButton_Click(object sender, EventArgs e)
        {
            double firstInput = Convert.ToDouble(FirstNumText.Text);
            double secondInput = Convert.ToDouble(SecondNumText.Text);

            double output = firstInput * secondInput;

            OutputNumText.Text = output.ToString();
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            double firstInput = Convert.ToDouble(FirstNumText.Text);
            double secondInput = Convert.ToDouble(SecondNumText.Text);

            double output = firstInput / secondInput;

            OutputNumText.Text = output.ToString();

        }
    }
}

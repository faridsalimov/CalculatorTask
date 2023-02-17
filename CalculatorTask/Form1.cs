namespace CalculatorTask
{
    public partial class Form1 : Form
    {
        double firstNumber;
        string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultBox.Text += (sender as Button).Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            resultBox.Text = null;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(resultBox.Text);
            operation = "+";
            resultBox.Text = null;
        }

        private void subtButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(resultBox.Text);
            operation = "-";
            resultBox.Text = null;
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(resultBox.Text);
            operation = "*";
            resultBox.Text = null;
        }

        private void diviButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(resultBox.Text);
            operation = "/";
            resultBox.Text = null;
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            double secondNumber;
            secondNumber = Convert.ToDouble(resultBox.Text);
            double result;

            if (operation == "+")
            {
                result = firstNumber + secondNumber;
                resultBox.Text = Convert.ToString(result);
                firstNumber = result;
            }

            if (operation == "-")
            {
                result = firstNumber - secondNumber;
                resultBox.Text = Convert.ToString(result);
                firstNumber = result;
            }

            if (operation == "*")
            {
                result = firstNumber * secondNumber;
                resultBox.Text = Convert.ToString(result);
                firstNumber = result;
            }

            if (operation == "/")
            {
                result = firstNumber / secondNumber;
                resultBox.Text = Convert.ToString(result);
                firstNumber = result;
            }
        }
    }
}
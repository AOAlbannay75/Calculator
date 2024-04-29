namespace Calculator
{
    public partial class calculator : Form
    {
        double num1, num2;
        String op;

        public calculator()
        {
            InitializeComponent();
        }

        private void NumbPad(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (calculatorDisplay.Text == "0")
                calculatorDisplay.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!calculatorDisplay.Text.Contains("."))
                        calculatorDisplay.Text += num.Text;
                }
                else
                {
                    calculatorDisplay.Text += num.Text;
                }
            }

        }

        private void Operators(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            num1 = Convert.ToDouble(calculatorDisplay.Text);
            op = num.Text;
            calculatorDisplay.Text = "";
        }

        private void Equal(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(calculatorDisplay.Text);
            switch (op)
            {
                case "+":
                    calculatorDisplay.Text = (num1 + num2).ToString();
                    break;

                case "-":
                    calculatorDisplay.Text = (num1 - num2).ToString();
                    break;

                case "*":
                    calculatorDisplay.Text = (num1 * num2).ToString();
                    break;

                case "/":
                    calculatorDisplay.Text = (num1 / num2).ToString();
                    break;

                default:
                    break;
            }
        }

        private void clearBt_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
        }

        private void ClearEntryBtn_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "0";
            String firstNumber, secondNumber;
            firstNumber = Convert.ToString(num1);
            secondNumber = Convert.ToString(num2);
            firstNumber = "";
            secondNumber = "";

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (calculatorDisplay.Text.Length > 0)
            {
                calculatorDisplay.Text = calculatorDisplay.Text.Remove(calculatorDisplay.Text.Length - 1);
             }
            if (calculatorDisplay.Text == "")
            {
                calculatorDisplay.Text = "0";
            }
        }

    }
}

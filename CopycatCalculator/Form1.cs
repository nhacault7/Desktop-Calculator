namespace CopycatCalculator
{
    public partial class frmMain : Form
    {
        public int firstStoredOperand { get; set; }
        public int secondStoredOperand { get; set; }
        public int answer { get; set; }
        public string storedOperator { get; set; }
        public bool isDefault { get; set; }

        public frmMain()
        {
            InitializeComponent();

            firstStoredOperand = 0;
            secondStoredOperand = 0;
            answer = 0;
            storedOperator = String.Empty;
            isDefault = false;
            
            lsbHistory.Font = new Font("Times New Roman", 16);
            lsbHistory.ForeColor = Color.White;
            lsbHistory.Items.Add("History");

            rtbOutput.Font = new Font("Times New Roman", 24);
            rtbOutput.ForeColor = Color.White;
            rtbOutput.RightToLeft = RightToLeft.Yes;
            rtbOutput.ReadOnly = true;
            rtbOutput.Text = firstStoredOperand.ToString();
        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (storedOperator == String.Empty)
            {
                if (firstStoredOperand == 0)
                {
                    rtbOutput.Text = button.Text;
                }
                else
                {
                    rtbOutput.AppendText(button.Text);
                }

                firstStoredOperand = Convert.ToInt32(rtbOutput.Text);
            }
            else
            {
                string[] currentEquation = rtbOutput.Lines;
                string secondOperand = currentEquation[1];

                if (secondStoredOperand == 0 || isDefault)
                {
                    secondOperand = button.Text;
                    isDefault = false;
                }
                else
                {
                    secondOperand += button.Text;
                }

                secondStoredOperand = Convert.ToInt32(secondOperand);
                string output = $"{storedOperator} {firstStoredOperand}\n{secondStoredOperand}";
                rtbOutput.Text = output;
            }
        }

        private void KeyboardInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (storedOperator == String.Empty)
            {
                if (e.KeyChar >= 48 && e.KeyChar <= 57)
                {
                    if (firstStoredOperand == 0)
                    {
                        rtbOutput.Text = e.KeyChar.ToString();
                    }
                    else
                    {
                        rtbOutput.AppendText(e.KeyChar.ToString());
                    }

                    firstStoredOperand = Convert.ToInt32(rtbOutput.Text);
                }
            }
            else
            {
                string[] currentEquation = rtbOutput.Lines;
                string secondOperand = currentEquation[1];

                if (secondStoredOperand == 0 || isDefault)
                {
                    secondOperand = e.KeyChar.ToString();
                    isDefault = false;
                }
                else
                {
                    secondOperand += e.KeyChar.ToString();
                }

                secondStoredOperand = Convert.ToInt32(secondOperand);
                string output = $"{storedOperator} {firstStoredOperand}\n{secondStoredOperand}";
                rtbOutput.Text = output;
            }
        }

        private void OperatorInput_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (storedOperator == String.Empty)
            {
                storedOperator = button.Text;
                secondStoredOperand = firstStoredOperand;
                isDefault = true;

                string output = $"{storedOperator} {firstStoredOperand}\n{firstStoredOperand}";
                rtbOutput.Text = output;
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            switch (storedOperator)
            {
                case "+":
                    answer = firstStoredOperand + secondStoredOperand;
                    break;
                case "-":
                    answer = firstStoredOperand - secondStoredOperand;
                    break;
                case "*":
                    answer = firstStoredOperand * secondStoredOperand;
                    break;
                case "/":
                    answer = firstStoredOperand / secondStoredOperand;
                    break;
            }

            rtbOutput.Text = answer.ToString();
            lsbHistory.Items.Add($"{firstStoredOperand} {storedOperator} {secondStoredOperand} = {answer}");
        }

        private void ConvertToBinary_Click(object sender, EventArgs e)
        {
            try
            {
                if (answer != 0)
                {
                    answer = Convert.ToInt32(Convert.ToString(answer, 2));
                    rtbOutput.Text = answer.ToString();
                    return;
                }

                if (secondStoredOperand != 0)
                {
                    secondStoredOperand = Convert.ToInt32(Convert.ToString(secondStoredOperand, 2));
                    rtbOutput.Text = secondStoredOperand.ToString();
                    return;
                }

                if (firstStoredOperand != 0)
                {
                    firstStoredOperand = Convert.ToInt32(Convert.ToString(firstStoredOperand, 2));
                    rtbOutput.Text = firstStoredOperand.ToString();
                    return;
                }
            } catch (OverflowException)
            {
                rtbOutput.Text = "Error";
            }
            
        }

        private void ConvertToLocational_Click(object sender, EventArgs e)
        {
            
        }

        private void ConvertToDecimal_Click(object sender, EventArgs e)
        {
            try
            {
                if (answer != 0)
                {
                    answer = Convert.ToInt32(Convert.ToString(answer, 10));
                    rtbOutput.Text = answer.ToString();
                    return;
                }

                if (secondStoredOperand != 0)
                {
                    secondStoredOperand = Convert.ToInt32(Convert.ToString(secondStoredOperand, 10));
                    rtbOutput.Text = secondStoredOperand.ToString();
                    return;
                }

                if (firstStoredOperand != 0)
                {
                    firstStoredOperand = Convert.ToInt32(Convert.ToString(firstStoredOperand, 10));
                    rtbOutput.Text = firstStoredOperand.ToString();
                    return;
                }
            }
            catch (OverflowException)
            {
                rtbOutput.Text = "Error";
            }
        }
    }
}
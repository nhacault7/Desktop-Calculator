namespace CopycatCalculator
{
    public partial class frmMain : Form
    {
        public string firstStoredOperand { get; set; }
        public string secondStoredOperand { get; set; }
        public string answer { get; set; }
        public string storedOperator { get; set; }
        public bool isDefault { get; set; }

        public frmMain()
        {
            InitializeComponent();

            firstStoredOperand = String.Empty;
            secondStoredOperand = String.Empty;
            answer = String.Empty;
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
                if (firstStoredOperand == String.Empty)
                {
                    firstStoredOperand = button.Text;
                }
                else
                {
                    firstStoredOperand += button.Text;
                }

                rtbOutput.Text = firstStoredOperand;
            }
            else
            {
                string[] currentEquation = rtbOutput.Lines;
                string secondOperand = currentEquation[1];

                if (secondStoredOperand == String.Empty || isDefault)
                {
                    secondOperand = button.Text;
                    isDefault = false;
                }
                else
                {
                    secondOperand += button.Text;
                }

                secondStoredOperand = secondOperand;
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
                    if (firstStoredOperand == String.Empty)
                    {
                        firstStoredOperand = e.KeyChar.ToString();
                    }
                    else
                    {
                        firstStoredOperand += e.KeyChar.ToString();
                    }

                    rtbOutput.Text = firstStoredOperand;
                }
            }
            else
            {
                string[] currentEquation = rtbOutput.Lines;
                string secondOperand = currentEquation[1];

                if (secondStoredOperand == String.Empty || isDefault)
                {
                    secondOperand = e.KeyChar.ToString();
                    isDefault = false;
                }
                else
                {
                    secondOperand += e.KeyChar.ToString();
                }

                secondStoredOperand = secondOperand;
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
                    answer = (Convert.ToInt32(firstStoredOperand) + Convert.ToInt32(secondStoredOperand)).ToString();
                    break;
                case "-":
                    answer = (Convert.ToInt32(firstStoredOperand) - Convert.ToInt32(secondStoredOperand)).ToString();
                    break;
                case "*":
                    answer = (Convert.ToInt32(firstStoredOperand) * Convert.ToInt32(secondStoredOperand)).ToString();
                    break;   
                case "/":    
                    answer = (Convert.ToInt32(firstStoredOperand) / Convert.ToInt32(secondStoredOperand)).ToString();
                    break;
            }

            rtbOutput.Text = answer.ToString();
            lsbHistory.Items.Add($"{firstStoredOperand} {storedOperator} {secondStoredOperand} = {answer}");
        }

        private void ConvertToBinary_Click(object sender, EventArgs e)
        {
            try
            {
                if (answer != String.Empty)
                {
                    answer = Convert.ToString(Convert.ToInt32(answer), 2);
                    rtbOutput.Text = answer.ToString();
                    return;
                }

                if (secondStoredOperand != String.Empty)
                {
                    secondStoredOperand = Convert.ToString(Convert.ToInt32(secondStoredOperand), 2);
                    rtbOutput.Text = secondStoredOperand.ToString();
                    return;
                }

                if (firstStoredOperand != String.Empty)
                {
                    firstStoredOperand = Convert.ToString(Convert.ToInt32(firstStoredOperand), 2);
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
                if (answer != String.Empty)
                {
                    answer = Convert.ToInt32(answer, 2).ToString();
                    rtbOutput.Text = answer.ToString();
                    return;
                }

                if (secondStoredOperand != String.Empty)
                {
                    secondStoredOperand = Convert.ToInt32(secondStoredOperand, 2).ToString();
                    rtbOutput.Text = secondStoredOperand.ToString();
                    return;
                }

                if (firstStoredOperand != String.Empty)
                {
                    firstStoredOperand = Convert.ToInt32(firstStoredOperand, 2).ToString();
                    rtbOutput.Text = firstStoredOperand.ToString();
                    return;
                }
            }
            catch (FormatException)
            {
                rtbOutput.Text = "Error";
            }
        }
    }
}
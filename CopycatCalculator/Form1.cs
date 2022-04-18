namespace CopycatCalculator
{
    public partial class frmMain : Form
    {
        public string firstStoredOperand { get; set; }
        public string secondStoredOperand { get; set; }
        public string answer { get; set; }
        public string storedOperator { get; set; }
        public bool isDefault { get; set; }
        public bool isDecimal { get; set; }
        public char[] locationalChars { get; set; }

        public frmMain()
        {
            InitializeComponent();

            firstStoredOperand = String.Empty;
            secondStoredOperand = String.Empty;
            answer = String.Empty;
            storedOperator = String.Empty;
            isDefault = false;
            isDecimal = false;
            locationalChars = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n' };
            
            lsbHistory.Font = new Font("Times New Roman", 16);
            lsbHistory.ForeColor = Color.White;
            lsbHistory.Items.Add("History");

            rtbOutput.Font = new Font("Times New Roman", 24);
            rtbOutput.ForeColor = Color.White;
            rtbOutput.RightToLeft = RightToLeft.Yes;
            rtbOutput.ReadOnly = true;
            rtbOutput.Text = "0";
        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (storedOperator == String.Empty)
            {
                if (button.Text == "." && isDecimal == false)
                {
                    if (firstStoredOperand == String.Empty)
                    {
                        firstStoredOperand = "0";
                    }

                    isDecimal = true;
                }
                else if (button.Text == "." && isDecimal == true)
                {
                    return;
                }

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
                if (button.Text == "." && isDecimal == false)
                {
                    if (isDefault)
                    {
                        secondStoredOperand = "0";
                        isDefault = false;
                    }

                    isDecimal = true;
                }
                else if (button.Text == "." && isDecimal == true)
                {
                    return;
                }

                if (isDefault)
                {
                    secondStoredOperand = button.Text;
                    isDefault = false;
                }
                else
                {
                    secondStoredOperand += button.Text;
                }

                string output = $"{storedOperator} {firstStoredOperand}\n{secondStoredOperand}";
                rtbOutput.Text = output;
            }
        }

        private void KeyboardInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (storedOperator == String.Empty)
            {
                if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 46)
                {
                    if (e.KeyChar == 46 && isDecimal == false)
                    {
                        if (firstStoredOperand == String.Empty)
                        {
                            firstStoredOperand = "0";
                        }

                        isDecimal = true;
                    }
                    else if (e.KeyChar == 46 && isDecimal == true)
                    {
                        return;
                    }

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
                if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 46)
                {
                    if (e.KeyChar == 46 && isDecimal == false)
                    {
                        if (isDefault)
                        {
                            secondStoredOperand = "0";
                            isDefault = false;
                        }

                        isDecimal = true;
                    }
                    else if (e.KeyChar == 46 && isDecimal == true)
                    {
                        return;
                    }

                    if (secondStoredOperand == String.Empty || isDefault)
                    {
                        secondStoredOperand = e.KeyChar.ToString();
                        isDefault = false;
                    }
                    else
                    {
                        secondStoredOperand += e.KeyChar.ToString();
                    }

                    string output = $"{storedOperator} {firstStoredOperand}\n{secondStoredOperand}";
                    rtbOutput.Text = output;
                }
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

                isDecimal = false;
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            switch (storedOperator)
            {
                case "+":
                    answer = (Convert.ToDouble(firstStoredOperand) + Convert.ToDouble(secondStoredOperand)).ToString();
                    break;
                case "-":
                    answer = (Convert.ToDouble(firstStoredOperand) - Convert.ToDouble(secondStoredOperand)).ToString();
                    break;
                case "*":
                    answer = (Convert.ToDouble(firstStoredOperand) * Convert.ToDouble(secondStoredOperand)).ToString();
                    break;   
                case "/":    
                    answer = (Convert.ToDouble(firstStoredOperand) / Convert.ToDouble(secondStoredOperand)).ToString();
                    break;
            }

            rtbOutput.Text = answer.ToString();
            lsbHistory.Items.Add($"{firstStoredOperand} {storedOperator} {secondStoredOperand} = {answer}");
            isDecimal = false;
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
            } catch
            {
                rtbOutput.Text = "Error";
            }
            
        }

        private void ConvertToLocational_Click(object sender, EventArgs e)
        {
            try
            {
                if (answer != String.Empty)
                {
                    answer = Convert.ToString(Convert.ToInt32(answer), 2);
                    char[] numbers = answer.ToCharArray();
                    answer = String.Empty;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] == '1')
                        {
                            answer += locationalChars[i];
                        }
                    }
                    rtbOutput.Text = answer.ToString();
                    return;
                }

                if (secondStoredOperand != String.Empty)
                {
                    secondStoredOperand = Convert.ToString(Convert.ToInt32(secondStoredOperand), 2);
                    char[] numbers = secondStoredOperand.ToCharArray();
                    secondStoredOperand = String.Empty;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] == '1')
                        {
                            secondStoredOperand += locationalChars[i];
                        }
                    }
                    rtbOutput.Text = secondStoredOperand.ToString();
                    return;
                }

                if (firstStoredOperand != String.Empty)
                {
                    firstStoredOperand = Convert.ToString(Convert.ToInt32(firstStoredOperand), 2);
                    char[] numbers = firstStoredOperand.ToCharArray();
                    firstStoredOperand = String.Empty;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] == '1')
                        {
                            firstStoredOperand += locationalChars[i];
                        }
                    }
                    rtbOutput.Text = firstStoredOperand.ToString();
                    return;
                }
            }
            catch
            {
                rtbOutput.Text = "Error";
            }
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

        private void Clear_Click(object sender, EventArgs e)
        {
            firstStoredOperand = String.Empty;
            secondStoredOperand = String.Empty;
            answer = String.Empty;
            storedOperator = String.Empty;
            isDefault = false;
            isDecimal = false;

            rtbOutput.Text = "";
        }
    }
}
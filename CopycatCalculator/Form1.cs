namespace CopycatCalculator
{
    public partial class frmMain : Form
    {
        public int firstStoredOperand { get; set; }
        public int secondStoredOperand { get; set; }
        public string storedOperator { get; set; }

        public frmMain()
        {
            InitializeComponent();

            firstStoredOperand = 0;
            secondStoredOperand = 0;
            storedOperator = String.Empty;
            
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

                if (secondStoredOperand == 0)
                {
                    secondOperand = button.Text;
                    
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

                if (secondStoredOperand == 0)
                {
                    secondOperand = e.KeyChar.ToString();

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

                string output = $"{storedOperator} {firstStoredOperand}\n{firstStoredOperand}";
                rtbOutput.Text = output;
            }
        }
    }
}
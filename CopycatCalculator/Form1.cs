namespace CopycatCalculator
{
    public partial class frmMain : Form
    {
        public int storedOperand { get; set; }
        public string storedOperator { get; set; }

        public frmMain()
        {
            InitializeComponent();

            storedOperand = 0;
            storedOperator = String.Empty;
            
            lsbHistory.Font = new Font("Times New Roman", 16);
            lsbHistory.ForeColor = Color.White;
            lsbHistory.Items.Add("History");

            rtbOutput.Font = new Font("Times New Roman", 24);
            rtbOutput.ForeColor = Color.White;
            rtbOutput.RightToLeft = RightToLeft.Yes;
            rtbOutput.ReadOnly = true;
            rtbOutput.Text = storedOperand.ToString();
        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (storedOperand == 0)
            {
                rtbOutput.Text = button.Text;
            }
            else
            {
                rtbOutput.AppendText(button.Text);
            }

            storedOperand = Convert.ToInt32(rtbOutput.Text);
        }

        private void KeyboardInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                if (storedOperand == 0)
                {
                    rtbOutput.Text = e.KeyChar.ToString();
                }
                else
                {
                    rtbOutput.AppendText(e.KeyChar.ToString());
                }
            }

            storedOperand = Convert.ToInt32(rtbOutput.Text);
        }

        private void OperatorInput_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (storedOperator == String.Empty)
            {
                storedOperator = button.Text;

                string output = $"{storedOperator} {storedOperand}\n{storedOperand}";
                rtbOutput.Text = output;
            }
        }
    }
}
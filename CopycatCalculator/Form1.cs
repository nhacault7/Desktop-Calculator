namespace CopycatCalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
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
            Button button = (Button) sender;
            rtbOutput.Text = button.Text;
        }

        private void KeyboardInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                rtbOutput.Text = e.KeyChar.ToString();
            }
        }
    }
}
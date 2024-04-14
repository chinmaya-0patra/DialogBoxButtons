namespace DialogBoxButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("1: To Purchase, Press YES \n 2: To Try free 30 days trial, Press Try \n 3: Cancel the Purchase, Press Cancel", "Purchase Software", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            
            if(dr == DialogResult.Yes)
            {
                lblHighlight.Text = "Thank you for Purchasing Our Software.";
            }
            if (dr == DialogResult.No)
            {
                lblHighlight.Text = "We're giving you 30days free trial";
            }
            if (dr == DialogResult.Cancel)
            {
                lblHighlight.Text = "Purchase cancelled. Get out from here";
            }
        }
    }
}

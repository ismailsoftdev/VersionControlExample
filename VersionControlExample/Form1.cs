namespace VersionControlExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string address = txtBoxAddress.Text;

            LblResult.Text = fullName + " resides " + address;
        }
    }
}
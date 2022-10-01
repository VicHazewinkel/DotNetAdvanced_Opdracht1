namespace Oefening2
{
    public partial class IsItBigger : Form
    {
        public IsItBigger()
        {
            InitializeComponent();
        }

        private void IsItBigger_Click(object sender, EventArgs e)
        {

        }

        private void IsItBigger_Load(object sender, EventArgs e)
        {
            label1.Text = "12345 * 54321 = " + (12345 * 54321);
            label2.Text = "22222 * 33333 = " + (22222 * 33333);
            label3.Text = "12345 * 54321 > 22222 * 33333 " + ((12345 * 54321) > (22222 * 33333));
        }
    }
}
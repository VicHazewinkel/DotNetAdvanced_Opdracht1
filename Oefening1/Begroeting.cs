namespace Oefening1
{
    public partial class Begroeting : Form
    {
        public Begroeting()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GreetingButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo " + Environment.UserName + ". Het is " + DateTime.Now.ToShortTimeString() + " op " + DateTime.Now.ToShortDateString());
        }
    }
}
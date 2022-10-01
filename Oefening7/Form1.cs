namespace Oefening7
{
    public partial class Sum : Form
    {
        public Sum()
        {
            InitializeComponent();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            int total = 0;
            int num = int.Parse(TB_Number.Text);

            for (int i = num; i > 0; i--) 
            {
                total = total + i;
            }
            label_Total.Text = "Resultaat is " +  (total.ToString());

        }
    }
}
namespace Oefening4
{
    public partial class SalesTaxCalculator : Form
    {
        public SalesTaxCalculator()
        {
            InitializeComponent();
        }

        private void Price_Each_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double subTotaal = 0; 

            try
            {
                double temp = Convert.ToDouble(numericUpDown1.Value) * Convert.ToDouble(textBox8.Text); 
                label1.Text = Convert.ToString(temp);
                subTotaal += temp; 

            }
            catch (Exception ex)
            {
                label1.Text = "error"; 
            }
            try
            {
                double temp = Convert.ToDouble(numericUpDown2.Value) * Convert.ToDouble(textBox7.Text);
                label2.Text = Convert.ToString(temp);
                subTotaal += temp;
            }
            catch (Exception ex)
            {
                label2.Text = "error";
            }
            try
            {
                double temp = Convert.ToDouble(numericUpDown3.Value) * Convert.ToDouble(textBox6.Text);
                label3.Text = Convert.ToString(temp);
                subTotaal += temp;
            }
            catch (Exception ex)
            {
                label3.Text = "error";
            }
            try
            {
                double temp = Convert.ToDouble(numericUpDown4.Value) * Convert.ToDouble(textBox5.Text);
                label4.Text = Convert.ToString(temp);
                subTotaal += temp;
            }
            catch (Exception ex)
            {
                label4.Text = "error";
            }

            label5.Text = subTotaal.ToString();

            try
            {
                double temp = subTotaal * Convert.ToDouble(textBox10.Text) / 100;
                label6.Text = Convert.ToString(temp); 
                label7.Text = Convert.ToString(temp+subTotaal);
            }
            catch
            {
                label6.Text = "error";  
                label7.Text = "error";  
            }


        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
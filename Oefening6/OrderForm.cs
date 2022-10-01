namespace Oefening6
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            double subotaal = 0;
            double shipping = 0;
           

            try
            {
                double temp = Convert.ToDouble(TB_priceEach1.Text) * Convert.ToDouble(TB_Qualtity1.Text); 
                label_price1.Text = Convert.ToString(temp);
                subotaal += temp;
            }
            catch (Exception)
            {
                label_price1.Text = "error"; 
            }
            try
            {
                double temp = Convert.ToDouble(TB_priceEach2.Text) * Convert.ToDouble(TB_Qualtity2.Text);
                label_price2.Text = Convert.ToString(temp);
                subotaal += temp;
            }
            catch (Exception)
            {
                label_price2.Text = "error";
            }
            try
            {
                double temp = Convert.ToDouble(TB_priceEach3.Text) * Convert.ToDouble(TB_Qualtity3.Text);
                label_price3.Text = Convert.ToString(temp);
                subotaal += temp;
            }
            catch (Exception)
            {
                label_price3.Text = "error";
            }
            try
            {
                double temp = Convert.ToDouble(TB_priceEach4.Text) * Convert.ToDouble(TB_Qualtity4.Text);
                label_price4.Text = Convert.ToString(temp);
                subotaal += temp;
            }
            catch (Exception)
            {
                label_price4.Text = "error";
            }

            label_priceSubtotal.Text = subotaal.ToString();

            try
            {
                double salesTax = subotaal * 7 / 100; 
                label_priceSalesTax.Text = salesTax.ToString();
                
                if (subotaal < 20)
                {
                    shipping = 5;
                } else if (subotaal < 50)
                {
                    shipping = 7.5; 
                } else if (subotaal < 75)
                {
                    shipping = 10; 
                } else if (subotaal >= 75)
                {
                    shipping = 0; 
                }

                label_priceShipping.Text = shipping.ToString();
                
                label_priceGrandTotal.Text = Convert.ToString(salesTax + subotaal + shipping);  
                
            }
            catch
            {
                label_priceSalesTax.Text = "error";
                label_priceShipping.Text = "error";
                label_priceGrandTotal.Text = "error";   
            }
        }
    }
}
using System.Security.Cryptography.X509Certificates;

namespace Oefening5
{
    public partial class CelciusToFahrenheit : Form
    {
        public CelciusToFahrenheit()
        {
            InitializeComponent();
        }

        private void C_F_Click(object sender, EventArgs e)
        {
            try
            {
                double temp = Convert.ToDouble(text_C.Text)*9/5+32;
                text_F.Text = Convert.ToString(temp);
            }
            catch
            {
                label_C_error.Text = "Geen cijfer"; 
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            // sfffffffffff
        }

        private void F_C_Click(object sender, EventArgs e)
        {
            try
            {
                double temp = (Convert.ToDouble(text_F.Text)-32)*5/9;
                text_C.Text = Convert.ToString(temp);
            }
            catch
            {
                label_F_error.Text = "Geen cijfer";
            }
        }
    }
}
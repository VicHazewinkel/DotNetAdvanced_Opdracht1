using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefening3
{
    public partial class IsItBigger : Form
    {
        public IsItBigger()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void teller_Layout(object sender, LayoutEventArgs e)
        {
            int i = 0; 

            while (i < 100)
                {
                teller.Text = Convert.ToString(i); 
                i++;       
                }
        }
    }
}

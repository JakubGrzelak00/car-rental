using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrental.Resources
{
    public partial class Carbox : UserControl
    {
        public Carbox()
        {
            InitializeComponent();
        }

        private void carbox_button_Click(object sender, EventArgs e)
        {
            string price_text;
            if (carbox_promotion.Text != "")
            {
                double price = double.Parse(carbox_price.Text.Replace("PLN/24H", ""));
                price = price * 0.8;
                price_text = price + "PLN";
            }
            else
            {
                price_text = carbox_price.Text.Replace("PLN/24H", "PLN");
            }
            Form rentForm = new RentForm(carbox_name.Text,  price_text);
            rentForm.Show();
        }
    }
}

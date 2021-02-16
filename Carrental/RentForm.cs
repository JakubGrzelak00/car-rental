using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrental
{
    public partial class RentForm : Form
    {
        public RentForm(string carName_, string price_)
        {
            InitializeComponent();
            carName.Text = carName_;
            price.Text = price_;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            ivod.Visible = false;

            try
            {
            int pricePerDay = int.Parse(price.Text.Replace("PLN", ""));
            int cost_ = pricePerDay * int.Parse(days.Text);

            cost.Text = cost_ + "PLN";

            rentPeriod.Text = DateTime.Now.Date.ToString("d") + " - " + DateTime.Now.Date.AddDays(int.Parse(days.Text)).ToString("d");

            rent.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            cost.Visible = true;
            rentPeriod.Visible = true;
            }
            catch (System.FormatException)
            {
                ivod.Visible = true;
            }
        }

        private void rent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RentForm_Load(object sender, EventArgs e)
        {

        }
    }
}

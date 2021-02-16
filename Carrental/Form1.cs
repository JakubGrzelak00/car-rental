using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarrentalLibary;
using Carrental.Resources;

namespace Carrental
{
    public partial class Form1 : Form
    {
        public List<Carbox> activeCarboxes = new List<Carbox>();
        public Offers offers = new Offers();
        public Car car = new Car();

        public Form1()
        {
            InitializeComponent();
            activeCarboxes = offers.GeneratePromotionOffers(mainPanel);

            carBrand.SelectedIndex = 0;
            carFuelType.SelectedIndex = 0;
            carType.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            offers.RemoveActiveOffers(mainPanel, activeCarboxes);
            activeCarboxes = offers.GenerateOffers(mainPanel, carType.Text, carFuelType.Text, carBrand.Text);

            wwf.Text = "What We Found For You";

            if (activeCarboxes.Count == 0)
            {
                wwf.Text = "We Didn't Found Anything 😕";
            }
        }
    }
}

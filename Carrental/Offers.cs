using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carrental.Resources;
using CarrentalLibary;
using System.Drawing;

namespace Carrental
{
    public class Offers
    {
        public Rnd rnd = new Rnd();
        public Car car = new Car();

        public List<Carbox> GeneratePromotionOffers(Panel mainPanel)
        { 
            List<Car> cars = new List<Car>();
            cars = car.GenerateCarList();

            List<Car> randomCars = new List<Car>();
            randomCars = rnd.RandomCars(cars);

            List<Carbox> activeCarboxes_ = new List<Carbox>();

            int y = 730;
            foreach (Car car_ in randomCars)
            {
                Carbox carbox = new Carbox();
                mainPanel.Controls.Add(carbox);
                carbox.Location = new Point(163, y);
                carbox.carbox_name.Text = car_.name;
                carbox.carbox_fuelType.Text = car_.fuelType;
                carbox.carbox_price.Text = $"{car_.price}PLN/24H";

                activeCarboxes_.Add(carbox);

                y = y + 130;
            }
            return activeCarboxes_;
        }

        public void RemoveActiveOffers(Panel mainPanel, List<Carbox> activeCarboxes)
        {
            foreach (Carbox carbox in activeCarboxes)
            {
                mainPanel.Controls.Remove(carbox);
            }
        }

        public List<Carbox> GenerateOffers(Panel mainPanel, string type, string fuelType, string brand)
        {

            List<Car> filteredCars = car.FilterCars(type, fuelType, brand);

            List<Carbox> activeCarboxes_ = new List<Carbox>();

            int y = 730;
            foreach (Car car_ in filteredCars)
            {
                Carbox carbox = new Carbox();
                mainPanel.Controls.Add(carbox);
                carbox.Location = new Point(163, y);
                carbox.carbox_name.Text = car_.name;
                carbox.carbox_fuelType.Text = car_.fuelType;
                carbox.carbox_price.Text = $"{car_.price}PLN/24H";
                carbox.carbox_promotion.Text = "";

                activeCarboxes_.Add(carbox);

                y = y + 130;
            }
            return activeCarboxes_;
        }
    }
}

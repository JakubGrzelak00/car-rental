using System;
using System.Collections.Generic;
using System.Text;

namespace CarrentalLibary
{
    public class Rnd
    {
        public List<Car> RandomCars(List<Car> cars)
        {
            List<Car> randomCars = new List<Car>();
            int[] carIndexes = { 0, 0, 0 };

            Random random = new Random();
            int firstPossibleIndex = random.Next(0, 37);
            int secondPossibleIndex = random.Next(0, 37);
            int thirdPossibleIndex = random.Next(0, 37);

            carIndexes[0] = firstPossibleIndex;

            while (secondPossibleIndex == firstPossibleIndex)
            {
                secondPossibleIndex = random.Next(0, 37);
            }

            carIndexes[1] = secondPossibleIndex;

            while (thirdPossibleIndex == secondPossibleIndex | thirdPossibleIndex == firstPossibleIndex)
            {
                thirdPossibleIndex = random.Next(0, 37);
            }

            carIndexes[2] = thirdPossibleIndex;

            foreach (int index in carIndexes)
            {
                randomCars.Add(cars[index]);
                int i = cars.Count;
            }
            return randomCars;
        }
    }
}

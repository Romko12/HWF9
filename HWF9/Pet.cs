using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWF9
{
    internal class Pet
    {
        private double EnergyCurrent = 0;
        private double EnergyMax = 0;

        private double FoodCurrent = 0;
        private double FoodMax = 0;

        private double HappynessCurrent = 0;
        private double HappynessMax = 0;

        public Pet(string name, int petVar)
        {
            EnergyMax = EnergyCurrent = 100;
            FoodMax = FoodCurrent = 100;
            HappynessMax = HappynessCurrent = 100;
        }

        public double getEnergy()
        {
            return EnergyCurrent;
        }
        public double getFood()
        {
            return FoodCurrent;
        }

        public double getHappyness()
        {
            return HappynessCurrent;
        }

        public void increaseEnergy(double value)
        {
            if (EnergyMax < EnergyCurrent + value)
                EnergyCurrent = EnergyMax;
            else
                EnergyCurrent += value;
        }

        public void decreaseEnergy(double value)
        {
            if (EnergyCurrent - value < 0)
                EnergyCurrent = 0;
            else
                EnergyCurrent -= value;
        }

        public void increaseHungry(double value)
        {
            if (FoodMax < FoodCurrent + value)
                FoodCurrent = FoodMax;
            else
                FoodCurrent += value;
        }

        public void decreaseHungry(double value)
        {
            if (FoodCurrent - value < 0)
                FoodCurrent = 0;
            else
                FoodCurrent -= value;
        }

        public void increaseHappyness(double value)
        {
            if (HappynessMax < HappynessCurrent + value)
                HappynessCurrent = HappynessMax;
            else
                HappynessCurrent += value;
        }

        public void decreaseHappyness(double value)
        {
            if (HappynessCurrent - value < 0)
                HappynessCurrent = 0;
            else
                HappynessCurrent -= value;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantF
{
    class Resto
    {
        public Resto()
        {
            newChoco_Crepes = 0;
            newStrawberry_Crepes = 0;
            newBanana_Crepes = 0;
            newOreo_Crepes = 0;
            newTaro_Crepes = 0;

            newCoffee_Latte = 0;
            newVanilla_Latte = 0;
            newVelvet_Latte = 0;
            newGreen_Latte = 0;
            newForest_Latte = 0;
        }

        public Resto(double Choco_Crepes, double Strawberry_Crepes, double Banana_Crepes, double Oreo_Crepes, double Taro_Crepes,
            double Coffee_Latte, double Vanilla_Latte, double Velvet_Latte, double Green_Latte, double Forest_Latte)
        {
            newChoco_Crepes = Choco_Crepes;
            newStrawberry_Crepes = Strawberry_Crepes;
            newBanana_Crepes = Banana_Crepes;
            newOreo_Crepes = Oreo_Crepes;
            newTaro_Crepes = Taro_Crepes;

            newCoffee_Latte = Coffee_Latte;
            newVanilla_Latte = Vanilla_Latte;
            newVelvet_Latte = Velvet_Latte;
            newGreen_Latte = Green_Latte;
            newForest_Latte = Forest_Latte;
        }

        public double getChoco_Crepes()
        {
            return newChoco_Crepes;
        }
        public double getStrawberry_Crepes()
        {
            return newStrawberry_Crepes;
        }
        public double getBanana_Crepes()
        {
            return newBanana_Crepes;
        }
        public double getOreo_Crepes()
        {
            return newOreo_Crepes;
        }
        public double getTaro_Crepes()
        {
            return newTaro_Crepes;
        }
        public double getCoffee_Latte()
        {
            return newCoffee_Latte;
        }
        public double getVanilla_Latte()
        {
            return newVanilla_Latte;
        }
        public double getVelvet_Latte()
        {
            return newVelvet_Latte;
        }
        public double getGreen_Latte()
        {
            return newGreen_Latte;
        }
        public double getForest_Latte()
        {
            return newForest_Latte;
        }
     
        private double newChoco_Crepes;
        private double newStrawberry_Crepes;
        private double newBanana_Crepes;
        private double newOreo_Crepes;
        private double newTaro_Crepes;

        private double newCoffee_Latte;
        private double newVanilla_Latte;
        private double newVelvet_Latte;
        private double newGreen_Latte;
        private double newForest_Latte;
    }
}



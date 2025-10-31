using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherianceProject
{
    class ChikenRetailShop
    {
        public virtual void Price()
        {
            Console.WriteLine("Price of the chicken is :250");
        }
    }
    class Resturant : ChikenRetailShop
    {
        public override void Price()
        {
            Console.WriteLine($"Chicken-65 400  Chicken-chilli 350 ");
        }
    }
    internal class Class4
    {
        static void Main(string[] args)
        {
          ChikenRetailShop refd =new Resturant();
          refd.Price();// price resturant
          refd  =new ChikenRetailShop();
          refd.Price(); // price of retailshop
          refd.ToString();
         }
    }
}

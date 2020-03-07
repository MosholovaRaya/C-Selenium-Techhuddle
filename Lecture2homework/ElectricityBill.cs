using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture2homework
{
    class ElectricityBill
    {
        public static void eB()
        {
            Console.Write("Input customer ID here: ");
            int ID = int.Parse(Console.ReadLine());
            Console.Write("Input customer name here: ");
            string name = Console.ReadLine();
            Console.Write("Input consumed unit here: ");
            double unitConsumed = double.Parse(Console.ReadLine());


            Console.WriteLine("Customer ID No: " + ID);
            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Unit consumed: " + unitConsumed);

            double price;

            if (unitConsumed >= 600)
            {
                price = 2;
            }
            else if (unitConsumed >= 400)
            {
                price = 1.80;
            }
            else if (unitConsumed >= 200)
            {
                price = 1.50;
            }
            else if (unitConsumed >= 0)
            {
                price = 2;
            }
            else
            {
                Console.WriteLine("Unit consumed can't be negative.");
                return;
            }

            double amountCharges = unitConsumed * price;
            if (amountCharges < 100)
            {
                amountCharges = 100;
            }

            double surcharge = amountCharges * 0.15;

            double totalAmount = amountCharges;
           
            if (amountCharges > 400)
            {
                totalAmount = amountCharges + surcharge;
                Console.WriteLine($"Surcharge amount: {surcharge:0.00}NET");
            }
            Console.WriteLine($"Amount charges Rs.{price:0.00} per unit: {amountCharges: 0.00}");
            Console.WriteLine($"Amount paid by the customer: {totalAmount:0.00}");
        }
    }
}

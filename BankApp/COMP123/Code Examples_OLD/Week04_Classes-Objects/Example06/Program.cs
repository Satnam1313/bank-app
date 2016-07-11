using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products();
            product1.ReadInput();
            product1.Print();
            product1.CalulatePayment();

            Products product2 = new Products();
            product2.ReadInput();
            product2.Print();
            product2.CalulatePayment();



        }
    } //end class program

    class Products
    {
        private double price; // instance data member
        private int quantity; // or instance data member, variables

        public void ReadInput()
        {
            Console.WriteLine(" Input Price:");
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Input Quantity:");
            quantity = Convert.ToInt32(Console.ReadLine());
        } //end method

        public void CalulatePayment()
        {
            double amt = price * quantity;
            Console.WriteLine(" Payment Amount: " + amt);
        } //end method

        public void Print()
        {
            Console.WriteLine(" Price:" + price);
            Console.WriteLine(" Quantity:" + quantity);
        } //end method
        //public double PaymentAmt()
        //{
        //    return price * quantity;
        //}

        //public double PaymentAmt(double price, int numberOfItems)
        //{
        //    return price * numberOfItems;
        //}
    } //end class
}

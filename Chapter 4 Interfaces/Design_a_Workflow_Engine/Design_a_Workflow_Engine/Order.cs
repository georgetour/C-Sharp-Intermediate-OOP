using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_Workflow_Engine
{
    public class Order : ICustomerActions
    {
        public List<Product> ProductList;

        public Order()
        {
            ProductList = new List<Product>();
        }

        public void Execute(Customer customer)
        {
            Console.WriteLine("Order was added for " + customer.Name);
            TotalProducts();
        }

        public void TotalProducts()
        {
            var product = new Product(12,"iPhone",800);
            ProductList.Add(product);

            var product2 = new Product(132, "iPhone leather case", 10);
            ProductList.Add(product2);

            //Creating a int list so we can store all prices in it
            List<int> totalPrice = new List<int>();
            int totalSummary = 0;

            foreach (var item in ProductList)
            {
                totalPrice.Add(item.Price);
                totalSummary = totalPrice.Sum();
                Console.WriteLine(String.Format("Product ID : {0} \n Name : {1} \n Price : ${2} " , item.ID,item.Name, item.Price));
            }
            Console.WriteLine("Total : $" + totalSummary);
            
        }

    }
}

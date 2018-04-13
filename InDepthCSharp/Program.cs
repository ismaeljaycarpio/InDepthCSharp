using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InDepthCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = Product.GetSampleProducts();
            
            //list.Sort(new ProductNameComprarer()); ////c# 1.0

            ////c# 2.0
            //creates a delegate instance
            //anonymous method
            //list.Sort(delegate(Product x, Product y) 
            //{
            //    return x.Name.CompareTo(y.Name);
            //});

            ////c# 3.0
            //lambda expression - still creates a Comparison<Product> delegate
            //list.Sort((x, y) => x.Name.CompareTo(y.Name));

            //OrderBy - extension method
            //foreach(Product p in list.OrderBy(p => p.Name))
            //{
            //    Console.Write(p);
            //}

            //querying
            //foreach(Product p in list.Where(p => p.Price > 10))
            //{
            //    Console.Write(p);
            //}

            //linq
            var filtered = from Product p in list
                           where p.Price > 10
                           select p;

            foreach(Product p in filtered)
            {
                Console.Write(p);
            }

            Console.ReadLine();
        }
    }
}

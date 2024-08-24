using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    //Below is example of how to use interfaces, and demonstration of IEnumerable<T> 

    //INTERFACE
    //Interface is a contract that defines set of methods, properties and events without implementing them.
    //it provides WHAT functionality to implement but HOW to implement can be decided when interface is used

    //IEnumerator<T> is used in the below example. This is an interface representing collection of objects that can be enumerated or iterated over one at a time. It has a single method GetEnumerator(). Allows you to use "foreach" loop and other LINQ operations

    //Below is the INTERFACE
    public interface IProductRepository
    {
        void AddProduct(Product product); //Method is defined which accepts args of type Product class
        IEnumerable<Product> GetAllProducts();

    }

    //BELOW IS THE MAIN Product CLASS
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Price: {Price:C}";
        }
    }

    //PRODUCT REPOSITORY - Implementation is taken care HERE. This uses the interface created above to perform actions
    public class ProductRepository: IProductRepository
    {
        private readonly List<Product> _products = new List<Product>();

        //Implement methods inside the interface
        public void AddProduct( Product product )
        {
            _products.Add( product );
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }
    }

    /*
     * EXPLANATION:
     
    * Interface IProductRepository: Defines methods for adding products and retrieving all products. It uses IEnumerable<Product> for the method GetAllProducts() to allow iteration over the collection.

    * Class ProductRepository: Implements the IProductRepository interface. Uses an internal list to store products and provides implementations for the interface methods.

    * Class Product: Represents a product with Id, Name, and Price properties. The ToString() method is overridden to provide a formatted string representation of the product.
     
     */

    //BELOW IS IMPLEMENTATION OF THE ABOVE MECHANISM - A SEPARATE CLASS
    public class DemonstrateProductInterface
    {
        public static void Demo()
        {
            IProductRepository productRepository = new ProductRepository(); //Create instance of product Repository

            //Add Products
            productRepository.AddProduct(new Product { Id = 1, Name = "Laptop", Price = 999.99m });
            productRepository.AddProduct(new Product { Id = 2, Name = "Car", Price = 3999.99m });

            //Retrieve and display ALL products
            var products = productRepository.GetAllProducts();

            Console.WriteLine("Products in Repository:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }

}

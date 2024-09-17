using ProductManagement.Models.Concrete;
using ProductManagement.Models.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Service
{
    public class ProductService : IEntityService
    {
        public List<Product> products = new List<Product>();
        public void Add()
        {
            Product product = new Product();
            Console.WriteLine("Product Name: ");
            product.ProductName = Console.ReadLine();
            Console.WriteLine("Product Stock: ");
            product.Stock = int.Parse(Console.ReadLine());
            Console.WriteLine("Product Price: ");
            product.ProductPrice = int.Parse(Console.ReadLine());
            products.Add(product);
            Console.WriteLine("Ürün Başarıyla eklendi.");
 
        }

        public void Delete()
        {
            Console.WriteLine("Silmek istediğiniz ürünün ıd'sini giriniz: ");
            int Id = int.Parse(Console.ReadLine());
            var product = products.Find(x => x.Id == Id);
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine("Ürün başarıyla silinmiştir.");
            }
            else Console.WriteLine("Ürün Bulunamadı.");
        }

        public void GetAll()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Product Id: {product.Id}, Product Name: {product.ProductName}, Product Stock: {product.Stock}, Product Price: {product.ProductPrice} ");
            }
        }

        public void Update()
        {
            Console.WriteLine("Güncellemek istediğiniz ürünün ıd'sini giriniz: ");
            int id = int.Parse(Console.ReadLine());
            var product = products.Find(x => x.Id == id);
            if (product != null)
            {
                Console.WriteLine("Product Id: ");
                product.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Product Name: ");
                product.ProductName = Console.ReadLine();
                Console.WriteLine("Product Stock: ");
                product.Stock = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Product Price: ");
                product.ProductPrice= Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Ürün Bulunamadı.");
            }
        }
    }
}

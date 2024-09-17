using ProductManagement.Models.Concrete;
using ProductManagement.Models.Interface;

namespace ProductManagement.Service
{
    public class CategoryService : IEntityService
    {
        public List<Category> categories = new List<Category>();

        public void Add()
        {
            Category newCategory = new Category();

            Console.WriteLine("Product Category Name: ");
            newCategory.CategoryName = Console.ReadLine();
            Console.WriteLine("Product Description: ");
            newCategory.Description = Console.ReadLine();
            categories.Add(newCategory);
            Console.WriteLine("Ürün kategorisi Başarıyla eklendi.");

        }

        public void Delete()
        {
            Console.WriteLine("Silmek istediğiniz ürün kategorisinin ıd'sini giriniz: ");
            int Id = int.Parse(Console.ReadLine());
            var category = categories.Find(x => x.Id == Id);
            if (category != null)
            {
                categories.Remove(category);
                Console.WriteLine("Ürün kategorisi başarıyla silinmiştir.");
            }
            else Console.WriteLine("Ürün Bulunamadı.");
        }

        public void GetAll()
        {
            foreach (var category in categories)
            {
                Console.WriteLine($"Product Id: {category.Id}, Product Category Name: {category.CategoryName}, Product Description: {category.Description}");
            }
        }

        public void Update()
        {
            Console.WriteLine("Güncellemek istediğiniz ürünün ıd'sini giriniz: ");
            int id = int.Parse(Console.ReadLine());
            var category = categories.Find(x => x.Id == id);
            if (category != null)
            {
                Console.WriteLine("Product Id: ");
                category.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Product Name: ");
                category.CategoryName = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ürün Bulunamadı.");
            }
        }
    }
}


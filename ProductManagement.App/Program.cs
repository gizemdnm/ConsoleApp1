using ProductManagement.Service;

public class Program()
{
    public static void Main(string[] args)
    {
        ProductService productService = new ProductService();
        CategoryService categoryService = new CategoryService();
        bool cikis = false;
        while (!cikis)
        {
            Console.WriteLine("1-Ürün Ekle");
            Console.WriteLine("2-ürün Sil");
            Console.WriteLine("3-Ürün Güncelle");
            Console.WriteLine("4-Ürünleri Listele");
            Console.WriteLine("5-Ürün kategorisi ekle");
            Console.WriteLine("6-Ürün kategorisi sil");
            Console.WriteLine("7-Ürün kategorisini güncelle");
            Console.WriteLine("8-Ürün kategorisini listele");
            Console.WriteLine("9-Çıkış");

            Console.Write("Seçimini Yap: ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    productService.Add();
                    break;
                case "2":
                    productService.Delete();
                    break;
                case "3":
                    productService.Update();
                    break;
                case "4":
                    productService.GetAll();
                    break;
                case "5":
                    categoryService.Add();
                    break;
                case "6":
                    categoryService.Delete();
                    break;
                case "7":
                    categoryService.Update();
                    break;
                case "8":
                    categoryService.GetAll();
                    break;
                case "9":
                    Console.WriteLine("Çıkış Yapılıyor.");
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }
        }
    }
}


using OrderControll.Common;
using OrderControll.Repos.Entities;
using System.Collections.Generic;

namespace OrderControll.Repos
{
    public class ProductRepo
    {
        private List<Product> Products { get; set; }

        public ProductRepo()
        {
            string fileName = FileReaderService.GetPathToResource("ProductsRepository.txt");
            Products = new FileReaderService().Import<Product>(fileName);
        }

        public List<Product> GetProducts() => Products;
    }
}
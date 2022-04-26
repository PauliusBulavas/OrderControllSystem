using OrderControll.Common;
using OrderControll.Repos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public Product GetProductsById(int productId)
        {
            var acctualProduct = Products.FirstOrDefault(x => x.Id == productId);

            return acctualProduct;
        }

        public void AddProduct(Product product)
        {
            product.Id = Products.LastOrDefault().Id + 1;
            Products.Add(product);
        }

        public bool RemoveProduct(int id)
        {
            return Products.Remove(GetProductsById(id));
        }
    }
}
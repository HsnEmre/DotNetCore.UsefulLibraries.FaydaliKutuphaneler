using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.App
{
    public class SRPGod
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    public class ProductRepository
    {
        private static List<Product> _Products = new List<Product>();
        public ProductRepository()
        {
            _Products = new()
            {
                new() { Id = 1,Name="Kalem 1"},
                new() { Id = 2,Name="Kalem 1"},
                new() { Id = 3,Name="Kalem 1"},
                new() { Id = 4,Name="Kalem 1"},
                new() { Id = 5,Name="Kalem 1"},
                new() { Id = 6,Name="Kalem 1"},
                new() { Id = 7,Name="Kalem 1"},
            };
        }
        public List<Product> GetProducts => _Products;
        public void SaveOrUpdate(Product product)
        {
            var hasProduct = _Products.Any(x => x.Id == product.Id);

            if (!hasProduct)
            {
                _Products.Add(product);
            }
            else
            {
                var index = _Products.FindIndex(x => x.Id == product.Id);

                _Products[index] = product;
            }
        }


        public void Delete(int id)
        {
            var hasProduct = _Products.Find(x => x.Id == id);
            if (hasProduct == null)
            {
                throw new Exception("urun yok");

            }

            //if (hasProduct!=null)
            //{
            _Products.Remove(hasProduct);

            //}

        }

    }

    public class ProducPresenter
    {
        public void WriteToConsole(List<Product> ProductList)
        {
            ProductList.ForEach(x =>
            {
                Console.WriteLine($"{x.Id}-{x.Name}");

            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.App
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private static List<Product> _products = new List<Product>();


        public List<Product> GetProducts => _products;



        public Product()
        {
            _products = new()
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

        public void SaveOrUpdate(Product product)
        {
            var hasProduct = _products.Any(x => x.Id == product.Id);

            if (!hasProduct)
            {
                _products.Add(product);
            }
            else
            {
                var index = _products.FindIndex(x => x.Id == product.Id);

                _products[index] = product;
            }
        }


        public void Delete(int id)
        {
            var hasProduct = _products.Find(x => x.Id == id);
            if (hasProduct == null)
            {
                throw new Exception("urun yok");

            }

            //if (hasProduct!=null)
            //{
            _products.Remove(hasProduct);

            //}

        }



        public void WriteToConsole()
        {
            _products.ForEach(x =>
            {
                Console.WriteLine($"{x.Id}-{x.Name}");

            });
        }
    }
}

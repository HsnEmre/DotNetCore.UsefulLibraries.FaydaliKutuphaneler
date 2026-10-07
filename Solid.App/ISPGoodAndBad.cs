using System;
using System.Collections.Generic;
using System.Text;
using static Solid.App.ISPGoodAndBad.ReadProductRepository;

namespace Solid.App.ISPGoodAndBad
{

    //1.class library Read Impl
    //class library CUD

    //public class ReadProductRepository : IProductRepository
    //{
    //    public Product Create(Product p)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Product Delete(Product p)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Product GetById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public List<Product> GetList()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Product Update(Product p)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    public class WriteRepository : IWriteREpository
    {
        public Product Create(Product p)
        {
            throw new NotImplementedException();
        }

        public Product Delete(Product p)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product p)
        {
            throw new NotImplementedException();
        }
    }
    public class ReadProductRepository : IReadRepository
    {
        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetList()
        {
            throw new NotImplementedException();
        }
    }


    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    //public interface IProductRepository
    //{



    //}

    public interface IReadRepository
    {
        List<Product> GetList();
        Product GetById(int id);
    }
    public interface IWriteREpository
    {



        Product Create(Product p);
        Product Update(Product p);
        Product Delete(Product p);
    }
}

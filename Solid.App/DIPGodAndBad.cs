using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.App.DIPGodAndBad

{
    public class ProductService
    {

        private readonly IRepository _repo;

        public ProductService(IRepository sl)
        {
            _repo = sl;
        }

        public List<string> GetAll()
        {
            return _repo.GetAll();
        }
    }
    public interface IRepository
    {
       public List<string> GetAll();
    }
    public class ProductRepositoryFromsql:IRepository
    {
        public List<string> GetAll()
        {
            return new List<string>() { "sql kalem1", "sql Kalem2" };
        }

    }
}

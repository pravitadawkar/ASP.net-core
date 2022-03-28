using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuplierAddressCRUD.suplierModel
{
    public interface IProduct
    {
        public List<Products> GetAllProducts(int supplierId);
        public Products GetProduct(int id);
        public void Insert(Products product);
        public void Update(Products product);
        public void Delete(int id);
    }
}

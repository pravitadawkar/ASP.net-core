using SuplierAddressCRUD.Athentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuplierAddressCRUD.suplierModel
{
    public class ProductService:IProduct
    {
        ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Products> GetAllProducts(int SupplierId)
        {
            return _context.products.Where(p=>p.Suplier.Id== SupplierId).ToList();
        }
        public Products GetProduct(int id)
        {

            return _context.products.Where(p => p.Id == id).FirstOrDefault();

        }
        public void Insert(Products product)
        {
            _context.Add(product);
            _context.SaveChanges();
        }
        public void Update(Products product)
        {
            _context.Update(product);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }
    }
}

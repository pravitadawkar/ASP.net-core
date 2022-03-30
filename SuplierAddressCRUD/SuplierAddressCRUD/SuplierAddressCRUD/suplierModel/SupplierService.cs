using SuplierAddressCRUD.Athentication;
using SuplierAddressCRUD.View_Models;
using System.Collections.Generic;
using System.Linq;

namespace SuplierAddressCRUD.suplierModel
{
    public class SupplierService : ISupplier
    {
        ApplicationDbContext _context;
        public SupplierService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<SupplierDTO> GetAllSuplier()
        {
            var result = (from s in _context.suppliers
                          join a in _context.addresses on s.Id equals a.Supplier.Id
                          select new SupplierDTO
                          {
                              AddressId = a.Id,
                              SupplierId = s.Id,
                              City = a.City,
                              Country = a.Country,
                              State = a.State,
                              SupplierName = s.Name,
                              Address1 = a.Address1,
                              Address2 = a.Address2,
                          }).ToList();
            return result;
        }
        public SupplierDTO GetSupplier(int id)
        {
            var result = (from s in _context.suppliers
                          join a in _context.addresses on s.Id equals a.Supplier.Id
                          where s.Id == id
                          select new SupplierDTO
                          {
                              AddressId = a.Id,
                              SupplierId = s.Id,
                              City = a.City,
                              Country = a.Country,
                              State = a.State,
                              SupplierName = s.Name,
                              Address1 = a.Address1,
                              Address2 = a.Address2,
                          }).FirstOrDefault();
            return result;
        }
        public void Update(SupplierDTO supplierddto)
        {
            Supplier supplier = new Supplier();
            supplier.Id = supplierddto.SupplierId;
            supplier.Name = supplierddto.SupplierName;
            _context.Update(supplier);
            //_context.SaveChanges();

            Address address = new Address();
            address.Id = supplierddto.AddressId;
            address.Supplier = supplier;
            address.Address1 = supplierddto.Address1;
            address.Address2 = supplierddto.Address2;
            address.City = supplierddto.City;
            address.State = supplierddto.State;
            address.Country = supplierddto.Country;
            _context.Update(address);
            _context.SaveChanges();
        }
        public void Insert(SupplierDTO supplierddto)
        {
            Supplier supplier = new Supplier();
            supplier.Name = supplierddto.SupplierName;
            _context.Add(supplier);
            _context.SaveChanges();

            Address address = new Address();
            address.Supplier = supplier;
            address.Address1 = supplierddto.Address1;
            address.Address2 = supplierddto.Address2;
            address.City = supplierddto.City;
            address.State = supplierddto.State;
            address.Country = supplierddto.Country;
            _context.Add(address);
            _context.SaveChanges();
        }
        public void Delete(int SupplierId)
        {
            var Address = _context.addresses.Where(s => s.Supplier.Id == SupplierId).FirstOrDefault();

            if (Address != null)
            {
                _context.Remove(Address);
                _context.SaveChanges();
            }
            var supplier = _context.suppliers.Where(s => s.Id == SupplierId).FirstOrDefault();

            if (supplier != null)
            {
                _context.Remove(supplier);
                _context.SaveChanges();
            }
        }
    }
}

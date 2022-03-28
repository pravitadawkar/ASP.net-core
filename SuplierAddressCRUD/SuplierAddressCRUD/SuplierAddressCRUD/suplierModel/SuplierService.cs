using SuplierAddressCRUD.Athentication;
using SuplierAddressCRUD.View_Models;
using System.Collections.Generic;
using System.Linq;

namespace SuplierAddressCRUD.suplierModel
{
    public class SuplierService : Isuplier
    {
        ApplicationDbContext _context;
        public SuplierService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<SupplierDTO> GetAllSuplier()
        {
            var result = (from s in _context.supliers
                          join a in _context.addresses on s.Id equals a.Suplier.Id
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
            var result = (from s in _context.supliers
                          join a in _context.addresses on s.Id equals a.Suplier.Id
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
            Suplier suplier = new Suplier();
            suplier.Id = supplierddto.SupplierId;
            suplier.Name = supplierddto.SupplierName;
            _context.Update(suplier);
            _context.SaveChanges();

            Addresscs address = new Addresscs();
            address.Id = supplierddto.AddressId;
            address.Suplier = suplier;
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
            Suplier suplier = new Suplier();
            suplier.Name = supplierddto.SupplierName;
            _context.Add(suplier);
            _context.SaveChanges();

            Addresscs address = new Addresscs();
            address.Suplier = suplier;
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
            var Address = _context.addresses.Where(s => s.Suplier.Id == SupplierId).FirstOrDefault();

            if (Address != null)
            {
                _context.Remove(Address);
                _context.SaveChanges();
            }
            var supplier = _context.supliers.Where(s => s.Id == SupplierId).FirstOrDefault();

            if (supplier != null)
            {
                _context.Remove(supplier);
                _context.SaveChanges();
            }
        }
    }
}

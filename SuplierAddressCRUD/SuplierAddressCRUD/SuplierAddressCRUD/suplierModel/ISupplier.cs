using SuplierAddressCRUD.View_Models;
using System.Collections.Generic;

namespace SuplierAddressCRUD.suplierModel
{
    public interface ISupplier
    {
        public List<SupplierDTO> GetAllSuplier();
        public SupplierDTO GetSupplier(int id);
        public void Insert(SupplierDTO supplier);
        public void Update(SupplierDTO supplier);
        public void Delete(int supplier);
    }
}

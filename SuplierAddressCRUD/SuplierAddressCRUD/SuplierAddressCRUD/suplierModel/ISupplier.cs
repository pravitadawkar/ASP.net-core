using SuplierAddressCRUD.View_Models;
using System.Collections.Generic;

namespace SuplierAddressCRUD.suplierModel
{
    public interface ISupplier
    {
        public List<SupplierDTO> GetAllSuplier();
        public SupplierDTO GetSupplier(int id);
        public void Insert(SupplierDTO suplier);
        public void Update(SupplierDTO suplier);
        public void Delete(int suplier);
    }
}

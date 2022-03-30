using SuplierAddressCRUD.suplierModel;
using System.Collections.Generic;

namespace SuplierAddressCRUD.suplierModel
{
    public class Address
    {
        public Address()
        {
            Supplier = new Supplier();
        }
        //[ForeignKey("Supplier")]
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}

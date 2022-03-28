using SuplierAddressCRUD.suplierModel;
using System.Collections.Generic;

namespace SuplierAddressCRUD.suplierModel
{
    public class Addresscs
    {
        public Addresscs()
        {
            Suplier = new Suplier();
        }
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public virtual Suplier Suplier { get; set; }
    }
}

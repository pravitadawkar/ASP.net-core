using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SuplierAddressCRUD.suplierModel
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public  virtual Address Address { get; set; }
        public virtual ICollection<Products> Product { get; set; }
    }
}

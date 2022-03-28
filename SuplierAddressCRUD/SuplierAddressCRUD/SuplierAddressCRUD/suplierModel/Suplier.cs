using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SuplierAddressCRUD.suplierModel
{
    public class Suplier
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

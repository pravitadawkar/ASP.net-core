using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOprationRepo.Firstmodels
{
    public class Car
    {
        [Key]
        public int CarNo { get; set; }
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public string CarColor { get; set; }
       
        
    }
}

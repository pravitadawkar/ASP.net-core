using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDOprationRepo.Firstmodels;

namespace CRUDOprationRepo.DataBase
{
    public class Databasecontext:DbContext
    {
       public Databasecontext(DbContextOptions<Databasecontext> options) : base(options)
        { 
        }
       public DbSet<Car> Cars { get; set; }
    }
}

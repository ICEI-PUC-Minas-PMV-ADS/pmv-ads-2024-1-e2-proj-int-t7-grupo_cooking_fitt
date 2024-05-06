using CookingFitDATA.Interfaces;
using CookingFitDATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingFitDATA.Repositories
{
    public class RepositoryIngrediente : RepositoryBase<Ingrediente>, IRepositoryIngrediente
    {
        public RepositoryIngrediente(bool SaveChanges = true) : base(SaveChanges) 
        {

        }
    }
}

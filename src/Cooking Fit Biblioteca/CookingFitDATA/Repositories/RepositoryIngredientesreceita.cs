using CookingFitDATA.Interfaces;
using CookingFitDATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingFitDATA.Repositories
{
    public class RepositoryIngredientesreceita : RepositoryBase<Ingredientesreceita>, IRepositoryIngredientesreceita
    {
        public RepositoryIngredientesreceita(bool SaveChanges = true) : base(SaveChanges)
        {

        }

    }
}


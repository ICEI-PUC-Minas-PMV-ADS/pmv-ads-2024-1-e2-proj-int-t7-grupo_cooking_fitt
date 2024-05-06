using CookingFitDATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingFitDATA.Services
{
    public class IngredienteServices
    {
        public RepositoryIngrediente oRepositoryIngrediente { get; set; }
        public IngredienteServices() 
        {
            oRepositoryIngrediente = new RepositoryIngrediente();
        }
    }
}

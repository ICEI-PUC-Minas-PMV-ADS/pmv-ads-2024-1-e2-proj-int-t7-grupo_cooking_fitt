using CookingFitDATA.Interfaces;
using CookingFitDATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingFitDATA.Repositories
{
    public class RepositoryConsumoCalorico : RepositoryBase<ConsumoCaloricoContext>, IRepositoryConsumoCalorico
    {
        public RepositoryConsumoCalorico(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}

using CookingFitDATA.Interfaces;
using CookingFitDATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingFitDATA.Repositories
{
    internal class RepositoryCardapio : RepositoryBase<Cardapio>, IRepositoryCardapio
    {
        public RepositoryCardapio(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}

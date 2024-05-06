using CookingFitDATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingFitDATA.Services
{
    public class UsuárioServices
    {
        public RepositoryUsuário oRepositoryUsuário { get; set; }
        public UsuárioServices() 
        {
            oRepositoryUsuário = new RepositoryUsuário ();


        }    
    }
}

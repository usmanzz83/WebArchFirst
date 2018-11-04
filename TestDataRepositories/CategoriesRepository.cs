using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCore;
using TestData;
using TestDataRepositories.Interfaces;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestDataRepositories
{
    public class CategoriesRepository  : GenericRepository<ModelNorthWind,Category>,ICategories
    {



        public void samemethod()
        {
            

        }
        
    }
}

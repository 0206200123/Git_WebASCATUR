using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebASCATUR.Data.Models;
using WebASCATUR.Data.Interfaces;

namespace WebASCATUR.Data.Repositories
{
    public class OpinionRepository : IOpinionRepository
    {
        private readonly AdmWebASCATUR_Default_v1Context _appDbContext;

        public OpinionRepository(AdmWebASCATUR_Default_v1Context appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //public IEnumerable<Opinion> Opiniones => _appDbContext.Servicio.Include(c => c.Category);

        public IEnumerable<Opinion> aleatorioOpiniones => _appDbContext.Opinion.OrderBy(x => Guid.NewGuid()).Take(3);

        //public Opinion GetOpinionById(int drinkId) => _appDbContext.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
    }
}

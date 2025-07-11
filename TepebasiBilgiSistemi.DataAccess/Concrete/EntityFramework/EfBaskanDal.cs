using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TepebasiBilgiSistemi.Core.DataAccess.EntityFramework;
using TepebasiBilgiSistemi.DataAccess.Abstract;
using TepebasiBilgiSistemi.Entities.Concrete;

namespace TepebasiBilgiSistemi.DataAccess.Concrete.EntityFramework
{
    public class EfBaskanDal : EfEntityRepositoryBase<Baskan, TpbsContext>, IBaskanDal
    {
        public IEnumerable<Baskan> BaskanF()
        {
            using (var context = new TpbsContext())
            {
                return context.Baskan
                    .Select(x => x)
                    .Include(x => x.BaskanMudurluk).ThenInclude(y => y.Mudurluk)
                    .ToList();
            }
        }
        public IEnumerable<Baskan> BaskanFBI(int Id)
        {
            using (var context = new TpbsContext())
            {
                return context.Baskan
                    .Where(x => x.Id == Id)
                    .Select(x => x)
                    .Include(x => x.BaskanMudurluk).ThenInclude(y => y.Mudurluk)
                    .ToList();
            }
        }
    }
}

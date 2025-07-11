using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TepebasiBilgiSistemi.Core.DataAccess;
using TepebasiBilgiSistemi.Entities.Concrete;

namespace TepebasiBilgiSistemi.DataAccess.Abstract
{
    public interface IBaskanDal : IEntityRepository<Baskan>
    {
        public IEnumerable<Baskan> BaskanF();
        public IEnumerable<Baskan> BaskanFBI(int Id);
    }
}

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
    public class EfBelgeDal : EfEntityRepositoryBase<Belge, TpbsContext>, IBelgeDal
    {
    }
}

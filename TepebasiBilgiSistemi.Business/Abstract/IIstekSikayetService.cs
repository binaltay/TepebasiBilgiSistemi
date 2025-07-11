using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TepebasiBilgiSistemi.Entities.Concrete;

namespace TepebasiBilgiSistemi.Business.Abstract
{
    public interface IIstekSikayetService
    {
        List<IstekSikayet> GetAll();
        void Add(IstekSikayet istekSikayet);
        Task AddAsync(IstekSikayet istekSikayet);
        void Update(IstekSikayet istekSikayet);
        void Delete(int istekSikayetId);
        IstekSikayet GetById(int istekSikayetId);
    }
}

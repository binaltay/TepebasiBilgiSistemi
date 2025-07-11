using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TepebasiBilgiSistemi.Entities.Concrete;

namespace TepebasiBilgiSistemi.Business.Abstract
{
    public interface IMudurlukService
    {
        List<Mudurluk> GetAll();
        void Add(Mudurluk mudurluk);
        Task AddAsync(Mudurluk mudurluk);
        void Update(Mudurluk mudurluk);
        void Delete(int mudurlukId);
        Mudurluk GetById(int mudurlukId);
    }
}

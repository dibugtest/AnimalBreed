using Animal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Repository
{
   public interface ILrpUserRepository
    {
        IEnumerable<Lrp> GetAll();
        Lrp GetById(int id);
        Lrp Insert(Lrp lrp);
        void Delete(int id);
        void Update(Lrp Model);
        void Save();
    }
}

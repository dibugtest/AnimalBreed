using Animal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Repository
{
    public class AiRepository : Repository<Ai>, IAiRepository
    {

        public AiRepository(AnimalContext Context)
            : base(Context)
        {
        }

        public AnimalContext AnimalContext
        {
            get { return db as AnimalContext; }

        }
        public IEnumerable<Ai> GetModel()
        {
            return db.ais.Include(M => M.Animal).Include(m => m.Bull).ToList();
        }
        public Ai GetById(int id)
        {
            return db.ais.Include(m => m.Animal).Include(m => m.Bull).FirstOrDefault(m => m.id == id);

        }
    }
}

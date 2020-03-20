using Animal.Models;
using AutoMapper.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Repository
{
    public class LrpUserRepository:ILrpUserRepository
    {
        private readonly IUserRepository _user;
        private readonly ILrpUserRepository _lrpUser;
        private readonly IConfiguration _config;
        private readonly AnimalContext _context;

        public LrpUserRepository(AnimalContext Context) 
        {
            _context = Context;   
        }

        public void Delete(int id)
        {
            Lrp model = _context.lrps.Find(id);
            _context.lrps.Remove(model);
            Save();
        }

        public Lrp GetById(int id)
        {
            return _context.lrps.Find(id);

        }
       

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Lrp Model)
        {
            _context.Entry(Model).State = EntityState.Modified;
            Save();
        }
        public IEnumerable<Lrp> GetAll()
        {
            return _context.lrps;
        }

        public Lrp Insert(Lrp lrp)
        {
            _context.lrps.Add(lrp);
            Save();
            return lrp;
        }
       
    }
}

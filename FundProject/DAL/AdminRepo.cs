using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdminRepo : IRepository<Admin, int>
    {
        FundProjectEntities db;
        public AdminRepo(FundProjectEntities db)
        {
            this.db = db;
        }

        public Admin Get(int id)
        {
            return db.Admins.FirstOrDefault(x => x.aId == id);
        }

        public List<Admin> Get()
        {
            return db.Admins.ToList();

        }

        public bool Add(Admin e)
        {
           db.Admins.Add(e);
            db.SaveChanges();
            return true;    
           
        }

        public void Edit(Admin e)
        {
            var d = db.Admins.FirstOrDefault(x => x.aId == e.aId);
            db.Entry(d).CurrentValues.SetValues(e);
            db.SaveChanges();

        }

        public void Delete(int id)
        {

            var d = db.Admins.FirstOrDefault(x => x.aId == id);
            db.Admins.Remove(d);
            db.SaveChanges();

        }

        
    }
}

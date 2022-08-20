using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User1Repo : IRepository<Users1, int>

    {

        FundProjectEntities db;
        public User1Repo(FundProjectEntities db)
        {
            this.db = db;
        }

        public List<Users1> Get()
        {
            return db.Users1.ToList();
        }

        public Users1 GetAll(int id)
        {
            return db.Users1.FirstOrDefault(x => x.uId == id);
        }

        public bool Add(Users1 e)
        {
            db.Users1.Add(e);
            db.SaveChanges();
            return true;
        }

        public void Edit(Users1 e)
        {
            var d = db.Users1.FirstOrDefault(x => x.uId == e.uId);
            db.Entry(d).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var e = db.Users1.FirstOrDefault(x => x.uId == id);
            db.Users1.Remove(e);
            db.SaveChanges();
            return true;
        }

    }
}

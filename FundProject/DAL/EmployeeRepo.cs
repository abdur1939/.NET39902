using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeRepo : IRepository<Employee, int>
    {
        FundProjectEntities db;
        public EmployeeRepo(FundProjectEntities db)
        {
            this.db = db;
        }

        public List<Employee> Get()
        {
            return db.Employees.ToList();

        }

        public Employee GetAll(int id)
        {
            return db.Employees.FirstOrDefault(x => x.eId == id);
        }


        public  bool Add(Employee e)
        {
            db.Employees.Add(e);    
            db.SaveChanges();
            return true;
        }

        public void Edit(Employee e)
        {
            var d = db.Employees.FirstOrDefault(x => x.eId == e.eId);
            db.Entry(d).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
           var e = db.Employees.FirstOrDefault(x => x.eId == id);
            db.Employees.Remove(e);
            db.SaveChanges();
            return true;

        }

    }
}

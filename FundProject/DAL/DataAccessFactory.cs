using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static FundProjectEntities db; 
        static DataAccessFactory()
        {
            db = new FundProjectEntities(); 
        }
        public static IRepository<Admin,int> AdminDataAccess()
        {
            return new AdminRepo(db);
        }

        public static IRepository<Employee, int> EmployeeDataAccess()
        {
            return new EmployeeRepo(db);
        }

        public static IRepository<Users1, int> User1DataAccess()
        {
            return new User1Repo(db);
        }

    }
}

using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace BLL1
{
    public class EmployeeService
    {
       

        public static List<string> GetNames()
        {
            var data = DataAccessFactory.EmployeeDataAccess().Get().Select(e => e.eName).ToList();
            return data;
        }

        public static List<EmployeeModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Employee, EmployeeModel>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<EmployeeModel>>(DataAccessFactory.EmployeeDataAccess().Get());
            return data;

        }


        public static void Add(EmployeeModel a)
        {

            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<EmployeeModel, Employee>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Employee>(a);
            DataAccessFactory.EmployeeDataAccess().Add(data);

        }

        public static void Edit(EmployeeModel employee)
        {
          

            var config = new MapperConfiguration(c => c.CreateMap<EmployeeModel, Employee>());
            var mapper = new Mapper(config);
            var data = mapper.Map<Employee>(employee);
            DataAccessFactory.EmployeeDataAccess().Edit(data);

        }

        public static bool Delete(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Employee, EmployeeModel>();

            });
            var mapper = new Mapper(config);
           
            DataAccessFactory.EmployeeDataAccess().Delete(id);
            return true;

        }

    }
}

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
    public class User1Service
    {

        public static List<string> GetNames()
        {
            var data = DataAccessFactory.User1DataAccess().Get().Select(e => e.uName).ToList();
            return data;
        }

        public static List<User1Model> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Users1, User1Model>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<User1Model>>(DataAccessFactory.User1DataAccess().Get());
            return data;

        }

       
        public static void Add(User1Model a)
        {

            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User1Model, Users1>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Users1>(a);
            DataAccessFactory.User1DataAccess().Add(data);

        }

        public static void Edit(User1Model user)
        {


            var config = new MapperConfiguration(c => c.CreateMap<User1Model, Users1>());
            var mapper = new Mapper(config);
            var data = mapper.Map<Employee>(user);
            DataAccessFactory.EmployeeDataAccess().Edit(data);

        }

        public static bool Delete(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Users1, User1Model>();

            });
            var mapper = new Mapper(config);

            DataAccessFactory.User1DataAccess().Delete(id);
            return true;

        }

    }
}

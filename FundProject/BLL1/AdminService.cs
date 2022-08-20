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
    public class AdminService
    {
        public static List<AdminModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminModel>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<AdminModel>>(DataAccessFactory.AdminDataAccess().Get());
            return data;

        }

        public static List<string> GetNames()
        {
            var data = DataAccessFactory.AdminDataAccess().Get().Select(e => e.aName).ToList();
            return data;
        }

        public static bool Add(AdminModel a)
        {

            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminModel, Admin>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Admin>(a);
            DataAccessFactory.AdminDataAccess().Add(data);
            return true;    

        }
       

        public static void Edit(AdminModel admin)
        {
            //var config = new MapperConfiguration(c =>
            //{
            //    c.CreateMap<AdminModel, Admin>();

            //});

            //var mapper = new Mapper(config);
            //var data = mapper.Map<Admin>(admin);
            //DataAccessFactory.AdminDataAccess().Edit(data);
            //return true;

            var config = new MapperConfiguration(c => c.CreateMap<AdminModel, Admin>());
            var mapper = new Mapper(config);
            var data = mapper.Map<Admin>(admin);
             DataAccessFactory.AdminDataAccess().Edit(data);
           

        }

        public static bool Delete(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminModel>();

            });
            var mapper = new Mapper(config);
            //var data = mapper.Map<Admin>(id);
            DataAccessFactory.AdminDataAccess().Delete(id);
            return true;

        }



    }
}

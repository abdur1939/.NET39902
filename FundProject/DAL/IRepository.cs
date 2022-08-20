using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
     public interface IRepository<T,ID>

    {
        List<T> Get();
        T GetAll(ID id);
        bool Add(T e);
        void Edit(T e); 

        bool Delete(ID id);
      

    }
}

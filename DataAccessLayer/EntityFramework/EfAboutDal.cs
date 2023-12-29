using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAboutDal:GenericRepository<About>, IAboutDal
    {
        public AppUser GetByUserName(string username)
        {
            using var c = new Context();
            return c.Set<AppUser>().Where(x => x.UserName == username).SingleOrDefault();
        }
    }
}

using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate
{
   
    public class WriterRepository:IwriterDal
    {
        Context c = new Context();
        DbSet<Writer> _object;
        public void Delete(Writer p)
        {
            throw new NotImplementedException();
        }
        public void Insert(Writer p)
        {
            throw new NotImplementedException();
        }
        public List<Writer> List()
        {
            throw new NotImplementedException();
        }

    }
}

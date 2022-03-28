using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{ //Generic yapı oluşturuyoruz
    public interface IContactDal:IRepository<Contact> //Irepository den miras alıp contact sınıfını kullan
    {

    }
}

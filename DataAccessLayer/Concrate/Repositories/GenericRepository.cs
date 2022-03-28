using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate.Repositories
{//Kod yükünü azaltmak için burada her şeyi kapsayacak şekilde yzıyoruz.
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object; //T değerine karşılık gelen sınıfı tutmak için
        //T nin karşılığı olan değerleri bulması için
        public GenericRepository()
        {
            _object=c.Set<T>();//Context e bağlı olarak gönderilen değeri objeckt olarak atıyoruz.
        }
        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            //GenericRepository de bu method tanımlandığı için buradan miras alan tüm sınıflar için de bu method geçerli oalcak.
            return _object.SingleOrDefault(filter); //Bir dizide veya listede sadece bir değer döndürmek için kullanılan entittyframework elemanı
        }

        public void Inser(T p)
        {
            throw new NotImplementedException();
        }

        public void Insert(T p)
        {
           _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();//List kısmında listeyi döndürmesi için mutlaka return konulu.
        }

        public List<T> List(Expression<Func<T, bool>> filter) //Şartlı listeleme
        {
            return _object.Where(filter).ToList(); //Filter da bana ne gönderirse onu listele 
        }

        public void Update(T p)
        {
            c.SaveChanges(); ;
        }
    }
}

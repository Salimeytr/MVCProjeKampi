using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate.Repositories
{
    public class CategoryRepository : ICategoryDal //Kalıtım olar alıyoruz.Metotları kullanabilmek için implement yapmamız gerekir.

    {
        Context c= new Context(); //çağırmamız gereken sınıflar
        DbSet<Category> _object; //dbset türünde object aCategory tablosunu kullanıyoruz
        public void Delete(Category p)
        {
           _object.Remove(p);
            c.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Inser(Category p)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category p)
        {
           _object.Add(p);//Category den gelen p yi object in içine ekle
            c.SaveChanges();//değişiklikleri kaydet
        }

        public List<Category> List()
        {
            return _object.ToList();//Entityframework de verileri listelemek için kullanılan metot
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }
    }
}

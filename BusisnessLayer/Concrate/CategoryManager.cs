using BusisnessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusisnessLayer.Concrate
{
    public class CategoryManager : ICategoryServices
    {
        //uzerinde çalışacağımız sınıfı repositry e bağlı olarak çağırıyoruz.
        // GenericRepository<Category> repo = new GenericRepository<Category>(); //Generic repository içinde kullanabileceğimiz tüm sınıfları görmek için
        //repo adında bir dğeişken tanımladık. Daha sonra repo. yazdığımız zaman generic repository in içine ulaşabilmemeizi sağlayacak.

        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categorydal) //Yapıcı methot oluşmuş oldu.Atama yapacaüımız kısım da böylelikle oluşmuş oldu.
        {
            _categoryDal = categorydal;

        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category); //ID me eşit olan category e göre AdminCategoryController kısmındaki catrgoryvalue=GetById(id) adlı değişkeni silecektir.
        }

        public Category GetById(int id) //Id ye göre veri bulma methodu
        {
            //Genericrepository de yer alan değerlerin hepsini _categoryDal ile çağırabiliriz
            return _categoryDal.Get(x=>x.CategoryId==id); //category sınıfında ait propertiler (CategoryId gibi) id den gelen değere eşit olmalı şartını kuruyoruz.
        }

        public List<Category> GetList()
        {
            return _categoryDal.List(); //IRepository içindeki metotları çekiyoruz.

        }

        void ICategoryServices.CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);//Irepository den çağırıyoruz.
        }

        List<Category> ICategoryServices.GetList()
        {
            throw new NotImplementedException();
        }
        //public void CategoryAddBl(Category p)
        //{
        //    if (p.CategoryName==" " || p.CategoryStatus==false|| p.CategoryName.Length <= 2)
        //    {
        //        //hata mesajı
        //    }

        //    else
        //    {
        //        _categorydal.Insert(p);
        //    }
        //}

    }
}

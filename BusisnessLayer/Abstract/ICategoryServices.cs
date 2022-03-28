using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusisnessLayer.Abstract
{
    //Once interface kısmında eklenecek metodun ismi tanımlanır.Ardından bu metodun içi sınıf tarafında doldurulur.
    public interface ICategoryServices
    {
        List<Category> GetList();
        void CategoryAdd(Category category);
        //Bulma işlemini yapabilmesi için gerekli olan ifadeyi yazıyoruz.
        Category GetById(int id); //Dışarıdan Id ye göre bul
        void CategoryDelete(Category category);

    }

}

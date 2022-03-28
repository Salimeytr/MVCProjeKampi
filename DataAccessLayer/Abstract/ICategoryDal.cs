using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{ //interfaceler sınıflara rehberlik edecek yapılardır.
    //metotlar oluşturulur ve metotlar üzerinde işlemler gerçekleştiriilir.

    //Uzun Yol//
    //public interface ICategoryDal
    //{//CRUD Operasyonları methot olarak tanımlanır.
    //    //type Name();
    //    List<Category> List();//Türü List olan ismi de List olan bir metot
    //    void Insert(Category p); //p parametresi aracılığıyla categorilerde yer alan tüm sınıflara ulaşım sağlayabileceğiz.
    //    void Update(Category p);    
    //    void Delete(Category p); //Yeni bir sınıf oluşturup burada yazdığım metotların ne işlemleri yaptığını görevlerini yazmamız gerekiyor.
    //    //Bu görevler için Concrate klasorunun içine Repositories adında bir klasör oluşturuyoruz.



    //}

    //Kısa Yol//
    public interface ICategoryDal:IRepository<Category>
    {

    }
}

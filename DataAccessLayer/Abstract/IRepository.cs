using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IRepository<T> //Bunu kullanmak için T yi yanımlıyoruz
    {
        List<T> List();
        void Insert(T p);//T den parametre alıyoruz
        //Önce sildireceğimiz işlemi bulduralım
        T Get(Expression<Func<T, bool>> filter); //List metodundan farkı sadece tek değer döndürmesi.List metodunda tüm liste taranıyor fakat bu metotda id=5 olan aranıyor
        void Delete(T p);   
        void Update(T p);
        List<T> List(Expression<Func<T, bool>> filter); // Buraya eklediğim her yeni metot interfacelerin tamamı için eklenmiş oldu.
        //Bu yüzden bu kısmı kullanıyoruz.Yaptığımzı her değişiklik diğerlerinşi de kapsasın diye.

    }
}

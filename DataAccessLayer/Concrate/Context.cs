using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate
{
    public class Context : DbContext //DBContext sınıfındaki ifadeler buraya eklensin
        //Burada tanımlauacaklarımız tablo ismi olarak karşımıza çıkacak
    {
        public DbSet<About> Abouts { get; set; } //About projenin içinde yer alan sonofon ismi. Abouts ise SQL de veri tabanı tablomuza yansıyacak tablonun ismi.

        //About başka katmanın yani entity katmanının bir elemanı.Eğer başka katmanın elemanını buraya
        //eklemek istiyorsak kullanacağımız o katmanı buray referans olarak eklememiz gerekmektedir. DateAccessLayer ın altındaki referances
        //kısmına gelip sağ tıklıyoruz.Add referance diyoruz. O katmanı Entity katmanını ekliyoruz. Artık o katmanı burada kullanabiliriz.

        public DbSet<Category> Categories{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Content> Contents{ get; set; }
        public DbSet<Heading> Headings{ get; set; }

        public DbSet<Writer> Writers { get; set; }

        //Buradakiler hepsi SQL a tablo olarak yansıtılacak.


    }
}

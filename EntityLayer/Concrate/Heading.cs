using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    //Concrate klasöründe somut olarak tuttuğumuz ifadeleri bir arada tutmak içim bu klasörü oluşturuyoruz.
    //Absract klasöründe ise soyut olarak eklenen ifadeler tutulacak.


    public class Heading //Başlık sınıfı
    {//propertiler: Her bir sınıf için kullanılacak ifadeler oluşturuluyor. Bunlar veri tabanına yansıycak sütun başlıkları
       [Key]
        public int HeadingId { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingTime { get; set; }
        public int CategoryId { get; set; } //İlişki kurulan category kımındaki tablodaki sutunismiyle aynı ismi yazıyoruz.
        public virtual Category Category { get; set; } //İlişkiyi kurmak için virtual kullanıyoruz.Category sınıfından catagory isminde prop oluşturuyoruz.

        public ICollection<Content> Contents { get; set; } //Content sınıfıyla ilişki kurmak için,Content kısmında da virtual işlemi yapıalcak.
        public int WriterId { get; set; } //Heading kısmında başlık açan kişinin Id sini görebilmek için yazıyoruz.
        public virtual Writer Writer { get; set; } //Heading kısmında başlığı açan writer ın kim olduğunu böylece ilişki kurarak görebiliyoruz.



    }
}

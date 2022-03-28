using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Content //içerik 
    {
        [Key] //Bu olmazsa hata alırız.

        public int ContentId { get; set; }
        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }
        //ContentYazar
        //ContentBaşlık

        public int HeadingId { get; set; } //ICollection ile Heading kısmında kurulan ilişkide ortak başlığımızı ekliyoruz.
        public virtual Heading Heading { get; set; } //Virtual ile kurulan ilişki tamamlanıyor.
        public int? WriterId{ get; set; } //ICollection Content ile bağlantı kuruluyor writerId ile ağlantının kurulması için ortak ıd belirleniyor.
        public virtual Writer Writer { get; set; } //Writer dan bir writer değeri alınacak.

    }
}

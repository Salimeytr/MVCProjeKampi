using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Writer
    {
        [Key]
        public int? WriterId { get; set; }
        [StringLength(50)]
        public string WriterName { get; set; }
        [StringLength(50)]
        public string WriterSurname { get; set; }
        [StringLength(100)]
        public string WriterImage { get; set; }
        [StringLength(50)]
        public string WriterMail { get; set; }
        [StringLength(20)]
        public string WriterPassword { get; set; }

        // Heading(Başlık) hangi yazar tarafından oluşturulduğunu görebilmek için heading ve writer arasında ilişki kuruyoruz.
        public ICollection<Heading> Headings { get; set; } //Heading kısmını açan kişinin ID sini görebilmek için Heading kısmınd aprop tanımlamamız gerekiyor.
       
        public ICollection <Content> Contents { get; set; } //Yapılan yorumlar Contentler kim tarafından yapıldı görmek için
                                                            



    }
}

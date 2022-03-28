﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(200)]
        public string CategoryDescription { get; set; }
        
        public bool CategoryStatus { get; set; }

        //Tablolar arasında ilişki kuruyoruz.Icollection<İlişki kurmak istediğin sınıf Ent> yazılır
        public ICollection<Heading> Headings { get; set; } //Bu işlemi tamamlamak için Heading kısmında da bazı işlemler yapmak gerekiyor.



    }
}

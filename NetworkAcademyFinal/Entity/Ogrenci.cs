using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetworkAcademyFinal.Entity
{
    public class Ogrenci
    {

        public int Id { get; set; }

        [StringLength(20)]
        public string Ad { get; set; }

        [StringLength(20)]
        public string Soyad { get; set; }

        [StringLength(11)]
        public string TCKimlikNo { get; set; }

        [StringLength(50)]
        public string Adres { get; set; }

        [StringLength(20)]
        public string Telefon { get; set; }

        [StringLength(20)]
        public string AldigiEgitim { get; set; }

        [StringLength(20)]
        public string BasariDurumu { get; set; }

    }
}
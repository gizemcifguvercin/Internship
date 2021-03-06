//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.veritabani
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web;
    public partial class StajBilgi
    {

        public int staj_id { get; set; }
        [Required]
        public string staj_bas { get; set; }
        [Required]
        public string staj_bit { get; set; }
        [Required]
        public string calisma_alani { get; set; }
        [Required]
        public string kullanilan_teknolojiler { get; set; }
        [Required]
        public string yetkili_yorumu { get; set; }
        [Required]
        public bool staj_onaylandimi { get; set; }
        [Required]
        public string ogrenci_tc { get; set; }
        [Required]
        public string staj_defteri { get; set; }
        [Required]
        public string firma_adi { get; set; }
        [Required]
        public string firma_tel { get; set; }
        [Required]
        public string firma_adres { get; set; }
        [Required]
        public string firma_fax { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+.[A-Za-z]{2,4}", ErrorMessage = "Yanl�� Mail Format�")]

        public string firma_mail { get; set; }
        [Required]
        public string departman { get; set; }


        public virtual Ogrenci Ogrenci { get; set; }
    }
}

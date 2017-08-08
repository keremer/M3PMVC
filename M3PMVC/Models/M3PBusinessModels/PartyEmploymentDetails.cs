using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using M3PMVC.PartyModels;

namespace M3PMVC.BusinessModels
{
    public partial class PartyEmploymentDetails
    {
        //public PartyEmployment()
        //{
        //    this.CiqPartypersonelgorev = "0";
        //}

        [Display(Name = "Görev ID")]
        [Key]
        public int EmployeeID { get; set; }

        public int CiqPrID { get; set; }

        [Display(Name = "İşe Giriş Tarihi", Prompt = "İşe Giriş Tarihi")]
        public System.DateTime Isegiris { get; set; }

        [Display(Name = "İşten Çıkış Tarihi", Prompt = "İşten Çıkış Tarihi")]
        public System.DateTime Istencikis { get; set; }

        [Display(Name = "Atama Nedeni", Prompt = "Bu göreve atanma nedeni")]
        public string Isegirisnedeni { get; set; }

        [Display(Name = "Ayrılma Nedeni", Prompt = "İşten çıkma/çıkarılma nedeni")]
        public string Istencikisnedeni { get; set; }

        [Display(Name = "Görevi", Prompt = "Görevi")]
        public string CiqPartypersonelgorev { get; set; }

        [Display(Name = "Çalıştığı Proje", Prompt = "Hangi proje kapsamında işe alındığı")]
        public string Calistigiprojekodu { get; set; }

        [Display(Name = "Pozisyon", Prompt = "Organizasyon şemasındaki kademesi")]
        public byte Personelkademesi { get; set; }

        [Display(Name = "Ülke", Prompt = "Görev yaptığı ülke (ve/veya şehir)")]
        public string Calistigiulke { get; set; }

        [Display(Name = "Ücret", Prompt = "Bordrosuna göre net maaşı")]
        public Nullable<decimal> ciplakucret { get; set; }

        [Display(Name = "Notlar", Prompt = "Notlar")]
        public string Notlar { get; set; }

        [Display(Name = "Migration ID", Prompt = "Dummy")]
        public string MigrationID { get; set; }

        public virtual M3PPartyReal Employment { get; set; }
    }
}
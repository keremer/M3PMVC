using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using M3PMVC.RootModels;
using M3PMVC.ProductModels;

namespace M3PMVC.PartyModels
{
    public partial class M3PPartyReal
    {
        [Display(Name = "Trimorya ID", Prompt = "Trimorya ID")]
        [Key]
        public int CiqPrID { get; set; }

        [Display(Name = "Ünvan", Prompt = "Ünvan")]
        public string CiqPrtitle { get; set; }

        [Display(Name = "İlk Adı", Prompt = "İlk Adı")]
        public string CiqPrname { get; set; }

        [Display(Name = "2. Adı", Prompt = "2. Adı")]
        public string CiqPrmidname { get; set; }

        [Display(Name = "Soyadı", Prompt = "Soyadı")]
        public string CiqPrsurname { get; set; }

        [Display(Name = "Uyruğu", Prompt = "Uyruğu")]
        public string CiqPruyruk { get; set; }

        [Display(Name = "Doğum Tarihi", Prompt = "Doğum Tarihi")]
        public DateTime CiqPrdt { get; set; }

        [Display(Name = "Doğum Yeri", Prompt = "Doğum Yeri")]
        public string CiqPrdy { get; set; }

        [Display(Name = "Baba Adı", Prompt = "Baba Adı")]
        public string CiqPrbabaad { get; set; }

        [Display(Name = "Anne Adı", Prompt = "Anne Adı")]
        public string CiqPrannead { get; set; }

        [Display(Name = "Sosyal Güvenlik No", Prompt = "Sosyal Günelik No")]
        public string CiqPrssec { get; set; }

        [Display(Name = "TC Kimlik No", Prompt = "TC Kimlik No")]
        public string CiqPrkimlikmaster { get; set; }

        [Display(Name = "Fotoğraf", Prompt = "Fotoğraf")]
        public byte[] CiqPrResim { get; set; }

        [Display(Name = "Notlar", Prompt = "Notlar")]
        public string Not { get; set; }

        //public virtual ICollection<PartyAffiliation> PartyAffiliations { get; set; }
        
        public virtual ICollection<PartyPassport> partyPassports { get; set; }
        public virtual ICollection<PartyVisa> partyVisas { get; set; }
        public virtual ICollection<M3PPartyLegal> partyEmployment { get; set; }
        public virtual ICollection<PartyeMail> partyeMails { get; set; }
        public virtual ICollection<PartyPostalAdress> partyAdresses { get; set; }
        public virtual ICollection<PartyPhone> partyPhones { get; set; }
        public virtual ICollection<M3PCostItems> servemats { get; set; }
        //public virtual ICollection<PartyEmploymentData> partyEmploymentDetails { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace M3PMVC.PartyModels
{
    public class M3PPartyLegal
    {
        [Display(Name = "Kurum ID", Prompt = "Kurum ID")]
        [Key]
        public int CiqPtID { get; set; }

        [Display(Name = "Ticari Ünvan", Prompt = "Ticari Ünvan")]
        public string CiqPartyTuzelTicariUnvan { get; set; }

        [Display(Name = "Kayıt Giriş Tarihi", Prompt = "Kayıt Giriş Tarihi")]
        public System.DateTime CiqPartTuzelvalfrom { get; set; }

        [Display(Name = "Geçerlilik Tarihi", Prompt = "Geçerlilik Tarihi")]
        public Nullable<System.DateTime> CiqPartyvalto { get; set; }

        [Display(Name = "Vergi Dairesi", Prompt = "Vergi Dairesi")]
        public string CiqPartyvergid { get; set; }

        [Display(Name = "Vergi No", Prompt = "Vergi No")]
        public string CiqPartyTuzelvergino { get; set; }

        [Display(Name = "Kurum Türü", Prompt = "Kurum Türü")]
        public string CiqPartyTuzelintype { get; set; }

        public virtual ICollection<M3PPartyReal> humanResources { get; set; }
        
    }
}
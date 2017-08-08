using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace M3PMVC.PartyModels
{
    public class PartyVisa //: IEnumerable<PartyVisa>, IList<PartyVisa>
    {
        [Display(Name = "Vize ID", Prompt = "Vize ID")]
        [Key]
        public int CiqPartyVisaID { get; set; }

        public string CiqPartyPasno { get; set; }
        public int CiqPrID { get; set; }
        
        [Display(Name = "Vize Türü", Prompt = "Vize Tipi")]
        public string CiqPartyVizetipi { get; set; }

        [Display(Name = "Vize Başlangıcı", Prompt = "Vize başlangıç tarihi")]
        public System.DateTime CiqPartyVizebas { get; set; }

        [Display(Name = "Vize Bitişi", Prompt = "Vize bitiş tarihi")]
        public System.DateTime CiqPartyVizeson { get; set; }

        [Display(Name = "Ülke", Prompt = "Vize hangi ülke için alındı?")]
        public string CiqPartyVizecnt { get; set; }

        [Display(Name = "Vize No", Prompt = "Vize No")]
        public string CiqPartyVizeno { get; set; }

        [Display(Name = "G/Ç Sayısı", Prompt = "Vizece izin verilen; ülkeye giriş çıkış sayısı")]
        public string CiqPartyVizeEnt { get; set; }

        [Display(Name = "Vize Görüntüsü", Prompt = "Vizenin taranmış görüntüsü")]
        public byte[] CiqPartyVizeimg { get; set; }

        public virtual PartyPassport partyPassport { get; set; }
        public virtual M3PPartyReal partyReal { get; set; }
      
    }
}
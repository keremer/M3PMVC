using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M3PMVC.PartyModels
{
    public partial class PartyPassport //: IEnumerable<PartyPassport>, IList<PartyPassport>
    {
        
        [Key]
        [Display(Name = "Pasaport No", Prompt = "Pasaport No")]
        public string CiqPartyPasno { get; set; }

        public int CiqPrID { get; set; }

        [Display(Name = "Veriliş Tarihi", Prompt = "Pasaport veriliş tarihi")]
        public System.DateTime CiqPartyPasvert { get; set; }

        [Display(Name = "Geçerlilik Tarihi", Prompt = "Pasaport aşağıdaki tarihe kadar geçerlidir")]
        public System.DateTime CiqPartyPasgec { get; set; }

        [Display(Name = "Verildiği Yer", Prompt = "Pasaportu veren yer")]
        public string CiqPartyPasvery { get; set; }

        [Display(Name = "Taranmış Pasaport Görüntüsü", Prompt = "Pasaportun taranmış sayfaları")]
        public byte[] CiqPartyPasimg { get; set; }

        public virtual M3PPartyReal partyReal { get; set; }
        public virtual ICollection<PartyVisa> partyVisas { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using M3PMVC.PartyModels;
using M3PMVC.ProcessModels;

namespace M3PMVC.ProductModels // yapı tanımları - inheritance graph
{
    public class M3PCostItems
    {
        [Display(Name = "Malzeme ID", Prompt = "Malzeme ID")]
        [Key]
        public int mkID { get; set; } // KAYIT NO
        public int compeID { get; set; } // ELEMAN NO; HANGİ ELEMANA - BİLEŞENE AİT?
        public int partmID { get; set; } // MALZEME NO - META INPUT - SINIFLANDIRMA
        public int pID { get; set; } // HANGİ PROJE İÇİN VERİ TEMİN EDİLDİ / KULLANILDI?
        // public int fID { get; set; }  // FIRMA NO - KİMDEN TEMİN EDİLDİ?
        public int miktar { get; set; } // Sipariş miktarı nedir?
        public string birim { get; set; } // ifcMeasure'a göre düzenlenecek - türetilmiş olabilir (adam/saat, vb.)
        public decimal fiyat { get; set; } // Malzeme "temin" fiyatı (Nakliye ve işçilik hariç - bunlar ayrı girdi olacak analiz olarak yer alacak)             
        public decimal tuWeight { get; set; } // Nakliye sırasında ölçülen ağırlık...

        public virtual ICollection<M3PPartyReal> suppliers { get; set; } // FIRMA NO - KİMDEN TEMİN EDİLDİ?

    }
}
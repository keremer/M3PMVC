using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace M3PMVC.ProductModels
{
    public class vbimEntityDatabase // hammadde, mamul, yarı mamul malzemeler - tüm varlıklar
        // Proje verileri önemli değil... Olası tüm inşaat girdilerinin master listesi. (Şablon analizlerle birlikte olsa?)
    {
        [Display(Name = "vbim ID", Prompt = "vbim ID")]
        [Key]
        public int entID { get; set; } //malzeme listesindeki girdi sırası

        public string refID { get; set; } // benim esas kullanacağım Trimorya Malzeme listesindeki kodu malzemenin... Her iki ID'de unique olacak.
        public string refDef { get; set; } // tanım

        // VBIM Classification - a leaner approach would be possible - just an ID to Classification inheritance table maybe?
        //public string hasFacets { get; set; }
        //public string hasAttributes { get; set; } //is the value of facet where required.
        //public Enum facetConfiguration { get; set; }
        //public Enum attributePlacement { get; set; }

        // basic data as per applicable standards       
        public string actFxN { get; set; }
        public string actColor { get; set; }
        public decimal actLength { get; set; }
        public decimal actWidth { get; set; }
        public decimal actHeight { get; set; }
        public decimal actArea { get; set; }
        public decimal actVolume { get; set; }
        public decimal actWeight { get; set; }
        public int actCount { get; set; } // in this context, amount of order.

        
        //public virtual IfcRoot hasModel { get; set; } //actual BIM junction point

    }
}
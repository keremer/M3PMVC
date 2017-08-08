using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace M3PMVC.ProductModels
{
    public class vbimEntityMetabase // hammadde, mamul, yarı mamul malzemeler - tüm varlıklar
        // Proje verileri önemli değil... Olası tüm inşaat girdilerinin master listesi. (Şablon analizlerle birlikte olsa?)
    {
        [Display(Name = "vbim ID", Prompt = "vbim ID")]
        [Key]
        public int mID { get; set; } //malzeme listesindeki girdi sırası

        public string hasID { get; set; } // benim esas kullanacağım Trimorya Malzeme listesindeki kodu malzemenin... Her iki ID'de unique olacak.
        public string hasDef { get; set; } // tanım

        // VBIM Classification - a leaner approach would be possible - just an ID to Classification inheritance table maybe?
        public string hasFacets { get; set; }
        public string hasAttributes { get; set; } //is the value of facet where required.
        public Enum facetConfiguration { get; set; }
        public Enum attributePlacement { get; set; }

        // basic data as per applicable standards       
        public string hasFxN { get; set; }
        public string hasColor { get; set; }
        public decimal hasLength { get; set; }
        public decimal hasWidth { get; set; }
        public decimal hasHeight { get; set; }
        public decimal hasArea { get; set; }
        public decimal hasVolume { get; set; }
        public decimal hasWeight { get; set; }
        public int hasCount { get; set; } // in this context, min. amount of order.

        
        //public virtual IfcRoot hasModel { get; set; } //actual BIM junction point

    }
}
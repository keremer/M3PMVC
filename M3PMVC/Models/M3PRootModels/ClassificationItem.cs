using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace M3PMVC.RootModels
{
    public class ClassificationItem
    {
        [Display(Name = "classification ID", Prompt = "classification ID")]
        [Key]
        public int cItemID { get; set; }
        public string cItemCode { get; set; } //sınıflandırma tablosundaki kodu
        public int cMetabaseID { get; set;} // hangi tabloya ait?
        public string cItemdef { get; set; }

        public virtual IfcClassificationMetabase cDomain { get; set; }
    }
}
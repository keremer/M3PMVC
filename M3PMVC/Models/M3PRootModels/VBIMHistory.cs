using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace M3PMVC.RootModels
{
    public class VBIMcell
    {
        [Display(Name = "vbim index ID", Prompt = "vbim history ID")]
        [Key]
        public int ID { get; set; }
        public string Content { get; set; }
        public Attribute Properties { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace M3PMVC.ProcessModels
{
    public class M3PProject
    {
        [Display(Name = "project ID", Prompt = "project ID")]
        [Key]
        public int projeID { get; set; }
        public string projeDef { get; set; }
    }
}
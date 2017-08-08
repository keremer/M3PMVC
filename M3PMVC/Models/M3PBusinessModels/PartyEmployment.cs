using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using M3PMVC.PartyModels;

namespace M3PMVC.BusinessModels
{
    public class PartyEmployment
    {
        public int EmpID { get; set; }

        [Display(Name = "Sicil No", Prompt = "Sicil No")]
        public string KurumSicilNo { get; set; }

        [Display(Name = "Ç.Kartı Süresi", Prompt = "Çalışma Kartı Süresi")]
        public Nullable<System.DateTime> Workpermitto { get; set; }

        public virtual PartyEmploymentDetails EmploymentDetails { get; set; }

    }
}
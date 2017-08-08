using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using M3PMVC.RootModels;


namespace M3PMVC.PartyModels
{
    public partial class PartyeMail
    {
        [Display(Name = "email ID", Prompt = "email ID")]
        [Key]
        public int CiqPartyepostaID { get; set; }
       
        public int CiqPrID { get; set; }

        public System.DateTime CiqPartyepostavalidfrom { get; set; }
        public Nullable<System.DateTime> CiqPartyepostavalidto { get; set; }
        public string CiqPartyeposta { get; set; }
        public byte ePostaAttribute { get; set; } // main, secondary, work
                
        public virtual M3PPartyReal emailOwner { get; set; }
    }
}
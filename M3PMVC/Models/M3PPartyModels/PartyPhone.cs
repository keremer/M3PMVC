using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace M3PMVC.PartyModels
{
    public class PartyPhone
    {
        [Display(Name = "phone ID", Prompt = "phone ID")]
        [Key]
        public int CiqPhonePID { get; set; }

        public string CiqPoolPhonenr { get; set; }
        public Nullable<System.DateTime> CiqPoolPhonevalto { get; set; }
        public System.DateTime CiqPoolPhonevalfrom { get; set; }
        public string CiqPager { get; set; }
        public byte CiqPoolPhonetype { get; set; }
        public byte CiqPoolDatarel { get; set; }
        public byte CiqPoolRelstate { get; set; } // not reachable, wrong number, phonetype mismatch
        public string CiqPoolpswitchboardtype { get; set; } // i.e. PBX
        public string CiqPoolpnrpoolrange { get; set; } // i.e. PBX pool - last two digits ie. 00 thru 40

        public virtual ICollection<M3PPartyReal> phoneOwners { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace M3PMVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ilceler
    {
        public Ilceler()
        {
            this.SemtMahs = new HashSet<SemtMah>();
        }
    
        public int ilceId { get; set; }
        public int SehirId { get; set; }
        public string IlceAdi { get; set; }
        public string SehirAdi { get; set; }
    
        public virtual Sehirler Sehirler { get; set; }
        public virtual ICollection<SemtMah> SemtMahs { get; set; }
    }
}

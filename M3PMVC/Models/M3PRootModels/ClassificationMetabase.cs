using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace M3PMVC.RootModels
{
    public class IfcClassificationMetabase
    {
        [Display(Name = "metabase ID", Prompt = "metabase ID")]
        [Key]
	    public int cMetabaseID {get; set;}
        public string cMetabasesource {get; set;} //Source 	    :  	IfcLabel; (data origin)
        public string cEdition {get; set;}  //Edition 	        :  	IfcLabel;
        public DateTime cEditiondate {get; set;} //EditionDate  :  	OPTIONAL IfcCalendarDate;
        public string cMetacode {get; set;} //örn: Masterformat Table nr.
        public string cMetaname {get; set;} //Name 	            :  	IfcLabel;

        public virtual ICollection<ClassificationItem> cItem {get; set;} //INVERSE    Contains 	 :  	SET OF IfcClassificationItem FOR ItemOf; 
    }
}
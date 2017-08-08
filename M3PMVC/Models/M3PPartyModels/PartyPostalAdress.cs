using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace M3PMVC.PartyModels
{
    public class PartyPostalAdress

//ENTITY IfcPostalAddress
	
//  SUBTYPE OF ( 	IfcAddress);
	
//      InternalLocation    :  	OPTIONAL IfcLabel;
//      AddressLines 	    :  	OPTIONAL LIST [1:?] OF IfcLabel;
//      PostalBox 	        :  	OPTIONAL IfcLabel;
//      Town 	            :  	OPTIONAL IfcLabel;
//      Region 	            :  	OPTIONAL IfcLabel;
//      PostalCode 	        :  	OPTIONAL IfcLabel;
//      Country 	        :  	OPTIONAL IfcLabel;
//  WHERE
	
//      WR1 	            :  	EXISTS (InternalLocation) OR EXISTS (AddressLines) OR EXISTS (PostalBox) OR EXISTS (PostalCode) OR EXISTS (Town) OR EXISTS (Region) OR EXISTS (Country);
//END_ENTITY; 

    {
        [Display(Name = "adres ID", Prompt = "adres ID")]
        [Key]
        public int ciqAdresPID { get; set; }

        public string CiqPooladrtype { get; set; }
        public string CiqPoolinternalLocation { get; set; }
        public string CiqPooladrline1 { get; set; }
        public string CiqPooladrline2 { get; set; }
        public string CiqPoolpostalbox { get; set; }
        public string CiqPooltown { get; set; }
        public string CiqPoolregion { get; set; }
        public string ciqZIP { get; set; }
        public string CiqPoolcountry { get; set; }
        public System.DateTime CiqPooladrValidfrom { get; set; }
        public Nullable<System.DateTime> CiqPooladrValidto { get; set; }
        public short ciqLocalizationIndex { get; set; }

        public virtual ICollection<M3PPartyReal> adresOwners { get; set; }
    }
}
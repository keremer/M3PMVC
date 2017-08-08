using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace M3PMVC.RootModels
{
    public class ClassificationMetabaseOntology
    {
        [Display(Name = "inheritance ID", Prompt = "classification inheritance ID")]
        [Key]
        public int CmetaID { get; set; } // classification meta ID
        public int CMapfrom { get; set; } // ontology parent (autonomous map from omniclass, masterformat, uniformat, bayındırlık)
        public int CMapto { get; set; } // ontology child (autonomous map to omniclass, masterformat, uniformat, bayındırlık)
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MercuryFitnessHubMain.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EntityTypeMaster
    {
        public System.Guid inEntityTypeId { get; set; }
        public int autoEntityTypeId { get; set; }
        public string stEntityTypeName { get; set; }
        public string stEntityTypeCode { get; set; }
        public Nullable<int> inPEntityTypeId { get; set; }
        public string stRemark { get; set; }
        public bool flgIsDeleted { get; set; }
        public string stInsUser { get; set; }
        public Nullable<System.DateTime> dtInsDate { get; set; }
        public string stInsTerm { get; set; }
        public string stUpdUser { get; set; }
        public Nullable<System.DateTime> dtUpdDate { get; set; }
        public string stUpdTerm { get; set; }
    }
}
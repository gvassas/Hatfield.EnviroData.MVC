//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hatfield.EnviroData.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransectResultValue
    {
        public TransectResultValue()
        {
            this.TransectResultValueAnnotations = new HashSet<TransectResultValueAnnotation>();
        }
    
        public long ValueID { get; set; }
        public long ResultID { get; set; }
        public double DataValue { get; set; }
        public System.DateTime ValueDateTime { get; set; }
        public System.DateTime ValueDateTimeUTCOffset { get; set; }
        public double XLocation { get; set; }
        public int XLocationUnitsID { get; set; }
        public double YLocation { get; set; }
        public int YLocationUnitsID { get; set; }
        public double TransectDistance { get; set; }
        public double TransectDistanceAggregationInterval { get; set; }
        public int TransectDistanceUnitsID { get; set; }
        public string CensorCodeCV { get; set; }
        public string QualityCodeCV { get; set; }
        public string AggregationStatisticCV { get; set; }
        public double TimeAggregationInterval { get; set; }
        public int TimeAggregationIntervalUnitsID { get; set; }
    
        public virtual TransectResult TransectResult { get; set; }
        public virtual ICollection<TransectResultValueAnnotation> TransectResultValueAnnotations { get; set; }
    }
}

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
    
    public partial class DataSet
    {
        public DataSet()
        {
            this.DataSetCitations = new HashSet<DataSetCitation>();
            this.DataSetsResults = new HashSet<DataSetsResult>();
            this.RelatedDatasets = new HashSet<RelatedDataset>();
            this.RelatedDatasets1 = new HashSet<RelatedDataset>();
        }
    
        public int DataSetID { get; set; }
        public System.Guid DataSetUUID { get; set; }
        public string DataSetTypeCV { get; set; }
        public string DataSetCode { get; set; }
        public string DataSetTitle { get; set; }
        public string DataSetAbstract { get; set; }
    
        public virtual ICollection<DataSetCitation> DataSetCitations { get; set; }
        public virtual ICollection<DataSetsResult> DataSetsResults { get; set; }
        public virtual ICollection<RelatedDataset> RelatedDatasets { get; set; }
        public virtual ICollection<RelatedDataset> RelatedDatasets1 { get; set; }
    }
}

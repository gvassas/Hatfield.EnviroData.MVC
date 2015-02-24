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
    
    public partial class DataloggerProgramFile
    {
        public DataloggerProgramFile()
        {
            this.DataLoggerFiles = new HashSet<DataLoggerFile>();
        }
    
        public int ProgramID { get; set; }
        public int AffiliationID { get; set; }
        public string ProgramName { get; set; }
        public string ProgramDescription { get; set; }
        public string ProgramVersion { get; set; }
        public string ProgramFileLink { get; set; }
    
        public virtual Affiliation Affiliation { get; set; }
        public virtual ICollection<DataLoggerFile> DataLoggerFiles { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XemPhimTT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Video
    {
        public int videoid { get; set; }
        public string videoname { get; set; }
        public byte[] videofile { get; set; }
        public string videofilename { get; set; }
        public int movieid { get; set; }
    
        public virtual Movie Movie { get; set; }
    }
}

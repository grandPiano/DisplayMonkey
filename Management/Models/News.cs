//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DisplayMonkey.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class News
    {
        public int FrameId { get; set; }
        public int Source { get; set; }
    
        public virtual Frame Frame { get; set; }
    }
}

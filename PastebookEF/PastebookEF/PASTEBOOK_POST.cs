//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PastebookEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class PASTEBOOK_POST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PASTEBOOK_POST()
        {
            this.PASTEBOOK_COMMENT = new HashSet<PASTEBOOK_COMMENT>();
            this.PASTEBOOK_LIKE = new HashSet<PASTEBOOK_LIKE>();
            this.PASTEBOOK_NOTIFICATION = new HashSet<PASTEBOOK_NOTIFICATION>();
        }
    
        public int POST_ID { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string CONTENT { get; set; }
        public int PROFILE_OWNER_ID { get; set; }
        public int POSTER_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PASTEBOOK_COMMENT> PASTEBOOK_COMMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PASTEBOOK_LIKE> PASTEBOOK_LIKE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PASTEBOOK_NOTIFICATION> PASTEBOOK_NOTIFICATION { get; set; }
        public virtual PASTEBOOK_USER PASTEBOOK_USER { get; set; }
        public virtual PASTEBOOK_USER PASTEBOOK_USER1 { get; set; }
    }
}

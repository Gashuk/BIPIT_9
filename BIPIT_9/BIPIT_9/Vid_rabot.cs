//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BIPIT_9
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vid_rabot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vid_rabot()
        {
            this.Rabot = new HashSet<Rabot>();
        }
    
        public int Id { get; set; }
        public string Name_vid_rabot { get; set; }
        public Nullable<int> Plan_vid_rabot { get; set; }
        public Nullable<int> Cost_vid_rabot { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rabot> Rabot { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lmbrd
{
    using System;
    using System.Collections.Generic;
    
    public partial class Klienti
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Klienti()
        {
            this.Sdacha = new HashSet<Sdacha>();
        }
    
        public int KlientID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public long Passport { get; set; }
        public System.DateTime Date_passport { get; set; }
        public bool RoleID { get; set; }
        public string login { get; set; }
        public string pass { get; set; }
    
        public virtual log log { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sdacha> Sdacha { get; set; }
    }
}

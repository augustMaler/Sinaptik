//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sinaptik
{
    using System;
    using System.Collections.Generic;
    
    public partial class AdvertisingСompany
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AdvertisingСompany()
        {
            this.Clients1 = new HashSet<Clients>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdClients { get; set; }
        public Nullable<int> IdType { get; set; }
        public Nullable<int> IdStatus { get; set; }
        public Nullable<int> IdStrategy { get; set; }
        public Nullable<int> IdPlace { get; set; }
        public Nullable<int> Consumption { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual PlaceForAdv PlaceForAdv { get; set; }
        public virtual StatusAdv StatusAdv { get; set; }
        public virtual StrategyAdv StrategyAdv { get; set; }
        public virtual TypeAdv TypeAdv { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clients> Clients1 { get; set; }
    }
}

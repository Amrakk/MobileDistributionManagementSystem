//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DistributionManagementWebForm.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_Note
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order_Note()
        {
            this.Order_Item = new HashSet<Order_Item>();
        }
    
        public int order_id { get; set; }
        public Nullable<System.DateTime> order_date { get; set; }
        public Nullable<int> reseller_id { get; set; }
        public Nullable<int> status_id { get; set; }
        public Nullable<decimal> total_price { get; set; }
        public string payment_method { get; set; }
    
        public virtual Delivery_Note Delivery_Note { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Item> Order_Item { get; set; }
        public virtual Reseller Reseller { get; set; }
        public virtual Status Status { get; set; }
    }
}

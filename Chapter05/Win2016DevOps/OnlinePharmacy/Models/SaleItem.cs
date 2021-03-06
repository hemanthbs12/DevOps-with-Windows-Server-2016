//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlinePharmacy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SaleItem
    {
        public int SaleItemID { get; set; }
        public int MedicineID { get; set; }
        [InventoryCheckValidator]
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal Total { get; set; }
        public int SaleID { get; set; }
    
        public virtual Drug Drug { get; set; }
        public virtual Sale Sale { get; set; }
    }
}

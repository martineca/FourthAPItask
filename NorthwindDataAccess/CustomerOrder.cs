//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NorthwindDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerOrder
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string Message { get; set; }
        public Nullable<int> quantity { get; set; }
    }
}

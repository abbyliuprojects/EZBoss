//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EZBoss.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Material
    {
        public string StoreId { get; set; }
        public string MaterialId { get; set; }
        public string MaterialName { get; set; }
        public string Type { get; set; }
        public double Number { get; set; }
        public string Unit { get; set; }
        public decimal Cost { get; set; }
        public string SupplierId { get; set; }
        public System.DateTime LastUpdateDateTime { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LYZJ.HM3Shop.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class GoodSKU
    {
        public GoodSKU()
        {
            this.GoodsPropValue = new HashSet<GoodsPropValue>();
        }
    
        public int ID { get; set; }
        public string SkuCode { get; set; }
        public string Remark { get; set; }
        public string SKUOptions { get; set; }
        public int GoodInfoID { get; set; }
        public decimal StoreCount { get; set; }
    
        public virtual GoodInfo GoodInfo { get; set; }
        public virtual ICollection<GoodsPropValue> GoodsPropValue { get; set; }
    }
}

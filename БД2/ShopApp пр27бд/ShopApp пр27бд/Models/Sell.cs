//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopApp_пр27бд.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sell
    {
        public int id_sell { get; set; }
        public int Good_id { get; set; }
        public System.DateTime DataSell { get; set; }
        public int SellCount { get; set; }
    
        public virtual Good Good { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CHockey
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sostav
    {
        public int ID { get; set; }
        public int IDName { get; set; }
        public Nullable<int> number { get; set; }
        public string FIO { get; set; }
        public string amplua { get; set; }
        public string countmatch { get; set; }
        public Nullable<int> goals { get; set; }
        public Nullable<int> rshots { get; set; }
        public Nullable<int> selections { get; set; }
        public Nullable<int> gamble { get; set; }
    
        public virtual Participants Participants { get; set; }
    }
}

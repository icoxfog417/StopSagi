//------------------------------------------------------------------------------
// <auto-generated>
//    このコードはテンプレートから生成されました。
//
//    このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//    このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace StopSagi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class blackList
    {
        public System.Guid id { get; set; }
        public string address { get; set; }
        public string comment { get; set; }
        public Nullable<int> address_type { get; set; }
        public Nullable<System.DateTime> ins_date { get; set; }
        public Nullable<System.DateTime> upd_date { get; set; }
        public string upd_usr { get; set; }
    }
}
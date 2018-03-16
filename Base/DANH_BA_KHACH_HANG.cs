namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("DANH_BA_KHACH_HANG")]
    public partial class DANH_BA_KHACH_HANG {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }
        public int THANHTOAN_ID { get; set; }
        public int TYPE_BILL { get; set; }

        [StringLength(256)]
        public string ACCOUNT { get; set; }

        [StringLength(256)]
        public string MA_TB { get; set; }

        [StringLength(256)]
        public string MA_KH { get; set; }

        [StringLength(256)]
        public string MA_TT_HNI { get; set; }

        [StringLength(512)]
        public string TEN_TT { get; set; }

        [StringLength(1024)]
        public string DIACHI_TT { get; set; }

        [StringLength(256)]
        public string DIENTHOAI { get; set; }

        [StringLength(256)]
        public string MS_THUE { get; set; }

        [StringLength(256)]
        public string BANKNUMBER { get; set; }

        [StringLength(128)]
        public string MA_DVI { get; set; }

        [StringLength(128)]
        public string MA_CBT { get; set; }

        [StringLength(128)]
        public string MA_TUYEN { get; set; }

        [StringLength(512)]
        public string CUSTCATE { get; set; }

        [StringLength(256)]
        public string STK { get; set; }
        public int MA_DT { get; set; }
        public int? KHLON_ID { get; set; }
        public int? LOAIKH_ID { get; set; }
        public int TH_SD { get; set; }
        public int ISNULL { get; set; }
        public int ISNULLMT { get; set; }
        public int FIX { get; set; }
        public int FLAG { get; set; }
    }
}
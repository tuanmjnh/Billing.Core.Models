namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("CD")]
    public partial class CD {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }
        public int TYPE_BILL { get; set; }
        public DateTime TIME_BILL { get; set; }
        public int APP_ID { get; set; }

        [StringLength(256)]
        public string MA_KH { get; set; }

        [StringLength(256)]
        public string MA_CQ { get; set; }

        [StringLength(256)]
        public string MA_TT { get; set; }

        [StringLength(256)]
        public string SO_TB { get; set; }

        [StringLength(512)]
        public string TEN_TT { get; set; }

        [StringLength(1024)]
        public string DIACHI_TT { get; set; }

        [StringLength(256)]
        public string MS_THUE { get; set; }

        [StringLength(128)]
        public string MA_DVI { get; set; }

        [StringLength(128)]
        public string MA_CBT { get; set; }

        [StringLength(128)]
        public string MA_TUYEN { get; set; }

        [StringLength(256)]
        public string KIEU { get; set; }

        [StringLength(256)]
        public string BANKNUMBER { get; set; }
        public int? TB_DAUCUOI { get; set; }

        [StringLength(128)]
        public string MA_DT { get; set; }
        public decimal CUOC_TB { get; set; }
        public decimal CUOC_DV { get; set; }
        public decimal CUOC_NH { get; set; }
        public decimal CUOC_NT { get; set; }
        public decimal CUOC_PSTN { get; set; }
        public decimal CUOC_V171 { get; set; }
        public decimal CUOC_VDNK { get; set; }
        public decimal CUOC_DD { get; set; }
        public decimal CUOC_IDD { get; set; }
        public decimal CUOC_V171Q { get; set; }
        public decimal CUOC_VDNKQ { get; set; }
        public decimal CUOC_CI { get; set; }
        public decimal CUOC_KM { get; set; }
        public decimal CHIET_KHAU { get; set; }
        public decimal TONG { get; set; }
        public decimal VAT { get; set; }
        public decimal TONGCONG { get; set; }
        public int DUPE_FLAG { get; set; }
    }
}
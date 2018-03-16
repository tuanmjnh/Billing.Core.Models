namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("BKN_GOICUOC_THANG")]
    public partial class BKN_GOICUOC_THANG {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public long ID { get; set; }
        public DateTime TIME_BILL { get; set; }

        [StringLength(256)]
        public string MA_TB { get; set; }

        [StringLength(256)]
        public string ACCOUNT { get; set; }
        public int GOICUOC_ID { get; set; }
        public int LOAIGOICUOC_ID { get; set; }
        public int STT { get; set; }
        public int LOAIHINHTB_ID { get; set; }

        [StringLength(512)]
        public string TEN_LHTB { get; set; }
        public int DICHVUVT_ID { get; set; }

        [StringLength(256)]
        public string MA_DVVT { get; set; }

        [StringLength(256)]
        public string TEN_DVVT { get; set; }
        public DateTime? NGAY_BD { get; set; }
        public DateTime? NGAY_KT { get; set; }

        [StringLength(128)]
        public string DV_QL { get; set; }
        public int DUPE_COUNT { get; set; }
        public int DUPE_FLAG { get; set; }
        public int NO_DUPE { get; set; }
        public int FIX_NGAY_KT { get; set; }
        public int TH_THANG { get; set; }
        public int TH_SO_NGAY { get; set; }
        public int FIX { get; set; }
        public int FLAG { get; set; }
    }
}
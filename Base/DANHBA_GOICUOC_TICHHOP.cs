namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("DANHBA_GOICUOC_TICHHOP")]
    public partial class DANHBA_GOICUOC_TICHHOP {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public long ID { get; set; }
        public DateTime TIME_BILL { get; set; }

        [StringLength(256)]
        public string MA_TB { get; set; }

        [StringLength(256)]
        public string ACCOUNT { get; set; }

        [StringLength(256)]
        public string TEN_GOICUOC { get; set; }
        public int LOAIGOICUOC_ID { get; set; }
        public int DICHVUVT_ID { get; set; }
        public int LOAIMAY_ID { get; set; }
        public int GOICUOC_ID { get; set; }
        public DateTime? NGAY_BD { get; set; }
        public DateTime? NGAY_KT { get; set; }
        public int DUPE_COUNT { get; set; }
        public int DUPE_FLAG { get; set; }
        public int NO_DUPE { get; set; }
        public int FIX_NGAY_KT { get; set; }
        public int TH_THANG { get; set; }
        public int TH_SO_NGAY { get; set; }
        public int FIX { get; set; }
        public int EXTRA_TYPE { get; set; }

        [StringLength(1024)]
        public string DETAILS { get; set; }

        [StringLength(1024)]
        public string EXTRAS { get; set; }
        public int FLAG { get; set; }
    }
}
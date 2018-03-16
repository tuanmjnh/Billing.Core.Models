namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("DICHVU_VT_BKN")]
    public partial class DICHVU_VT_BKN {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public int DICHVUVT_ID { get; set; }

        [StringLength(256)]
        public string MA_DVVT { get; set; }

        [StringLength(256)]
        public string TEN_DVVT { get; set; }

        [StringLength(1024)]
        public string GHICHU { get; set; }

        [StringLength(1024)]
        public string TINHTP_ID { get; set; }

        [StringLength(256)]
        public string LOAI_HD { get; set; }

        [StringLength(128)]
        public string MENU { get; set; }

        [StringLength(128)]
        public string QUYCHIEU { get; set; }
        public int? ORDERS { get; set; }

        [StringLength(256)]
        public string CREATEDBY { get; set; }
        public DateTime? CREATEDAT { get; set; }

        [StringLength(256)]
        public string UPDATEDBY { get; set; }
        public DateTime? UPDATEDAT { get; set; }

        [StringLength(128)]
        public string TABLE_TARGET { get; set; }

        [StringLength(128)]
        public string TABLE_FIELD_SET { get; set; }
        public int? TT_SUDUNG { get; set; }
        public int TT_UPLOAD { get; set; }
        public int FLAG { get; set; }
    }
}
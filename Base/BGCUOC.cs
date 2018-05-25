namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("BGCUOC")]
    public partial class BGCUOC {
        [Dapper.Contrib.Extensions.Key]
        public long BGCUOCID { get; set; }

        [StringLength(256)]
        public string TENGOI { get; set; }

        [StringLength(256)]
        public string PROFILE { get; set; }
        public string PROFILEIP { get; set; }
        public int TOCDO { get; set; }
        public decimal GIA { get; set; }
        public int DICHVUVT_ID { get; set; }
        public int GOICUOCID { get; set; }
        public int TICHHOPID { get; set; }
        public int IS_DATA { get; set; }
        public int IS_TH { get; set; }
        public DateTime? NGAY_BD { get; set; }
        public DateTime? NGAY_KT { get; set; }

        [StringLength(256)]
        public string CREATEDBY { get; set; }
        public DateTime? CREATEDAT { get; set; }

        [StringLength(256)]
        public string UPDATEDBY { get; set; }
        public DateTime? UPDATEDAT { get; set; }
        public int EXTRA_TYPE { get; set; }
        public int FLAG { get; set; }

        [StringLength(1024)]
        public string GHICHU { get; set; }
    }
}
namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("BANGGIACUOC")]
    public partial class BANGGIACUOC {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }

        [StringLength(256)]
        public string TENGOI { get; set; }

        [StringLength(256)]
        public string PROFILE { get; set; }
        public int TOCDO { get; set; }
        public decimal GIA { get; set; }

        [StringLength(128)]
        public string KIEU { get; set; }
        public int KIEUID { get; set; }
        public int GOICUOCID { get; set; }
        public int TICHHOPID { get; set; }
        public int IS_DATA { get; set; }
        public int IS_TH { get; set; }
        public DateTime? NGAYBATDAU { get; set; }
        public DateTime? NGAYKETTHUC { get; set; }

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
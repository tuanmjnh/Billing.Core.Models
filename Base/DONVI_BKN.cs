namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("DONVI_BKN")]
    public partial class DONVI_BKN {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public int DONVI_ID { get; set; }
        public int DONVI_CHA_ID { get; set; }
        public int CAPDONVI_ID { get; set; }
        public int MA_QUANHUYEN { get; set; }

        [StringLength(20)]
        public string MA_DV { get; set; }

        [StringLength(200)]
        public string TEN_DV { get; set; }

        [StringLength(100)]
        public string DIACHI_DV { get; set; }

        [StringLength(20)]
        public string SO_FAX { get; set; }

        [StringLength(20)]
        public string MST { get; set; }

        [StringLength(20)]
        public string SO_TK { get; set; }

        [StringLength(50)]
        public string SO_DT { get; set; }

        [StringLength(100)]
        public string GHICHU { get; set; }
        public int DV_NOITHANH { get; set; }

        [StringLength(10)]
        public string DV_DAUVAO { get; set; }

        [StringLength(10)]
        public string DV_TT { get; set; }

        [StringLength(10)]
        public string DV_CAP1 { get; set; }

        [StringLength(10)]
        public string MA_CHA { get; set; }
        public int TRANGTHAI { get; set; }
        public int LOAIHOST_ID { get; set; }
        public int TINHTP_ID { get; set; }
        public int DONVI_ID_MAP { get; set; }
        public int FLAG { get; set; }
    }
}
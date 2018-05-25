namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("QUAN_HUYEN_BKN")]
    public partial class QUAN_HUYEN_BKN {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public int QUANHUYEN_ID { get; set; }

        [StringLength(256)]
        public string TEN_QUANHUYEN { get; set; }
        public int MA_QUANHUYEN { get; set; }

        [StringLength(50)]
        public string MA_KHUVUC { get; set; }

        [StringLength(256)]
        public string VIETTAT { get; set; }
        public int VUNG_ID { get; set; }
        public int TTHAI_SD { get; set; }
        public int TINHTP_ID { get; set; }
    }
}
namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("DISCOUNT")]
    public partial class DISCOUNT {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }
        public int TYPE_HD { get; set; }
        public int TYPE_BILL { get; set; }
        public DateTime TIME_BILL { get; set; }

        [StringLength(256)]
        public string ACCOUNT { get; set; }

        [StringLength(256)]
        public string TYPE { get; set; }
        public int TYPEID { get; set; }
        public decimal VALUE { get; set; }

        [StringLength(512)]
        public string DETAILS { get; set; }
        public DateTime? NGAY_DK { get; set; }
        public DateTime? NGAY_BD { get; set; }
        public DateTime? NGAY_KT { get; set; }
        public int FLAG { get; set; }
    }
}
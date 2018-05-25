namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("DB_DUONGTHU_BKN")]
    public partial class DB_DUONGTHU_BKN {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }

        [StringLength(50)]
        public string MA_DT { get; set; }

        [StringLength(50)]
        public string MA_DT_GOC { get; set; }

        [StringLength(50)]
        public string MA_DT_CU { get; set; }
        public int? DONVI_ID { get; set; }

        [StringLength(500)]
        public string MOTA_DUONGTHU { get; set; }
        public int FIX { get; set; }
        public int FLAG { get; set; }
    }
}
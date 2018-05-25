namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("TEST")]
    public partial class TEST {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }

        [StringLength(256)]
        public string NAME { get; set; }
        public int LEVELS { get; set; }
        public decimal MONEY { get; set; }
        public DateTime? TIME { get; set; }
    }
}
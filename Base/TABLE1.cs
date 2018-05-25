namespace Billing.Core.Models {
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("TABLE1")]
    public partial class TABLE1 {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public int ID { get; set; }
        public string NAME { get; set; }
        public DateTime TIME { get; set; }
    }
}
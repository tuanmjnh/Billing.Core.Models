namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("SETTINGS")]
    public partial class SETTINGS {
        public Guid ID { get; set; }

        [StringLength(256)]
        public string APP_KEY { get; set; }

        [StringLength(256)]
        public string SUB_KEY { get; set; }
        public string VAL { get; set; }
        public string SUB_VAL { get; set; }
        public string DESC { get; set; }
        public string EXTRAS { get; set; }
    }
}
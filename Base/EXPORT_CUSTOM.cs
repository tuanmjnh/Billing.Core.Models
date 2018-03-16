namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("EXPORT_CUSTOM")]
    public partial class EXPORT_CUSTOM {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }

        [StringLength(128)]
        public string NAME { get; set; }

        [StringLength(128)]
        public string TABLE_NAME { get; set; }

        [StringLength(512)]
        public string TABLE_LIST { get; set; }
        public string QUERY_CREATE { get; set; }
        public string QUERY_SELECT { get; set; }
        public string QUERY_INSERT { get; set; }
        public string QUERY_END { get; set; }

        [StringLength(2048)]
        public string CONDITION { get; set; }
        public string EXTRAS { get; set; }
        public int FLAG { get; set; }
    }
}
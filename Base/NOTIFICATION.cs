namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("NOTIFICATION")]
    public partial class NOTIFICATION {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }

        [StringLength(128)]
        public string ROOT_ID { get; set; }

        [StringLength(128)]
        public string PARENT_ID { get; set; }

        [StringLength(256)]
        public string URL { get; set; }

        [StringLength(256)]
        public string SOURCE { get; set; }

        [StringLength(256)]
        public string DESTINATION { get; set; }

        [StringLength(512)]
        public string TITLE { get; set; }

        [StringLength(1024)]
        public string DESC { get; set; }

        [StringLength(2048)]
        public string CONTENTS { get; set; }

        [StringLength(256)]
        public string CREATEDBY { get; set; }
        public DateTime CREATEDAT { get; set; }

        [StringLength(256)]
        public string UPDATEDBY { get; set; }
        public DateTime? UPDATEDAT { get; set; }
        public string EXTRAS { get; set; }
        public int FLAG { get; set; }
    }
}
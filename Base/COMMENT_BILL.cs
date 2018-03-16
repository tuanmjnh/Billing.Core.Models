namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("COMMENT_BILL")]
    public partial class COMMENT_BILL {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }
        public DateTime TIME_BILL { get; set; }

        [StringLength(256)]
        public string MA_TT_HNI { get; set; }

        [StringLength(128)]
        public string ROOT_ID { get; set; }

        [StringLength(128)]
        public string PARENT_ID { get; set; }
        public string PARENTS_ID { get; set; }
        public int LEVELS { get; set; }
        public string CONTENTS { get; set; }

        [StringLength(256)]
        public string CREATEDBY { get; set; }
        public DateTime CREATEDAT { get; set; }

        [StringLength(256)]
        public string UPDATEDBY { get; set; }
        public DateTime? UPDATEDAT { get; set; }
        public int FLAG { get; set; }
    }
}
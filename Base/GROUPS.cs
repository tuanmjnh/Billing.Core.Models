namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("GROUPS")]
    public partial class GROUPS {
        [Dapper.Contrib.Extensions.Key]
        public long GROUPID { get; set; }

        [StringLength(256)]
        public string APPKEY { get; set; }

        [StringLength(512)]
        public string TITLE { get; set; }

        [StringLength(1024)]//AllowHtml, 
        public string DESCRIPTION { get; set; }

        [StringLength(256)]
        public string PARENT_ID { get; set; }

        [StringLength(512)]
        public string PARENTS_ID { get; set; }
        public int LEVELS { get; set; }

        [StringLength(1024)]
        public string IMAGES { get; set; }

        [StringLength(128)]
        public string ICONS { get; set; }
        public int QUANTITY { get; set; }

        [StringLength(64)]
        public string POSITION { get; set; }
        public int ORDERS { get; set; }

        [StringLength(128)]
        public string CREATEDBY { get; set; }
        public DateTime CREATEDAT { get; set; }

        [StringLength(128)]
        public string UPDATEDBY { get; set; }
        public DateTime? UPDATEDAT { get; set; }

        [StringLength(128)]
        public string DELETEDBY { get; set; }
        public DateTime? DELETEDAT { get; set; }
        public int FLAG { get; set; }
    }
}
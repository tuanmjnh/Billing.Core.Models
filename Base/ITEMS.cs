namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("ITEMS")]
    public partial class ITEMS {
        [Dapper.Contrib.Extensions.Key]
        public long ITEMID { get; set; }

        [StringLength(256)]
        public string APPKEY { get; set; }

        [StringLength(512)]
        public string GROUPID { get; set; }

        [StringLength(512)]
        public string TITLE { get; set; }

        //[AllowHtml]
        public string DESCRIPTION { get; set; }

        //[AllowHtml]
        public string CONTENTS { get; set; }
        public decimal AMOUNT_START { get; set; }
        public decimal AMOUNT_END { get; set; }
        public int QUANTITY { get; set; }

        [StringLength(1024)]
        public string IMAGES { get; set; }

        [StringLength(1024)]
        public string ATTACH { get; set; }

        [StringLength(64)]
        public string AUTHOR { get; set; }

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
    public partial class ITEMS_G : ITEMS {
        public string GROUPTITLE { get; set; }
    }
}
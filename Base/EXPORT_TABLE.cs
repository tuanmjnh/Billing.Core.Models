namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("EXPORT_TABLE")]
    public partial class EXPORT_TABLE {
        [Key]
        public long ID { get; set; }
        public Guid APP_KEY { get; set; }
        public int TABLE_TYPE { get; set; }

        [StringLength(256)]
        public string TABLE_NAME { get; set; }

        [StringLength(256)]
        public string COLUMN_NAME { get; set; }

        [StringLength(256)]
        public string COLUMN_TYPE { get; set; }

        [StringLength(256)]
        public string COLUMN_LENGTH { get; set; }

        [StringLength(256)]
        public string COLUMN_NAME_EXPORT { get; set; }

        [StringLength(256)]
        public string COLUMN_TYPE_EXPORT { get; set; }

        [StringLength(256)]
        public string COLUMN_LENGTH_EXPORT { get; set; }
        public string CONDITION { get; set; }
        public int ORDERS { get; set; }
        public int FLAG { get; set; }
    }
}
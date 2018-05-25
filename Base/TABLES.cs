namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TABLES")]
    public partial class TABLES {
        public string TABLE_CATALOG { get; set; }
        public string TABLE_SCHEMA { get; set; }
        public string TABLE_NAME { get; set; }
        public string TABLE_TYPE { get; set; }
    }
}
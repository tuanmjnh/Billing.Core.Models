namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("ACCOUNT_JSON")]
    public partial class ACCOUNT_JSON {
        public string CODINH { get; set; }
        public string DIDONG { get; set; }
        public string MYTV { get; set; }
        public string MEGAVNN { get; set; }
        public string FIBER { get; set; }
        public string FIBERMEN { get; set; }
        public string MEGAWAN { get; set; }
        public string METRONET { get; set; }
        public string TSL { get; set; }
        public string VNPTHISS { get; set; }
    }
}
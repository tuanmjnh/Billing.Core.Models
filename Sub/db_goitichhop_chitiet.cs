namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("db_goitichhop_chitiet")]
    public partial class db_goitichhop_chitiet {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid id_goitichhop_chitiet { get; set; }
        public int dichvuvt_id { get; set; }
        public int id_goitichhop { get; set; }
        public string giatien { get; set; }
        public int flag { get; set; }
    }
}
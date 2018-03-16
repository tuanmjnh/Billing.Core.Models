namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("FILE_MANAGER")]
    public partial class FILE_MANAGER {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }
        public Guid? PARENTID { get; set; }

        [StringLength(512)]
        public string PARENT { get; set; }

        [StringLength(512)]
        public string ROOT { get; set; }
        public string SUBDIRECTORY { get; set; }
        public int? LEVELS { get; set; }

        [StringLength(255)]
        public string NAME { get; set; }
        public string FULLNAME { get; set; }

        [StringLength(50)]
        public string EXTENSION { get; set; }

        [StringLength(50)]
        public string EXTENSIONICON { get; set; }

        [StringLength(50)]
        public string TYPE { get; set; }

        [StringLength(50)]
        public string ATTRIBUTES { get; set; }
        public int? ATTRIBUTESENUM { get; set; }
        public long? LENGTH { get; set; }
        public bool? ISREADONLY { get; set; }

        [StringLength(1024)]
        public string DESCRIPTION { get; set; }
        public DateTime? CREATIONTIME { get; set; }
        public DateTime? CREATIONTIMEUTC { get; set; }
        public DateTime? LASTACCESSTIME { get; set; }
        public DateTime? LASTACCESSTIMEUTC { get; set; }
        public DateTime? LASTWRITETIME { get; set; }
        public DateTime? LASTWRITETIMEUTC { get; set; }

        [StringLength(256)]
        public string CREATEDBY { get; set; }

        [StringLength(256)]
        public string LASTACCESSBY { get; set; }

        [StringLength(256)]
        public string LASTWRITEBY { get; set; }
        public bool? EXISTS { get; set; }
        public int FLAG { get; set; }
        public string EXTRAS { get; set; }
    }
}
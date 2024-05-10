using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace WMSLite.Core.Api.src.Entities
{
    [Table("ITEM_LOCATION_ASSIGNMENT")]
    public class ItemLocationAssignmentDbo
    {

        [Key]
        [Required]
        [Column("INTERNAL_ITEM_LOC_NUM", TypeName = "numeric(9,0)")]
        public int InternalItemLocNum { get; set; }

        [Column("TENANT_ID", TypeName = "uniqueidentifier")]
        public Guid TenantId { get; set; }

        [Column("warehouse", TypeName = "nvarchar(25)")]
        public string warehouse { get; set; }

        [Column("ITEM", TypeName = "nvarchar(50)")]
        public string Item { get; set; }

        [Column("COMPANY", TypeName = "nvarchar(25)")]
        public string Company { get; set; }

        [Column("QUANTITY_UM", TypeName = "nvarchar(25)")]
        public string QuantityUm { get; set; }

        [Column("ALLOCATION_LOC", TypeName = "nvarchar(25)")]
        public string AllocationLoc { get; set; }

        [Column("USER_DEF1", TypeName = "nvarchar(25)")]
        public string UserDef1 { get; set; }

        [Column("USER_DEF2", TypeName = "nvarchar(25)")]
        public string UserDef2 { get; set; }

        [Column("USER_DEF3", TypeName = "nvarchar(25)")]
        public string UserDef3 { get; set; }

        [Column("USER_DEF4", TypeName = "nvarchar(25)")]
        public string UserDef4 { get; set; }

        [Column("USER_DEF5", TypeName = "nvarchar(25)")]
        public string UserDef5 { get; set; }

        [Column("USER_DEF6", TypeName = "nvarchar(25)")]
        public string UserDef6 { get; set; }

        [Column("USER_DEF7", TypeName = "nvarchar(25)")]
        public string UserDef7 { get; set; }

        [Column("USER_DEF8", TypeName = "nvarchar(25)")]
        public string UserDef8 { get; set; }

        [Column("USER_STAMP", TypeName = "nvarchar(30)")]
        public string UserStamp { get; set; }

        [Column("PROCESS_STAMP", TypeName = "nvarchar(100)")]
        public string ProcessStamp { get; set; }

        [Column("DATE_TIME_STAMP", TypeName = "datetime")]
        public DateTime DateTimeStamp{ get; set; }

    }
}

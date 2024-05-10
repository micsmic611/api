using System.ComponentModel.DataAnnotations.Schema;

namespace WMSLite.Core.Api.DTOs
{
    public class ItemLocationAssignmentGetAllDto
    {
        public int InternalItemLocNum { get; set; }

        public Guid TenantId { get; set; }

        public string warehouse { get; set; }

        public string Item { get; set; }

        public string Company { get; set; }

        public string QuantityUm { get; set; }

        public string AllocationLoc { get; set; }

        public string UserDef1 { get; set; }

        public string UserDef2 { get; set; }

        public string UserDef3 { get; set; }

        public string UserDef4 { get; set; }

        public string UserDef5 { get; set; }

        public string UserDef6 { get; set; }

        public string UserDef7 { get; set; }

        public string UserDef8 { get; set; }

        public string UserStamp { get; set; }

        public string ProcessStamp { get; set; }

        public DateTime DateTimeStamp { get; set; }

    }
}

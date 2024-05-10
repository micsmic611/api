using WMSLite.Core.Api.DTOs;

namespace WMSLite.Core.Api.src.Core.Interface
{
    public interface IItemLocationAssignmentService
    {
        Task<List<ItemLocationAssignmentGetAllDto>> GetAllItemLocationAssignmenAsync(Guid tenantId);
    }
}

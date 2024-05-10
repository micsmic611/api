using WMSLite.Core.Api.src.Entities;

namespace WMSLite.Core.Api.src.Infrastructure.Interface
{
    public interface IItemLocationAssignmentRepository
    {
        Task<List<ItemLocationAssignmentDbo>> GetAllItemLocationAssignmentAsync(Guid tenantId);

    }
}

using WMSLite.Core.Api.DTOs;
using WMSLite.Core.Api.src.Core.Interface;
using WMSLite.Core.Api.src.Infrastructure.Interface;

namespace WMSLite.Core.Api.src.Core.Service
{
    public class ItemLocationAssignmentService : IItemLocationAssignmentService
    {
        private readonly IItemLocationAssignmentRepository _itemLocationAssignmentRepository;

        public ItemLocationAssignmentService(IItemLocationAssignmentRepository itemLocationAssignmentRepository)
        {
            _itemLocationAssignmentRepository = itemLocationAssignmentRepository;
        }

        public async Task<List<ItemLocationAssignmentGetAllDto>> GetAllItemLocationAssignmenAsync(Guid tenantId)
        {
            try
            {
                var itemLocationAssignmentData = await _itemLocationAssignmentRepository.GetAllItemLocationAssignmentAsync(tenantId);
                var itemLocationAssignmentReturn = itemLocationAssignmentData.Select(s => new ItemLocationAssignmentGetAllDto
                {
                   Item  = s.Item,
                }).ToList();

                return itemLocationAssignmentReturn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

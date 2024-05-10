using Microsoft.EntityFrameworkCore;
using WMSLite.Core.Api.src.Entities;

namespace WMSLite.Core.Api.src.Infrastructure.Interface
{
    public class ItemLocationAssignmentRepository : IItemLocationAssignmentRepository
    {
        private readonly DataContext _dbContext;

        public ItemLocationAssignmentRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ItemLocationAssignmentDbo>> GetAllItemLocationAssignmentAsync(Guid tenantId)
        {
            var itemmLocationAssignmentData = new List<ItemLocationAssignmentDbo>();
            try
            {
                itemmLocationAssignmentData = await _dbContext.ItemLocationAssignment.Where(x => x.TenantId == tenantId).AsNoTracking().ToListAsync();

                return itemmLocationAssignmentData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

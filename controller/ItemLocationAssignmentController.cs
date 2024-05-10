using Microsoft.AspNetCore.Mvc;
using WMSLite.Core.Api.DTOs;
using WMSLite.Core.Api.src.Core.Interface;

namespace WMSLite.Core.Api.Controllers
{
    [ApiController]
    [Route("api/core/[controller]")]
    public class ItemLocationAssignmentController : Controller
    {
        private readonly IItemLocationAssignmentService _itemLocationAssignmenService;
        private readonly ILogger<ItemLocationAssignmentController> _logger;

        public ItemLocationAssignmentController(IItemLocationAssignmentService itemLocationAssignmenService, ILogger<ItemLocationAssignmentController> logger)
        {
            _logger = logger;
            _itemLocationAssignmenService = itemLocationAssignmenService;
        }

        [HttpGet("GetItemLocationAssignmen/{tenantId}")]
        public async Task<IActionResult> GetAllItemLocationAssignmenAsync(Guid tenantId)
        {
            var response = new BaseHttpResponse<List<ItemLocationAssignmentGetAllDto>>();
            try
            {
                var data = await _itemLocationAssignmenService.GetAllItemLocationAssignmenAsync(tenantId);

                response.SetSuccess(data, "Success", "200");
                return Ok(response);
            }
            catch (Exception ex)
            {
                ErrorData err = new ErrorData();
                err.Code = "-2";
                err.Message = ex.Message;
                _logger.LogError(ex, "Error getting all item location assingment");
                response.SetError(err, ex.Message, "500");

                return BadRequest(response);
            }
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeoplePartnershipTest.DTOs;

namespace PeoplePartnershipTest.Controllers
{
    [Route("peoplespartnership/api/[controller]")]
    [ApiController]
    public class StudioItemController : ControllerBase
    {
        public StudioItemController()
        {

        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            InterfaceWithDatabase _iwd = new InterfaceWithDatabase();

            return Ok(await _iwd.GetAllStudioHeaderItems());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            InterfaceWithDatabase _iwd = new InterfaceWithDatabase();

            return Ok(await _iwd.GetStudioItemById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudioItemDto studioItem)
        {
            InterfaceWithDatabase _iwd = new InterfaceWithDatabase();

            return Ok(await _iwd.AddStudioItem(studioItem));
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateStudioItemDto studioItem)
        {
            InterfaceWithDatabase _iwd = new InterfaceWithDatabase();

            return Ok(await _iwd.UpdateStudioItem(studioItem));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            InterfaceWithDatabase _iwd = new InterfaceWithDatabase();

            return Ok(await _iwd.DeleteStudioItem(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetStudioItemTypes()
        {
            InterfaceWithDatabase _iwd = new InterfaceWithDatabase();

            return Ok(await _iwd.GetAllStudioItemTypes());
        }
    }
}

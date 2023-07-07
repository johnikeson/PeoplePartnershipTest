using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeoplePartnershipTest.DTOs;
using PeoplePartnershipTest.Interfaces;
using PeoplePartnershipTest.Library;

namespace PeoplePartnershipTest.Controllers
{
    [Route("peoplespartnership/api/[controller]")]
    [ApiController]
    public class StudioItemController : ControllerBase
    {
        private readonly IInterfaceWithDatabase _iwd;
        public StudioItemController(IInterfaceWithDatabase interfaceWithDatabase)
        {
            _iwd = interfaceWithDatabase;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {

            //InterfaceWithDatabase iwd = await _iwd.GetAllStudioHeaderItems();

            return Ok(await _iwd.GetAllStudioHeaderItems());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
          
            var responce = await _iwd.GetStudioItemById(id);
            return responce.Data != null? Ok(responce) : NotFound();
            
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudioItemDto studioItem)
        {

            return Ok(await _iwd.AddStudioItem(studioItem));
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateStudioItemDto studioItem)
        {
            //IInterfaceWithDatabase _iwd = Factory.CreateInterfaceWithDatabase();

            return Ok(await _iwd.UpdateStudioItem(studioItem));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            //IInterfaceWithDatabase _iwd = Factory.CreateInterfaceWithDatabase();

            return Ok(await _iwd.DeleteStudioItem(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetStudioItemTypes()
        {
            //IInterfaceWithDatabase _iwd = Factory.CreateInterfaceWithDatabase();

            return Ok(await _iwd.GetAllStudioItemTypes());
        }
    }
}

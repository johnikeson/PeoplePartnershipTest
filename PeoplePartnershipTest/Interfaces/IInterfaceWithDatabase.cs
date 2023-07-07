using PeoplePartnershipTest.Library;
using PeoplePartnershipTest.DTOs;

namespace PeoplePartnershipTest.Interfaces
{
    public interface IInterfaceWithDatabase
    {
        Task<ServiceResponse<List<GetStudioItemDto>>> AddStudioItem(AddStudioItemDto newStudioItem);
        Task<ServiceResponse<List<GetStudioItemDto>>> DeleteStudioItem(int id);
        Task<ServiceResponse<List<GetStudioItemHeaderDto>>> GetAllStudioHeaderItems();
        Task<ServiceResponse<List<StudioItemType>>> GetAllStudioItemTypes();
        Task<ServiceResponse<GetStudioItemDto>> GetStudioItemById(int id);
        Task<ServiceResponse<GetStudioItemDto>> UpdateStudioItem(UpdateStudioItemDto updatedStudioItem);
    }
}
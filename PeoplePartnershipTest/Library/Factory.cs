using PeoplePartnershipTest.Interfaces;

namespace PeoplePartnershipTest.Library
{
    public class Factory
    {
        public static IInterfaceWithDatabase CreateInterfaceWithDatabase()
        {
            return new InterfaceWithDatabase();
        }

        
    }
}

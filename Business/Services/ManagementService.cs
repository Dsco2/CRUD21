using Business.Entities;
using Business.Interfaces;

namespace Business.Services
{
    public class ManagementService : IManagementService
    {
        private readonly IManagementRepository _managementRepository;

        public ManagementService(IManagementRepository managementRepository)
        {
            _managementRepository = managementRepository;
        }

        public Data GetTable(int idData)
        {
            return _managementRepository.GetTable(idData);
        }
    }
}

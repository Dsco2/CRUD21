using Business.Entities;

namespace Business.Interfaces
{
    public interface IManagementRepository
    {
        Data GetTable(int idData);
    }
}

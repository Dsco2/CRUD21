using System.Linq;
using Business.Entities;
using Business.Interfaces;

namespace Persistence.Repository
{
    public class ManagementRepository : IManagementRepository
    {
        private readonly PrincipalContext _context;

        public ManagementRepository(PrincipalContext context)
        {
            _context = context;
        }

        public Data GetTable(int idData)
        {
            return _context.Data.FirstOrDefault(x => x.IdData == idData);
        }
    }
}

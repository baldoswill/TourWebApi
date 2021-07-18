using System.Threading.Tasks;
using TourWebApi.Data;
using TourWebApi.IRepository;

namespace TourWebApi.Respository
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly DatabaseContext _context;
        private IGenericRepository<Country> _countries;
        private IGenericRepository<Hotel> _hotels;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public IGenericRepository<Country> Countries => _countries ??= new GenericRepository<Country>(_context);
        public IGenericRepository<Hotel> Hotels => _hotels ??= new GenericRepository<Hotel>(_context);

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
 
        public Task Save()
        {
            throw new System.NotImplementedException();
        }
    }
}
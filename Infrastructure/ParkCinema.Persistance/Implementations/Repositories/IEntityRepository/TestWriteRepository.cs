using ParkCinema.Application.Abstraction.Repositories.IEntityRepository;
using ParkCinema.Domain.Entities;
using ParkCinema.Persistance.Context;

namespace ParkCinema.Persistance.Implementations.Repositories.IEntityRepository;

public class TestWriteRepository : WriteRepository<Test>, ITestWriteRepository
{
    public TestWriteRepository(AppDbContext context) : base(context)
    {
    }
}

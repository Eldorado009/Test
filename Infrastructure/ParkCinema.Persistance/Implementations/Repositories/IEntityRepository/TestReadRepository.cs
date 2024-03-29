using ParkCinema.Application.Abstraction.Repositories.IEntityRepository;
using ParkCinema.Application.DTOs.Test;
using ParkCinema.Domain.Entities;
using ParkCinema.Persistance.Context;

namespace ParkCinema.Persistance.Implementations.Repositories.IEntityRepository;

public class TestReadRepository : ReadRepository<Test>, ITestReadRepository
{
    private readonly AppDbContext _appDbContext;
    public TestReadRepository(AppDbContext context) : base(context)
    {
        _appDbContext = context;
    }

    public Task<GetTestDto> GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}

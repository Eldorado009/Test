using ParkCinema.Application.DTOs.Test;
using ParkCinema.Domain.Entities;

namespace ParkCinema.Application.Abstraction.Repositories.IEntityRepository;

public interface ITestReadRepository:IReadRepository<Test>
{
    Task<GetTestDto> GetById(Guid id);
}

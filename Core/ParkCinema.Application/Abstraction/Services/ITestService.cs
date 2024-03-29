using ParkCinema.Application.DTOs.Test;
using ParkCinema.Domain.Entities;

namespace ParkCinema.Application.Abstraction.Services;

public interface ITestService
{
    Task CreateAsync(CreateTestDto createTestDto);
    Task<List<GetTestDto>> GetAllTestAsync();
    Task<GetTestDto> GetByIdAsync(Guid Id);
    Task Update(UpdateTestDto updateTestDto);
    Task RemoveAsync(Guid Id);
}

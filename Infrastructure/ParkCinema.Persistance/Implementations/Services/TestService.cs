using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ParkCinema.Application.Abstraction.Repositories.IEntityRepository;
using ParkCinema.Application.Abstraction.Services;
using ParkCinema.Application.DTOs.Test;
using ParkCinema.Domain.Entities;
using ParkCinema.Persistance.Exceptions;

namespace ParkCinema.Persistance.Implementations.Services;

public class TestService : ITestService
{
    private readonly ITestReadRepository _testReadRepository;
    private readonly ITestWriteRepository _testWriteRepository;
    private readonly IMapper _mapper;

    public TestService(ITestReadRepository testReadRepository,
                       ITestWriteRepository testWriteRepository,
                       IMapper mapper)
    {
        _testReadRepository = testReadRepository;
        _testWriteRepository = testWriteRepository;
        _mapper = mapper;
    }

    public async Task CreateAsync(CreateTestDto createTestDto)
    {
        var newTest = _mapper.Map<Test>(createTestDto);

        await _testWriteRepository.AddAsync(newTest);
        await _testWriteRepository.SaveChangeAsync();
    }

    public async Task<List<GetTestDto>> GetAllTestAsync()
    {
        var allTest = await _testReadRepository.GetAll().ToListAsync();
        return _mapper.Map<List<GetTestDto>>(allTest);
    }

    public async Task<GetTestDto> GetByIdAsync(Guid Id)
    {
        var byTest = await _testReadRepository.GetByIdAsync(Id);
        if (byTest is null) throw new NotFoundException("Not Found");

        return _mapper.Map<GetTestDto>(byTest);
    }

    public async Task RemoveAsync(Guid Id)
    {
        var byTest = await _testReadRepository.GetByIdAsync(Id);
        if (byTest is null) throw new NotFoundException("Not Found");

        _testWriteRepository.Remove(byTest);
        await _testWriteRepository.SaveChangeAsync();
    }

    public async Task Update(UpdateTestDto updateTestDto)
    {
        var byTest = await _testReadRepository.GetByIdAsync(updateTestDto.Id);
        if (byTest is null) throw new NotFoundException("Not Found");

        _mapper.Map(byTest, updateTestDto);

        _testWriteRepository.Update(byTest);
        await _testWriteRepository.SaveChangeAsync();
    }
}

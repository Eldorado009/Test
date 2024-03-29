using Microsoft.AspNetCore.Mvc;
using ParkCinema.Application.Abstraction.Services;
using ParkCinema.Application.DTOs.Test;
using System.Net;

namespace ParkCinema.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestsController : ControllerBase
{
    private readonly ITestService _testService;
    public TestsController(ITestService testService)
    => _testService = testService;

    [HttpPost]
    public async Task<IActionResult> CreateTest(CreateTestDto createTestDto)
    {
        await _testService.CreateAsync(createTestDto);
        return StatusCode((int)HttpStatusCode.Created);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateTest(UpdateTestDto updateTestDto)
    {
        await _testService.Update(updateTestDto);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        return Ok(await _testService.GetAllTestAsync());
    }

    [HttpGet]
    public async Task<IActionResult> GetByIdAsync(Guid Id)
    {
        return Ok(await _testService.GetByIdAsync(Id));
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(Guid Id)
    {
        return Ok(_testService.RemoveAsync(Id));
    }
}

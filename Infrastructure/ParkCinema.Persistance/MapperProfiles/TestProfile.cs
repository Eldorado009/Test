using AutoMapper;
using ParkCinema.Application.DTOs.Test;
using ParkCinema.Domain.Entities;

namespace ParkCinema.Persistance.MapperProfiles;

public class TestProfile:Profile
{
    public TestProfile()
    {
        CreateMap<Test, CreateTestDto>().ReverseMap();
        CreateMap<Test, GetTestDto>().ReverseMap();
        CreateMap<Test, UpdateTestDto>().ReverseMap();
    }
}

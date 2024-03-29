using ParkCinema.Domain.Entities.Common;

namespace ParkCinema.Domain.Entities;

public class Test:BaseEntity
{
    public string Question { get; set; }
    public string Answer { get; set; }
    public int Point { get; set; }
}


namespace Bai5_4;

public class Employee
{
    public string Id { get; set; } = "";
    public string FullName { get; set; } = "";
    public string Position { get; set; } = "";
    public DateTime StartDate { get; set; }

    public string[] ToRow() => new[]
    {
        Id,
        FullName,
        Position,
        StartDate.ToString("dd/MM/yyyy")
    };
}

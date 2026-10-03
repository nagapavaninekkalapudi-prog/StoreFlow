namespace StoreFlow.Models;

public class Colleague
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public int DepartmentId { get; set; }
}
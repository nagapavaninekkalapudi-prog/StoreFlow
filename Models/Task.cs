namespace StoreFlow.Models;

public class Task
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int AssignedToId { get; set; }
    public string Priority { get; set; } = "Medium";
    public string Status { get; set; } = "Open";
    public int DepartmentId { get; set; }
    
    public int StoreId { get; set; }
}
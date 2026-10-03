using System.Text.Json;
using StoreFlow.Models;

string json = File.ReadAllText("Data/tasks.json");

List<StoreFlow.Models.Task>? tasks = JsonSerializer.Deserialize<List<StoreFlow.Models.Task>>(json,
    new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    });
    
string colleaguesJson = File.ReadAllText("Data/colleagues.json");

List<Colleague>? colleagues = JsonSerializer.Deserialize<List<Colleague>>(
    colleaguesJson,
    new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    });

string departmentsJson = File.ReadAllText("Data/departments.json");

List<Department>? departments = JsonSerializer.Deserialize<List<Department>>(
    departmentsJson,
    new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    });

string storesJson = File.ReadAllText("Data/stores.json");

List<Store>? stores = JsonSerializer.Deserialize<List<Store>>(
    storesJson,
    new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    });

Console.Write("Enter store ID: ");
int storeId = int.Parse(Console.ReadLine()!);

var storeTasks = tasks!
    .Where(task => task.StoreId == storeId && task.Priority == "High")
    .ToList();

Console.WriteLine("\nHigh Priority Tasks:");

if (!storeTasks.Any())
{
    Console.WriteLine("No high priority tasks found for this store.");
}
else
{
    foreach (var task in storeTasks)
    {
        var colleague = colleagues!
            .FirstOrDefault(c => c.Id == task.AssignedToId);

        var department = departments!
            .FirstOrDefault(d => d.Id == task.DepartmentId);

        var store = stores!
            .FirstOrDefault(s => s.Id == task.StoreId);

        Console.WriteLine(
            $"{task.Title} - {colleague?.Name} - {department?.Name} - {store?.Name}");
    }
}

Console.Write("\nEnter colleague ID: ");
int colleagueId = int.Parse(Console.ReadLine()!);

var colleagueTasks = tasks!
    .Where(task => task.AssignedToId == colleagueId)
    .ToList();

Console.WriteLine("\nTasks assigned to colleague:");

if (!colleagueTasks.Any())
{
    Console.WriteLine("No tasks found for this colleague.");
}
else
{
    foreach (var task in colleagueTasks)
    {
        var department = departments!
            .FirstOrDefault(d => d.Id == task.DepartmentId);

        var store = stores!
            .FirstOrDefault(s => s.Id == task.StoreId);

        Console.WriteLine(
            $"{task.Title} - {task.Priority} - {task.Status} - {department?.Name} - {store?.Name}");
    }
}

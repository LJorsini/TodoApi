namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? Email { get; set; }
    public bool IsComplete { get; set; }
}
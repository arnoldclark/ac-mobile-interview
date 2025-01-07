namespace AcGarageAPI.Entities;

public class Car
{
    public Guid Id { get; set; }
    public required string Make { get; set; }
    public required string Model { get; set; }
    public required string Registration { get; set; }
    public required decimal Price { get; set; }
}
namespace Demo.Api.Models;

public record PersonModel
{
    public int Id { get; set; }
    public string Name { get; set; }
}
public record PersonCreateModel
{
    public string Name { get; set; }
}
public record PersonUpdateModel
{
    public int Id { get; set; }
    public string Name { get; set; }
}
using Demo.Domain.People;
using Microsoft.EntityFrameworkCore;

namespace Demo.Infrastructure;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }
    public DbSet<Person> People { get; set; }
}
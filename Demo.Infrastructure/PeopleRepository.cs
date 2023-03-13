using Demo.Domain.People;
using Microsoft.EntityFrameworkCore;

namespace Demo.Infrastructure;

public class PeopleRepository : IPeopleRepository
{
    private readonly MyDbContext _context;

    public PeopleRepository(MyDbContext context)
    {
        _context = context;
    }
    public async Task<List<Person>> GetAll(CancellationToken cancellationToken)
    {
        return await _context.People.ToListAsync(cancellationToken);
    }

    public Task<Person> Get(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Person> Create(Person person, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Person> Update(Person person, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
public class OtherPeopleRepository : IPeopleRepository
{
    public Task<List<Person>> GetAll(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Person> Get(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Person> Create(Person person, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Person> Update(Person person, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

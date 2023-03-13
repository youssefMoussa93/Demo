namespace Demo.Domain.People;

public interface IPeopleRepository
{
    public Task<List<Person>> GetAll(CancellationToken cancellationToken);
    public Task<Person> Get(int id, CancellationToken cancellationToken);
    public Task<Person> Create(Person person, CancellationToken cancellationToken);
    public Task<Person> Update(Person person, CancellationToken cancellationToken);
    public Task Delete(int id, CancellationToken cancellationToken);
}
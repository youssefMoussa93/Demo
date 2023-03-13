using Demo.Api.Models;
using Demo.Domain.People;

namespace Demo.Api.Services;

public class PeopleService : IPeopleService
{
    private readonly IPeopleRepository _repo;

    public PeopleService(IPeopleRepository repo)
    {
        _repo = repo;
    }
    public async Task<List<PersonModel>> GetAll(CancellationToken cancellationToken)
    {
        var people = await _repo.GetAll(cancellationToken);
        return people.Select(a => new PersonModel()
        {
            Id = a.Id,
            Name = a.Name
        }).ToList();
    }

    public Task<PersonModel> Get(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<PersonModel> Create(PersonCreateModel person, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<PersonModel> Update(PersonUpdateModel person, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
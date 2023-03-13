using Demo.Api.Models;

namespace Demo.Api.Services;

public interface IPeopleService
{
    public Task<List<PersonModel>> GetAll(CancellationToken cancellationToken);
    public Task<PersonModel> Get(int id, CancellationToken cancellationToken);
    public Task<PersonModel> Create(PersonCreateModel person, CancellationToken cancellationToken);
    public Task<PersonModel> Update(PersonUpdateModel person, CancellationToken cancellationToken);
    public Task Delete(int id, CancellationToken cancellationToken);
}
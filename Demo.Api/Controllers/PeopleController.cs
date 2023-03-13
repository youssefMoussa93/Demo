using Demo.Api.Models;
using Demo.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PeopleController : ControllerBase
{
    private readonly IPeopleService _service;

    public PeopleController(IPeopleService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<List<PersonModel>> Get(CancellationToken cancellationToken)
    {
        return await _service.GetAll(cancellationToken);
    }
}
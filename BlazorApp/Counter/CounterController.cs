using Microsoft.AspNetCore.Mvc;
using Shared.Counter;

namespace BlazorApp.Counter;

[Route("api/[controller]")]
public sealed class CounterController : ControllerBase
{

    [HttpGet("Random")]
    public IResult RandomValue()
    {
        return TypedResults.Ok(new RandomCounter { Value = Random.Shared.Next() });
    }
}
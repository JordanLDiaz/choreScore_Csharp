namespace choreScore_Csharp.Controllers;

[ApiController]
[Route("api/chores")]
public class ChoresController : ControllerBase
{
  private readonly ChoresService _choresService;

  public ChoresController(ChoresService choresService)
  {
    _choresService = choresService;
  }

  [HttpGet]
  public ActionResult<List<Chore>> Get()
  {
    try
    {
      List<Chore> chores = _choresService.Get();
      return Ok(chores);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("{id}")]
  public ActionResult<Chore> Get(int id)
  {
    try
    {
      Chore chore = _choresService.Get(id);
      return Ok(chore);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPost]
  [Authorize]
  // NOTE Take the data from the body, make it a Chore, and call it choreData
  // The [FromBody] tells dotNet to take the data and cast it to a Chore
  public ActionResult<Chore> Create([FromBody] Chore choreData)
  {
    try
    {
      Chore chore = _choresService.Create(choreData);
      return Ok(chore);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{id}")]
  public ActionResult<string> Remove(int id)
  {
    try
    {
      string message = _choresService.Remove(id);
      return Ok(message);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}
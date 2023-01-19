namespace choreScore_Csharp.Services;
public class ChoresService
{
  private readonly ChoresRepository _repo;

  public ChoresService(ChoresRepository repo)
  {
    _repo = repo;
  }

  internal List<Chore> Get()
  {
    List<Chore> chores = _repo.Get();
    return chores;
  }

  internal Chore Get(int id)
  {
    Chore chore = _repo.Get(id);
    return chore;
  }

  internal Chore Create(Chore choreData)
  {
    Chore newChore = _repo.Create(choreData);
    return newChore;
  }

  internal string Remove(int id)
  {
    Chore chore = this.Get(id);
    bool deleted = _repo.Remove(id);
    if (deleted == false)
    {
      throw new Exception("No chore was deleted.");
    }
    return $"{chore.Name} was removed.";
  }
}

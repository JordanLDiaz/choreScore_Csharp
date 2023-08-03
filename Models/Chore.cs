using choreScore_Csharp.Enums;
namespace choreScore_Csharp.Models;

// NOTE this defines our data as its passed through the api
public class Chore
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public string Location { get; set; }
  public int Time { get; set; }
  public bool Complete { get; set; }
  public Priority Priority { get; set; }
  public string CreatorId { get; set; }
  public Account Creator { get; set; }
}

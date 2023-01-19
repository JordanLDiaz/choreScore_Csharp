using choreScore_Csharp.Enums;
namespace choreScore_Csharp.Models;

public class Chore
{
  // public Chore(string name, string description, string location, int time, bool complete, Priority priority)
  // {
  //   Id = Guid.NewGuid();
  //   Name = name;
  //   Description = description;
  //   Location = location;
  //   Time = time;
  //   Complete = complete;
  //   Priority = priority;
  // }
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

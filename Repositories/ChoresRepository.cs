namespace choreScore_Csharp.Repositories;

public class ChoresRepository
{
  private readonly IDbConnection _db;

  public ChoresRepository(IDbConnection db)
  {
    _db = db;
  }

  // NOTE internal says you have to exist within the namespace to call this. It's a public accessor only for the project we're in. 
  internal List<Chore> Get()
  {
    string sql = @"
   SELECT
   *
   FROM chores;

   ";
    List<Chore> chores = _db.Query<Chore>(sql).ToList();
    return chores;
  }

  internal Chore Get(int id)
  {
    string sql = @"
    SELECT
    *
    FROM chores
    WHERE id = @id;
    ";
    Chore chore = _db.Query<Chore>(sql, new { id }).FirstOrDefault();
    return chore;
  }

  internal Chore Create(Chore choreData)
  {
    string sql = @"
    INSERT INTO chores
    (name, description, location, time, complete, priority)
    VALUES
    (@name, @description, @location, @time, @complete, @priority);

    SELECT LAST_INSERT_ID();
    ";
    int id = _db.ExecuteScalar<int>(sql, choreData);
    choreData.Id = id;
    return choreData;
  }

  // NOTE void is return type for anything that returns nothing, this is different than null, which will be returned if something should have been returned, but wasn't found
  internal bool Remove(int id)
  {
    string sql = @"
    DELETE FROM chores
    WHERE id = @id;
    ";
    int rows = _db.Execute(sql, new { id });
    return rows > 0;
  }
}

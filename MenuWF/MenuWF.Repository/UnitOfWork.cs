using MenuWF.Data;

namespace MenuWF.Repository;

public class UnitOfWork
{
    private readonly AppDbContext _db;
    public UnitOfWork(AppDbContext db)
    {
        _db = db;
    }


}

using MenuWF.Data;
using MenuWF.MenuWF.Repository.Repositories;

namespace MenuWF.Repository;

public class UnitOfWork : IDisposable
{
    private readonly AppDbContext _db;
    public UnitOfWork()
    {
        _db = new AppDbContext();
    }

    private DishesRepository _dishesRepository;
    private JournalsRepository _journalsRepository;
    private ProductsRepository _productsRepository;
    private RecipesRepository _recipesRepository;

    public DishesRepository DishesRepository => _dishesRepository ?? new DishesRepository(_db);
    public JournalsRepository JournalsRepository => _journalsRepository ?? new JournalsRepository(_db);
    public ProductsRepository ProductsRepository => _productsRepository ?? new ProductsRepository(_db);
    public RecipesRepository RecipesRepository => _recipesRepository ?? new RecipesRepository(_db);


    private bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
            if (disposing)
                _db.Dispose();
        this.disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}

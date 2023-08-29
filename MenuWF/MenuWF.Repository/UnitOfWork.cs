using MenuWF.Data;
using MenuWF.MenuWF.Repository.Repositories;

namespace MenuWF.Repository;

public class UnitOfWork
{
    private readonly AppDbContext _db;
    public UnitOfWork(AppDbContext db)
    {
        _db = db;
    }

    private DishesRepository _dishesRepository;
    private JournalsRepository _journalsRepository;
    private ProductsRepository _productsRepository;
    private RecipesRepository _recipesRepository;

    public DishesRepository DishesRepository => _dishesRepository ?? new DishesRepository(_db);
    public JournalsRepository JournalsRepository => _journalsRepository ?? new JournalsRepository(_db);
    public ProductsRepository ProductsRepository => _productsRepository ?? new ProductsRepository(_db);
    public RecipesRepository RecipesRepository => _recipesRepository ?? new RecipesRepository(_db);

}

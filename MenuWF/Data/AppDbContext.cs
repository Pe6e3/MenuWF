using MenuWF.Entities;
using Microsoft.EntityFrameworkCore;

namespace MenuWF.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Огурец", Prots = 1, Carbs = 20, Fats = 0, Calories = 50 },
                new Product { Id = 2, Name = "Картофель", Prots = 2, Carbs = 15, Fats = 0, Calories = 80 },
                new Product { Id = 3, Name = "Морковь", Prots = 1, Carbs = 10, Fats = 0, Calories = 35 },
                new Product { Id = 4, Name = "Говядина", Prots = 20, Carbs = 0, Fats = 15, Calories = 250 },
                new Product { Id = 5, Name = "Рис", Prots = 3, Carbs = 30, Fats = 1, Calories = 130 },
                new Product { Id = 6, Name = "Яйцо", Prots = 6, Carbs = 1, Fats = 5, Calories = 70 },
                new Product { Id = 7, Name = "Помидор", Prots = 1, Carbs = 5, Fats = 0, Calories = 20 },
                new Product { Id = 8, Name = "Курица", Prots = 25, Carbs = 0, Fats = 10, Calories = 180 },
                new Product { Id = 9, Name = "Сыр", Prots = 10, Carbs = 2, Fats = 15, Calories = 150 },
                new Product { Id = 10, Name = "Свекла", Prots = 1, Carbs = 24, Fats = 0, Calories = 40 },
                new Product { Id = 11, Name = "Капуста", Prots = 1, Carbs = 26, Fats = 0, Calories = 50 },
                new Product { Id = 12, Name = "Хлеб", Prots = 3, Carbs = 20, Fats = 1, Calories = 100 }
            );

            modelBuilder.Entity<Dish>().HasData(
                new Dish { Id = 1, Name = "Салат овощной" },
                new Dish { Id = 2, Name = "Борщ" },
                new Dish { Id = 3, Name = "Салат Сингулярность" }
            );

            modelBuilder.Entity<Recipe>().HasData(
                new Recipe { Id = 1, DishId = 1, ProductId = 1, ProductWeight = 200 }, // Огурец
                new Recipe { Id = 2, DishId = 1, ProductId = 2, ProductWeight = 150 }, // Помидор
                new Recipe { Id = 3, DishId = 1, ProductId = 3, ProductWeight = 200 },  // Морковь
                new Recipe { Id = 4, DishId = 2, ProductId = 2, ProductWeight = 300 },  // Картофель
                new Recipe { Id = 5, DishId = 2, ProductId = 3, ProductWeight = 200 },  // Морковь
                new Recipe { Id = 6, DishId = 2, ProductId = 4, ProductWeight = 300 },  // Говядина
                new Recipe { Id = 7, DishId = 2, ProductId = 7, ProductWeight = 300 },  // Помидор
                new Recipe { Id = 8, DishId = 2, ProductId = 10, ProductWeight = 100 },  // Свекла
                new Recipe { Id = 9, DishId = 2, ProductId = 11, ProductWeight = 100 },  // Капуста
                new Recipe { Id = 10, DishId = 3, ProductId = 12, ProductWeight = 200 },  // 
                new Recipe { Id = 11, DishId = 3, ProductId = 5, ProductWeight = 200 },  //
                new Recipe { Id = 12, DishId = 3, ProductId = 6, ProductWeight = 200 },  //
                new Recipe { Id = 13, DishId = 3, ProductId = 8, ProductWeight = 200 },  //
                new Recipe { Id = 14, DishId = 3, ProductId = 9, ProductWeight = 300 }  //

            );
        }
    }
}

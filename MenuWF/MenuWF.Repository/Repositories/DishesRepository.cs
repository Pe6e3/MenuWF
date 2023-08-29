﻿using MenuWF.Data;
using MenuWF.Entities;
using MenuWF.Interfaces;

namespace MenuWF.MenuWF.Repository.Repositories
{
    public class DishesRepository :GenericRepository<Dish>, IDishesRepository
    {
        private readonly AppDbContext db;

        public DishesRepository(AppDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
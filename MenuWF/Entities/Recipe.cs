namespace MenuWF.Entities;

public class Recipe : BaseEntity
{
    public int DishId { get; set; }
    public int ProductId { get; set; }
    public int ProductWeight { get; set; }
    public virtual Dish? Dish { get; set; }
    public virtual Product? Product { get; set; }
    //public virtual List<Product>? Products { get; set; }
}

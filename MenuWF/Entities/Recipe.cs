namespace MenuWF.Entities;

public class Recipe : BaseEntity
{
    public int DishId { get; set; }
    public int ProductId { get; set; }
    public int ProductWeight { get; set; }
}

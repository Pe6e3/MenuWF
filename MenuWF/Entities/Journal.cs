namespace MenuWF.Entities;

public class Journal : BaseEntity
{
    public int RecipeId { get; set; }
    public int DishWeight { get; set; }
    public DateTime Date { get; set; }

}

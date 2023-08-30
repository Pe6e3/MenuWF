namespace MenuWF.Entities;

public class Journal : BaseEntity
{
    public int RecipeId { get; set; }
    public decimal DishWeight { get; set; }
    public DateTime Date { get; set; }
    public Meal meal { get; set; }


    public enum Meal
    {
        Breakfast =1,
        Dinner =2 ,
        Supper =3
    }

}

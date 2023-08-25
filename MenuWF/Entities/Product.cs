namespace MenuWF.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; } = null!;
    public int Prots { get; set; }
    public int Carbs { get; set; }
    public int Fats { get; set; }
    public int Calories { get; set; }
}

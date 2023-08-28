namespace MenuWF.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public decimal Prots { get; set; }
    public decimal Carbs { get; set; }
    public decimal Fats { get; set; }
    public decimal Calories { get; set; }
}

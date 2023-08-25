using System.ComponentModel.DataAnnotations;

namespace MenuWF.Entities;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrudWebApi.Model
{
    public class Hero
    {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public string LastName { get; set; } = string.Empty;
    public bool isActive { get; set; } = true;
    }
}

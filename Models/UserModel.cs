using System.ComponentModel.DataAnnotations;
using UserAPI.Validations;

namespace UserAPI.Models;

public class UserModel
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(maximumLength: 20, ErrorMessage = "Must to indicate User Name")]
    [FirstCapitalAttribute]
    public string Name { get; set; }
    public int Age { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace AcGarageAPI.DtoModels;

public class CarDto
{
    [Required, StringLength(100, MinimumLength = 1)]
    public string Make { get; set; }

    [Required, StringLength(100, MinimumLength = 1)]
    public string Model { get; set; }

    [Required, StringLength(10, MinimumLength = 1)]
    public string Registration { get; set; }

    [Required]
    public decimal? Price { get; set; }
}
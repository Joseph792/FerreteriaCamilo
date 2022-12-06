using System.ComponentModel.DataAnnotations;

public class Suplidores
{
    [Key]
    public int SuplidorId { get; set; }
    [Required(ErrorMessage ="El Nombre de la Compañia es Obligatorio")]
    public String? NombreComp { get; set; }
    [Required(ErrorMessage ="El Nombre del Vendedor es Obligatorio")]
    public String? NombreVendedor { get; set; }
    [Required(ErrorMessage ="El RNC es Obligatorio")]
    public String? RNC { get; set; }
    [Required(ErrorMessage ="La Direccion es Obligatoria")]
    public String? Direccion { get; set; }
    [Required(ErrorMessage ="El Telefono es Obligatorio")]
    public String? Telefono { get; set; }
    [Required(ErrorMessage ="El Celular es Obligatorio")]
    public String? Celular { get; set; }
}
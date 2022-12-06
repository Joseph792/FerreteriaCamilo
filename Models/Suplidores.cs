using System.ComponentModel.DataAnnotations;

public class Suplidores
{
    [Key]
    public int SuplidorId { get; set; }
    public String? NombreComp { get; set; }
    public String? NombreVendedor { get; set; }
    public String? RNC { get; set; }
    public String? Direccion { get; set; }
    public String? Telefono { get; set; }
    public String? Celular { get; set; }
}
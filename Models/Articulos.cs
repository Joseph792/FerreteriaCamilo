using System.ComponentModel.DataAnnotations;

public class Articulos
{
[Key]
public int ArticuloId { get; set; }
[Required(ErrorMessage ="El Nombre es obligatorio")]
public String? Nombre { get; set; }
[Required(ErrorMessage ="La Referencia es obligatoria")]
public String? Referencia { get; set; }
[Range(minimum:1, maximum:5000000, ErrorMessage ="El Costo es obligatorio")]
public int Costo { get; set; }
[Range(minimum:1, maximum:5000000, ErrorMessage ="El Precio es obligatorio")]
public int Precio { get; set; }
public int SuplidorId { get; set; }
}
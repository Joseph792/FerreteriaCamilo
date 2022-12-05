using System.ComponentModel.DataAnnotations;

public class Articulos
{
[Key]
public int ArticuloId { get; set; }
[Required(ErrorMessage ="El nombre es obligatorio")]
public String? Nombre { get; set; }
[Required(ErrorMessage ="La referencia es obligatoria")]
public String? Referencia { get; set; }
[Range(minimum:0, maximum:5000000, ErrorMessage ="El costo es obligatorio")]
public int Costo { get; set; }
[Range(minimum:0, maximum:5000000, ErrorMessage ="El costo es obligatorio")]
public int Precio { get; set; }
public int SuplidorId { get; set; }
}
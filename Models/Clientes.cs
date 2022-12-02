using System.ComponentModel.DataAnnotations;

    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage ="El Nombre es Obligatorio")]
        public String? Nombre { get; set; }
        [Required(ErrorMessage ="El Apellido o Apellidos son Obligatorios")]
        public String? Apellidos { get; set; }
        [Required(ErrorMessage ="La Cedula es Obligatoria")]
        public String? Direccion { get; set; }
        [Required(ErrorMessage ="El Telefono es Obligatorio")]
        public String? NumeroTelefono { get; set; }
        [Required(ErrorMessage ="El Celular es Obligatorio")]
        public String? NumeroCelular { get; set; }
        [Range(minimum:18, maximum:150, ErrorMessage ="La Edad es Obligatoria")]
        public int Edad { get; set; }
        [Required(ErrorMessage ="La Cedula es Obligatoria")]
        public String? Cedula { get; set; }
    }

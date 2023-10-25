using System.ComponentModel.DataAnnotations;

namespace JuanAlvarez_ExamenP1.Models
{
    public class JuanAlvarez_tabla
    {
        [Range(18, 60)]
        public int jaEdad { get; set; }

        [StringLength(15)]
        public string? jaNombre { get; set; }

        [Required]
        public bool jaAñosEmpresa { get; set; }

        public decimal jaSalario { get; set; }

        [Key]
        public string? jaCedula { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? jaCorreo { get; set; }

        [DataType(DataType.Date)]
        public string jaNacimiento { get; set; }
        
        
    }
}

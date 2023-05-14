using System.ComponentModel.DataAnnotations;

namespace RegistroPrioridad.Models{
    public class Registros_Prioridad{

        [Key]
        public int PrioridadId { get; set;}

        [Required (ErrorMessage ="La descripcion es obligatorio")]
        public string Descripcion { get; set; } = string.Empty;

        [Required (ErrorMessage ="Los dia son necesarios")]
        public DateTime DiasCompromiso { get; set; } = DateTime.Today;
    }
}
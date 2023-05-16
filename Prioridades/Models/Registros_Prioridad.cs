using System.ComponentModel.DataAnnotations;

public class Registros_Prioridad{

    [Key]
    public int PrioridadId { get; set;}

    [Required (ErrorMessage ="La descripcion es obligatorio")]
    public string Descripcion { get; set; } = string.Empty;

    [Required (ErrorMessage ="Los dia son necesarios")]
    [Range(minimum:0, maximum:31,ErrorMessage ="Debe estar de 0 a 31")]
    public int DiasCompromiso { get; set; }

}
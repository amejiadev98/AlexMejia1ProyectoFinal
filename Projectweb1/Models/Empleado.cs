using System.ComponentModel.DataAnnotations;

namespace Projectweb1.Models
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(13)]
        public string Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set;}
        [Required]
        public string Correo{ get; set;}
        [Required]
        public string Departamento {  get; set;}
        [Required]
        public required string Posicion { get;set;}
        [Required]
        public required int Sueldo { get; set;}
        [Required]
        public string Telefono  { get; set;}
        [Required]
        public string Horario { get; set;}
        




    }
}
//  cedula, nombre apello, posicion,  direccion, sueldo, departamento, telefono, posicion, horario, comision,
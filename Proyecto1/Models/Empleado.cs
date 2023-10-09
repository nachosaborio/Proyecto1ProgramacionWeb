using System.ComponentModel.DataAnnotations;

namespace Proyecto1.Models
{
    public class Empleado
    {
        [Required]
        [Display(Name ="ID")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Fecha de ingreso")]
        public DateTime FechaIngreso { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string? Nombre { get; set; }

        [Required]
        [Display(Name = "Apellidos")]
        public string? Apellidos { get; set; }

        [Required]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaDeNacimiento { get; set; }

        [Required]
        [Display(Name = "Cédula")]
        public long Cedula { get; set; }

        [Required]
        [Display(Name = "Dirección")]
        public string? Direccion { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Required]
        [Display(Name = "Teléfono")]
        public int Telefono { get; set; }

        [Required]
        [Display(Name = "Persona de contacto")]
        public string? PersonaDeContacto { get; set; }
    }
}

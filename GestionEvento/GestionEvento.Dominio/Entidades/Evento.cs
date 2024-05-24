using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEvento.Dominio.Entidades
{
    public class Evento
    {
        public int EventoId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string Nom_Evento { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime Fecha_Evento { get; set; }

        [StringLength(500, ErrorMessage = "La descripción no puede exceder los 500 caracteres.")]
        public string Desc_Evento { get; set; }

        [Required(ErrorMessage = "El número de asistentes es obligatorio.")]
        [Range(1, 10000, ErrorMessage = "El número de asistentes debe ser entre 1 y 10,000.")]
        public int Num_Asistentes_Evento { get; set; }
    }
}

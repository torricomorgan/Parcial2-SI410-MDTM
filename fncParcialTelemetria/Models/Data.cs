using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace fncParcialTelemetria.Models
{
    class Data
    {
        [Key]
        public string id { get; set; }

        [Required]
        public string Estudiante { get; set; }

        [Required]
        public string Temperatura { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public string Hora { get; set; }
    }
}

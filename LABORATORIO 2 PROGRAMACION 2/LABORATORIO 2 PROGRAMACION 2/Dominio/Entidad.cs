﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LABORATORIO_2_PROGRAMACION_2.Dominio
{
    public class Entidad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdPersona { get; set; }


        [Display(Name = "NombrePersona")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string NombrePersona { get; set; }

        [Display(Name = "EdadPersona")]
        [Range(18, int.MaxValue, ErrorMessage = "No cumple con la edad necesaria")]
        public int EdadPersona { get; set; }


        [Display(Name = "DescripcionPersona")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string DescripcionPersona { get; set;  }

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Registro2.Entidades
{
   public class Persona
    {
       [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
       
        public string Email { get; set; }
        public string NivelUsuario { get; set; }

        public string Usuario { get; set; }

        public string Clave { get; set; }

        public DateTime FechaIngreso { get; set; }

        public Persona()
        {
            Id = 0;
            Nombre = string.Empty;
            Email = string.Empty;
            NivelUsuario = string.Empty;
            Usuario = string.Empty;
            Clave = string.Empty;
            FechaIngreso = DateTime.Now;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace citasmedicas.Datos
{
   public class Datos
    {
        //defino los atributos de la tabla
        public int id_usuario { get; set; } 
        public string nombre { get; set; }  
        public string apellido {get; set; } 
        public int cedula { get; set; }
        public int historia_clin { get; set; }
        public string email { get; set; }
        public int telefono { get; set; }   
        public int edad { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public string especialidad { get; set; }
        public int id_rol { get; set; } 
        public string rol { get; set; }
        public string horario { get; set; } 
    }
}

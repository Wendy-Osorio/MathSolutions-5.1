using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathSolutions.Data.Models
{
    public class Inscripcion
    {
        public Inscripcion()
        {

        }

        public int IdInscripcion { get; set; }

        public int IdEstudiante { get; set; }
        public int IdCurso { get; set; }

        public virtual Curso Cursos { get; set; }
        public virtual Estudiante Estudiantes { get; set; }
    }
}

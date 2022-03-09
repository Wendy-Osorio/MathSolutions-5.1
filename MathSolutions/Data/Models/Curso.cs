using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathSolutions.Data.Models
{
    public class Curso
    {
        public Curso()
        {
            Inscripcions = new HashSet<Inscripcion>();
        }

        public int IdCurso { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaCierre { get; set; }
        public string LinkReunion { get; set; }
        public string Material { get; set; }
        public string Descripcion { get; set; }
        public int? IdEstatus { get; set; }
        public int IdProfesor { get; set; }

        public virtual Profesor IdProfesorNavigation { get; set; }
        public virtual Estatus IdEstatusNavigation { get; set; }
        public virtual ICollection<Inscripcion> Inscripcions { get; set; }
        //public virtual Inscripcion Inscripcions { get; set; }
    }
}

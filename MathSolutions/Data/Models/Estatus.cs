using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathSolutions.Data.Models
{
    public class Estatus
    {
        public Estatus()
        {
            Cursos = new HashSet<Curso>();
        }

        public int IdEstatus { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<Curso> Cursos { get; set; }
    }
}

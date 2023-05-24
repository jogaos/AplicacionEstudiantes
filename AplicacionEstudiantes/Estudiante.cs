using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEstudiantes
{
    public class Estudiante
    {
        private String id;
        private String name;
        private Curso[] cursos =  new Curso[2];

        public Estudiante(String id, String name)
        {
            this.id = id;
            this.name = name;
        }

        public String getId()
        {
            return this.id;
        }

        public String getName()
        {
            return this.name;
        }

        public void setId(String id)
        {
            this.id = id;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public Curso[] getCursos()
        {
                return this.cursos;
        }

        public void setCursos(Curso[] cursos)
        {
            this.cursos = cursos;
        }
    }
}

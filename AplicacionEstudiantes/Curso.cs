using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEstudiantes
{
    public class Curso
    {
        String name;
        int grade;

        public Curso(String name, int grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public String getName()
        {
            return name;
        }

        public int getGrade()
        {
            return grade;
        }

        public void setGrade(int grade)
        {
            this.grade = grade;
        }

        public void setName(String name)
        {
            this.name = name;
        }
    }
}

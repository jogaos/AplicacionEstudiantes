using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEstudiantes
{
    public class Node
    {
        private Estudiante value;
        private Node next;

        public Node (Estudiante value)
        {
            this.value = value;
            this.next = null;
        }

        public Estudiante getValue(){ return this.value; }

        public Node getNext(){ return this.next; }

        public void setValue (Estudiante value){ this.value = value; }

        public void setNext (Node next){ this.next = next; }

    }
}

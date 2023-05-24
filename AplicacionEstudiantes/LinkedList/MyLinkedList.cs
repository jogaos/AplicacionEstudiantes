using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEstudiantes
{
    public class MyLinkedList
    {
        private String name;
        private Node head;

        public MyLinkedList(string name)
        {
            this.name = name;
            this.head = null;
        }

        public String getName()
        {
            return this.name;
        }

        public Node getHead()
        {
            return this.head;
        }

        public void setName(String name){ this.name = name; }

        public void setHead(Node head) { this.head = head; }    

        public bool IsListEmpty()
        {
            return this.head == null;
        }

        public void Add(Node node)
        {
            if (IsListEmpty())
            {
                this.head = node;
            }else
            {
                Node last = this.head;

                while(last.getNext() != null)
                {
                    last = last.getNext();
                }

                last.setNext(node);
            }
        }

        public bool existNode(String identifier)
        {
            bool exists = false;

            Node actual = this.head;

            while (actual != null)
            {
                Estudiante student = actual.getValue();
                if (student.getId() == identifier)
                {
                    exists= true;
                    break;
                }

                actual = actual.getNext();
            }

            return exists;
        }

        public void addCourse(String identifier, Curso newCourse)
        {
            Node actual = this.head;

            while (actual != null)
            {
                Estudiante student = actual.getValue();
                if (student.getId() == identifier)
                {
                    student.getCursos()[0] = newCourse;
                    break;
                }

                actual = actual.getNext();
            }


        }
        public String getNodeList()
        {
            String message = "";

            Node actual = this.head;

            while (actual != null)
            {
                Estudiante student = actual.getValue();
                
                message += student.getId() + " - " + student.getName() + "\n";

                foreach (Curso course in student.getCursos())
                {
                    if (course != null)
                    {
                        message += "\t" + course.getName() + " - " + course.getGrade() + "\n";
                    }
                }

                actual = actual.getNext();
            }
            return message;
        }
    }
}

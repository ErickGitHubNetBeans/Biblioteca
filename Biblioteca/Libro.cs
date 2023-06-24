using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Biblioteca
{
    internal class Libro
    {
        //Atributos:
        private int id;
        private string titulo;
        private string autor;
        private int anio;
        private bool estadoLibro; //disponible o no disponible

        //Constructor por defecto:
        public Libro()
        {

        }
        //Constructor de 3 parámetros:
        public Libro(int id, string titulo, string autor,int anio)
        {
            this.id = id;
            this.titulo = titulo;
            this.autor = autor;
            this.anio = anio;
        }
        //Métodos de acceso:
        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }
        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public string getTitulo()
        {
            return this.titulo;
        }
        public void setAutor(string autor)
        {
            this.autor = autor;
        }
        public string getAutor()
        {
            return this.autor;
        }
        public void setAnio(int anio)
        {
            this.anio = anio;
        }
        public int getAnio()
        {
            return this.anio;
        }
        public void setEstado(bool estadoLibro)
        {
            this.estadoLibro = estadoLibro;
        }
        public bool getEstado()
        {
            return this.estadoLibro;
        }

        // Compara los id de dos objetos. Útil para saber si un nodo es igual
        // a otro que pretende ingresar al ABB.       
        public int compare(Libro libro)
        {
            if (libro.getId() == this.getId())
            {
                return 0;
            }
            else if (libro.getId() > this.getId())
            {
                // El elemento que pretende ingresar al ABB estaria
                // ingresando por la derecha.
                return 1;
            }
            else
            {
                // El elemento que pretende ingresar al ABB estaria
                // ingresando por la izquierda.
                return -1;
            }
        }

        // Valida si existe un identificador de objeto en el árbol.
        public int compareId(int id)
        {
            if (id == this.getId())
            {
                return 0;
            }
            else if (id > this.getId())
            {
                // El elemento que pretende ingresar al ABB estaria
                // ingresando por la derecha.
                return 1;
            }
            else
            {
                // El elemento que pretende ingresar al ABB estaria
                // ingresando por la izquierda.
                return -1;
            }
        }

        //METODOS CRUD

        /*public void agregarLibro() { }
        public void mostrarLibro() { }
        public void actualizarLibro() { }
        public void eliminarLibro() { }*/
    }
}


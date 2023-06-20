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
        private int idLibro;
        private string titulo;
        private string autor;
        private int anio;
        private bool estadoLibro; //disponible o no disponible

        //Constructor:
        Libro()
        {

        }
        //Métodos de acceso:
        public void setIdLibro(int id)
        {
            this.idLibro = id;
        }
        public int getIdLibro()
        {
            return this.idLibro;
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
            this.autor= autor;
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
        public void setEstadoLibro(bool estadoLibro)
        {
            this.estadoLibro= estadoLibro;
        }
        public bool getEstadoLibro()
        {
            return this.estadoLibro;
        }

        //METODOS CRUD

        public void agregarLibro() { }
        public void mostrarLibro() { }
        public void actualizarLibro() { }
        public void eliminarLibro() { }
    }
}


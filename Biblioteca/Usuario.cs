using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Usuario
    {
        //Atributos:
        private int idUsuario; //es identificacion interna
        private string nombre;
        private string apellido;
        private string dni; //es identificacion externa

        //Constructor por defecto:
        public Usuario()
        {
        }

        //Constructor de 3 parámetros:
        public Usuario(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        //Métodos de acceso
        public void setIdUsuario(int id)
        {
            this.idUsuario = id;
        }
        public int getIdUsuario()
        {
            return this.idUsuario;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public string getApellido()
        {
            return this.apellido;
        }
        public void setDni(string dni)
        {
            this.dni = dni;
        }
        public string getDni()
        {
            return this.dni;
        }

        //toString()
        public override string? ToString()
        {
            return base.ToString();
        }
        public bool consultarLibro(Libro libro)
        {
            return libro.getEstado();
        }
        public void prestarLibro(Libro libro)
        {
            libro.setEstado(false);
        }
        public void devolverLibro(Libro libro)
        {
            libro.setEstado(true);
        }
        //METODOS CRUD

        /*public void agregarUsuario() { }
        public void mostrarUsuario() { }
        public void actualizarUsuario() { }
        public void eliminarUsuario() { }*/
    }
}

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
        private int idUsuario;
        private string nombre;
        private string apellido;
        private string dni;

        //Constructor por defecto:
        public Usuario()
        {
        }

        //Métodos de acceso
        public void setIdUsuario(int id)
        {
            this.idUsuario = id;
        }
        public int getIdUsuario() {
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

        //METODOS CRUD

        public void agregarUsuario() { }
        public void mostrarUsuario() { }
        public void actualizarUsuario() { }
        public void eliminarUsuario() { }
    }
}

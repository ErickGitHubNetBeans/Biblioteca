using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Libreria
    {
        //Atributos
        private LinkedList<Libro> listaLibros = new LinkedList<Libro>();
        private LinkedList<Usuario> listaUsuarios=new LinkedList<Usuario>();

        //Constructor por defecto:
        public Libreria()
        {

        }
        //Métodos de acceso
        public void setListaLibros(LinkedList<Libro> listaLibros){
            this.listaLibros = listaLibros;
        }
        public LinkedList<Libro> getListaLibros()
        {
            return this.listaLibros;
        }
        public void setListaUsuarios(LinkedList<Usuario> listaUsuarios)
        {
            this.listaUsuarios = listaUsuarios;
        }
        public LinkedList<Usuario> getListaUsuarios()
        {
            return this.listaUsuarios;
        }

        //toString()
        public override string? ToString()
        {
            return base.ToString();
        }
        public void agregarUsuario() { 
            Usuario usuario = new Usuario();
            listaUsuarios.AddLast(usuario);
        }
        public void mostrarUsuario() { }
        public void actualizarUsuario() { }
        public void eliminarUsuario() { }

        public void agregarLibro() { }
        public void mostrarLibro() { }
        public void actualizarLibro() { }
        public void eliminarLibro() { }
    }
}

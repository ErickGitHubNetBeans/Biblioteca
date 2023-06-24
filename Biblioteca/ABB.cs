using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class ABB
    {
        //Atributo raíz - es único
        private Nodo raiz;

        public ABB() //Constructor
        {
            this.raiz = null;
        }

        public void insertar(Libro libro) //insertar llama a insertarRecursivo
        {
            this.raiz = this.insertarRecursivo(this.raiz, libro);
        }

        private Nodo insertarRecursivo(Nodo raiz, Libro libro)
        {
            if (raiz == null) //si es null, será el primer nodo del árbol (raíz)
            {
                return new Nodo(libro);
            }
            if (this.raiz.getDato().compare(libro) < 0)
            //libro.getId()< raiz.getDato().getId()
            {
                raiz.setIzquierda(insertarRecursivo(raiz.getIzquierda(), libro));
                //si es menor, va a la izquierda
            }
            else if (this.raiz.getDato().compare(libro) > 0)
            //libro.getId() > raiz.getDato().getId()
            {
                raiz.setDerecha(insertarRecursivo(raiz.getDerecha(), libro));
                //si es mayor, va a la derecha
            }
            return raiz;
        }
        public void mostrar() //mostrar llama a mostrarRecursivo
        {
            this.mostrarRecursivo(raiz);
        }

        private void mostrarRecursivo(Nodo raiz)
        {
            if (raiz != null)
            {
                mostrarRecursivo(raiz.getIzquierda());
                Console.WriteLine(raiz.getDato());
                mostrarRecursivo(raiz.getDerecha());
            }
        }

        //Llena el árbol a partir de una base de datos:
        public void crearArbol(string ruta)
        {
            try //asegura que el código no caiga
            {
                string[] contenidoArchivo = File.ReadAllLines(ruta);
                //contenidoArchivo es un arreglo[] string que almacena
                //el contenido del archivo

                HashSet<int> numerosAleatorios = new HashSet<int>();
                foreach (string i in contenidoArchivo) //recorrido para parsear
                {
                    numerosAleatorios.Add(int.Parse(i));
                }

                //recorrido para insertar los datos al árbol
                foreach (int i in numerosAleatorios)
                {
                    this.insertar(new Libro());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error en lectura de archivo"); //alerta en caso de error
            }
        }

        //Exporta los datos del árbol a la base de datos:
        public void exportarTxt(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                this.exportarTxtRecursivo(this.raiz, writer); //exportar recursivo
                writer.Close();
            }

            Console.WriteLine("Exportación completada.");
        }//exportarTxt llama a exportarTxtRecursivo

        private void exportarTxtRecursivo(Nodo raiz, StreamWriter writer)
        {
            if (raiz != null) //garantiza que no esté vacío
            {
                this.exportarTxtRecursivo(raiz.getDerecha(), writer); //primero el mayor
                writer.WriteLine(raiz.getDato());
                this.exportarTxtRecursivo(raiz.getIzquierda(), writer); //luego el menor
            }
        }
    }
}

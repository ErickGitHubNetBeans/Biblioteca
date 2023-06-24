using System.Text;

namespace Biblioteca
{
    public class ABB
    {
        //Atributos
        private Libro l;
        private ABB izq, der;

        public bool isEmpty()
        {
            return this.l is null;
        }

        public bool treeWithoutSheets()
        {
            return this.l is not null && this.izq is null && this.der is null;
        }

        public void add(Libro lib)
        {
            if (this.isEmpty())
            {
                // Por comentar.
                this.l = lib;
            }
            else
            {
                if (this.l.compare(lib) > 0)
                {
                    // Por comentar.
                    if (this.der is null) { this.der = new ABB(); }
                    this.der.add(lib);
                }
                else if (this.l.compare(lib) < 0)
                {
                    // Por comentar.
                    if (this.izq is null) { this.izq = new ABB(); }
                    this.izq.add(lib);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Parece que estas intentando ingresar un libro con el mismo id que otro ya cargado en el arbol. ");
                    sb.Append("Se ignorara este libro y se continuara con la carga de los demás libros.\n");
                    sb.Append("Revisar el libro titulado: " + lib.getTitulo());

                    MessageBoxButtons btnOk = MessageBoxButtons.OK;
                    MessageBoxIcon icoErr = MessageBoxIcon.Error;

                    string msg = sb.ToString();

                    string title = "Id de libro repetido";
                    MessageBox.Show(msg, title, btnOk, icoErr);
                }
            }
        }

        /*
         * Imprime en consola los nodos del árbol desde el nodo más a la 
         * izquierda del subárbol izquierdo (representando el número 
         * menor) hasta el nodo más a la derecha del subárbol derecho
         * (representando el número mayor)
         */
        public void inOrdenPrint()
        {
            if (this.l is not null)
            {
                if (this.izq is not null) { this.izq.inOrdenPrint(); }
                MessageBox.Show(this.l.getTitulo());
                if (this.der is not null) { this.der.inOrdenPrint(); }
            }
        }

        public int getGreaterId()
        {
            if (this.der != null) { return this.der.getGreaterId(); } 
            else { return this.l.getId(); }
        }
    }
}

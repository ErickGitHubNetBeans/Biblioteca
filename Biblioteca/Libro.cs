namespace Biblioteca
{
    internal class Libro
    {
        //Atributos.
        private int id;
        private string titulo;
        private string autor;
        private string editorial;
        private string pais;
        private int anio;
        private bool disponible;

        //Constructor.
        public Libro(int id, string titulo, string autor, string editorial,
            string pais, int anio)
        {
            this.id = id;
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.pais = pais;
            this.anio = anio;

            // Al ser un libro nuevo, el estado es disponible.
            this.disponible = true;
        }

        // INICIO ## Getters y setters

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

        public void setEditorial(string editorial)
        {
            this.editorial = editorial;
        }

        public string getEditorial()
        {
            return this.editorial;
        }

        public void setPais(string pais)
        {
            this.pais = pais;
        }

        public string getPais()
        {
            return this.pais;
        }

        public void setAnio(int anio)
        {
            this.anio = anio;
        }

        public int getAnio()
        {
            return this.anio;
        }

        public void setDisponible(bool estadoLibro)
        {
            this.disponible = estadoLibro;
        }

        public bool isDisponible()
        {
            return this.disponible;
        }

        // FIN ## Getters y setters
    
        public int compare(Libro l)
        {
            if (this.getId() == l.getId())
            {
                return 0;
            }
            else if (this.getId() < l.getId())
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        
        public int compareId(int id)
        {
            if (this.getId() == id)
            {
                return 0;
            }
            else if (this.getId() < id)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}

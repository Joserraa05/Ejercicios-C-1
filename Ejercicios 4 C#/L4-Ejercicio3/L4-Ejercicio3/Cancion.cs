using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace L4_Ejercicio3
{
    internal class Cancion
    {
        protected String titulo;
        protected String autor;

        public Cancion(String titulo, String autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }

        public Cancion()
        {
            this.titulo = "";
            this.autor = "";
        }

        public String getTitulo()
        {
            return titulo;
        }

        public String getAutor()
        {
            return autor;
        }

        public void setTitulo(String titulo)
        {
            this.titulo = titulo;
        }

        public void setAutor(String autor)
        {
            this.autor = autor;
        }
    }
}

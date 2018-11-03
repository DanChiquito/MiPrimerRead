using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiprimerGIT
{
    class ClasePokemon
    {
        private string pokemon;
        private string num;
        private string tipo;
        private string entrenador;

        public ClasePokemon(string pokemon, string num, string tipo, string entrenador)
        {
            this.Pokemon = pokemon;
            this.Num = num;
            this.Tipo = tipo;
            this.Entrenador = entrenador;
        }

        public string Pokemon { get => pokemon; set => pokemon = value; }
        public string Num { get => num; set => num = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Entrenador { get => entrenador; set => entrenador = value; }
    }
}

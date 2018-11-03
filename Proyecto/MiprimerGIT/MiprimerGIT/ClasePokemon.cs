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
            this.pokemon = pokemon;
            this.num = num;
            this.tipo = tipo;
            this.entrenador = entrenador;
        }
    }
}

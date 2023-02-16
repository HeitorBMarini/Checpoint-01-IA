using Exercicio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Models
{
    internal class VideoGame: Console
    {
        public string Cor;
        public string tipo;
        public int jogo;
        public bool ligado;

        public void escolherJogp(int jogo)
        {
            jogo = novoJogo;
        }

        public void ligar(bool Estado)
        {
            ligado = Estado;
        }
    }
}

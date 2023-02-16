using Exercicio.Models;

Videogame videogame = new();

videogame.cor = "preto";
videogame.tipo = "console";

Console.WriteLine("Ligar videogame? (s/n)")
string funcionamento Readline();
if (estado == "S")
{
    videogame.ligado = true;
    videogame.ligar = (videogame.ligado);
} else { videogame.ligado = false}

if (videogame.ligado)
{
    Console.WriteLine("escolha o jogo: "):
    int jogo =Convert.Int32( Console.ReadLine() );
    if (jogo < 0) throw new Exception("jogo indisponivel");

    videogame.jogo = jogo;

    videogame.escolherJogo(jogo);
}
using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1: iJogador
    {
        public readonly string Nome;


        public Jogador1 (string par_nome = "Ronaldo")
        {
            Nome = par_nome;
        }

        public string Chuta()
        {
            return $"{Nome} está chutando";
        }

        public string Corre()
        {
            return $"{Nome} está correndo";
        }

        public string Passe()
        {
            return $"{Nome} está passando";
        }

    }
}
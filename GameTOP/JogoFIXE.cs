using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFIXE
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;

        public JogoFIXE(iJogador jogador1, iJogador jogador2)
        {
            _jogadorA = jogador1;
            _jogadorB = jogador2;
        }

        public void IniciarJogo()
        {
            System.Console.WriteLine(_jogadorA.Chuta());
            System.Console.WriteLine(_jogadorA.Passe());
            System.Console.WriteLine(_jogadorA.Corre());


            System.Console.WriteLine("PRÓXIMO JOGADOR");
            
            System.Console.WriteLine(_jogadorB.Corre());
            System.Console.WriteLine(_jogadorB.Chuta());
            System.Console.WriteLine(_jogadorB.Passe());
        }
    }
}
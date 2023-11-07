using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    internal class Game
    {
        public enum Resultado
        {
            Ganhar, Perder, Empatar
        }

        public static Image[] images =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Tesoura.png"),
            Image.FromFile("imagens/Papel.png")

        };
        public Image ImgPC { get; private set; }
        public Image ImgJogador { get; private set; }
        public Resultado Jogar(int Jogador)
        {
            int pc = JogadaPC();

            ImgJogador = images[Jogador];
            ImgPC = images[pc];
            if(Jogador == pc)
            {
                return Resultado.Empatar;

            }else if((Jogador == 0) && (pc == 1) || (Jogador == 1 && pc == 2) || (Jogador == 2 && pc ==0))

            {
                return Resultado.Ganhar;
            }else
            {
                return Resultado.Perder;
            }

             
            //return Resultado.Empatar;

        }

        private int JogadaPC()
        {
            int mil = DateTime.Now.Millisecond;
            if (mil> 333)
            {
                return 0;

            }
            else if (mil>= 333 && mil < 667)
            {
                return 1;
            }else
            {
                return 2;
            }
        }
        
         
    


   


         

        

        
    }
}

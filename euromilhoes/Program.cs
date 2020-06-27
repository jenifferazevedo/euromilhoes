using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euromilhoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao jogo do Euro Milhões - feito por Jeniffer Azevedo!\n");
            EuroNumeros jogoJogador = new EuroNumeros();
            Console.WriteLine("Agora é o momento de fazer o seu jogo!");
            Console.WriteLine("Escolha 5 numeros entre 1 e 50");
            jogoJogador.lerChave();
            Console.WriteLine("Escolha 2 valores entre 1 e 12 para as estrelas");
            jogoJogador.lerEstrelas();
            Console.WriteLine("\nSeu jogo é: ");
            Console.WriteLine(jogoJogador.ToString());
            EuroNumeros jogoAleatorio = new EuroNumeros();
            jogoAleatorio.gerarChaveAleatoria();
            jogoAleatorio.gerarEstrelasAleatoria();
            Console.WriteLine("\n\nPreparado para ver o resultado?!");
            Console.Write("Chaves: ");
            int[] acertosChave = comparar(jogoJogador.getChave(), jogoAleatorio.getChave(), "chave");
            Console.Write("Estrelas: ");
            int[] acertosEstrelas = comparar(jogoJogador.getEstrelas(), jogoAleatorio.getEstrelas(), "estrela");

            Console.WriteLine("\nCurioso para saber o jogo sorteado? Ele é:");
            Console.WriteLine(jogoAleatorio.ToString());


            Console.ReadKey();
        }
        static int[] comparar(int[] vec1, int[] vec2, string tipo)
        {
            int[] iguais = new int[vec1.Length];
            int cont = 0;
            for(int i = 0; i < vec1.Length; i++)
            {
                for(int j = 0; j < vec1.Length; j++)
                {
                    if(vec1[i] == vec2[j])
                    {
                        Console.WriteLine("Numero acertado " + vec1[i]);
                        iguais[i] = vec1[i];
                        cont++;
                    }
                }
            }
            Array.Sort(iguais);
            if (cont == 0)
            {
                Console.WriteLine("você não acertou nenhum número da " + tipo + "! Melhor sorte na proxima vez!");
            }
            else if (cont == vec1.Length)
            {
                Console.WriteLine("Seu dia de sorte!!! Você ganhou!! Aqui está seu 'Parabéns'!");
            }
            return iguais;
        }
        static void escreverArray(int[] vec1)
        {
            for (int i = 0; i < vec1.Length; i++)
            {
                Console.WriteLine(vec1[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euromilhoes
{
    public class EuroNumeros
    {
        private int[] chave;
        private int[] estrelas;
        public EuroNumeros()
        {
            this.chave = new int[5];
            this.estrelas = new int[2];
        }

        public int[] getChave()
        {
            return this.chave;
        }
        public int[] getEstrelas()
        {
            return this.estrelas;
        }

        public int[] lerChave()
        {
            Console.Write("Digite o 1º valor: ");
            this.chave[0] = lerNum1aN(50);
            for (int i = 1; i<5; i++)
            {
                Console.Write("Digite o " + (i+1) + "º valor: " );
                this.chave[i] = lerNum1aN(50);
                for (int j = 0; j < i; j++)
                {
                    while(this.chave[i] == this.chave[j])
                    {
                        Console.Write("Número repitido, digite outro valor para a " + (i+1) + "º: ");
                        this.chave[i] = lerNum1aN(50);
                    }
                }
            }
            Array.Sort(this.chave);
            return this.chave;
        }
        public void escreverChave()
        {
            for(int i = 0; i < this.chave.Length; i++)
            {
                Console.WriteLine(i + "º número da chave: " + this.chave[i]);
            }
        }
        
        public int[] lerEstrelas()
        {
            Console.Write("Digite o valor da 1º estrela: ");
            this.estrelas[0] = lerNum1aN(12);
            Console.Write("Digite o valor da 2º estrela: ");
            this.estrelas[1] = lerNum1aN(12);
            while (this.estrelas[1] == this.estrelas[0])
            {
                Console.Write("Número repitido, digite outro valor para a 2º estrela: ");
                this.estrelas[1] = lerNum1aN(12);
            } 
            Array.Sort(this.estrelas);
            return this.estrelas;
        }
        public void escreverEstrelas()
        {
            for (int i = 0; i < this.estrelas.Length; i++)
            {
                Console.WriteLine("O valor da " + i + "º estrela é: " + this.estrelas[i]);
            }
        }
        
        public int[] gerarChaveAleatoria()
        {
            Random rnd = new Random();
            this.chave[0] = rnd.Next(1,51);
            for (int i = 1; i < 5; i++)
            {
                this.chave[i] = rnd.Next(1,51);
                for (int j = 0; j < i; j++)
                {
                    while (this.chave[i] == this.chave[j])
                    {
                        this.chave[i] = rnd.Next(1,51);
                    }
                }
            }
            Array.Sort(this.chave);
            return this.chave;
        }
        public int[] gerarEstrelasAleatoria()
        {
            Random rnd = new Random();
            this.estrelas[0] = rnd.Next(1, 13);
            this.estrelas[1] = rnd.Next(1, 13);
            while (this.estrelas[1] == this.estrelas[0])
            {
              this.estrelas[1] = rnd.Next(1, 13);
            }
            Array.Sort(this.estrelas);
            return this.estrelas;
        }

        public override string ToString()
        {
            return "Chave: " + this.chave[0] + ", " + this.chave[1] + ", " + this.chave[2] + ", " +  this.chave[3] + ", " +  this.chave[4] + "\nEstrelas: " + this.estrelas[0] + ", " + this.estrelas[1];
        }
        static int lerNum1aN(int vMax)
        {
            int n = 0;
            bool flag;
            do
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if(n > vMax || n <= 0)
                        Console.Write("O número deve ser entre 1 e " + vMax + ": ");
                    flag = true;
                }
                catch
                {
                    Console.WriteLine("Error - numero inválido, deve ser positivo e entre 1 e " + vMax);
                    flag = false;
                }
            }
            while (!flag || n <= 0 || n > vMax);
            return n;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFTStart5NET.Desafio
{
    public class Maior_e_Posição
    {
        public void retorno()
        {
            int n;
            int maior = 0;
            int posicao = 0;
            for (int i = 1; i <= 100; i++)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > maior)
                {
                    maior = n;
                    posicao = i;     //Complete o código nos espaços em branco
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}

/*
 * 
 * Desafio
Você recebeu o desafio de ler 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.

Entrada
O arquivo de entrada contém 100 números inteiros, positivos e distintos.

Saída
Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo.

 
Exemplo de Entrada	Exemplo de Saída
2
113
45
34565
6
...
8
 

34565
4
 * 
 */
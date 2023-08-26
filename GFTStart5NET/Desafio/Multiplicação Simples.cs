using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFTStart5NET.Desafio
{
    public class Multiplicação_Simples
    {
        public void resultado()
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PROD = " + (a * b)); //implemente o código que representa a multiplicação.
            Console.ReadLine();
        }
    }
}


/*
 * 
 * Desafio
Você receberá dois valores inteiros. Faça a leitura e em seguida calcule o produto entre estes dois valores. Atribua esta operação à variável PROD, mostrando esta de acordo com a mensagem de saída esperada (exemplo abaixo).   

Entrada
A entrada contém 2 valores inteiros.

Saída
Exiba a variável PROD conforme exemplo abaixo, tendo obrigatoriamente um espaço em branco antes e depois da igualdade.

 
Exemplos de Entrada	Exemplos de Saída
3
9

PROD = 27

-30                             
10

PROD = -300         

0                                
9

PROD = 0          
 * 
 */
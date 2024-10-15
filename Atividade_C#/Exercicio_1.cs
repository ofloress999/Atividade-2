//Adiciona a biblioteca System
using System;


namespace exercicio1;
public class Exercicio_1
{
    static void ex_1()
    {
        
        Console.WriteLine("Escreva o primeiro texto: "); //Pede para o usuario entrar com um texto
        var text1 = Console.ReadLine(); //Guarda o valor fornecido pelo usuario
        Console.WriteLine("Escreva o segundo texto: ");
        var text2 = Console.ReadLine();

        if(string.Compare(text1.ToUpper(), text2.ToUpper()) == 0) //Utilizando o .ToUpper deixamos ambos textos em maisculo para comparar o .Compare e verificar se sao iguais;
        {
            Console.WriteLine("As strings são iguais.");
        } else
        {
            Console.WriteLine("As strings são diferentes.");
        }

        Console.WriteLine($"O texto 1 tem {text1.Length} caracteres"); //Retornamos uma mensagem utilizando .Length para informar a quantidade de caracteres do texto.
        Console.WriteLine($"O texto 2 tem {text2.Length} caracteres");


    }

}
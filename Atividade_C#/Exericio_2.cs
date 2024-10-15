using System;


namespace exercicio2;

public class Exericio_2
{
    static void ex_2()
    {
        Console.WriteLine("Escreva uma palavra: ");
        var text = Console.ReadLine();

        Console.WriteLine("Escreva uma unica letra: ");
        char letra = char.Parse(Console.ReadLine());

        text = text.ToUpper();
        letra = Char.ToUpper(letra);

        int count = 0;

        for (int i = 0;i < text.Length; i++)
        {
            if (text[i] == letra)
            {
                count++;
            }
        }

        Console.WriteLine($"A letra {letra} aparece {count} vezes");
    }
}

/*
 Escreva um programa que solicite ao usuário uma palavra (string) e uma letra(char). 
O programa deve contar e exibir quantas vezes a letra aparece na palavra, 
ignorando se está em maiúsculas ou minúsculas. 
Para ler a variável letra do tipo char: 
letra = Console.ReadLine()[0];       
Para deixar maisculas:  palavra = palavra.ToUpper();        
letra = Char.ToUpper(letra); 
*/
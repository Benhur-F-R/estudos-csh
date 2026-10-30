using System;

class NumberZ
{
    static void Main()
    {
        int idade = 30; // inteiro
        Console.WriteLine(idade);

        Console.WriteLine(31); // inteiro literal

        float altura = 1.80f; // número com . mais leve e menos preciso - 32 bit
        Console.WriteLine(altura); 

        double temperatura = 24.5; // padrão do C# para número com ponto - 64 bit
        Console.WriteLine(temperatura);

        decimal digitosPi = 3.14m; // maior alcance e precisão para número com ponto - 128 bit
        Console.WriteLine(digitosPi);
    }
}

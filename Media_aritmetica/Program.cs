using System;

namespace Media_aritmetica
{
    public class Program
    {
        public static void Main()
        {
            
            int nota1, nota2, nota3, nota4, media;
            Console.WriteLine("Informe a nota 1");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a nota 2");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a nota 3");
            nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a nota 4");
            nota4 = int.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;
            if (media >= 6)
            {
                Console.WriteLine("Parabêns você foi aprovado!!! Sua média é:");
                Console.WriteLine(media);
            }
            if (media < 6)
            {
                Console.WriteLine("Infelizmente você foi repovado... Sua média é:");
                Console.WriteLine(media);
            }

        }
    }
}

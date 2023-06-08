using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperList numbers = new SuperList { 10.5, 20.8, 15.3, 7.2, 30.1 };

            // Versão 1: parâmetros out
            double min1, max1;
            numbers.GetMinMax1(out min1, out max1);
            Console.WriteLine($"Versão 1 - Mínimo: {min1}, Máximo: {max1}");

            // Versão 2: com classe/struct específica
            var (min2, max2) = numbers.GetMinMax2();
            Console.WriteLine($"Versão 2 - Mínimo: {min2}, Máximo: {max2}");

            // Versão 3: com tuplos de referência
            double min3, max3;
            (min3, max3) = numbers.GetMinMax3();
            Console.WriteLine($"Versão 3 - Mínimo: {min3}, Máximo: {max3}");

            // Versão 4: com tuplos de valor e nomes definidos por nós
            var result = numbers.GetMinMax4();
            Console.WriteLine($"Versão 4 - Mínimo: {result.minValue}, Máximo: {result.maxValue}");
        }
    }
}

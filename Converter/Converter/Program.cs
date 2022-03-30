using System;

namespace Converter
{
    class Program
    {
        static void Main()
        {
            Converter converter = new Converter();
            Console.WriteLine(converter.GetConvertedValue("Длина", "Миллиметр", "Метр", 2)); 
            Console.WriteLine("Hello World!");
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        unsafe
        {
           //  кейс 1 
            Console.WriteLine("--- Кейс 1 ---");
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("До: " + string.Join(" ", numbers));
            fixed (int* pArray = numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    *(pArray + i) += 10;
                }
            }
            Console.WriteLine("После: " + string.Join(" ", numbers));
            Console.WriteLine();

            //  Кейс 2.
            Console.WriteLine("--- Кейс 2 ---");
            int x = 50;
            int* p = &x;
            int** pp = &p;
            Console.WriteLine($"Адрес x: 0x{(ulong)&x:X}");
            Console.WriteLine($"Адрес p: 0x{(ulong)&p:X}");
            Console.WriteLine($"Значение x до: {x}");
            **pp = 999;
            Console.WriteLine($"Значение x после изменения через **pp: {x}");
        }
    }
}

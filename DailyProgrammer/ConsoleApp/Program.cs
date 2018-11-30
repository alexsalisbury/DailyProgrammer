namespace ConsoleApp
{
    using System;
    using EasyLibrary.Challenge369;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HexColors_369.ConvertToHex(64, 128, 192));
            Console.WriteLine(HexColors_369.Blend("#000000", "#778899"));
            Console.ReadKey();
        }
    }
}
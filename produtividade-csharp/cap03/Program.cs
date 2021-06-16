using System;

namespace cap03
{
    public class Animal
    {
        public string Nome { get; set; }
    }
    public class Gato : Animal //A classe Gato é filha de Animal
    {

    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

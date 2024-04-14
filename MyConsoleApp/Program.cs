using MyLibrary;

namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageWriter MyWrite = new MessageWriter();
            MyWrite.Write("Hola, Profe");
            Console.ReadLine();
            FiggleWriter FWrite = new FiggleWriter();
            FWrite.Write("Hello, figgle!!");
        }
    }
}


namespace FactoryMethod;

public class LinuxPlayer : Player
{
    public override  Task Play(string fileName)
    {
         System.Console.WriteLine("flaying audio in Linux");
         System.Console.WriteLine($"mpg123 -q '{fileName}'");
         return Task.CompletedTask;
    }
}
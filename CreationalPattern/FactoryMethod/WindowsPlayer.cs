 
namespace FactoryMethod;

public class WindowPlayer : Player
{
    public override  Task Play (string filename)
    {
        System.Console.WriteLine("playing in the windows");
        System.Console.WriteLine($"playing file {filename}");
        return Task.CompletedTask ;
    }
    private static int Val() => 1;
}
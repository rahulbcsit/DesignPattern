
using System.Runtime.InteropServices;
using FactoryMethod;

 PlayerCreator playerFactoryCreator;

 if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
 {
    playerFactoryCreator = new WindowsPlayerCreator();
 }
else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
{
    playerFactoryCreator = new LinuxPlayerCreator();
}
else
{
    throw new Exception("only mac and winodw ssupport ");


}

System.Console.WriteLine("please give the file path");
var filePath = Console.ReadLine() ?? "defult.mg";
await playerFactoryCreator.CreatePlayer().Play(filePath);
Console.ReadKey();

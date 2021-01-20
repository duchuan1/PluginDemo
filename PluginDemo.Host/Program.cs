using System;
using System.IO;

namespace PluginDemo.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------TestAPluginOne-------------------------");
            load("plugins\\TestAPluginOne.dll");

            Console.WriteLine("----------------TestPluginOne-------------------------");
            load("plugins\\TestPluginOne.dll");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void load(string assembly)
        {
            Directory.CreateDirectory("plugins");

            var manager = new AssemblyManager();

            manager.LoadFrom(assembly);
            manager.DoWork();

            //Directory.Delete("plugins", true);

            manager.DoWork();
            //manager.ShowCrossDomainPollutionExceptions();

            manager.UnLoad();
        }
    }
}

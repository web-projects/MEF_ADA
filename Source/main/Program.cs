using MEF.Core;
using MEF.Core.Activator;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {
        static readonly MEFActivator activator = new MEFActivator();

        static async Task Main(string[] args)
        {
            string featurePath = Path.Combine(Environment.CurrentDirectory, "DeviceFeatures");

            IMEFApplication application = activator.Start(featurePath);
            await application.Run().ConfigureAwait(false);

            while (Console.ReadKey().Key != ConsoleKey.Q)
            {
                await Task.Delay(50).ConfigureAwait(false);
            }

            application.Shutdown();
        }
    }
}

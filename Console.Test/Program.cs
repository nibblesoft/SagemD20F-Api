using HackSagemRouter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Console.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var credentials = new NetworkCredential(GetValue("router_username"), GetValue("router_password"));

            // var credentialsCache = new CredentialCache();
            // credentialsCache.Add()

            var sagemClient = new SagemClient(credentials);
            sagemClient.RefreshAsync().Wait();
            GetDevicesInfo(sagemClient);
            //sagemClient.RebootAsync().Wait();

            // Tasks executed by calling the RunSynchronously method are instantiated by calling a
            // Task or Task<TResult> class constructor. The task to be run synchronously must be in the TaskStatus.Created state.
            // A task may be started and run only once. Any attempts to schedule a task a second time results in an exception.
            // sagemClient.RefreshAsync().RunSynchronously(TaskScheduler.FromCurrentSynchronizationContext());

            System.Console.WriteLine("Press any key..");
            System.Console.ReadLine();
        }

        public static async void GetDevicesInfo(SagemClient sagemClient)
        {
            var devices = await sagemClient.GetDeviesInfoAsync();
            foreach (var device in devices)
            {
                System.Console.WriteLine($"Hostname: {device.Hostname}, Expire-date: {device.ExpiresIn}");
            }
        }

        public static string GetValue(string name)
        {
            string value = Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.User);
            return value;
        }
    }
}

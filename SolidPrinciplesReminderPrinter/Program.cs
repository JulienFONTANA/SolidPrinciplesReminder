using Ninject;
using SolidPrinciplesReminder.Injection;
using SolidPrinciplesReminder.Service;

namespace SolidPrinciplesReminderPrinter
{
    public class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel(new SPRInjectionModule());

            var service = kernel.Get<ISolidPrincipleService>();

            service.Execute();
        }
    }
}

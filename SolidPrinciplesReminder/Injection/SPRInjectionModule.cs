using System;
using Ninject.Modules;
using SolidPrinciplesReminder.Service;
using SolidPrinciplesReminder.SolidPrinciples;

namespace SolidPrinciplesReminder.Injection
{
    public class SPRInjectionModule : NinjectModule
    {
        public override void Load()
        {
            BindService();
            BindPrinciples();
        }

        private void BindService()
        {
            Bind<ISolidPrincipleService>().To<SolidPrincipleService>();
        }

        private void BindPrinciples()
        {
            Bind<ISolidPrinciple>().To<SingleResponsibilityPrinciple>();
            Bind<ISolidPrinciple>().To<OpenClosePrinciple>();
            Bind<ISolidPrinciple>().To<LiskovSubstitutionPrinciple>();
            Bind<ISolidPrinciple>().To<InterfaceSegregationPrinciple>();
            Bind<ISolidPrinciple>().To<DependencyInversionPrinciple>();
        }
    }
}

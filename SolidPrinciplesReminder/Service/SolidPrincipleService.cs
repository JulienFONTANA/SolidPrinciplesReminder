using SolidPrinciplesReminder.SolidPrinciples;
using System;
using System.Linq;

namespace SolidPrinciplesReminder.Service
{
    public class SolidPrincipleService : ISolidPrincipleService
    {
        private readonly ISolidPrinciple[] SolidPrinciples;

        public SolidPrincipleService(ISolidPrinciple[] solidPrinciples)
        {
            SolidPrinciples = solidPrinciples;
        }

        public void Execute()
        {
            foreach (var principle in SolidPrinciples.OrderBy(x => x.RuleNumber))
            {
                Console.WriteLine(principle.RuleName);
                Console.WriteLine(principle.EnummerateSolidRule());
                Console.WriteLine();
            }
        }
    }
}

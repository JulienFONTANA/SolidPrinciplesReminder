namespace SolidPrinciplesReminder.SolidPrinciples
{
    class DependencyInversionPrinciple : ISolidPrinciple
    {
        public int RuleNumber { get; }
        public string RuleName { get;  }

        public DependencyInversionPrinciple()
        {
            RuleNumber = 5;
            RuleName = "Dependency Inversion";
        }

        public string EnummerateSolidRule()
        {
            return @"One should depend upon abstractions, [not] concretions.";
        }
    }
}

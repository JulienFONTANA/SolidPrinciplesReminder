namespace SolidPrinciplesReminder.SolidPrinciples
{
    class InterfaceSegregationPrinciple : ISolidPrinciple
    {
        public int RuleNumber { get; }
        public string RuleName { get; }

        public InterfaceSegregationPrinciple()
        {
            RuleNumber = 4;
            RuleName = "Interface Segregation";
        }

        public string EnummerateSolidRule()
        {
            return @"Many client-specific interfaces are better than one general-purpose interface.";
        }
    }
}

namespace SolidPrinciplesReminder.SolidPrinciples
{
    class OpenClosePrinciple : ISolidPrinciple
    {
        public int RuleNumber { get; }
        public string RuleName { get; }

        public OpenClosePrinciple()
        {
            RuleNumber = 2;
            RuleName = "Open/Close";
        }

        public string EnummerateSolidRule()
        {
            return @"Software entities (methods, classes...) should be open for "
            + "extension, but closed for modification.";
        }
    }
}

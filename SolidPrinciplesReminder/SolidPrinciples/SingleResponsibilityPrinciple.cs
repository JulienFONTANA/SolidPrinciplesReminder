namespace SolidPrinciplesReminder.SolidPrinciples
{
    class SingleResponsibilityPrinciple : ISolidPrinciple
    {
        public int RuleNumber { get; }
        public string RuleName { get; }

        public SingleResponsibilityPrinciple()
        {
            RuleNumber = 1;
            RuleName = "Single Responsibility";
        }

        public string EnummerateSolidRule()
        {
            return @"A class should only have a single responsibility, that is, "
            + "only changes to one part of the software's specification should be " 
            + "able to affect the specification of the class.";
        }
    }
}

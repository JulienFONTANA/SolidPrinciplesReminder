namespace SolidPrinciplesReminder.SolidPrinciples
{
    class LiskovSubstitutionPrinciple : ISolidPrinciple
    {
        public int RuleNumber { get; }
        public string RuleName { get; }

        public LiskovSubstitutionPrinciple()
        {
            RuleNumber = 3;
            RuleName = "LiskovSubstitution";
        }

        public string EnummerateSolidRule()
        {
            return "Objects in a program should be replaceable with instances "
            + "of their subtypes without altering the correctness of that program.";
        }
    }
}

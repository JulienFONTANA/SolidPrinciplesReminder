namespace SolidPrinciplesReminder.SolidPrinciples
{
    public interface ISolidPrinciple
    {
        int RuleNumber { get; }
        string RuleName { get; }
        string EnummerateSolidRule();
    }
}
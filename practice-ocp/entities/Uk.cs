namespace practice_ocp.entities;

public class Uk : TaxtCalculator
{
    public override double Calculate()
    {
        double taxableIncome = Income - Deduction;
        double taxAmount = taxableIncome * 0.20;
        return taxAmount;
    }
}
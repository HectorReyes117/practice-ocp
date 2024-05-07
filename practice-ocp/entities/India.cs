namespace practice_ocp.entities;

public class India : TaxtCalculator
{
    public override double Calculate()
    {
        double taxableIncome = Income - Deduction;
        double taxAmount = taxableIncome * 0.10;
        return taxAmount;
    }
}
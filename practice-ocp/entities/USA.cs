namespace practice_ocp.entities;

public class USA : TaxtCalculator
{
    public override double Calculate()
    {
        double taxableIncome = Income - Deduction;
        double taxAmount = taxableIncome * 0.30 * 0.01;
        return taxAmount;
    }
}
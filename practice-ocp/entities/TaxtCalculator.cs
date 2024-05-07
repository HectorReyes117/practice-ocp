namespace practice_ocp.entities;

public abstract class TaxtCalculator
{
    protected double Income { get; set; }
    protected double Deduction { get; set; }
    public abstract double Calculate();
}
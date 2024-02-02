namespace GarionLightningLab1;

public class Backpack
{
    ICalculator calculator;
    public Backpack(ICalculator calc)
    {
        calculator = calc;
    }

    public int BackpackAdd(int a, int b)
    {
        return calculator.Add(a, b);
    }
}

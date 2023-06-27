namespace CalcMvpApp.Models;

public sealed class CalculatorEngine : ICalculatorEngine
{
    public decimal Add(decimal left, decimal right) => left + right;

    public decimal Subtract(decimal left, decimal right) => left - right;

    public decimal Multiply(decimal left, decimal right) => left * right;

    public decimal Divide(decimal left, decimal right)
    {
        if (right == 0)
        {
            throw new DivideByZeroException(nameof(right));
        }
        return left / right;
    }
}

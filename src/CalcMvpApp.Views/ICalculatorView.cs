namespace CalcMvpApp.Views;

public interface ICalculatorView
{
    decimal LeftValue { get; }
    decimal RightValue { get; }
    void UpdateResultValue(decimal value);
}

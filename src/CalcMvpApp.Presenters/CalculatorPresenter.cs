namespace CalcMvpApp.Presenters;

using CalcMvpApp.Models;
using CalcMvpApp.Views;

public class CalculatorPresenter
{
    private readonly ICalculatorEngine model;
    private readonly ICalculatorView view;

    public CalculatorPresenter(ICalculatorEngine model, ICalculatorView view)
        => (this.model, this.view) = (model, view);

    public void Add()
    {
        var result = this.model.Add(this.view.LeftValue, this.view.RightValue);
        this.view.UpdateResultValue(result);
    }

    public void Subtract()
    {
        var result = this.model.Subtract(this.view.LeftValue, this.view.RightValue);
        this.view.UpdateResultValue(result);
    }

    public void Multiply()
    {
        var result = this.model.Multiply(this.view.LeftValue, this.view.RightValue);
        this.view.UpdateResultValue(result);
    }

    public void Divide()
    {
        var result = this.model.Divide(this.view.LeftValue, this.view.RightValue);
        this.view.UpdateResultValue(result);
    }
}

namespace CalcMvpApp.WinUI;

using System.Globalization;
using CalcMvpApp.Models;
using CalcMvpApp.Presenters;
using CalcMvpApp.Views;

public partial class CalculatorForm : Form, ICalculatorView
{
    private readonly CalculatorPresenter presenter;
    public CalculatorForm()
    {
        this.InitializeComponent();
        this.presenter = new CalculatorPresenter(new CalculatorEngine(), this);
    }

    public decimal LeftValue => decimal.Parse(this.txtLeftValue.Text);
    public decimal RightValue => decimal.Parse(this.txtRightValue.Text);

    public void UpdateResultValue(decimal value)
    {
        this.txtResultValue.Text = value.ToString(CultureInfo.InvariantCulture);
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        this.presenter.Add();
    }

    private void btnMultiply_Click(object sender, EventArgs e)
    {
        this.presenter.Multiply();
    }

    private void btnDivide_Click(object sender, EventArgs e)
    {
        this.presenter.Divide();
    }

    private void btnSubtract_Click(object sender, EventArgs e)
    {
        this.presenter.Subtract();
    }
}

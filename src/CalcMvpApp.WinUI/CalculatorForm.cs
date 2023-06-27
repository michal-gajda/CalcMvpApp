namespace CalcMvpApp.WinUI;

using System.ComponentModel;
using System.Globalization;
using CalcMvpApp.Models;
using CalcMvpApp.Presenters;
using CalcMvpApp.Views;

public partial class CalculatorForm : Form, ICalculatorView
{
    private const string DEFAULT_ERROR_CAPTION = "Error";
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
        try
        {
            this.presenter.Divide();
        }
        catch (DivideByZeroException exception)
        {
            MessageBox.Show(exception.Message, DEFAULT_ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSubtract_Click(object sender, EventArgs e)
    {
        this.presenter.Subtract();
    }

    private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
    {
        var isControl = char.IsControl(e.KeyChar);
        var isDigit = char.IsDigit(e.KeyChar);
        var @char = e.KeyChar;

        if (isControl is false && isDigit is false && @char is not '.')
        {
            e.Handled = true;
        }

        if (e.KeyChar is '.' && (sender as TextBox)!.Text.IndexOf('.') > -1)
        {
            e.Handled = true;
        }
    }

    private void txtValue_Validating(object sender, CancelEventArgs e)
    {
        e.Cancel = !decimal.TryParse((sender as TextBox)!.Text, out _);
    }
}

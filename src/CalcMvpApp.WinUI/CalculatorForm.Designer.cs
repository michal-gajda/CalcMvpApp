namespace CalcMvpApp.WinUI;

partial class CalculatorForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        txtLeftValue = new TextBox();
        txtRightValue = new TextBox();
        txtResultValue = new TextBox();
        lblLeftValue = new Label();
        lblRightValue = new Label();
        lblResultValue = new Label();
        btnAdd = new Button();
        btnSubtract = new Button();
        btnMultiply = new Button();
        btnDivide = new Button();
        this.SuspendLayout();
        // 
        // txtLeftValue
        // 
        txtLeftValue.Location = new Point(76, 15);
        txtLeftValue.Name = "txtLeftValue";
        txtLeftValue.Size = new Size(402, 31);
        txtLeftValue.TabIndex = 0;
        txtLeftValue.Text = "0";
        txtLeftValue.KeyPress += this.txtValue_KeyPress;
        txtLeftValue.Validating += this.txtValue_Validating;
        // 
        // txtRightValue
        // 
        txtRightValue.Location = new Point(76, 64);
        txtRightValue.Name = "txtRightValue";
        txtRightValue.Size = new Size(402, 31);
        txtRightValue.TabIndex = 1;
        txtRightValue.Text = "0";
        txtRightValue.KeyPress += this.txtValue_KeyPress;
        txtRightValue.Validating += this.txtValue_Validating;
        // 
        // txtResultValue
        // 
        txtResultValue.Location = new Point(76, 141);
        txtResultValue.Name = "txtResultValue";
        txtResultValue.ReadOnly = true;
        txtResultValue.Size = new Size(402, 31);
        txtResultValue.TabIndex = 2;
        // 
        // lblLeftValue
        // 
        lblLeftValue.AutoSize = true;
        lblLeftValue.Location = new Point(25, 15);
        lblLeftValue.Name = "lblLeftValue";
        lblLeftValue.Size = new Size(45, 25);
        lblLeftValue.TabIndex = 3;
        lblLeftValue.Text = "Left:";
        // 
        // lblRightValue
        // 
        lblRightValue.AutoSize = true;
        lblRightValue.Location = new Point(12, 64);
        lblRightValue.Name = "lblRightValue";
        lblRightValue.Size = new Size(58, 25);
        lblRightValue.TabIndex = 4;
        lblRightValue.Text = "Right:";
        // 
        // lblResultValue
        // 
        lblResultValue.AutoSize = true;
        lblResultValue.Location = new Point(7, 141);
        lblResultValue.Name = "lblResultValue";
        lblResultValue.Size = new Size(63, 25);
        lblResultValue.TabIndex = 5;
        lblResultValue.Text = "Result:";
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(12, 101);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(112, 34);
        btnAdd.TabIndex = 6;
        btnAdd.Text = "+";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += this.btnAdd_Click;
        // 
        // btnSubtract
        // 
        btnSubtract.Location = new Point(130, 101);
        btnSubtract.Name = "btnSubtract";
        btnSubtract.Size = new Size(112, 34);
        btnSubtract.TabIndex = 7;
        btnSubtract.Text = "-";
        btnSubtract.UseVisualStyleBackColor = true;
        btnSubtract.Click += this.btnSubtract_Click;
        // 
        // btnMultiply
        // 
        btnMultiply.Location = new Point(248, 101);
        btnMultiply.Name = "btnMultiply";
        btnMultiply.Size = new Size(112, 34);
        btnMultiply.TabIndex = 8;
        btnMultiply.Text = "*";
        btnMultiply.UseVisualStyleBackColor = true;
        btnMultiply.Click += this.btnMultiply_Click;
        // 
        // btnDivide
        // 
        btnDivide.Location = new Point(366, 101);
        btnDivide.Name = "btnDivide";
        btnDivide.Size = new Size(112, 34);
        btnDivide.TabIndex = 9;
        btnDivide.Text = "/";
        btnDivide.UseVisualStyleBackColor = true;
        btnDivide.Click += this.btnDivide_Click;
        // 
        // CalculatorForm
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(btnDivide);
        this.Controls.Add(btnMultiply);
        this.Controls.Add(btnSubtract);
        this.Controls.Add(btnAdd);
        this.Controls.Add(lblResultValue);
        this.Controls.Add(lblRightValue);
        this.Controls.Add(lblLeftValue);
        this.Controls.Add(txtResultValue);
        this.Controls.Add(txtRightValue);
        this.Controls.Add(txtLeftValue);
        this.Name = "CalculatorForm";
        this.Text = "Calculator";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private TextBox txtLeftValue;
    private TextBox txtRightValue;
    private TextBox txtResultValue;
    private Label lblLeftValue;
    private Label lblRightValue;
    private Label lblResultValue;
    private Button btnAdd;
    private Button btnSubtract;
    private Button btnMultiply;
    private Button btnDivide;
}

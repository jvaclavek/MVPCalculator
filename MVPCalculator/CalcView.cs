using System;
using System.Windows.Forms;

namespace MVPCalculator
{
  public partial class CalcView : Form, ICalcView
  {
    public CalcView()
    {
      InitializeComponent();
      btnAdd.Click += delegate { Add?.Invoke(this, EventArgs.Empty); };
      btnReset.Click += delegate
      {
        Reset?.Invoke(this, EventArgs.Empty);
        txtNumber1.Focus();
      };
    }

    public event EventHandler? Add;
    public event EventHandler? Reset;
    public string Value1
    {
      get => txtNumber1.Text;
      set => txtNumber1.Text = value;
    }

    public string Value2
    {
      get => txtNumber2.Text;
      set => txtNumber2.Text = value;
    }

    public string Value3
    {
      get => txtNumber3.Text;
      set => txtNumber3.Text = value;
    }

    public string Total
    {
      set => txtTotal.Text = value;
    }
    public string RunningTotal
    {
      set => txtRunningTotal.Text = value;
    }
  }
}
using System;
using System.Collections.Generic;

namespace MVPCalculator
{
  public class CalcPresenter
  {
    readonly ICalcView _view;
    readonly ICalcModel _model;

    public CalcPresenter(ICalcView view, ICalcModel model)
    {
      _view = view;
      _model = model;
      _view.Add += Add;
      _view.Reset += Reset;
      _view.Show();
    }

    public void Add(object sender, EventArgs e)
    {
      _model.CalculateTotal(new List<string>
      {
        _view.Value1, 
        _view.Value2, 
        _view.Value3
      }.ConvertAll(TryGetNumber));

      _view.Total = Convert.ToString(_model.Total);
      _view.RunningTotal = Convert.ToString(_model.RunningTotal);
    }

    public void Reset(object sender, EventArgs e)
    {
      _model.ResetTotal();

      _view.Value1 = _view.Value2 = _view.Value3 = _view.Total = "";
    }

    public decimal TryGetNumber(string input)
    {
      var value = input.Replace('.', ',');
      return decimal.TryParse(value, out decimal res) ? res : 0;
    }
  }
}

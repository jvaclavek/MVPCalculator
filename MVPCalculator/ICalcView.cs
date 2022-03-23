using System;

namespace MVPCalculator;

public interface ICalcView
{
  event EventHandler Add;
  event EventHandler Reset;
  public string Value1 { get; set; }
  public string Value2 { get; set; }
  public string Value3 { get; set; }
  public string Total {set; }
  public string RunningTotal  {set; }
  void Show();
}
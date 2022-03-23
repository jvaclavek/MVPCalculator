using System;
using System.Reflection;
using System.Windows.Forms;
using Ninject;

namespace MVPCalculator
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      ApplicationConfiguration.Initialize();
      var kernel = new StandardKernel();
      kernel.Load(Assembly.GetExecutingAssembly());

      CalcPresenter presenter = new CalcPresenter(
        kernel.Get<CalcView>(),
        kernel.Get<CalcModel>());
      Application.Run(new ApplicationContext());
    }
  }
}
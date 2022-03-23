using Ninject.Modules;

namespace MVPCalculator
{
  internal class Bindings : NinjectModule
  {
    public override void Load()
    {
      Bind<ICalcModel>().To<CalcModel>();
      Bind<ICalcView>().To<CalcView>();
    }
  }
}

using Ninject.Modules;

namespace MVPCalculator
{
  public class Bindings : NinjectModule
  {
    public override void Load()
    {
      Bind<ICalcModel>().To<CalcModel>();
      Bind<ICalcView>().To<CalcView>();
      Bind<CalcPresenter>().ToSelf();
    }
  }
}

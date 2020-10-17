using Facade.VSFacade;

namespace Facade
{
    class Programmer
    {
        public void CreateConsoleApp(VisualStudioFacade visualStudioFacade)
        {
            visualStudioFacade.Start();
            visualStudioFacade.Stop();
        }
    }
}

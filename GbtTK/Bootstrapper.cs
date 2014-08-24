using System.Windows;
using Microsoft.Practices.Composite.Modularity;
using Microsoft.Practices.Composite.UnityExtensions;
using GbtTK.Modules.Employee;
using GbtTK.Modules.Project;

namespace GbtTK
{
    internal class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            Shell shell = this.Container.Resolve<Shell>();
            shell.Show();
            return shell;
        }

        protected override void InitializeModules()
        {
            IModule employeeModule = this.Container.Resolve<EmployeeModule>();
            employeeModule.Initialize();

            IModule projectModule = this.Container.Resolve<ProjectModule>();
            projectModule.Initialize();
        }
    }
}
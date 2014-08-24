using Microsoft.Practices.Composite.Modularity;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Unity;
using GbtTK.Modules.Employee.Controllers;
using GbtTK.Modules.Employee.Services;

namespace GbtTK.Modules.Employee
{
    public class EmployeeModule : IModule
    {
        private readonly IUnityContainer container;
        private readonly IRegionManager regionManager;

        public EmployeeModule(IUnityContainer container, IRegionManager regionManager)
        {
            this.container = container;
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            this.RegisterViewsAndServices();

            EmployeesPresenter presenter = this.container.Resolve<EmployeesPresenter>();

            IRegion mainRegion = this.regionManager.Regions[RegionNames.MainRegion];
            mainRegion.Add(presenter.View);
        }

        protected void RegisterViewsAndServices()
        {
            this.container.RegisterType<IEmployeesController, EmployeesController>();

            this.container.RegisterType<IEmployeeService, EmployeeService>(new ContainerControlledLifetimeManager());

            this.container.RegisterType<IEmployeesView, EmployeesView>();

            this.container.RegisterType<IEmployeesListView, EmployeesListView>();
            this.container.RegisterType<IEmployeesListPresenter, EmployeesListPresenter>();

            this.container.RegisterType<IEmployeesDetailsView, EmployeesDetailsView>();
            this.container.RegisterType<IEmployeesDetailsPresenter, EmployeesDetailsPresenter>();
        }
    }
}

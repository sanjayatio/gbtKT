using System.Globalization;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Unity;
using GbtTK.Modules.Project;

namespace GbtTK.Modules.Employee.Controllers
{
    public class EmployeesController : IEmployeesController
    {
        private IUnityContainer container;
        private IRegionManager regionManager;

        public EmployeesController(IUnityContainer container, IRegionManager regionManager)
        {
            this.container = container;
            this.regionManager = regionManager;
        }

        public virtual void OnEmployeeSelected(BusinessEntities.Employee employee)
        {
            IRegion detailsRegion = regionManager.Regions[RegionNames.DetailsRegion];
            object existingView = detailsRegion.GetView(employee.EmployeeId.ToString(CultureInfo.InvariantCulture));

            if (existingView == null)
            {
                IProjectsListPresenter projectsListPresenter = this.container.Resolve<IProjectsListPresenter>();
                projectsListPresenter.SetProjects(employee.EmployeeId);

                IEmployeesDetailsPresenter detailsPresenter = this.container.Resolve<IEmployeesDetailsPresenter>();
                detailsPresenter.SetSelectedEmployee(employee);

                IRegionManager detailsRegionManager = detailsRegion.Add(detailsPresenter.View, employee.EmployeeId.ToString(CultureInfo.InvariantCulture), true);
                IRegion region = detailsRegionManager.Regions[RegionNames.TabRegion];
                region.Add(projectsListPresenter.View, "CurrentProjectsView");
                detailsRegion.Activate(detailsPresenter.View);
            }
            else
            {
                detailsRegion.Activate(existingView);
            }
        }
    }
}

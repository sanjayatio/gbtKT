using GbtTK.Modules.Employee.PresentationModels;

namespace GbtTK.Modules.Employee
{
    public class EmployeesDetailsPresenter : IEmployeesDetailsPresenter
    {
        public EmployeesDetailsPresenter(IEmployeesDetailsView view)
        {
            this.View = view;
        }

        public IEmployeesDetailsView View { get; set; }

        public void SetSelectedEmployee(BusinessEntities.Employee employee)
        {
            EmployeesDetailsPresentationModel model = new EmployeesDetailsPresentationModel();
            model.SelectedEmployee = employee;
            this.View.Model = model;
        }
    }
}

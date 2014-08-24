using System;
using GbtTK.Modules.Employee.Controllers;
using Microsoft.Practices.Composite.Events;

namespace GbtTK.Modules.Employee
{
    public class EmployeesPresenter
    {
        private IEmployeesListPresenter listPresenter;
        private IEmployeesController employeeController;

        public EmployeesPresenter(
            IEmployeesView view,
            IEmployeesListPresenter listPresenter,
            IEmployeesController employeeController)
        {
            this.View = view;
            this.listPresenter = listPresenter;
            this.listPresenter.EmployeeSelected += new EventHandler<DataEventArgs<BusinessEntities.Employee>>(this.OnEmployeeSelected);
            this.employeeController = employeeController;

            View.SetHeader(listPresenter.View);
        }

        public IEmployeesView View { get; set; }

        private void OnEmployeeSelected(object sender, DataEventArgs<BusinessEntities.Employee> e)
        {
            employeeController.OnEmployeeSelected(e.Value);
        }
    }
}

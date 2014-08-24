using System;
using Microsoft.Practices.Composite.Events;
using GbtTK.Modules.Employee.Services;

namespace GbtTK.Modules.Employee
{
    public class EmployeesListPresenter : IEmployeesListPresenter
    {
        public event EventHandler<DataEventArgs<BusinessEntities.Employee>> EmployeeSelected = delegate { };

        public EmployeesListPresenter(IEmployeesListView view,
            IEmployeeService employeeService)
        {
            this.View = view;
            this.View.EmployeeSelected += delegate(object sender, DataEventArgs<BusinessEntities.Employee> e)
            {
                EmployeeSelected(sender, e);
            };
            view.Model = employeeService.RetrieveEmployees();
        }

        public IEmployeesListView View { get; set; }
    }
}

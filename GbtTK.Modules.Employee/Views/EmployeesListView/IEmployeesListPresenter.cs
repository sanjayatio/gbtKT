using System;
using Microsoft.Practices.Composite.Events;

namespace GbtTK.Modules.Employee
{
    public interface IEmployeesListPresenter
    {
        event EventHandler<DataEventArgs<BusinessEntities.Employee>> EmployeeSelected;

        IEmployeesListView View { get; set; }
    }
}

//===================================================================================
using System;
using System.Collections.ObjectModel;
using Microsoft.Practices.Composite.Events;

namespace GbtTK.Modules.Employee
{
    public interface IEmployeesListView
    {
        event EventHandler<DataEventArgs<BusinessEntities.Employee>> EmployeeSelected;

        ObservableCollection<BusinessEntities.Employee> Model { get; set; }
    }
}

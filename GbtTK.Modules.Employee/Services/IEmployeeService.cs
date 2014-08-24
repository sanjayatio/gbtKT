using System.Collections.ObjectModel;

namespace GbtTK.Modules.Employee.Services
{
    public interface IEmployeeService
    {
        ObservableCollection<BusinessEntities.Employee> RetrieveEmployees();
    }
}

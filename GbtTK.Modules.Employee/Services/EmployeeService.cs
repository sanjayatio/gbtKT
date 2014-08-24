using System.Collections.ObjectModel;

namespace GbtTK.Modules.Employee.Services
{
    public class EmployeeService : IEmployeeService
    {
        public ObservableCollection<BusinessEntities.Employee> RetrieveEmployees()
        {
            ObservableCollection<BusinessEntities.Employee> employees = new ObservableCollection<BusinessEntities.Employee>();

            employees.Add(new BusinessEntities.Employee(1) { FirstName = "John", LastName = "Smith", Phone = "+1 (425) 555-0101", Email = "john.smith@example.com", Address = "One Microsoft Way", City = "Redmond", State = "WA" });
            employees.Add(new BusinessEntities.Employee(2) { FirstName = "Bonnie", LastName = "Skelly", Phone = "+1 (425) 555-0105", Email = "bonnie.skelly@example.com", Address = "One Microsoft Way", City = "Redmond", State = "WA"});

            return employees;
        }
    }
}

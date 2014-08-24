using GbtTK.Modules.Employee.PresentationModels;

namespace GbtTK.Modules.Employee
{
    public interface IEmployeesDetailsView
    {
        EmployeesDetailsPresentationModel Model { get; set; }
    }
}

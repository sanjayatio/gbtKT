namespace GbtTK.Modules.Employee
{
    public interface IEmployeesDetailsPresenter
    {
        IEmployeesDetailsView View { get; set; }

        void SetSelectedEmployee(BusinessEntities.Employee employee);
    }
}

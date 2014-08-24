using System.Collections.ObjectModel;

namespace GbtTK.Modules.Project.Services
{
    public interface IProjectService
    {
        ObservableCollection<BusinessEntities.Project> RetrieveProjects(int employeeId);
    }
}

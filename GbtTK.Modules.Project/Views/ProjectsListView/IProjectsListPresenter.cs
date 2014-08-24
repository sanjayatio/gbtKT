namespace GbtTK.Modules.Project
{
    public interface IProjectsListPresenter
    {
        IProjectsListView View { get; set; }
        void SetProjects(int employeeId);
    }
}

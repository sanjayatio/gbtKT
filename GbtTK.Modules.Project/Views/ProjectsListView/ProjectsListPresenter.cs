using GbtTK.Modules.Project.Services;

namespace GbtTK.Modules.Project
{
    public class ProjectsListPresenter : IProjectsListPresenter
    {
        private readonly IProjectService projectService;

        public ProjectsListPresenter(IProjectsListView view, IProjectService projectService)
        {
            this.View = view;
            this.projectService = projectService;
        }

        public IProjectsListView View { get; set; }

        public void SetProjects(int employeeId)
        {
            this.View.Model = new ProjectsListPresentationModel
                                  {
                                      Projects = this.projectService.RetrieveProjects(employeeId)
                                  };
        }
    }
}

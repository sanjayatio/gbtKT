using Microsoft.Practices.Composite.Modularity;
using Microsoft.Practices.Unity;
using GbtTK.Modules.Project.Services;

namespace GbtTK.Modules.Project
{
    public class ProjectModule : IModule
    {
        private readonly IUnityContainer container;

        public ProjectModule(IUnityContainer container)
        {
            this.container = container;
        }

        public void Initialize()
        {
            this.RegisterViewsAndServices();
        }

        protected void RegisterViewsAndServices()
        {
            this.container.RegisterType<IProjectService, ProjectService>(new ContainerControlledLifetimeManager());

            this.container.RegisterType<IProjectsListView, ProjectsListView>();
            this.container.RegisterType<IProjectsListPresenter, ProjectsListPresenter>();
        }
    }
}
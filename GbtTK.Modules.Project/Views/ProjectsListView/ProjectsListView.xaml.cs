using System.Windows.Controls;

namespace GbtTK.Modules.Project
{
    /// <summary>
    /// Interaction logic for ProjectsListView.xaml
    /// </summary>
    public partial class ProjectsListView : UserControl, IProjectsListView
    {
        public ProjectsListView()
        {
            InitializeComponent();
        }

        public ProjectsListPresentationModel Model
        {
            get { return this.DataContext as ProjectsListPresentationModel; }
            set { this.DataContext = value; }
        }
    }
}

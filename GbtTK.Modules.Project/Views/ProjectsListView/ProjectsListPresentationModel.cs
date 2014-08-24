using System.Collections.ObjectModel;

namespace GbtTK.Modules.Project
{
    public class ProjectsListPresentationModel
    {
        public ObservableCollection<BusinessEntities.Project> Projects { get; set; }

        public static string HeaderInfo
        {
            get { return "Current Projects"; }
        }
    }
}
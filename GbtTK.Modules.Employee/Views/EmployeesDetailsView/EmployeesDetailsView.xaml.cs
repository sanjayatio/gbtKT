using System.Windows.Controls;
using GbtTK.Modules.Employee.PresentationModels;

namespace GbtTK.Modules.Employee
{
    /// <summary>
    /// Interaction logic for EmployeesDetailsView.xaml
    /// </summary>
    public partial class EmployeesDetailsView : UserControl, IEmployeesDetailsView
    {
        public EmployeesDetailsView()
        {
            InitializeComponent();
        }

        public EmployeesDetailsPresentationModel Model
        {
            get { return this.DataContext as EmployeesDetailsPresentationModel; }
            set { this.DataContext = value; }
        }

    }
}

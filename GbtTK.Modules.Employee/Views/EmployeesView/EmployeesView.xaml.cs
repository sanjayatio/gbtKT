using System.Windows.Controls;

namespace GbtTK.Modules.Employee
{
    /// <summary>
    /// Interaction logic for EmployeesView.xaml
    /// </summary>
    public partial class EmployeesView : UserControl, IEmployeesView
    {
        public EmployeesView()
        {
            InitializeComponent();
        }

        public void SetHeader(IEmployeesListView employeesListView)
        {
            this.HeaderPanel.Content = employeesListView;
        }
    }
}

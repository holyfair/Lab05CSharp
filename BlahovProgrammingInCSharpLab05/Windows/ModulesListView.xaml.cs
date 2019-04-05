using BlahovProgrammingInCSharpLab05.Models;
using BlahovProgrammingInCSharpLab05.ViewModels;
using System.Windows;

namespace BlahovProgrammingInCSharpLab05.Windows
{
    /// <summary>
    /// Логика взаимодействия для ModulesListView.xaml
    /// </summary>
    public partial class ModulesListView : Window
    {
        public ModulesListView(MyProcess process)
        {
            InitializeComponent();
            DataContext = new ModulesListViewModel(process);
        }
    }
}

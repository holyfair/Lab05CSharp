using BlahovProgrammingInCSharpLab05.Tools.Managers;
using BlahovProgrammingInCSharpLab05.ViewModels;
using System.ComponentModel;
using System.Windows;

namespace BlahovProgrammingInCSharpLab05
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ProcessesListViewModel();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            StationManager.CloseApp();
        }
    }
}

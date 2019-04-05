using BlahovProgrammingInCSharpLab05.Models;
using BlahovProgrammingInCSharpLab05.ViewModels;
using System.Windows;

namespace BlahovProgrammingInCSharpLab05.Windows
{
    /// <summary>
    /// Логика взаимодействия для ThreadsListView.xaml
    /// </summary>
    public partial class ThreadsListView : Window
    {
        public ThreadsListView(MyProcess process)
        {
            InitializeComponent();
            DataContext = new ThreadsListViewModel(process);
        }
    }
}

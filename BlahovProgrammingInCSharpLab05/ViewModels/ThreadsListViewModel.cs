using BlahovProgrammingInCSharpLab05.Models;
using System.Diagnostics;

namespace BlahovProgrammingInCSharpLab05.ViewModels
{
    internal class ThreadsListViewModel
    {
        public ProcessThreadCollection ProcessThreads { get; private set; }

        public ThreadsListViewModel(MyProcess process)
        {
            ProcessThreads = process.Process.Threads;
        }
    }
}

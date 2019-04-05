using BlahovProgrammingInCSharpLab05.Models;
using System.Diagnostics;

namespace BlahovProgrammingInCSharpLab05.ViewModels
{
    internal class ModulesListViewModel
    {
        public ProcessModuleCollection ProcessModules { get; private set; }

        public ModulesListViewModel(MyProcess process)
        {
            ProcessModules = process.Process.Modules;
        }
    }
}

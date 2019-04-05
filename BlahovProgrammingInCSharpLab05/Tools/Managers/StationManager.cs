using System;
using System.Windows;

namespace BlahovProgrammingInCSharpLab05.Tools.Managers
{
    internal static class StationManager
    {
        public static event Action StopThreads;

        internal static void CloseApp()
        {
            MessageBox.Show("ShutDown");
            try
            {
                StopThreads?.Invoke();
            }
            catch
            {

            }
            Environment.Exit(1);
        }
    }
}

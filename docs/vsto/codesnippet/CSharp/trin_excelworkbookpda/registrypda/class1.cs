using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//<snippet4>
using Microsoft.VisualStudio.Tools.Applications.Deployment;
//</snippet4>

namespace RegistryPDA 
{
//<snippet5>
    public class RegistryPDA : IAddInPostDeploymentAction
// </snippet5>
    {
//<snippet6>
        public void Execute(AddInPostDeploymentActionArgs args)
        {

            switch (args.InstallationStatus)
            {
                case AddInInstallationStatus.InitialInstall:
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\VSTO Runtime Setup\\v4");
                    key.SetValue("RegKeyString", "Post-Deployment Action Test");
                    key.Close();
                    break;
                case AddInInstallationStatus.Uninstall:
                    Microsoft.Win32.Registry.LocalMachine.DeleteSubKey("SOFTWARE\\Microsoft\\VSTO Runtime Setup\\v4\\RegKeyString");
                    break;
            }
        }
//</snippet6>
    }
}

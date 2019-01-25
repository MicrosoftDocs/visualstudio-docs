using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// <snippet7>
// <snippet1>
using Microsoft.VisualStudio.Tools.Applications.Deployment;
using Microsoft.VisualStudio.Tools.Applications;
using System.IO;
// </snippet1>

namespace FileCopyPDA
{
// <snippet2>
    public class FileCopyPDA : IAddInPostDeploymentAction
// </snippet2>
    {
// <snippet3>
        public void Execute(AddInPostDeploymentActionArgs args) 
        {
            string dataDirectory = @"Data\ExcelWorkbook.xlsx";
            string file = @"ExcelWorkbook.xlsx";
            string sourcePath = args.AddInPath;
            Uri deploymentManifestUri = args.ManifestLocation;
            string destPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string sourceFile = System.IO.Path.Combine(sourcePath, dataDirectory);
            string destFile = System.IO.Path.Combine(destPath, file);

            switch (args.InstallationStatus)
            {
                case AddInInstallationStatus.InitialInstall:
                case AddInInstallationStatus.Update:
                    File.Copy(sourceFile, destFile);
                    ServerDocument.RemoveCustomization(destFile);
                    ServerDocument.AddCustomization(destFile, deploymentManifestUri);
                    break;
                case AddInInstallationStatus.Uninstall:
                    if (File.Exists(destFile))
                    {
                        File.Delete(destFile);
                    }
                    break;
            }
        }
// </snippet3>
    }
}
// </snippet7>

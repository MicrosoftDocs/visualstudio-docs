---
title: "Troubleshooting Office Solution Deployment | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "ClickOnce deployment [Office development in Visual Studio], troubleshooting"
  - "Office development in Visual Studio, troubleshooting"
  - "deploying applications [Office development in Visual Studio], troubleshooting"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Troubleshooting Office Solution Deployment
  This topic contains information about how to solve common problems that you might encounter when you deploy Office solutions.  
  
 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]  
  
## Troubleshooting Office Solutions by Using the Event Viewer  
 You can use the event viewer in Windows to see error messages that are captured by the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] when you install or uninstall Office solutions. You can use these messages from the event logger to resolve installation and deployment problems. For more information, see [Event Logging for Office Solutions](../vsto/event-logging-for-office-solutions.md).  
  
## Changing the Assembly Name Causes Conflicts  
 If you change the **Assembly Name** value in the **Application** page of the **Project Designer** after you've already deployed a solution, the publishing tools will modify the Setup package to have one Setup.exe file and two deployment manifests. If you deploy two manifest files, the following conditions might occur:  
  
-   If the end user installs both versions, the application will load both VSTO Add-ins.  
  
-   If the VSTO Add-in was installed before the assembly name was changed, the end user will never receive updates.  
  
 To avoid these conditions, don't change the solution's **Assembly Name** value after you deploy the solution.  
  
## Checking for Updates Takes a Long Time  
 Visual Studio 2010 Tools for Office Runtime provides a registry entry that administrators can use to set the time-out value for downloading the manifests and the solution.  
  
#### To set the time-out value  
  
1.  In the registry, navigate to the following key:  
  
     HKEY_CURRENT_USER\Software\Microsoft\VSTA  
  
2.  In the **AddInTimeout** subkey, set the time-out value in milliseconds.  
  
     If the **AddInTimeout** subkey doesn't exist, create it as a DWORD.  
  
## Can't Update or Publish to a Network File Share  
 Office solutions that are on a network file share might display a misleading message during updates if the solution's Setup.exe file is locked in a process while the update is being published. The message might say the following: "Unable to add 'setup.exe' to the Web. The file 'setup.exe' already exists in this Web."  
  
 To help prevent file locking, you can make the share read-only to the end users. However, if documents are on the share, they will also become read-only to the end users.  
  
## Prerequisites for Microsoft Office Aren't Installed  
 You can add the .NET Framework, the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)], and the Office primary interop assemblies to your Setup package as prerequisites that are deployed with your Office solution. For information about how to install the primary interop assemblies, see [Configuring a Computer to Develop Office Solutions](../vsto/configuring-a-computer-to-develop-office-solutions.md) and [How to: Install Office Primary Interop Assemblies](../vsto/how-to-install-office-primary-interop-assemblies.md).  
  
## Publishing Using 'Localhost' Can Cause Installation Problems  
 When you use "http://localhost" as the publish or installation location for document-level solutions, the **Publish Wizard** doesn't convert the string to the real computer name. In this case, the solution must be installed on the development computer. To make deployed solutions use IIS on the development computer, use the fully qualified name for all HTTP/HTTPS/FTP locations instead of localhost.  
  
## Cached Assemblies Are Loaded Instead of Updated Assemblies  
 Fusion, the .NET Framework assembly loader, loads the cached copy of assemblies when the project output path is on a network file share, the assembly is signed with a strong name, and the assembly version of the customization doesn't change. If you update an assembly that meets these conditions, the update won't appear the next time that you run the project because the cached copy is loaded.  
  
 You can configure Visual Studio so that Fusion will download assemblies every time that the project is run.  
  
#### To download assemblies instead of loading cached copies  
  
1.  On the menu bar, choose **Project**, *ProjectName***Properties**.  
  
2.  On the **Application** page, choose **Assembly Information**.  
  
3.  In the first **Assembly Version** box, enter an asterisk (\*), and then choose the **OK** button.  
  
 After you change the assembly version, you can continue to sign your assembly with a strong name, and Fusion will load the most recent version of the customization.  
  
## Installation Fails When the URI Has Characters That Are't US-ASCII  
 When you publish an Office solution to an HTTP/HTTPS/FTP location, the path can't have any Unicode characters that aren't in US-ASCII. Such characters can cause inconsistent behavior in the Setup program. Use US-ASCII characters for the installation path.  
  
## Prompt to Manually Uninstall Appears When You Publish and Install a Solution on the Development Computer  
 When you build an Office solution, the built version is automatically registered. If you have previously published and installed the same solution to your development computer, [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] detects that the installation path for the published version and the built version are different after the solution is next built, rebuilt, or published. The error message says "the customization cannot be installed because another version is currently installed and cannot be upgraded from this location." The registry keys are updated whenever a solution is rebuilt. Therefore, you must uninstall the previous version before you publish, debug, or run the new version.  
  
 To prevent the message from appearing, create another user account on your development computer to test your deployment. As an alternative, you can uninstall the version from the list of installed programs on the computer before you next publish, debug, or rebuild the solution.  
  
## Uncaught Exception or Method Not Found Error When You Install a Solution  
 When you install Office solutions by opening the deployment manifest (a .vsto file), Office application, document, or workbook, error messages for the following conditions might appear:  
  
-   Method not found.  
  
-   MissingMethodException.  
  
-   Uncaught exception.  
  
 To prevent these error messages, install the solution by running the Setup program.  
  
 When you install the solution without running the Setup program, the installer doesn't check for or install prerequisites. The Setup program checks for the correct version of prerequisites and installs them as necessary.  
  
## Manifest Registry Keys for Add-ins Change After an InstallShield Limited Edition Project Is Built  
 The manifest registry key that's part of an VSTO Add-in Setup program sometimes changes from .vsto to .dll.manifest when you build an InstallShield Limited Edition project.  
  
 To work around this issue, create the InstallShield Limited Edition project in a different solution, or use CompanyName.AddinName as the value of the registry key that contains the name of the VSTO Add-in.  
  
## The ClickOnce Installer for Your Office Solution Doesn't Install the Primary Interop Assemblies  
 When you run the Setup program that ClickOnce creates for your Office solution, the installer for the Office primary interop assemblies (PIAs) runs only if no PIAs are already installed.  
  
 If the Setup program doesn't install the PIAs correctly, install them manually by running the installer file that's named o2007pia.msi from the installation directory.  
  
## Reinstalling Office Solutions Causes an Argument Out Of Range Exception  
 When you reinstall an Office solution, a <xref:System.ArgumentOutOfRangeException> exception might appear with the following error message: Specified argument was out of the range of valid values.  
  
 This situation occurs if the casing for the URL for the installation location is different. For example, this error would appear if you installed an Office solution from [http://fabrikam.com/ExcelSolution.vsto](http://fabrikam.com/ExcelSolution.vsto) the first time and then used [http://fabrikam.com/excelsolution.vsto](http://fabrikam.com/excelsolution.vsto) the second time.  
  
 To prevent the message from appearing, use the same casing when you install Office solutions.  
  
## Can't Install a ClickOnce Solution by Opening the Deployment Manifest from the Web  
 Users can install Office solutions by opening the deployment manifest from the web. However, a some installations  of Internet Information Services (IIS) blocks the .vsto file name extension. You must define the MIME type  in IIS before you use it to deploy an Office solution.  
  
 For information about how to define the MIME type in IIS 6, see [Configure MIME Types (IIS 6.0)](http://www.microsoft.com/technet/prodtechnol/WindowsServer2003/Library/IIS/cd72c0dc-c5b8-42e4-96c2-b3c656f99ead.mspx?mfr=true).  
  
 For information about how to define the MIME type in IIS 7, see [Add a MIME Type (IIS7).](http://technet.microsoft.com/library/cc725608(WS.10).aspx).  
  
 Set the extension to **.vsto** and the MIME type to **application/x-ms-vsto**.  
  
## See Also  
 [Troubleshooting ClickOnce Deployments](/visualstudio/deployment/troubleshooting-clickonce-deployments)   
 [Deploying an Office Solution](../vsto/deploying-an-office-solution.md)  
  
  
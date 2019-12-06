---
title: "Troubleshooting Setup and Deployment Projects | Microsoft Docs"
ms.date: "11/01/2012"
ms.topic: "conceptual"
helpviewer_keywords:
  - "packaging"
  - "packaging, overview"
ms.workload:
  - "multiple"
---
customizing-windows-installer-packages

# Troubleshooting Setup and Deployment Projects

The topics in this section cover various problems that you might encounter when you create deployment projects and deploy applications.

## The .NET Framework version required by the Setup project is different than the .NET Framework version targeted by the application

Setup projects have a launch condition that can check for a particular version of the .NET Framework version. However, the version may not be the same as the target .NET Framework that the application uses. For example, your application may target .NET Framework 2.0, but the launch condition in the Setup project may look for and install the .NET Framework 3.5. Another example is that a Visual Studio project template may target .NET Framework 4 Client Profile, but the Setup project has a launch condition to check for and install .NET Framework 4.

To change this default behavior, follow these steps:

1.  In **Solution Explorer**, click the Setup project.

2.  On the **View** menu, point to **Editor**, and then click **Launch Conditions**.

3.  Click **.NET Framework**.

4.  In the Properties window, change the **Version** property to the version of the .NET Framework that you want the Setup project to check for and install.

Make sure that the Setup.exe program also checks for and installs the correct version of the .NET Framework.

## Cannot install .NET Framework 3.5 SP1 on Windows Server 2008 R2 or Windows 7

You can configure Setup projects to include .NET Framework 3.5 SP1 as a prerequisite. However, installing this prerequisite on a Windows Server 2008 R2 or Windows 7 computer displays the following error message: "You must use the Role Management Tool to install or configure Microsoft .NET Framework 3.5 SP1." Windows Server 2008 R2 has .NET Framework 3.5 SP1 as an optional component of the operating system, but by default, this prerequisite is turned off. For more information, see [Which Version of .NET is Built into Windows?](http://go.microsoft.com/fwlink/?linkid=184110)

To work around this error, change the .NET Framework 3.5 SP1 bootstrapper package.

1.  Create an executable program that runs this command line "ocsetup Netfx3".

2.  Navigate to the %ProgramFiles(x86)%\\Microsoft SDKs\\Windows\\v7.0A\\Bootstrapper\\Packages\\DotNetFX35SP1 folder.

3.  Copy the executable program to the DotNetFX35SP1 folder.

4.  Navigate to the **en** folder and open the package.xml with admininistrator privilege.

5.  Add a \<Command\> element inside the \<Commands\> section to run the executable program.

## Errors when using the Microsoft Visual Studio Registry Capture Utility on Windows 7

If you use the Microsoft Visual Studio Registry Capture Utility (regcap.exe) on a computer running Windows 7, you may see the following error: "Microsoft Visual Studio Registry Capture Utility has stopped working." The installer project may build, but later, the dll is not installed.

To work around this error, follow these steps:

1.  Navigate to %ProgramFiles(x86)%\\Microsoft Visual Studio 10.0\\Common7\\Tools\\Deployment.

2.  Right-click on regcap.exe, and then click **Properties**.

3.  Click **Compatibility**.

4.  Select the checkbox under **Compatibility** mode.

## Dependencies are not detected with Visual C++ setup projects

If you add a setup project to a Visual C++ solution, the dependencies in the Visual C++ solution may not be detected if the folder path has spaces in the name. As a workaround, rename projects to remove the space or manually add the dependencies. For example, rename the **Documents\\Visual Studio 2010\\Projects** to **Documents\\VisualStudio2010\\Projects**.

## Cannot build Setup projects in Visual Studio with source control

When you build Setup projects in Visual Studio 2008, you may see errors such as "The command you are attempting cannot be completed because the file filename.vdproj is under source control and cannot be checked out." Setup projects do not auto-checkout files from source control.

## Operating System Support

The Visual Studio bootstrapper and Visual Studio Installer (Setup projects) are not supported on Windows Server 2008 Server Core or Windows Server 2008 R2 Server Core, which provide a low-maintenance server environment with limited functionality. For example, the Server Core installation option only supports the .NET Framework 3.5 Server Core profile, so Visual Studio features that depend on the full .NET Framework cannot run. For more information, see [Server Core](https://msdn.microsoft.com/en-us/library/ms723891).

## Cannot install managed custom actions

When you install a managed custom action, you may see an error message stating that the .installstate file is missing. This occurs if the managed custom action does not implement the Install action. The Install action creates the .installstate file, and the other actions update the file.

To work around this error, implement the Install, Uninstall, Commit, and Rollback actions in the custom action.

## Cannot install .NET Framework 3.5 SP1 language packs for a locale if Visual Studio 2008 is using a different locale

When you select .NET Framework 3.5 SP1 as a prerequisite in Setup projects, Visual Studio does not generate a bootstrapper or Setup program to install the language pack for a different locale. For example, if you are using a non-Japanese version of Visual Studio, the Setup project does not include the .NET Framework 3.5 SP1 Japanese language pack.

To work around this error and create a Japanese redistributable for the .NET Framework 3.5 SP1, create a new ja directory in %ProgramFiles%\\Microsoft SDKs\\Windows\\v7.0A\\Bootstrapper\\Packages\\DotNetFX35SP1 directory. The ja directory should contain a eula.rtf and package.xml file.

## Cannot install language packs if .NET Framework 3.5 SP1 is already installed

If the core .NET Framework 3.5 SP1 is already installed on a computer, the .NET Framework 3.5 SP1 language packs cannot install. For example, if a computer already has .NET Framework 3.5 SP1 installed, you cannot install the .NET Framework 3.5 SP1 Japanese language pack as a prerequisite in a different application installer.

As a workaround, create a bootstrapper package just for the language packs. In the bootstrapper package, add a dependency on .NET Framework 3.5 SP1 so that the language packs install only if the core .NET Framework is already installed. Alternatively, you can install the language packs manually.

## 64-bit managed custom actions throw a System.BadImageFormatException exception

If you add a 64-bit managed custom action to a Setup project, the Visual Studio build process embeds a 32-bit version of InstallUtilLib.dll into the MSI as InstallUtil. In turn, the 32-bit .NET Framework is loaded to run the 64-bit managed custom action and causes a [BadImageFormatException](https://msdn.microsoft.com/en-us/library/92hkyaf2) exception.

For the workaround, replace the 32-bit InstallUtilLib.dll with the 64-bit version.

1.  Open the resulting .msi in Orca from the Windows Installer SDK.

2.  Select the Binary table.

3.  Double click the cell \[Binary Data\] for the record InstallUtil.

4.  Make sure "Read binary from filename" is selected and click the Browse button.

5.  Browse to %WINDIR%\\Microsoft.NET\\Framework64\\v2.0.50727.
    

    > [!NOTE]
    > <P>The Framework64 directory is only installed on 64-bit platforms and corresponds to the 64-bit processor type.</P>


6.  Select InstallUtilLib.dll.

7.  Click the Open button.

8.  Click the OK button.

For more information, see [64-bit Managed Custom Actions with Visual Studio](http://go.microsoft.com/fwlink/?linkid=165484).

## Creating a path for a custom dialog box and text box

If you create a custom dialog box with a text box, the "Installation Folder" dialog box should be placed after the custom dialog box. Then, the directory value will be propagated automatically. Otherwise, if the order of the dialog box and "Installation Folder" dialog box are reversed, the directory value must be propagated manually.

## Extra build errors appear in the output window

When you have a specific build error, you may also see generic error messages such as "General failure building bootstrapper" or "Unrecoverable build error." Disregard these generic error messages and address the specific error.

## Previously excluded files are included again when the solution is re-opened

When you exclude a file from a Setup project, you may see that the file is included again after you close and re-open the solution. This may occur if there are two copies of the same DLL file from two different source locations.

To work around this error, change the **Copy Local** property on one of the files:

1.  In **Solution Explorer**, click on the DLL reference that you want to remove.

2.  On the **View** menu, click **Properties Window**.

3.  Change the **Copy Local** property to False.

## Setup Projects failed to build with 'Not enough storage is available to complete this operation' error

When you add large files to a Setup project, the following error appears after you try to build the Setup project: "Not enough storage is available to complete this operation" even if the local hard disk has available disk space. There may also be an increase of virtual memory usage during the build process.

To work around this error, add more RAM to the build computer, or try this workaround:

1.  In the project, add a file that has the same name as the large file.

2.  In the project properties page, set to installer to Package as Loose Uncompressed files.

3.  Build.

4.  Copy the full-sized large files to the build location.

## Setup project does not update modified files

Even if you configure your Setup project to remove earlier versions of files, Windows Installer does not replace files that have been modified or replaced by the user. For more information, see [Neither File Has a Version with File Hash Check](https://msdn.microsoft.com/en-us/library/aa370532).

## Cannot use a launch condition to check for the .NET Framework 3.5 SP1

The prerequisite detection for the .NET Framework 3.5 SP1 is not supported with MSI-only scenarios. Instead, you must configure the Setup.exe bootstrapper to check for and install the .NET Framework 3.5 SP1.

## How to create a 64-bit bootstrapper that includes the .NET Framework

Including .NET Framework 3.0 as a prerequisite and installing the Setup.exe bootstrapper on 64-bit computers shows an error message that 64-bit operating systems are not supported.

The .NET Framework 3.5 supports both 32-bit and 64-bit operating systems. If your application targets both 32-bit and 64-bit operating systems, select the .NET Framework 3.5 in the Prerequisites Dialog Box.

## How do I install the bootstrapper packages for SQL 2008 and .NET Framework 3.5 SP1?

The bootstrapper packages for SQL 2008 and the .NET Framework 3.5 SP1 can be installed to your development computer by installing the Visual Studio Express Editions. For Visual Studio 2010, the SQL 2008 and the .NET Framework 3.5 SP1 bootstrapper packages are included, and this workaround is not necessary.

## Backslash in textbox causes invalid directory or URL exception

If your custom action relies on customers typing a path of an installation folder, you may see a [ArgumentException](https://msdn.microsoft.com/en-us/library/3w1b3114) error message. This may be related to an invalid directory or URL.

To prevent this error message, replace the backslash in the **Edit1** property and **Edit1Value** textbox with a space: /name="\[TARGETDIR\] ". Then, parse the value and create a fully qualified path using the [Combine](https://msdn.microsoft.com/en-us/library/dd781134) method.

## Cannot add a newline (\\n) to an error message in a Setup project

If you write an error message in a Setup project, the newline character cannot be added in the Setup project or with Orca.exe. Instead, you can add it by using the Windows Installer API in a post-build action with the following command: "INSERT INTO \`Property\` (\`Property\`, \`Value\`) VALUES 'ERRORMESSAGELINES', 'first\\r\\nnext\\r\\nlast')". For more information about using a post-build action, see [http://go.microsoft.com/fwlink/?LinkId=150770](http://go.microsoft.com/fwlink/?linkid=150770).

## Cannot select .NET Framework 2.0 SP1 or .NET Framework 3.0 SP1 in the Prerequisites Dialog Box

The Prerequisites Dialog Box does not show .NET Framework 2.0 SP1 or .NET Framework 3.0 SP1 in the list of applications to install if these are not already installed. These are not available as a stand-alone redistributable file. To install these as prerequisites on end user computers, select .NET Framework 3.5 in the Prerequisites Dialog Box.

## Default value in textbox overwrites command-line parameters

If you run the installer by using the \\qb flag and pass in command-line parameters to set properties in a user dialog box, these parameters may be overwritten. To prevent the default value of a property from being overwritten by a customer, change the msi file by using Orca.exe.

1.  Set the edit field value on the dialog to its property name. For example, set the **Edit1Value** property to \[EDITB1\].

2.  Build the MSI in Visual Studio.

3.  Edit the MSI using ORCA and put the default value of the property in the Property table.

4.  Save the MSI.

You can also use a post-build action to make this change. For more information about using a post-build action, see [http://go.microsoft.com/fwlink/?LinkId=150770](http://go.microsoft.com/fwlink/?linkid=150770).

## Assembly dependencies were not detected

When a project output group, assembly, or merge module are added to a deployment project, any dependent assemblies are automatically detected and added to the project. We recommend that you add a project output group that contains the assembly because the deployment tools can more easily detect dependencies for a project output group.

If a dependent assembly is loaded at run time by using code, it cannot be detected by the deployment tools. You should avoid loading assemblies from code, or you can manually add the dependent assemblies to your deployment project. The following table lists problems where dependencies cannot be detected and their solutions.

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Dependency problem</p></th>
<th><p>Solution</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>The project references a component that should only be installed as part of another product.</p></td>
<td><ul>
<li><p>Exclude the component from the deployment project.</p></li>
<li><p>Add a launch condition to check for the component on the target computer. If the component is not found, stop the installation.</p></li>
</ul></td>
</tr>
<tr class="even">
<td><p>The project references an unmanaged component that does not expose all of its dependencies.</p></td>
<td><ul>
<li><p>Detect dependencies and include them as prerequisites.</p></li>
</ul></td>
</tr>
<tr class="odd">
<td><p>The project references an assembly that has a dependency on an unmanaged component.</p></td>
<td><ul>
<li><p>Include the unmanaged component as a prerequisite in a chainer or bootstrapper.</p></li>
</ul></td>
</tr>
</tbody>
</table>

## An MFC application is not localized when it is installed on a computer where the locale is not English

When deploying an MFC application by using a Visual Studio deployment project, dependencies for the localized merge modules Mfc\_loc\_e.msm and Mfc\_loc\_fe.msm are not detected. The merge modules are included with Visual C++; the default installation location is \\Program Files\\Common\\Merge Modules. In order to distribute a localized MFC application, you have to manually add the two merge modules to your deployment project.

## Cannot find files on a Web server after they are installed

When installing a Web Setup to a Web server, the **VirtualDirectory** property for the Web Application folder and any Web Custom folders determines where files included in those folders will be installed relative to the Web root. If this property is left blank, the files will be installed in the Web root folder (inetpub\\wwwroot).

## How do I install a Web application to the Web server root directory?

By default, when you install a Web application using a Web Setup deployment project, files are installed to a folder that has the same name as the deployment project directly beneath the Web root folder. The **VirtualDirectory** property of the Web Application folder determines where the files are installed. To install to the Web root directory, change the **VirtualDirectory** property to null (delete the default value).

## How do I turn off dependency analysis?

Unfortunately, there is no direct way to turn off dependency-analysis searching and resolution. However, there is a work-around: you can clear the **Include standard search paths** option in the dialog box that comes up when you click the **SearchPath** property.

There are several additional points to consider:

  - You have to add the files by using the **Add File** command (from the **Project** menu, select **Add**, and then **File**). If you use Add **Project Output** (from the **Project** menu, select **Add**, and then **Project Output**), dependencies reported from the code project will be included.

  - When you build, you may see one or more **Unable to find dependency** warnings, but these can be ignored in this case.

  - If you only want to turn off dependency analysis for some files, you can put those files in a merge module project with standard search paths turned off. Then use **Add Merge Module** (from the **Project** menu, select **Add**, and then **Add Merge Module**) to include the .msm in a regular setup project with standard search paths turned on.

## How do I turn off repair for a file that users are expected to modify or delete?

Visual Studio creates advertised shortcuts so that when the program is started it verifies that all its files exist. To change this behavior and cause it not to repair the file, select the files in the setup project and change the **Condition** property to **NOT REINSTALL** so that the file will not get reinstalled on a repair and its **Transitive** property to **TRUE** so that the condition is re-evaluated. This will cause the Installer to flash on the screen the first time after the file is deleted, as it verifies that the file should not be reinstalled, but you will not see the installer after that.

## How do I debug a custom action/installer class?

You can use one of the following methods:

  - Add a call in your code to System.Diagnostics.Debugger.Launch. This method opens Just-In-Time debugging and enables you to attach a new debugger to your code.

  - Add a call in your code to MessageBox.Show("Debug Me"). When the message box is shown, use Visual Studio to attach to the [MessageBox](https://msdn.microsoft.com/en-us/library/411ze57x) process. Then add breaks (for Visual C\# projects) or stops (for Visual Basic projects) in the code.

  - Set your debugging preferences to start %windir%\\Microsoft.net\\Framework\\version\\InstallUtil.exe as an external program on the Debug Page of the Project Designer. The name of the custom action assembly is the command line arguments. When you press F5, you hit your breakpoint. InstallUtil.exe will run your custom actions just as MSI does.

## Registering assemblies with COM interfaces does not work

This is a known RegAsm bug. If your assembly has a dependency, for example on another class library, RegisterCOM might not work because RegAsm is called to obtain the registration information. Because RegAsm is called in the \\obj directory, the dependency is not found, and RegAsm fails without notification. The best workaround is to add the assembly by hand from the \\bin directory. Another workaround is to use RegisterSelfReg.

Also, make sure that you manually register using RegAsm/Codebase. If your assembly is not in a shared location, it is not found unless it is in the same directory as the calling code. /Codebase enters the directory into the registry.

## How do I troubleshoot Windows Installer installations using log files?

Windows Installer logs its operations while installing programs in a log file. The log file is located in the directory where the .msi file resides.

## How do I get a log file for my installation?

There are two ways:

  - Run from the command line with the logging switch.
    
        misexec /i mysetup.msi /l*v mylog.txt

  - Save the following as a .reg file and load it into your registry.
    
        REGEDIT4
        
        [HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\Installer]
        "Logging"="voicewarmup"
        "Debug"=dword:00000007
    
    Then open your \\temp directory and sort on date. The most recent msi\*.log file is from the most recent install or uninstall.

## How do I install to a subdirectory of a previously installed product?

1.  Assume that the previously installed product, Product 1, is installed and has a file that is named MyFile.txt.

2.  Use Orca.exe (from the Windows Installer SDK) to view the File table, and find the row that represents MyFile.txt.

3.  Get the value of the Component\_ column and then open the Component Table.

4.  In the Component Table, find the row that has the Component\_ value in the Component column, and get the ComponentID. Copy this value into the Clipboard. Close Orca.exe.

5.  In your setup project, open the **Launch Conditions Editor** and add a Windows Installer Component Search. For the ComponentID property of the new search, paste the ComponentID.

6.  Copy the **Property** property. It should be something like COMPONENTEXISTS1.

7.  Open the **File System Editor** and select the Application Folder.

8.  Edit the DefaultLocation property to be something like \[COMPONENTEXISTS1\]MySubFolder (because the path in COMPONENTEXISTS1 includes a trailing '\\').

After step 6 in the previous procedure, you might want to add a Condition to the **Launch Conditions Editor** to check if the component was found, and to block install and show a message if it was not. The condition would be COMPONENTEXISTS1 (which means it is okay to run the Installer if COMPONENTEXISTS1 is not empty).

## How do I install custom Web folders to a non-default port?

To install custom Web folders to a port not designated by default, run your installation from the command line. The command must include the **Property** property values for each of your Web Custom Folders. Typically, a value would be something like NEWWEBPROPERTY1. You also need to include TARGETPORT for the Web Application Folder.

For example, if the Web server is on Port 20, your command line should resemble this:

    msiexec /i mywebsetup.msi TARGETPORT=20 NEWWEBPROPERTY1PORT=20

The previous command is for only one Web folder. If you have more than one Web folder, add more PROPERTY=VALUE pairs as specified earlier for each folder to redirect each listed folder's port to the specified port.

You might want to remove the **Installation Address** dialog box, because if someone changes the port in the user interface during installation, the Custom Web Folders will use the command-line value.

## How do I install to the root of a Web site?

To install to the root of a Web site, for example, c:\\inetpub\\wwwroot, set the VirtualDirectory to an empty string, either in the Web Setup project, or during installation.

## How do I install a ServicedComponent into the GAC and configure it in the COM+ catalog?

If you try to install a ServicedComponent into the GAC and configure it in the COM+ catalog, you might receive the following compilation error:

    "Unable to build custom action named 'Primary output from RegServer (Active)' because the file's Folder property is set to Global Assembly Cache."

This installation is not supported, because assemblies in the GAC are not always available (committed to the GAC) when the custom actions are run.

The workaround is to put your code into different files and put your custom action code into a file that is not going to the GAC. Sometimes you cannot distribute the code in this manner.

## How do I create an uninstall link on my shortcut?

1.  In your Setup project's directory, create a new Uninstall.bat file.

2.  In your Setup project, copy the **ProductCode** property (a value like \[12345678-1234-1234-1234-123412341234\]).

3.  Edit Uninstall.bat so that it has one line that contains the following, where ProductCode is the value that you copied in step 2:
    
    Msiexec /x ProductCode

4.  Add Uninstall.bat to your Setup project's application folder.

5.  Right-click Uninstall.bat and select **Create Shortcut** to create a shortcut.

6.  Put the shortcut in the appropriate **Start** menu folder in the Setup project.

7.  Rename the shortcut to something like "Uninstall \<Application Name\>."

## How do I plan the deployment of .NET Framework-based applications?

This guide will give you the information that you must have to plan and implement the effective deployment of your .NET Framework-based applications: [Deploying .NET Framework-based Applications](http://go.microsoft.com/fwlink/?linkid=100574).

## Where can I download the Windows Installer SDK?

You can download the Windows Installer SDK from the Microsoft Download Center:

[http://go.microsoft.com/fwlink/?LinkId=161393](http://go.microsoft.com/fwlink/?linkid=161393).

## Where can I get updates and help for Crystal Reports?

Updated software and merge modules can be installed from the "Downloads & Updates" page on the BusinessObjects.com Web site:

<http://support.businessobjects.com/fix/downloads_updates.asp>

## How do I resolve "Unrecoverable Build Error" error messages?

If you are receiving an "Unrecoverable Build Error" error message when you build Setup and Deployment Projects, read this article:

"PRB: 'Unrecoverable Build Error' Error Message When You Build Setup and Deployment Projects" at <http://support.microsoft.com/?id=329214>.

## How do I resolve validation error messages?

If you are receiving error messages such as An error occurred when validating. HRESULT = '80040155' see "PRB: "Unrecoverable Build Error" Error Message When You Build Setup and Deployment Projects" at <http://support.microsoft.com/?id=329214> and follow the steps for "Missing Registrations."

## How to modify IIS during deployment with custom actions

The article "Modifying Internet Information Services During Deployment with Custom Actions" at [http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dv\_vstechart/html/vbtchUsingCustomActionsToModifyInternetInformationServerDuringDeployment.asp?frame=true](http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dv_vstechart/html/vbtchusingcustomactionstomodifyinternetinformationserverduringdeployment.asp?frame=true) explains how to fix common problems. This includes the following:

  - How to modify settings for an IIS folder that are not available on a Web Folder in the File System Editor

  - How to deploy a hybrid application that uses both Visual Basic 6 and Visual Basic .NET and later versions.

  - Changes in deploying applications written with Visual Studio .NET and later compared to Visual Basic 6 applications.

## How do I deploy ASP.NET applications?

For information about how to deploy an ASP.NET application using Visual Studio .NET, see [Deploying an ASP.NET App Using Visual Studio .NET](http://go.microsoft.com/fwlink/?linkid=121731).

## After installation on Windows 2000, the application fails with a warning that MDAC 2.8 is required

Any application that references the [System.Data](https://msdn.microsoft.com/en-us/library/ax3wd0k9) namespace has a dependency on Microsoft Data Access Components (MDAC) 2.8 or later versions. In most cases the file is already installed as part of the operating system. On Windows 2000 Service Pack3 and earlier, you may have to install the component with your application. You can do so by adding it to the bootstrapper package and downloading the file from Microsoft during installation. For more information, see [Application Deployment Prerequisites](application-deployment-prerequisites.md).

## How do I change the permission level for the custom actions?

By default, custom actions run with SYSTEM privileges, but you may find that the custom action requires more privileges in order to complete the task. To change this default behavior, disable the "noimpersonate" flag in the custom action. For more information, see [Custom Action In-Script Execution Options](https://msdn.microsoft.com/en-us/library/aa368069).

## Related Knowledge Base Articles

The following Knowledge Base Articles provide information about Windows Installer Deployment issues:

  - "'This Setup Does Not Contain the .NET Framework' Error Message During Visual Studio .NET Deployment" (320426) at <http://support.microsoft.com/default.aspx?scid=kb;en-us;320426>.

  - "How To Create Shortcuts for a .NET Deployment Project" (307358) at <http://support.microsoft.com/default.aspx?scid=kb;en-us;307358>

  - "BUG: 'Error Installing ODBC Driver' Error Message When You Use the Vfpodbc.msm Merge Module in a Visual Studio .NET Setup and Deployment Project" (814700) at <http://support.microsoft.com/default.aspx?scid=kb;en-us;814700>

  - "FIX: 'Unable to build custom action' Error When You Build a Setup Project" (814744) at <http://support.microsoft.com/default.aspx?scid=kb;en-us;814744>

  - "HOW TO: Deploy a Visual Basic .NET Application That Uses ADO Interop" (321688) at <http://support.microsoft.com/default.aspx?scid=kb;en-us;321688>

  - "BUG: Error 1619 When You Install a Package That Uses Web Bootstrapper" (313498) at <http://support.microsoft.com/default.aspx?scid=kb;en-us;313498>

  - "HOW TO: Deploy an Assembly to the Target Computer Global Assembly Cache (GAC)" (324168) at <http://support.microsoft.com/default.aspx?scid=kb;en-us;324168>

## See Also

#### Other Resources

[Deploying Applications and Components](choosing-a-deployment-strategy.md)

---
title: "Walkthrough: Creating a Basic Isolated Shell Application | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "Visual Studio shell, walkthroughs"
  - "Shell [Visual Studio], walkthroughs"
  - "walkthroughs [Visual Studio], isolated shell-based application"
ms.assetid: 8b12e223-aae3-4c23-813d-ede1125f5f69
caps.latest.revision: 55
ms.author: gregvanl
manager: jillfra
---
# Walkthrough: Creating a Basic Isolated Shell Application
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This walkthrough shows how to create an isolated shell solution, customize the Help About tool window, and create a setup program that installs the isolated shell.  
  
## Prerequisites  
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Visual Studio SDK](../extensibility/visual-studio-sdk.md). To deploy the isolated shell, you must also use the Visual Studio Shell (Isolated) Redistributable Package.  
  
## Creating an Isolated Shell Solution  
 This section shows how to use the Visual Studio Shell Isolated project template to create an isolated shell solution. The solution contains the following projects:  
  
- The *SolutionName*.AboutBoxPackage project, which allows you to customize the appearance of the Help/About box.  
  
- The ShellExtensionsVSIX project, which contains the source.extension.vsixmanifest file that defines the different components of the isolated shell application.  
  
- The *SolutionName* project, which produces the executable file that invokes the isolated shell application. This project contains the Shell Customization folder, which allows you to customiz the appearance and behavior of the isolated shell application.  
  
- The *SolutionName* UI project, which produces a satellite assembly that defines active menu commands and localizable strings.  
  
#### To create a basic isolated shell solution  
  
1. Open Visual Studio and create a new project.  
  
2. In the **New Project** window, expand **Other Project Types** and then **Extensibility**. Select the **Visual Studio Shell Isolated** project template.  
  
3. Name the project `MyVSShellStub` and specify a location. Make sure that **Create directory for solution** is checked, and then click **OK**.  
  
     The new solution appears in **Solution Explorer**.  
  
4. Build the solution and start debugging the isolated shell application.  
  
     The Visual Studio isolated shell appears. The title bar reads **MyVSShellStub**. The title bar icon is generated from \MyVSShellStub\Resource Files\ApplicationIcon.ico.  
  
## Customizing the Application Name and Icon  
 You may want to brand your application by using the name of your company and its logo in the title bar. The following steps show how to change the name and icon that are displayed in the custom application title bar by changing the package definition file, MyVSShellStub.Application.pkgdef.  
  
#### To customize the application name and icon  
  
1. In the MyVSShellStub project, open \Shell Customization\MyVSShellStub.Application.pkgdef.  
  
2. Change the `AppName` element value to **"AppName"="Fabrikam Music Editor"**  
  
3. To change the application icon, copy a different icon to the \MyVSShellStub\MyVSShellStub\MyVSShellStub\ directory. Rename the existing ApplicationIcon.ico file to ApplicationIcon1.ico. Rename the new file to ApplicationIcon.ico.  
  
4. Build the solution and start debugging. The isolated shell IDE appears. The title bar has your new icon next to the words **Fabrikam Music Editor**.  
  
## Customizing the Default Web Browser Home Page  
 This section shows how to change the default home page of the **Web Browser** window by changing the package definition file.  
  
#### To customize the default Web Browser home page  
  
1. In the MyVSShellStub.Application.pkgdef file, change the `DefaultHomePage` element value to "<https://www.microsoft.com>".  
  
2. Rebuild the MyVSShellStub project.  
  
3. Build the solution and start debugging.  
  
4. In **View / Other Windows**, click **Web Browser**. The **Web Browser** window displays the Microsoft Corporation home page.  
  
## Removing the Print Command  
 The .vsct file in an isolated shell UI project consists of a set of declarations of the form `<Define name=No_`*Element*`>`, where *Element* is one of the standard Visual Studio menus and commands.  
  
 If a declaration is uncommented, that menu or command is excluded from the isolated shell. Conversely, if a declaration is commented, the menu or command is included in the isolated shell.  
  
 In the following steps, you uncomment print command in your .vsct file.  
  
#### To remove the print command  
  
1. Verify that the **Print** command appears on the **File** menu in the isolated shell application.  
  
2. In the MyVSShellStubUI project, open \Resource Files\MyVSShellStubUI.vsct for editing.  
  
3. Uncomment this line:  
  
    ```  
    <!-- <Define name="No_PrintChildrenCommand"/> -->  
    ```  
  
4. This removes the print command.  
  
5. Start debugging the isolated shell application. Verify that the **File / Print** command is gone.  
  
## Removing Features from the Isolated Shell  
 You can remove some of the packages that are loaded with Visual Studio by editing the .pkgundef file if you do not want those features in your custom isolated shell application. You specify the package in one of the subkeys of the $RootKey$\Packages registry key.  
  
> [!NOTE]
> To find the GUIDs of Visual Studio features, see [Package GUIDs of Visual Studio Features](../extensibility/package-guids-of-visual-studio-features.md).  
  
 The following procedure shows how to remove the XML editor from the isolated shell.  
  
#### To remove the XML editor  
  
1. Open the MyVSShellStub.pkgundef file in the Shell Customization folder of the MyVSShellStub project.  
  
2. Uncomment the following line:  
  
     [$RootKey$\Packages\\{87569308-4813-40a0-9cd0-d7a30838ca3f}]  
  
3. Rebuild the solution and start debugging the isolated shell. Open an XML file,for example, \MyVSShellStub\MyVSShellStub\MyVSShellStubUI\MyVSShellStubUI.vsct. Verify that the XML keywords in the file are not colorized and that typing "<" on a line does not bring up XML tooltips.  
  
## Customizing the Help/About box  
 You can customize the Help/About box, which is created as part of the isolated shell project template.  
  
#### To customize the company name  
  
1. The company name, copyright information, product version, and product description are found in the MyVSShellStub.AboutBoxPackage project, in the \Properties\AssemblyInfo.cs file. Open this file.  
  
2. Change the `AssemblyCompany` value to **Fabrikam**, the `AssemblyProduct` and `AssemblyTitle` values to **Fabrikam Music Editor**, and the `AssemblyCopyright` value to **Copyright © Fabrikam 2015**:  
  
    ```  
    [assembly: AssemblyTitle("Fabrikam Music Editor")]  
    [assembly: AssemblyDescription("")]  
    [assembly: AssemblyConfiguration("")]  
    [assembly: AssemblyCompany("Fabrikam")]  
    [assembly: AssemblyProduct("Fabrikam Music Editor")]  
    [assembly: AssemblyCopyright("Copyright © Fabrikam 2015")] [assembly: AssemblyCompany("Fabrikam")]  
    [assembly: AssemblyProduct("Fabrikam Music Editor ")]  
    [assembly: AssemblyCopyright("Copyright © Fabrikam 2015”)]  
    ```  
  
3. To add a description of the product, change the `AssemblyDescription` value to **The description of Fabrikam Music editor.**:  
  
    ```  
    [assembly: AssemblyDescription("The description of Fabrikam Music editor.”)]  
    ```  
  
4. Start debugging and in the isolated shell application, open the **Help / About** box. You should see the changed strings. The title of the Help/About box is the same as the `AssemblyTitle` value in AssemblyInfo.cs.  
  
5. The properties of the **Help/About** box itself are found in the MyVSShellStub.AboutBoxPackage\AboutBox.xaml file. To change the width of the Help/About box, go to the `AboutDialogStyle` block and set the `Width` property to 200:  
  
    ```  
    <Style x:Key="AboutDialogStyle" TargetType="Window">  
        <Setter Property="Height" Value="Auto" />  
        <Setter Property="Width" Value="200" />  
        <Setter Property="ShowInTaskbar" Value="False" />  
        <Setter Property="ResizeMode" Value="NoResize" />  
        <Setter Property="WindowStyle" Value="SingleBorderWindow" />  
        <Setter Property="SizeToContent" Value="Height" />  
    </Style>  
    ```  
  
6. Rebuild the solution and start debugging the isolated shell. The Help/About box should be approximately square.  
  
## Before You Deploy the Isolated Shell Application  
 Your isolated shell application can be installed on any computer that has the Visual Studio Shell (Isolated) Redistributable Package. For more information about the redistributable package, see the [Visual Studio Extensibility Downloads](https://go.microsoft.com/fwlink/?LinkID=119298) website.  
  
## Deploying the Isolated Shell Application  
 You deploy your isolated shell application to a target computer by creating a setup project. You must specify these things:  
  
- The layout of the folders and files on the target computer.  
  
- The launch conditions that guarantee that the .NET Framework and the Visual Studio shell runtime are installed on the target computer.  
  
  In the following procedure you will need to install InstallShield Limited Edition on your computer.  
  
#### To create the setup project  
  
1. In **Solution Explorer**, right-click the solution node and then click **Add New Project**.  
  
2. In the **New Project** dialog box, expand **Other Project Types** and then select **Setup and Deployment**. Select the InstallShield template. Name the new project `MySetup` and then click **OK**.  
  
3. If InstallShield Limited Edition is already installed, continue to the next step.  
  
    If InstallShield Limited Edition is not already installed, the InstallShield download page appears. Follow the instructions to download and install the product, choosing the version of InstallShield that is compatible with your version of Visual Studio. You must decide whether to register your installation of InstallShield or use it as an evaluation. You must restart Visual Studio after you complete the installation.  
  
   > [!IMPORTANT]
   > You must start Visual Studio as an administrator before you create an InstallShield project. If you do not do so, you will get an error when you build the project.  
  
   The next steps show how to configure the setup project.  
  
> [!IMPORTANT]
> Make sure that you have built the release configuration of your isolated shell project at least once before you configure the setup project.  
  
#### To configure the setup project  
  
1. In the **Solution Explorer**, under the **MySetup** project, choose **Project Assistant**. On the bottom row of the **Project Assistant** window, choose **Application Information**. Enter **Fabrikam** as your company name and **Fabrikam Music Editor** as your application name. Choose the forward arrow at the bottom right of the **Project Assistant**.  
  
2. Select **Yes** under **Does your application require any software to be installed on the machine?** and then select **Microsoft .NET Framework 4.5 Full Package**.  
  
3. Choose the **Application Files** button at the bottom of the window, and make sure that the **Fabrikam Music Editor** folder is selected.  
  
4. Choose the **Add Files** button. In the **Add Files** dialog box, add the following files from the **MyVSShellStub\Release** folder:  
  
    1. MyVSShellStub.exe.config  
  
    2. DebuggerProxy.dll  
  
    3. DebuggerProxy.dll.manifest  
  
    4. MyVSShellStub.pkgdef  
  
    5. MyVSShellStub.pkgundef  
  
    6. MyVSShellStub.winprf  
  
    7. Splash.bmp  
  
5. Click the **Add Project Outputs** button and add **MyVSShellStub/Primary Output**. Click **OK**.  
  
6. In the left pane, under **Destination Computer**, right-click the **Fabrikam Music Editor [INSTALLDIR]** node and add a **New Folder** named **Extensions**.  
  
7. Right-click the **Extensions** node in the left pane and add a new folder named **Application**.  
  
8. Select the **Application** folder and click the **Add Project Outputs** button, then select the primary output from the MyVSShellStub.AboutBoxPackage project.  
  
9. Click the **Add Files** button and from the \MyVSShellStub\Release\Extensions\Application\ folder add the following files:  
  
    - MyVSShellStub.AboutBoxPackage.pkgdef  
  
    - MyVSShellStub.Application.pkgdef  
  
10. Right-click the **Fabrikam Music Editor [INSTALLDIR]** node in the left pane and add a new folder named **1033**.  
  
11. Select the 1033 folder and then click the **Add Project Outputs** button, and select the primary output from the MyVSShellStubUI project.  
  
12. Move to the **Application Shortcuts** window.  
  
13. Click **New** to create a shortcut and select **[ProgramFilesFolder]\Fabrikam\Fabrikam Music Editor\MyVSShellStub.Primary Output**.  
  
14. Move to the **Installation Interview** pane.  
  
15. Set all items to **No**.  
  
16. In **Solution Explorer**, in the MySetup project, open **Define Setup Requirements and Actions \ Requirements**. The **Requirements** window opens.  
  
17. Right click **System Software Requirements** and select **Create New Launch Condition**. The **System Search Wizard** appears.  
  
18. In the **What do you want to find?** pane, choose **Registry Entry** in the drop-down list and click **Next**.  
  
19. In the **How do you want to look for it?** pane, select **HKEY_LOCAL_MACHINE** as the registry root. Enter **SOFTWARE\Wow6432Node\Microsoft\DevDiv\vs\Servicing\14.0\isoshell** for 64-bit systems or **SOFTWARE\Microsoft\DevDiv\vs\Servicing\14.0\isoshell** for 32-bit systems, and enter **Install** as the registry value. Click **Next**.  
  
20. In the **What do you want to do with the value?** pane, enter **This product requires the Visual Studio 2015 Isolated Shell Redistributable to be installed.** as the display text and click **Finish**.  
  
21. Rebuild the isolated shell solution to create the setup project.  
  
     You can find the setup.exe file in the following folder:  
  
     \MyVSShellStub\MySetup\MySetup\Express\SingleImage\DiskImages\DISK1  
  
## Testing the Installation Program  
 To test the setup, copy the setup.exe file to a different computer and run the Setup executable. You should be able to run the isolated shell application.

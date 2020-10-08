---
title: "Customizing the Isolated Shell | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "Visual Studio shell, isolated mode"
ms.assetid: e0b7c3ae-210f-4f48-ac49-6a59e6034f5f
caps.latest.revision: 16
ms.author: gregvanl
manager: jillfra
---
# Customizing the Isolated Shell
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can customize your Visual Studio isolated shell application by changing different aspects of the Visual Studio user interface and by restricting the commands and features included in your specialized application.  
  
## Using the Application.pkgdef file  
 The isolated shell template solution includes a *SolutionName*.Application.pkgdef file that allows you to modify the following features:  
  
##### The application title  
 You can customize the application title, which is the name that is displayed in the title bar of the application, by changing the value of the "AppName" row in the *SolutionName*.Application.pkgdef file. For more details, see [Walkthrough: Creating a Basic Isolated Shell Application](../extensibility/walkthrough-creating-a-basic-isolated-shell-application.md).  
  
 If you do not want the application title to display the project that is currently loaded, change the value of the "ShowHierarchyRootInTitle" row in the *SolutionName*.Application.pkgdef file from dword:00000001 to dword:00000000.  
  
##### The application icon  
 You can customize the application icon, which is the icon that is displayed by the application name in the application title bar. Copy a different icon to the icon directory. In **Solution Explorer**, add the icon to the Resource Files folder. Then open the VSShellStub.rc file and replace the value of IDI_STUBPROGRAM with the name of the new icon. For more details, see [Walkthrough: Creating a Basic Isolated Shell Application](../extensibility/walkthrough-creating-a-basic-isolated-shell-application.md).  
  
##### The command-line logo  
 You can customize the command-line logo, which is the text that appears when the application is started from the command line, by changing the value of the "CommandLineLogo" row in the *SolutionName*.Application.pkgdef file. For more details, see [Walkthrough: Creating a Basic Isolated Shell Application](../extensibility/walkthrough-creating-a-basic-isolated-shell-application.md)  
  
##### The name of the user files subfolder  
 You can change the name of the folder your application maintains for user files by changing the value of the "UserFilesSubFolderName" row in *SolutionName*.Application.pkgdef file.  
  
##### The title of the solution tree node in the New Project dialog  
 You can customize the title of the solution node in the New Project dialog by changing the value of the "NewProjDlgSlnTreeNodeTitle" row in the *SolutionName*.Application.pkgdef file.  
  
##### The installed templates header in the New Project dialog  
 You can change the installed templates header in the New Project dialog by changing the value of the "NewProjDlgInstalledTemplatesHdr" row in the *SolutionName*.Application.pkgdef file.  
  
##### Whether or not to hide Miscellaneous files by default  
 You can specify whether or not to hide Miscellaneous files by default by changing the value of the "HideMiscellaneousFilesByDefault" row in the *SolutionName*.Application.pkgdef file. To hide Miscellaneous files, set the value `dword:00000001`, and to show the files, set the value `dword:00000000`.  
  
##### Whether or not to disable the output window  
 You can specify whether or not to disable the output window in your application by changing the value of the "DisableOutputWindow" row in the *SolutionName*.Application.pkgdef file. To disable the output window, set the value `dword:00000001`, and to show the output window, set the value `dword:00000000`.  
  
##### Whether or not to allow dropped files on the main window  
 You can specify whether or not to allow dropped files on the main window in your application by changing the value of the "AllowsDroppedFilesOnMainWindow" row in the *SolutionName*.Application.pkgdef file. To allow dropped files, set the value `dword:00000001`, and to disallow dropped files, set the value `dword:00000000`.  
  
##### The default search page  
 You can customize the web browser page, which is page that is displayed when the web browser window is opened, by changing the value of the "DefaultSearchPage" row in the *SolutionName*.Application.pkgdef file.  
  
##### The default home page  
 You can customize the home page by changing the value of the "DefaultHomePage" row in the *SolutionName*.Application.pkgdef file. For more details, see [Walkthrough: Creating a Basic Isolated Shell Application](../extensibility/walkthrough-creating-a-basic-isolated-shell-application.md)  
  
##### Whether or not to hide the solution concept  
 You can specify whether or not to hide the solution in your application by changing the value of the "HideSolutionConcept" row in the *SolutionName*.Application.pkgdef file. To hide the solution, set the value `dword:00000001`, and to show the solution, set the value `dword:00000000`.  
  
##### The default debug engine  
 You can change the debug engine your application uses by changing the value of the "DefaultDebugEngine" row in the *SolutionName*.Application.pkgdef file to the GUID of your debug engine.  
  
##### The file extension of the user options file  
 You can change the name of the folder your application maintains for user files by changing the value of the "UserOptsFileExt" row in *SolutionName*.Application.pkgdef file.  
  
##### The solution file extension  
 You can change the extension used for your solution files by changing the value of the "SolutionFileExt" row in the *SolutionName*.Application.pkgdef file.  
  
##### The default user files folder root  
 You can change the name of the root folder of the user files for your application by changing the value of the "UserFilesSubFolderName" row in the *SolutionName*.Application.pkgdef file.  
  
##### The solution file creator identifier  
 You can change the identifier used for your solution files by changing the value of the "SolutionFileCreatorIdentifier" row in the *SolutionName*.Application.pkgdef file.  
  
##### The default projects location  
 You can change the name of the default projects location by changing the value of the "DefaultProjectsLocation" row in the *SolutionName*.Application.pkgdef file.  
  
##### The application localization package  
 You can change the localization package used for your application by changing the value of the "AppLocalizationPackage" row in the *SolutionName*.Application.pkgdef file.  
  
##### Whether or not to show the hierarchy root in the title  
 You can specify whether or not to show the hierarchy root in the title bar in your application by changing the value of the "ShowHierarchyRootInTitle" row in the *SolutionName*.Application.pkgdef file. To show the hierarchy root, set the value `dword:00000001`, and to hide the hierarchy root, set the value `dword:00000000`.  
  
##### Specifying a start page  
 To specify a start page for your custom application, in the *SolutionName*.Application.pkgdef file, set the "DisableStartPage" value to `dword:00000000`, and under `[$RootKey$\StartPage\Default]` set the URI to the location of the .xaml file:  
  
```  
DisableStartPage=dword:00000000  
[$RootKey$\StartPage\Default]  
"Uri"="$RootFolder$\<name of XAML file>"  
```  
  
 In the Applicationcommands.vsct file in the *SolutionName*UI project, comment out the "No_ShellPkg_startPageCommand" entry:  
  
```  
<!--<Define name="No_ShellPkg_StartPageCommand"/>-->  
```  
  
 You must add the .xaml file, and any graphics files you need, to the *SolutionName* project. These files must actually be copied to the *SolutionName* project directory, not added from some other directory.  
  
 On all the files, set the **Item Type** property to **Isolated Shell File** in order for the files to be copied to the *$RootFolder$* directory. (To set the **Item Type** property, right-click the file and select **Properties**. This property is found under **Configuration Properties**, **General**.)  
  
 For more information on customizing start pages, see [Customizing the Start Page](../ide/customizing-the-start-page-for-visual-studio.md).  
  
## Using other elements of the isolated shell  
 You can use other files and projects that are included in the isolated shell solution template to further customize your application.  
  
##### Enable/disable Visual Studio packages  
 The *SolutionName*.pkgundef file allows you to disable certain kinds of Visual Studio functionality by excluding certain packages. For example, the following line:  
  
```  
[$RootKey$\Projects\{A2FE74E1-B743-11d0-AE1A-00A0C90FFFC3}\AddItemTemplates\TemplateDirs\{39c9c826-8ef8-4079-8c95-428f5b1c323f}]  
```  
  
 removes the Miscellaneous Files project from the set of project templates displayed in the **New Project** dialog. For more details, see [Walkthrough: Creating a Basic Isolated Shell Application](../extensibility/walkthrough-creating-a-basic-isolated-shell-application.md).  
  
##### Enable/disable menu commands  
 The *SolutionName*UI.vsct file includes a commented-out list of all the menu commands available to the isolated shell. To disable a given command, uncomment the corresponding row. For example, to disable the Window/Split comment, uncomment the `<Define name="No_SplitCommand"/>` row. For more details, see [Walkthrough: Creating a Basic Isolated Shell Application](../extensibility/walkthrough-creating-a-basic-isolated-shell-application.md).  
  
##### The bitmap used on the splash screen  
 You can customize the bitmap used on the splash screen, which is the window that is displayed when the application is started, by changing the value of the "SplashScreenBitmap" row in the *SolutionName*.Application.pkgdef file. For more details, see [Walkthrough: Creating a Basic Isolated Shell Application](../extensibility/walkthrough-creating-a-basic-isolated-shell-application.md).  
  
##### The Help/About window  
 In the isolated shell template there is a separate project you can use to customize the Help/About box for your application. For more details, see [Walkthrough: Creating a Basic Isolated Shell Application](../extensibility/walkthrough-creating-a-basic-isolated-shell-application.md).

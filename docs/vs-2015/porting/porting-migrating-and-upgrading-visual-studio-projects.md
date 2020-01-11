---
title: "Porting, Migrating, and Upgrading Projects | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords:
  - "Win8ExpressDesktopBlock"
  - "w8trefactor"
  - "VS.ReviewProjectAndSolutionChangesDialog.UpgradeRetarget"
  - "ProjectCompatibilityDlgHelpTopic"
  - "VS.ReviewProjectAndSolutionChangesDialog.Upgrade"
helpviewer_keywords:
  - "conversion, projects"
  - "asset compatibility"
  - "projects, conversion"
ms.assetid: bee759bd-6ff5-4c2e-913a-ea7d3c906c29
caps.latest.revision: 108
author: "kraigb"
ms.author: "kraigb"
manager: jillfra
---
# Port, migrate, and upgrade Visual Studio projects
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

For the latest documentation on Visual Studio, see [Project migration and upgrade reference for Visual Studio](/visualstudio/porting/port-migrate-and-upgrade-visual-studio-projects).

When you are considering whether you should move to a newer version of Visual Studio, you can use this article to find out which solutions, projects, files, and other assets that you created in Visual Studio 2013, Visual Studio 2012, or Visual Studio 2010 SP1 will run without modification in Visual Studio 2013 and Visual Studio 2015. Or, you might have reached this page if you encountered an error message when trying to open a project that isn't supported in the version of Visual Studio you opened it in, or that requires an SDK or extension, such as the Azure SDK for .NET.

Many widely used assets behave the same in Visual Studio 2015, Visual Studio 2013, and the two earlier versions. For example, in Visual Studio 2015, you can open a project that was created in Visual Studio 2013 or Visual Studio 2012, change it, and then reopen it in Visual Studio 2015. Your changes persist and the project behaves the same as it does in the earlier version. The same is true for many assets that were created in Visual Studio 2010 SP1.

For Visual Basic, Visual Studio 2015 introduced no changes that will prevent a Visual Basic app that was created in Visual Studio 2013 from compiling. Run-time behavior of Visual Basic apps that are recompiled using Visual Studio 2015 will not change.

If you use Visual Studio 2015 together with Visual Studio 2013, Visual Studio 2012, or Visual Studio 2010 SP1, you can create and modify projects and files in any of the versions. You can transfer projects and files among the versions as long as you don't add features that aren't supported in one or more versions.

## <a name="project"></a> Projects

The following list describes support in Visual Studio 2015 and Visual Studio 2013 for projects that were created in Visual Studio 2012 or Visual Studio 2010 SP1. Use this list to help determine whether you can open a project "as is" in Visual Studio 2015,  Visual Studio 2013, Visual Studio 2012, or Visual Studio 2010 SP1, or whether you have to modify it to ensure compatibility.

|Type of Project|Compatibility|
|---------------------|-------------------|
|Universal Windows Platform apps|To install the tools Universal Windows apps, in Visual Studio setup, select **Custom** or **Modify**, and then select **Universal Windows App Development Tools**.<br /><br /> Universal Windows Platform (UWP) app development for Windows 10 is supported only in Visual Studio 2015 on Windows 10 or [!INCLUDE[win81](../includes/win81-md.md)].|
|Windows Store apps|Windows Store app development, including Universal apps that target both Windows 8.1 and Windows Phone 8.1, is supported on [!INCLUDE[win81](../includes/win81-md.md)] and Windows 10. Existing [!INCLUDE[win8](../includes/win8-md.md)] projects can continue to be serviced, but new [!INCLUDE[win8](../includes/win8-md.md)] projects cannot be created. [!INCLUDE[win81](../includes/win81-md.md)] projects can depend only on certain types of references. For more information, see [Managing references in a project](../ide/managing-references-in-a-project.md). **Note:**  [!INCLUDE[win81](../includes/win81-md.md)] projects that you create by using Visual Studio 2015 or Visual Studio 2013 cannot be opened in Visual Studio 2012. That is because [!INCLUDE[win81](../includes/win81-md.md)] projects created by using Visual Studio 2015 and Visual Studio 2013 target those versions, and Visual Studio 2012 supports only [!INCLUDE[win8](../includes/win8-md.md)] projects that target [!INCLUDE[win8](../includes/win8-md.md)].|
|[!INCLUDE[net_v451](../includes/net-v451-md.md)]|You can create and use these projects in Visual Studio 2015 and Visual Studio 2013 after you install the appropriate multi-targeting pack. These projects are not supported in Visual Studio 2010 SP1.|
|[!INCLUDE[net_v45](../includes/net-v45-md.md)]|You can create and open these projects in Visual Studio 2015, Visual Studio 2013, and Visual Studio 2012, but not in Visual Studio 2010 SP1.|
|BizTalk|BizTalk server projects are not compatible with Visual Studio 2015 or Visual Studio 2013.|
|C#/Visual Basic Silverlight 4 Application or Class Library|If you allow Visual Studio to update the project automatically, you can open it in either Visual Studio 2013 or Visual Studio 2012.|
|C#/Visual Basic Webform or Windows Form|You can open the project in Visual Studio 2013 and Visual Studio 2012.|
|Visual Basic 6 and Visual C++ 6|Visual Studio 2012 and Visual Studio 2013 do not support debugging applications built with Visual Basic 6 or Visual C++ 6; to debug these applications, use earlier versions of Visual Studio.|
|Coded UI test|If you allow Visual Studio to update the project automatically, you can open it in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1.|
|F#|If you allow Visual Studio to upgrade a project that was created in Visual Studio 2010 SP1, you can open it in Visual Studio 2013 and Visual Studio 2012. However, you can’t upgrade a Silverlight project that was created in an older version of Visual Studio to Visual Studio 2013. Instead, you must create a Silverlight project in Visual Studio 2013 and then copy your code into it. Silverlight projects that you create in Visual Studio 2013 target Silverlight 5.|
|LightSwitch|If you allow Visual Studio to upgrade the project automatically, you can open it in Visual Studio 2013 only.|
|Local Database Cache|The Local Database Cache template and the **Configure Data Synchronization** dialog box are not included in Visual Studio 2013. You can use Visual Studio 2013 to open and run projects that were created in [!INCLUDE[vs2010](../includes/vs2010-md.md)] if Microsoft Synchronization Services v1.0 is installed, but if you want to update them in Visual Studio 2013, you must make all changes manually in code. As an alternative, you can continue to use [!INCLUDE[vs2010](../includes/vs2010-md.md)] to maintain and update these projects.  For new development, target the new synchronization model that's provided by the Microsoft Sync Framework. For information, see [Microsoft Sync Framework Developer Center](https://msdn.microsoft.com/sync/default)|
|Model-View-Controller framework|Visual Studio 2010 SP1 supports only MVC 2 and MVC 3, Visual Studio 2012 supports only MVC 3 and MVC 4, and Visual Studio 2013 supports only MVC 4. For information about how to automatically upgrade from MVC 2 to MCV 3, see [ASP.NET MVC 3 Application Upgrader](https://aspnet.codeplex.com/releases/view/59008). For information about how to manually upgrade from MVC 2 to MVC 3, see [Upgrading an ASP.NET MVC 2 Project to ASP.NET MVC 3 Tools Update](https://aspnet.codeplex.com/releases/view/59008). For information about how to manually upgrade from MVC3 to MVC 4, see [Upgrading an ASP.NET MVC 3 Project to ASP.NET MVC 4](https://docs.microsoft.com/aspnet/whitepapers/mvc4-release-notes). If your project targets the .NET Framework 3.5 SP1, you must retarget it to use the .NET Framework 4.|
|Modeling|If you allow Visual Studio to update the project automatically, you can open it in Visual Studio 2013, Visual Studio 2012, or Visual Studio 2010 SP1.<br /><br /> When Team Foundation builds a modeling project, it tries to validate the layers in the project. In Visual Studio 2013, Team Foundation Build can't validate the layers for a modeling project that was created in Visual Studio 2010 SP1. However, in Visual Studio 2010 SP1, Team Foundation Build can validate the layers in a modeling project that was created in Visual Studio 2013.|
|MPI/Cluster Debugging|If the same version of the runtime or tools is installed on the computers that are running Visual Studio 2013, Visual Studio 2012, or Visual Studio 2010 SP1, you can open this project in all three versions.|
|MSI setup (.vdproj)|This project can't be opened in Visual Studio 2013 because it doesn't support that project type. We recommend that you use InstallShield Limited Edition for Visual Studio (ISLE), a free deployment solution that directly supports most Windows platforms and application runtimes. You can also use ISLE to import data and settings from Visual Studio Installer projects. .|
|Office 2007 VSTO|If you upgrade the project to target Office 2013 and the .NET Framework 4, you can open this project in Visual Studio 2013, Visual Studio 2012, or Visual Studio 2010 SP1.|
|Office 2010 VSTO|If the project targets the .NET Framework 4, you can open it in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. All other projects require a one-way upgrade.|
|Rich Internet Applications|If you upgrade the project, you can open it in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1.|
|SharePoint 2007|This project can't be opened in Visual Studio 2013. However, if you manually upgrade the project to SharePoint 2010, you can open it in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. For more information about how to upgrade SharePoint 2007, see [Migrating from SharePoint 2007 to SharePoint 2010 for the IT Pro](https://channel9.msdn.com/Blogs/matthijs/Migrating-from-SharePoint-2007-to-SharePoint-2010-for-the-IT-Pro) and [SharePoint Enterprise Search Migration Tool for SharePoint Server 2010](https://docs.microsoft.com/previous-versions/office/developer/sharepoint-2010/ee556856(v%3Doffice.14)).|
|SharePoint 2010|You can open the project in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1.|
|SketchFlow|If you allow Visual Studio to upgrade the project to WPF 4.5/Silverlight 5, you can open it in Visual Studio 2012 and Visual Studio 2013.|
|[!INCLUDE[ssKatmai_exp](../includes/sskatmai-exp-md.md)] database|You can open the project in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. If you have a database file (.mdf) that was created in an earlier version of SQL Server, you must upgrade it to [!INCLUDE[sql_Denali_long](../includes/sql-denali-long-md.md)] before you can use it with SQL Server Express LocalDB, but the database is no longer compatible with earlier versions of SQL Server. If you don’t upgrade, you can continue to work with the database in Visual Studio 2013 by installing and using [!INCLUDE[ssKatmai_exp](../includes/sskatmai-exp-md.md)] on the same computer. For more information, see [Upgrade .mdf files](../data-tools/upgrade-dot-mdf-files.md).|
|[!INCLUDE[sskatmai_r2](../includes/sskatmai-r2-md.md)] Express|If [!INCLUDE[sskatmai_r2](../includes/sskatmai-r2-md.md)] Express is installed on the computers that are running Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1, you can open the project in all three versions.|
|SQL Server Report Project|You can open the project in Visual Studio 2013 and Visual Studio 2012. For local mode only (that is, when not connected to SQL Server), you won’t get the design-time experience for controls that are associated with the viewer in [!INCLUDE[vs2010](../includes/vs2010-md.md)], but the project will function correctly at runtime. **Caution:**  If you add a feature that’s specific to Visual Studio 2013, the report schema is upgraded automatically and you can no longer open the project in Visual Studio 2012.|
|Unit tests|You can use [!INCLUDE[TCMext](../includes/tcmext-md.md)] in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1 to open tests that were created in any of these versions.|
|Visual C++|You can use Visual Studio 2013 to open a C++ project that was created in Visual Studio 2012 or Visual Studio 2010 SP1. If you want to use the Visual Studio 2013 build environment to build a project that was created in Visual Studio 2012, you must have both versions of Visual Studio installed on the same computer. For more information, see [How to: Upgrade Visual C++ Projects to Visual Studio 2015](../porting/how-to-upgrade-visual-cpp-projects-to-visual-studio-2015.md) and [Visual C++ Porting and Upgrading Guide](https://msdn.microsoft.com/library/f5fbcc3d-aa72-41a6-ad9a-a706af2166fb).|
|Visual Studio 2010 web|If you allow Visual Studio to upgrade the project automatically, you can open it in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1.|
|Visual Studio 2010 Database (.dbproj)|If you convert the project to a SQL Server Data Tools Database project, you can open it in Visual Studio 2013. However, Visual Studio 2013 doesn’t support these artifacts:<br /><br /> -   unit tests<br />-   data-generation plans<br />-   data-comparison files<br />-   custom rule extensions for static code analysis<br />-   server.sqlsettings<br />-   .sqlcmd files<br />-   custom deployment extensions<br />-   partial projects (.files)<br /><br /> If you install SQL Server Data Tools, you can open the project in Visual Studio 2010 SP1 after the conversion. For more information, see [Microsoft SQL Server Data Tools](https://msdn.microsoft.com/data/tools.aspx).|
|Visual Studio 2010 Visual Database Tools|You can open this project in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1.|
|Visual Studio Lab Management|You can use [!INCLUDE[TCMext](../includes/tcmext-md.md)], Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1 to open environments that were created in any of these versions. However, the version of Microsoft Test Manager must match the version of Team Foundation Server before you can create environments.|
|Visual Studio Macro|This project can't be opened in Visual Studio 2013 because it doesn't support the project type.|
|Visual Studio SDK/VSIX|After you upgrade a Visual Studio SDK project to Visual Studio 2013, it can't be opened in Visual Studio 2012. For more information, see [How to: Migrate Extensibility Projects to Visual Studio 2015](../extensibility/how-to-migrate-extensibility-projects-to-visual-studio-2015.md).|
|Microsoft Azure Tools for Visual Studio|If you’re using Microsoft Azure Tools for Visual Studio version 2.1, you can open the project in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. For projects that target earlier versions, if you allow Visual Studio to upgrade the project to version 2.1, you can open it in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1.|
|Windows Communication Foundation, Windows Presentation Foundation|You can open this project in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1.|
|Windows Mobile|This project can't be opened in Visual Studio 2013 because it doesn't support the project type.|
|Windows Phone 7.1|If you allow Visual Studio to upgrade the project to Windows Phone 8.0, you can open it in Visual Studio 2012 and Visual Studio 2013.|
|Other|You can open most other types of projects in Visual Studio 2012, Visual Studio 2013, and Visual Studio 2010 SP1.|
|FrontPage Web Sites|This project can't be opened in Visual Studio 2013 because it doesn't support the project type.|
|Portable Class Library|If you allow Visual Studio to update the project automatically, you can open it in Visual Studio 2013, Visual Studio 2012, or Visual Studio 2010 SP1.<br /><br /> -   Projects that targeted Silverlight 4 will target Silverlight 5.<br />-   Projects that targeted Windows Phone 7.0 or Windows Phone 7.5 will target Windows Phone 8.<br />-   Projects that targeted Xbox 360 will no longer target Xbox 360.|
|Azure projects such as cloud service projects (.ccproj extension) and Azure Resource Manager projects (Cloud Deployment Projects) with the .deployproj extension|To open these types of projects, first install the [Azure SDK for .NET](https://azure.microsoft.com/downloads/), then open the project.|

## Troubleshooting project compatibility issues
 Here are some things you can do when a project won't open in Visual Studio 2015 or Visual Studio 2013:

- If you try to open a project that isn't supported in Visual Studio 2015 or Visual Studio 2013 and for which the associated version of Visual Studio isn't installed, a message that the project type isn't supported might appear and the project type might be listed in the **Review Project and Solution Changes** dialog box under **Unsupported projects**. To resolve this issue, open the programs and features page in the Windows **Control Panel**, select **Visual Studio**, and then choose **Change**, **Repair**. Then you can install the missing version.

- If you try to open a project for a desktop app in [!INCLUDE[vs_dev12_expwin](../includes/vs-dev12-expwin-md.md)], an error occurs and one of these messages is displayed: "This edition of Visual Studio only supports [!INCLUDE[win81](../includes/win81-md.md)] apps" or "This project is incompatible with the current edition of Visual Studio." [!INCLUDE[vs_dev12_expwin](../includes/vs-dev12-expwin-md.md)] is restricted to the development, testing, and deployment of Windows Store apps designed for Windows 8.1. To open a desktop app project, you must use an edition of Visual Studio that supports that project type.

   For more information about the Visual Studio editions, see [Microsoft Visual Studio Products](https://visualstudio.microsoft.com/products/)

- If you try to open a Windows Store App project in [!INCLUDE[vs_dev12_expwin](../includes/vs-dev12-expwin-md.md)] Desktop, an error occurs. [!INCLUDE[vs_dev12_expwin](../includes/vs-dev12-expwin-md.md)] Desktop cannot be used to build Windows Store apps. If you want to build Windows Store apps, you can also install [!INCLUDE[vs_dev12_expwin](../includes/vs-dev12-expwin-md.md)]. Or, to develop apps for all Microsoft platforms and the web, try Visual Studio Professional 2013.

- If a project requires features that are specific to Visual Studio 2013, it can't be opened in an earlier version.

- If you're using Visual Studio 2012 and you want to open a project that was created in Visual Studio 2013, you might be able to customize the project system to incorporate features of Visual Studio 2013. For information about how to do this, see [Making Custom Projects Version-Aware](../misc/making-custom-projects-version-aware.md).

  For additional troubleshooting information, see the [Visual Studio 2013 Compatibility](https://support.microsoft.com/help/2863286/roundtrip-issues-for-visual-studio-2012-and-visual-studio-2013-preview) KB article.

## <a name="file"></a> Files

The following list identifies whether Visual Studio 2013 supports each type of file, whether you can open the file in Visual Studio 2012 and Visual Studio 2010 SP1, and whether you have to modify it to ensure compatibility.

|Type of File|Compatibility|
|------------------|-------------------|
|AppManifest, Inbrowsersettings, OutOfBrowserSettings (.xml files)|You can open these files in Visual Studio 2012, Visual Studio 2013, and Visual Studio 2010 SP1.|
|BizTalk flat file schemas|You can add these schemas to a BizTalk 2013 project in Visual Studio 2013. To use Visual Studio 2013 with BizTalk 2010 projects that have flat file schemas, install BizTalk 2013 on the computer that has Visual Studio 2013. The first time you open the BizTalk 2010 project, it is automatically upgraded to the BizTalk 2013 or Visual Studio 2013 project system.|
|Client Report Definition (.rdlc) files|You can open these files in Visual Studio 2013, and the schema is automatically upgraded if you add Visual Studio 2013 features and controls.|
|Code analysis rule sets|You can open these files in Visual Studio 2012, Visual Studio 2013, and Visual Studio 2010 SP1.|
|Data-tier application package files|You can open these files in Visual Studio 2013 if they’re version 2.0 or version 2.5.|
|Debugger dump files|You can open these files in Visual Studio 2012, Visual Studio 2013, and Visual Studio 2010 SP1.|
|Directed Graph Markup Language (DGML) diagram files|You can open these files in Visual Studio 2012, Visual Studio 2013, and Visual Studio 2010 SP1 without changing the file.|
|Entity Data Model (EDMX) files|In Visual Studio 2013, you can open an EDMX file that targets the .NET Framework 4.5 or the .NET Framework 4 without changing the file.|
|Profiler report files|You can open Profiler report files (.vsp .vsps, .psess, and .vspf) in Visual Studio 2012 and Visual Studio 2013. A .vspx file can't be opened in Visual Studio 2010 SP1.|
|Solution (.suo) file|You can use Visual Studio 2013 to open a solution file that was created in Visual Studio 2012 or Visual Studio 2010 SP1|
|SQL Server Compact Edition|Visual Studio 2013 doesn't support SQL Server Compact Edition.|
|SQLX files|To open these files in Visual Studio 2013, you must perform a one-way upgrade, deploy the .sqlx file on the target version of Visual Studio, and then rebuild the file in the .dacpac format.|
|IntelliTrace log files from [!INCLUDE[vs2010](../includes/vs2010-md.md)]|You can open these files in Visual Studio 2012, Visual Studio 2013, and Visual Studio 2010 SP1.|
|JavaScript Memory Analyzer (.diagsession) files|Files created by older versions of Visual Studio can be viewed in Visual Studio 2013. However, depending on the information gathered, files created in Visual Studio 2013 may not open in Visual Studio 2012 or Visual Studio 2010 SP1.|

## <a name="integration"></a> Integration assets

You might encounter compatibility issues if you use clients and servers from different versions of Visual Studio Team Foundation Server.

|Kind of Integration|Compatibility|
|-------------------------|-------------------|
|Code Review and My Work|The Code Review and My Work features won't work if you connect a client of [!INCLUDE[esprfound](../includes/esprfound-md.md)] to [!INCLUDE[vstsTfsRosarioLong](../includes/vststfsrosariolong-md.md)].|
|[!INCLUDE[vs_dev11_expwin_long](../includes/vs-dev11-expwin-long-md.md)]|A 64-bit environment such as MSBuild or [!INCLUDE[esprbuild](../includes/esprbuild-md.md)] can't be used to build [!INCLUDE[win8_appname_long](../includes/win8-appname-long-md.md)] apps that are created in [!INCLUDE[vs_dev12_expwin](../includes/vs-dev12-expwin-md.md)].|

## See also

- [Making Custom Projects Version-Aware](../misc/making-custom-projects-version-aware.md)

---
title: "Port, Migrate, and Upgrade Visual Studio Projects | Microsoft Docs"
ms.custom: ""
ms.date: 01/04/2018
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
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
author: "kraigb"
ms.author: "kraigb"
manager: ghogen
ms.workload: 
  - "multiple"
---

# Port, Migrate, and Upgrade Visual Studio Projects

Each new version of Visual Studio generally supports most previous types of projects, files, and other assets. You can work with them [as you always have](../ide/solutions-and-projects-in-visual-studio.md), and provided that you don't depend on newer features, Visual Studio preserves backwards compatibility with previous versions like Visual Studio 2015, Visual Studio 2013, and Visual Studio 2012. (See the [Release Notes](https://www.visualstudio.com/vs/release-notes/) for which features are specific to which versions.)

Support for some project types change over time, however. A newer version of Visual Studio may no longer support certain types, or require that they be migrated and updated such that they're no longer backwards-compatible. For current status on migration issues, refer to the [Visual Studio Developer Community site](https://developercommunity.visualstudio.com).

> [!Important]
> This present article provides details only for project types in Visual Studio 2017 that involve migration. It does not include supported project types that have no migration issues; that list is found on [Platform Targeting and Compatibility](https://www.visualstudio.com/productinfo/vs2017-compatibility-vs). Note also that some project types are no longer supported in Visual Studio 2017 at all and therefore cannot be migrated.

> [!Important]
> Adding appropriate workloads in the Visual Studio installer is necessary for opening certain project types. If you don't have the workload installed, Visual Studio reports an unknown or incompatible project type. In that case, check your installation options and try again. Again, see the [Platform Targeting and Compatibility](https://www.visualstudio.com/productinfo/vs2017-compatibility-vs) article for details on project support in Visual Studio 2017.

## Projects

The following list describes support in Visual Studio 2017 for projects that were created in earlier versions.

If you don't see a project or file type listed here that should be, consult the [Visual Studio 2015 version of this article](https://msdn.microsoft.com/library/hh266747.aspx) and use the "Give documentation feedback" option at the bottom of this page to provide details of your project.

| Type of Project | Support |
| --- | --- |
| .NET Core projects (.xproj) | Projects created with Visual Studio 2015 used preview tooling that included a .xproj project file. When you open a .xproj file with Visual Studio 2017, you are prompted to migrate the file to the .csproj format (a backup of the .xproj file is made). This .csproj format for .NET Core projects is not supported in VS2015 and earlier.  The .xproj format is not supported in Visual Studio 2017 other than for migration to .csproj. For more information, see [Migrating .NET Core projects to the .csproj format](/dotnet/core/migration/#visual-studio-2017).|
| ASP.NET Web Application and ASP.NET Core Web Application with Application Insights enabled | For each Visual Studio user, resource information is stored in the registry per user instance. This is used when a user doesn't t have a project opened and wants to search Azure Application Insights data. Visual Studio 2015 uses different registry location than Visual Studio 2017 and does not conflict.<br/><br/>Once a user creates an ASP.NET Web Application or ASP.NET Core Web Application, the resource is stored in the .suo file. The user can open the project in Visual Studio 2015 or 2017 and the resource information is used for both as long as Visual Studio supports projects and solutions being used across both versions. Users need to authenticate once on each product. For example, if a project is created with Visual Studio 2015 and opened in Visual Studio 2017, the user needs to authenticate on Visual Studio 2017. |
| C#/Visual Basic Webform or Windows Form | You can open the project in Visual Studio 2017 and Visual Studio 2015. |
| Database Unit Test Projects (.csproj, .vbproj) | Older Data Unit test projects are loaded in Visual Studio 2017 but use the GAC’d version of dependencies. To upgrade the unit test project to use the latest dependencies, right-click on the project in Solution Explorer and select **Convert to SQL Server Unit Testing Project...**. |
| F# | Visual Studio 2017 can open projects created in Visual Studio 2013 and 2015. To enable Visual Studio 2017 features in these projects, however, open the project properties and change target fsharp.core to F# 4.1. Note also that the **F# language support** option in the Visual Studio installer is not selected by default with .NET workloads; you must include it by selecting that option for the workload, or selecting it from the **Individual components** tab under **Development activities**. |
| InstallShield<br/>MSI setup | Installer projects created in Visual Studio 2010 can be opened in later versions with the help of the  [Visual Studio Installer Projects extension](https://marketplace.visualstudio.com/items?itemName=UnniRavindranathan-MSFT.MicrosoftVisualStudio2013InstallerProjects). Also see the [WiX Toolset Visual Studio 2017 Extension](https://marketplace.visualstudio.com/items?itemName=RobMensching.WixToolsetVisualStudio2017Extension). InstallShield Limited Edition is no longer included with Visual Studio. Check with [Flexera Software](http://learn.flexerasoftware.com/content/IS-EVAL-InstallShield-Limited-Edition-Visual-Studio) about availability for Visual Studio 2017. |
| LightSwitch | LightSwitch is no longer supported in Visual Studio 2017. Projects created with Visual Studio 2012 and earlier opened in Visual Studio 2013 or Visual Studio 2015 are upgraded and can be opened only in Visual Studio 2013 or Visual Studio 2015 thereafter. |
| Microsoft Azure Tools for Visual Studio | To open these types of projects, first install the [Azure SDK for .NET](http://azure.microsoft.com/downloads/), then open the project. If necessary, your project is updated. |
| Model-View-Controller framework (ASP.NET MVC) | Support for MVC versions and Visual Studio:<ul><li>Visual Studio 2010 SP1 supports MVC 2 and MVC 3; MVC 4 support is added through the [ASP.NET 4 MVC 4 for Visual Studio 2010 SP1 download](https://www.microsoft.com/download/details.aspx?id=30683)</li><li>Visual Studio 2012 supports only MVC 3 and MVC 4</li><li>Visual Studio 2013 supports only MVC 4 and MVC 5</li><li>Visual Studio 2017 and Visual Studio 2015 supports MVC 4 (you can open existing projects but not create new ones) and MVC 5</li></ul><br/><br/>Upgrading MVC versions:<ul><li>For information about how to automatically upgrade from MVC 2 to MVC 3, see [ASP.NET MVC 3 Application Upgrader](http://go.microsoft.com/fwlink/?LinkID=238178).</li><li>For information about how to manually upgrade from MVC 2 to MVC 3, see [Upgrading an ASP.NET MVC 2 Project to ASP.NET MVC 3 Tools Update](http://go.microsoft.com/fwlink/?linkid=238178).</li><li>For information about how to manually upgrade from MVC3 to MVC 4, see [Upgrading an ASP.NET MVC 3 Project to ASP.NET MVC 4](http://www.asp.net/whitepapers/mvc4-release-notes). If your project targets .NET Framework 3.5 SP1, you must retarget it to use .NET Framework 4.</li><li>For information about how to manually upgrade from MVC 4 to MVC 5, see [How to Upgrade an ASP.NET MVC 4 and Web API Project to ASP.NET MVC 5 and Web API 2](https://www.asp.net/mvc/overview/releases/how-to-upgrade-an-aspnet-mvc-4-and-web-api-project-to-aspnet-mvc-5-and-web-api-2)</li></ul> |
| Modeling | If you allow Visual Studio to update the project automatically, you can open it in Visual Studio 2015, Visual Studio 2013, or Visual Studio 2012.<br/><br/>The format of the modeling project has not changed between Visual Studio 2015 and Visual Studio 2017 and the project can be opened and modified in either version. However, there are differences in behavior in Visual Studio 2017:<ul><li>Modeling projects are now referred to as "Dependency Validation" projects in the menus and templates.</li><li>UML diagrams are no longer supported in Visual Studio 2017. UML files are listed in the Solution Explorer as before but are opened as XML files. Use Visual Studio 2015 to view, create, or edit UML diagrams.</li><li>In Visual Studio 2017, validation of architectural dependencies is no longer performed when the modeling project is built. Instead, validation is carried out as each code project is built. This change does not affect the modeling project, but it does require changes to the code projects being validated. Visual Studio 2017 can automatically make the necessary changes to the code projects ([more information](http://go.microsoft.com/fwlink/?LinkId=827800)).</li></ul> |
| MSI Setup (.vdproj) | See InstallShield Projects above. | 
| Office 2007 VSTO | Requires a one-way upgrade for Visual Studio 2017. |
| Office 2010 VSTO | If the project targets the .NET Framework 4, you can open it in Visual Studio 2010 SP1 and later. All other projects require a one-way upgrade. |
| SharePoint 2010 | When a SharePoint solution project is opened with Visual Studio 2017, it's upgraded to either SharePoint 2013 or SharePoint 2016. The ".NET Desktop Development" workload must be installed in Visual Studio 2017 for the upgrade.<br/><br/>For more information about how to upgrade SharePoint projects, see [Upgrade to SharePoint 2013](https://technet.microsoft.com/library/cc303420.aspx), [Update Workflow in SharePoint Server 2013](https://technet.microsoft.com/library/dn133867.aspx), and [Create the SharePoint Server 2016 farm for a database attach upgrade](https://technet.microsoft.com/library/cc263026(v=office.16).aspx). |
| SharePoint 2016 | SharePoint Add-In projects created in Office Developer Tools Preview 2 cannot be opened in Visual Studio 2017. To work around this limitation, update the `MinimumVisualStudioVersion` to 12.0 and `MinimumOfficeToolsVersion` to 12.2 in the `.csproj` or `.vbproj` file. |
| Silverlight | Silverlight projects not supported in Visual Studio 2017. To maintain Silverlight applications, continue to use Visual Studio 2015. |
| SQL Server Reporting Services and SQL Server Analysis Services (SSRS, SSDT, SSAS, MSAS) | Support for these project types is provided through two extensions in the Visual Studio Gallery:  [Microsoft Analysis Services Modeling Projects](https://marketplace.visualstudio.com/items?itemName=ProBITools.MicrosoftAnalysisServicesModelingProjects) and [Microsoft Reporting Services Projects](https://marketplace.visualstudio.com/items?itemName=ProBITools.MicrosoftReportProjectsforVisualStudio). SSDT support is also included with the Data Storage and Processing workload in Visual Studio 2017. |
| SQL Server Integration Services (SSIS) | Support for Visual Studio 2017 is available through the SQL Server Data Tools (SSDT). For more information, see the [SQL Server Integration Services blog](https://blogs.msdn.microsoft.com/ssis/2017/08/23/ssis-designer-is-now-available-for-visual-studio-2017/). |
| Visual C++ | You can use Visual Studio 2017 to open solutions and projects that were created in Visual Studio 2015 as-is. Projects created in older versions of Visual Studio may require upgrading the project or retargeting to a more recent toolset to build with Visual Studio 2017. For more information, see [Visual C++ Porting and Upgrading Guide](https://docs.microsoft.com/cpp/porting/visual-cpp-porting-and-upgrading-guide). |
| Visual Studio Extensibility/VSIX | Projects with MinimumVersion 14.0 or less are updated to declare MinimumVersion 15.0, which prevents the project from being opened in earlier versions of Visual Studio. To allow a project to open in earlier versions, set MinimumVersion to `$(VisualStudioVersion)`. See also [How to: Migrate Extensibility Projects to Visual Studio 2017](../extensibility/how-to-migrate-extensibility-projects-to-visual-studio-2017.md). |
| Visual Studio Lab Management | You can use Microsoft Test Manager or Visual Studio 2010 SP1 and later to open environments created in any of these versions. However, for Visual Studio 2010 SP1 the version of Microsoft Test Manager must match the version of Team Foundation Server before you can create environments. |
| Visual Studio Tools for Apache Cordova | Projects can be opened in Visual Studio 2017, but it are not backwards compatible. Upon opening a project from Visual Studio 2015, you're prompted to allow modifications to your project. This modification upgrades the project to use toolsets instead of a `taco.json` file to manage the versioning of the Cordova library, its platforms and plugins, as well as its node/npm dependencies. See the [migration guide](https://docs.microsoft.com/visualstudio/cross-platform/tools-for-cordova/first-steps/migrate-from-visual-studio-2015) for more information. |
| Windows Communication Foundation, Windows Workflow Foundation | You can open this project in Visual Studio 2017, Visual Studio 2015, Visual Studio 2013, and Visual Studio 2012 |
| Windows Presentation Foundation | You can open this project in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. |
| Windows Store/Phone apps | Projects for Windows Store 8.1 and 8.0, and Windows Phone 8.1 and 8.0 are not supported in Visual Studio 2017. To maintain these apps, continue to use Visual Studio 2015. To maintain Windows Phone 7.x projects, use Visual Studio 2012. |

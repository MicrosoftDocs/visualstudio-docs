---
title: "Port, Migrate, and Upgrade Visual Studio Projects | Microsoft Docs"
ms.custom: ""
ms.date: "2/6/2017"
ms.prod: "visual-studio-dev15"
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
ms.assetid: bee759bd-6ff5-4c2e-913a-ea7d3c906c29
author: "TerryGLee"
ms.author: "tglee"
manager: "ghogen"
translation.priority.ht:
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt:
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Port, Migrate, and Upgrade Visual Studio Projects

Each new version of Visual Studio generally supports most previous types of projects, files, and other assets. You can work with them as you always have, and provided that you don't depend on newer features, Visual Studio preserves backwards compatibility with previous versions like Visual Studio 2015, Visual Studio 2013, and Visual Studio 2012. (See the [Release Notes](https://www.visualstudio.com/vs/release-notes/) for which features are specific to which versions.)

Support for some types change over time, however. A newer version of Visual Studio may no longer support certain types, or require that they be migrated and updated such that they're no longer backwards compatible. This topic provides details on each of the affected project, file, and asset types.


## Projects

The following list describes support in Visual Studio 2017 and Visual Studio 2015 for projects that were created in Visual Studio 2013 or Visual Studio 2012. 

| Type of Project | Compatibility |
| --- | --- |
| Universal Windows Platform apps | To install the tools Universal Windows apps, in Visual Studio setup, select **Custom** or **Modify**, and then select **Universal Windows App Development Tools**.<br/><br/>Universal Windows Platform (UWP) app development for Windows 10 is supported only in Visual Studio 2015 and later on Windows 10 or Windows 8.1. |
| Windows Store apps | Windows Store app development, including Universal apps that target both Windows 8.1 and Windows Phone 8.1, is supported on Windows 8.1 and Windows 10.<br/><br/>Existing Windows 8 projects can continue to be serviced, but new Windows 8 projects cannot be created. Windows 8.1 projects can depend only on certain types of references. For more information, see [Managing references in a project](https://msdn.microsoft.com/en-us/library/ez524kew.aspx).<br/><br/>**Note:**  Windows 8.1 projects that you create by using Visual Studio 2013 and 2015 cannot be opened in Visual Studio 2012 because the latter supports only Windows 8 projects that target Windows 8. |
| .NET Core projects (.xproj) | Projects created with Visual Studio 2015 used preview tooling which include a .xproj project file. When you open a .xproj file with Visual Studio 2017, you will be prompted to migrate the file to the .csproj format (a backup of the .xproj file is made). This .csproj format for .NET Core projects is not supported in VS2015 and earlier.  The .xproj format is not supported in Visual Studio 2017 other than for migration to .csproj. |
| ASP.NET Web Application and ASP.NET Core Web Application with Application Insights enabled | For each Visual Studio user, resource information is stored in the registry per user instance. This is used when user don’t have a project opened and wants to search Azure Application Insights data. Visual Studio 2015 uses different registry location than Visual Studio 2017 and does not conflict.<br/><br/>Once a user creates an ASP.NET Web Application or ASP.NET Core Web Application, the resource is stored in the .suo file. The user can open the project in Visual Studio 2015 or 2017 and the resource information will be used for both as long as Visual Studio supports projects and solutions being used across both versions. Users will need to authenticate once on each product. For example, if a project is created with Visual Studio 2015 and opened in Visual Studio 2017, the user will need to authenticate on Visual Studio 2017. |
| BizTalk | BizTalk server projects are not compatible with Visual Studio 2013 and later. |
| C#/Visual Basic Silverlight 4 Application or Class Library | If you allow Visual Studio to update the project automatically, you can open it in either Visual Studio 2013 or Visual Studio 2012. |
| C#/Visual Basic Webform or Windows Form | You can open the project in Visual Studio 2017 and Visual Studio 2015. |
| Visual Basic 6 and Visual C++ 6 | Visual Studio 2012 and Visual Studio 2013 do not support debugging applications built with Visual Basic 6 or Visual C++ 6; to debug these applications, use earlier versions of Visual Studio. |
| Coded UI test | If you allow Visual Studio to update the project automatically, you can open it in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. |
| F# | If you allow Visual Studio to upgrade a project that was created in Visual Studio 2010 SP1, you can open it in Visual Studio 2013 and Visual Studio 2012. However, you can’t upgrade a Silverlight project that was created in an older version of Visual Studio to Visual Studio 2013. Instead, you must create a Silverlight project in Visual Studio 2013 and then copy your code into it. Silverlight projects that you create in Visual Studio 2013 target Silverlight 5. |
| LightSwitch | LightSwitch is no longer supported in Visual Studio 2017. Projects created with Visual Studio 2012 and earlier opened in Visual Studio 2013 or Visual Studio 2015 will be upgraded and can be opened only in Visual Studio 2013 or Visual Studio 2015 thereafter. |
| Local Database Cache | The Local Database Cache template and the **Configure Data Synchronization** dialog box are not included in Visual Studio 2013. You can use Visual Studio 2013 to open and run projects that were created in Visual Studio 2010 if Microsoft Synchronization Services v1.0 is installed, but if you want to update them in Visual Studio 2013, you must make all changes manually in code.<br/><br/>As an alternative, you can continue to use Visual Studio 2010 to maintain and update these projects. For new development, target the new synchronization model that's provided by the Microsoft Sync Framework. For information, see [Microsoft Sync Framework Developer Center](https://msdn.microsoft.com/sync/default) |
| Model-View-Controller framework (ASP.NET MVC) | Support for MVC versions and Visual Studio:<ul><li>Visual Studio 2010 SP1 supports only MVC 2 and MVC 3</li><li>Visual Studio 2012 supports only MVC 3 and MVC 4</li><li>Visual Studio 2013 supports only MVC 4 and MVC 5</li><li>Visual Studio 2015 supports MVC 4 (you can open existing projects but not create new ones) and MVC 5</li></ul><br/><br/>Upgrading MVC versions:<ul><li>For information about how to automatically upgrade from MVC 2 to MCV 3, see [ASP.NET MVC 3 Application Upgrader](http://go.microsoft.com/fwlink/?LinkID=238178).</li><li>For information about how to manually upgrade from MVC 2 to MVC 3, see [Upgrading an ASP.NET MVC 2 Project to ASP.NET MVC 3 Tools Update](http://go.microsoft.com/fwlink/?linkid=238178).</li><li>For information about how to manually upgrade from MVC3 to MVC 4, see [Upgrading an ASP.NET MVC 3 Project to ASP.NET MVC 4](http://www.asp.net/whitepapers/mvc4-release-notes). If your project targets .NET Framework 3.5 SP1, you must retarget it to use .NET Framework 4.</li><li>For information about how to manually upgrade from MVC 4 to MVC 5, see [How to Upgrade an ASP.NET MVC 4 and Web API Project to ASP.NET MVC 5 and Web API 2](https://www.asp.net/mvc/overview/releases/how-to-upgrade-an-aspnet-mvc-4-and-web-api-project-to-aspnet-mvc-5-and-web-api-2)</li></ul> |
| Modeling | If you allow Visual Studio to update the project automatically, you can open it in Visual Studio 2015, Visual Studio 2013, or Visual Studio 2012.<br/><br/>The format of the modeling project has not changed between Visual Studio 2015 and Visual Studio 2017 and the project can be opened and modified in either version. However, there are differences in behavior in Visual Studio 2017:<ul><li>Modeling projects are now referred to as “Dependency Validation” projects in the menus and templates.</li><li>UML diagrams are no longer supported in Visual Studio 2017. UML files are listed in the Solution Explorer as before but will be opened as XML files. Use Visual Studio 2015 to view, create, or edit UML diagrams.</li><li>In Visual Studio 2017, validation of architectural dependencies is no longer performed when the modeling project is built. Instead, validation is carried out as each code project is built. This change does not affect the modeling project, but it does require changes to the code projects being validated. Visual Studio 2017 can automatically make the necessary changes to the code projects ([more information](http://go.microsoft.com/fwlink/?LinkId=827800)).</li></ul> |
| MPI/Cluster Debugging | If the same version of the runtime or tools is installed on the computers that are running Visual Studio 2013, Visual Studio 2012, or Visual Studio 2010 SP1, you can open this project in all three versions. |
| MSI setup (.vdproj) | This project type can be opened only in Visual Studio 2012 and earlier; it is not supported in Visual Studio 2013 and later. |
| Office 2007 VSTO | If you upgrade the project to target Office 2013 and the .NET Framework 4, you can open this project in Visual Studio 2013, Visual Studio 2012, or Visual Studio 2010 SP1. |
| Office 2010 VSTO | If the project targets the .NET Framework 4, you can open it in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. All other projects require a one-way upgrade. |
| Rich Internet Applications | If you upgrade the project, you can open it in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. |
| SharePoint 2007 | This project can't be opened in Visual Studio 2013. However, if you manually upgrade the project to SharePoint 2010, you can open it in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. For more information about how to upgrade SharePoint 2007, see [Migrating from SharePoint 2007 to SharePoint 2010 for the IT Pro](http://go.microsoft.com/fwlink/?LinkId=238224), [Migrating a 2007 Workflow to Visual Studio & SharePoint 2010](http://go.microsoft.com/fwlink/?LinkId=238225), and [SharePoint Enterprise Search Migration Tool for SharePoint Server 2010](http://go.microsoft.com/fwlink/?LinkId=238226). |
| SharePoint 2010 | You can open the project in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. |
| SketchFlow | If you allow Visual Studio to upgrade the project to WPF 4.5/Silverlight 5, you can open it in Visual Studio 2012 and Visual Studio 2013. |
| SQL Server 2008 Express database | You can open the project in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. If you have a database file (.mdf) that was created in an earlier version of SQL Server, you must upgrade it to SQL Server 2012 before you can use it with SQL Server Express LocalDB, but the database is no longer compatible with earlier versions of SQL Server. If you don’t upgrade, you can continue to work with the database in Visual Studio 2013 by installing and using SQL Server 2008 Express on the same computer. For more information, see [Upgrade .mdf files](https://msdn.microsoft.com/en-us/library/hh873188.aspx). |
| SQL Server 2008 R2 Express | If SQL Server 2008 R2 Express is installed on the computers that are running Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1, you can open the project in all three versions. |
| SQL Server Report Project | You can open the project in Visual Studio 2012 and later. For local mode only (that is, when not connected to SQL Server), you won’t get the design-time experience for controls that are associated with the viewer in Visual Studio 2010, but the project will function correctly at runtime. **Caution:** If you add a feature that’s specific to Visual Studio 2013 or later, the report schema is upgraded automatically and you can no longer open the project in Visual Studio 2012. |
| Unit tests | You can use Microsoft Test Manager in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1 to open tests that were created in any of these versions. |
| Visual C++ | You can use Visual Studio 2017 to open solutions and projects that were created in Visual Studio 2015 as-is, but projects that were created in older versions of Visual Studio may require upgrading the project or retargeting to a more recent toolset to build with Visual Studio 2017. For more information, see [How to: Upgrade Visual C++ Projects to Visual Studio 2015](https://msdn.microsoft.com/en-us/library/hh690665.aspx) and [Visual C++ Porting and Upgrading Guide](https://msdn.microsoft.com/en-us/library/dn986839.aspx). |
| Visual Studio 2010 web | If you allow Visual Studio to upgrade the project automatically, you can open it in Visual Studio 2013 and later. |
| Visual Studio 2010 Database (.dbproj) | If you convert the project to a SQL Server Data Tools Database project, you can open it in Visual Studio 2013. However, Visual Studio 2013 doesn’t support the following artifacts:<ul><li>unit tests</li><li>data-generation plans</li><li>data-comparison files</li><li>custom rule extensions for static</li><li>code analysis</li><li>server.sqlsettings</li><li>.sqlcmd files</li><li>custom deployment extensions</li><li>and partial projects (.files)</li></ul><br/>If you install SQL Server Data Tools, you can open the project in Visual Studio 2010 SP1 after the conversion. For more information, see [Microsoft SQL Server Data Tools](https://msdn.microsoft.com/data/tools.aspx). |
| Visual Studio 2010 Visual Database Tools | You can open this project in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. |
| Database Unit Test Projects (.csproj, .vbproj)	| Older Data Unit test projects will be loaded in Visual Studio 2017 but will use the GAC’d version of dependencies. To upgrade the unit test project to use the latest dependencies right click on the project not in Solution Explorer and click Upgrade from context menu. |
| Visual Studio Lab Management | You can use Microsoft Test Manager or Visual Studio 2010 SP1 and later to open environments created in any of these versions. However, for Visual Studio 2010 SP1 the version of Microsoft Test Manager must match the version of Team Foundation Server before you can create environments. |
| Visual Studio Tools for Apache Cordova |This project can be opened in Visual Studio 2017, but it is not backwards compatible. Upon opening a project from Visual Studio 2015, you will be prompted to allow modifications to your project. This upgrades the project to use toolsets instead of a `taco.json` file to manage the versioning of the Cordova library, its platforms and plugins, as well as its node/npm dependencies. See the [migration guide](http://taco.visualstudio.com/docs/vs-taco-2017-migration/) for more information. |
| Visual Studio Macro | This project can't be opened in Visual Studio 2013 because it doesn't support the project type. |
| Visual Studio SDK/VSIX | After you upgrade a Visual Studio SDK project to Visual Studio 2013, it can't be opened in Visual Studio 2012. For more information, see [How to: Migrate Extensibility Projects to Visual Studio 2015](https://msdn.microsoft.com/en-us/library/cc512930.aspx). |
| Microsoft Azure Tools for Visual Studio | To open these types of projects, first install the [Azure SDK for .NET](http://azure.microsoft.com/en-us/downloads/), then open the project. If necessary, your project will be updated. |
| Windows Communication Foundation, Windows Workflow Foundation | You can open this project in Visual Studio 2017, Visual Studio 2015, Visual Studio 2013, and Visual Studio 2012 |
| Windows Presentation Foundation | You can open this project in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. |
| Windows Mobile | This project can't be opened in Visual Studio 2013 because it doesn't support the project type. |
| Windows Phone 7.1 | If you allow Visual Studio to upgrade the project to Windows Phone 8.0, you can open it in Visual Studio 2012 and Visual Studio 2013. |
| Other | You can open most other types of projects in Visual Studio 2012, Visual Studio 2013, and Visual Studio 2010 SP1. |
| FrontPage Web Sites | This project can't be opened in Visual Studio 2013 because it doesn't support the project type. |
| Portable Class Library | If you allow Visual Studio to update the project automatically, you can open it in Visual Studio 2013, Visual Studio 2012, or Visual Studio 2010 SP1.<ul><li>Projects that targeted Silverlight 4 will target Silverlight 5.</li><li>Projects that targeted Windows Phone 7.0 or Windows Phone 7.5 will target Windows Phone 8.</li><li>Projects that targeted Xbox 360 will no longer target Xbox 360.</li></ul> |
| Azure projects such as cloud service projects (.ccproj extension) and Azure Resource Manager projects (Cloud Deployment Projects) with the .deployproj extension | To open these types of projects, first install the [Azure SDK for .NET](http://azure.microsoft.com/en-us/downloads/), then open the project. |

## Troublshooting project compatibility issues

Here are some things you can do when a project won't open in Visual Studio 2015 or Visual Studio 2013:

* If you try to open a project that isn't supported in Visual Studio 2015 or Visual Studio 2013 and for which the associated version of Visual Studio isn't installed, a message that the project type isn't supported might appear and the project type might be listed in the **Review Project and Solution Changes** dialog box under **Unsupported projects**. To resolve this issue, open the programs and features page in the Windows **Control Panel**, select **Visual Studio**, and then choose **Change**, **Repair**. Then you can install the missing version.

* If you try to open a project for a desktop app in Visual Studio Express 2013 for Windows, an error occurs and one of these messages is displayed: "This edition of Visual Studio only supports Windows 8.1 apps" or "This project is incompatible with the current edition of Visual Studio." Visual Studio Express 2013 for Windows is restricted to the development, testing, and deployment of Windows Store apps designed for Windows 8.1. To open a desktop app project, you must use an edition of Visual Studio that supports that project type.

    For more information about the Visual Studio editions, see [Microsoft Visual Studio Products](http://go.microsoft.com/fwlink/?LinkId=254332)

* If you try to open a Windows Store App project in Visual Studio Express 2013 for Windows Desktop, an error occurs. Visual Studio Express 2013 for Windows Desktop cannot be used to build Windows Store apps. If you want to build Windows Store apps, you can also install Visual Studio Express 2013 for Windows. Or, to develop apps for all Microsoft platforms and the web, try Visual Studio Professional 2013.

* If a project requires features that are specific to Visual Studio 2013, it can't be opened in an earlier version.

* If you're using Visual Studio 2012 and you want to open a project that was created in Visual Studio 2013, you might be able to customize the project system to incorporate features of Visual Studio 2013. For information about how to do this, see [Making Custom Projects Version-Aware](https://msdn.microsoft.com/en-us/library/hh266706.aspx).

For additional troubleshooting information, see the [Visual Studio 2013 Compatibility](http://support.microsoft.com/kb/2863286) KB article.

## Files

The following list identifies whether Visual Studio 2013 supports each type of file, whether you can open the file in Visual Studio 2012 and Visual Studio 2010 SP1, and whether you have to modify it to ensure compatibility.

| Type of File | Compatibility |
| --- | --- |
| AppManifest, Inbrowsersettings, OutOfBrowserSettings (.xml files) | You can open these files in Visual Studio 2012, Visual Studio 2013, and Visual Studio 2010 SP1. |
| BizTalk flat file schemas | You can add these schemas to a BizTalk 2013 project in Visual Studio 2013.<br/><br/>To use Visual Studio 2013 with BizTalk 2010 projects that have flat file schemas, install BizTalk 2013 on the computer that has Visual Studio 2013. The first time you open the BizTalk 2010 project, it is automatically upgraded to the BizTalk 2013 or Visual Studio 2013 project system. |
| Client Report Definition (.rdlc) files | You can open these files in Visual Studio 2013, and the schema is automatically upgraded if you add Visual Studio 2013 features and controls. |
| Code analysis rule sets | You can open these files in Visual Studio 2012, Visual Studio 2013, and Visual Studio 2010 SP1. |
| Data-tier application package files | You can open these files in Visual Studio 2013 if they’re version 2.0 or version 2.5. |
| Debugger dump files | You can open these files in Visual Studio 2012, Visual Studio 2013, and Visual Studio 2010 SP1. |
| Directed Graph Markup Language (DGML) diagram files | You can open these files in Visual Studio 2012, Visual Studio 2013, and Visual Studio 2010 SP1 without changing the file. |
| Entity Data Model (EDMX) files | In Visual Studio 2013, you can open an EDMX file that targets the .NET Framework 4.5 or the .NET Framework 4 without changing the file. |
| Profiler report files | You can open Profiler report files (.vsp .vsps, .psess, and .vspf) in Visual Studio 2012 and Visual Studio 2013. A .vspx file can't be opened in Visual Studio 2010 SP1. |
| Solution (.suo) file | You can use Visual Studio 2013 to open a solution file that was created in Visual Studio 2012 or Visual Studio 2010 SP1 |
| SQL Server Compact Edition | Visual Studio 2013 doesn't support SQL Server Compact Edition. |
| SQLX files | To open these files in Visual Studio 2013, you must perform a one-way upgrade, deploy the .sqlx file on the target version of Visual Studio, and then rebuild the file in the .dacpac format. |
| IntelliTrace log files from Visual Studio 2010 | You can open these files in Visual Studio 2012, Visual Studio 2013, and Visual Studio 2010 SP1. |
| JavaScript Memory Analyzer (.diagsession) files | Files created by older versions of Visual Studio can be viewed in Visual Studio 2013. However, depending on the information gathered, files created in Visual Studio 2013 may not open in Visual Studio 2012 or Visual Studio 2010 SP1. |

## Integration assets

You might encounter compatibility issues if you use clients and servers from different versions of Visual Studio Team Foundation Server.

| Kind of Integration | Compatibility |
| --- | --- |
| Code Review and My Work | The Code Review and My Work features won't work if you connect a client of Team Foundation to Visual Studio Team Foundation Server 2010. |
| Visual Studio Express 2012 for Windows 8 | A 64-bit environment such as MSBuild or Team Foundation Build can't be used to build Windows 8.x Store apps that are created in Visual Studio Express 2013 for Windows. |
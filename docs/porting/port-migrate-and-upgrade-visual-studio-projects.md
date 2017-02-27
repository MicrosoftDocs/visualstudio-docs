---
title: "Port, Migrate, and Upgrade Visual Studio Projects | Microsoft Docs"
ms.custom: ""
ms.date: "2/27/2017"
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
author: "kraigb"
ms.author: "kraigb"
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

Support for some types change over time, however. A newer version of Visual Studio may no longer support certain types, or require that they be migrated and updated such that they're no longer backwards-compatible. This topic provides details on each of the affected project, file, and asset types.

Note also that opening certain project types will require adding the appropriate workload through the Visual Studio Installer.

Details on the project types supported in Visual Studio 2017 can be found in the [Platform Targeting and Compatibility](https://www.visualstudio.com/productinfo/vs2017-compatibility-vs) topic.

## Projects

The following list describes support in Visual Studio 2017 for projects that were created in earlier versions. If you don't see a project or file type listed here that should be, please consult the [Visual Studio 2015 version of this topic](https://msdn.microsoft.com/library/hh266747.aspx) and make a note in the comments below.

| Type of Project | Compatibility |
| --- | --- |
| .NET Core projects (.xproj) | Projects created with Visual Studio 2015 used preview tooling which include a .xproj project file. When you open a .xproj file with Visual Studio 2017, you will be prompted to migrate the file to the .csproj format (a backup of the .xproj file is made). This .csproj format for .NET Core projects is not supported in VS2015 and earlier.  The .xproj format is not supported in Visual Studio 2017 other than for migration to .csproj. |
| ASP.NET Web Application and ASP.NET Core Web Application with Application Insights enabled | For each Visual Studio user, resource information is stored in the registry per user instance. This is used when user don’t have a project opened and wants to search Azure Application Insights data. Visual Studio 2015 uses different registry location than Visual Studio 2017 and does not conflict.<br/><br/>Once a user creates an ASP.NET Web Application or ASP.NET Core Web Application, the resource is stored in the .suo file. The user can open the project in Visual Studio 2015 or 2017 and the resource information will be used for both as long as Visual Studio supports projects and solutions being used across both versions. Users will need to authenticate once on each product. For example, if a project is created with Visual Studio 2015 and opened in Visual Studio 2017, the user will need to authenticate on Visual Studio 2017. |
| C#/Visual Basic Webform or Windows Form | You can open the project in Visual Studio 2017 and Visual Studio 2015. |
| Coded UI test | If you allow Visual Studio to update the project automatically, you can open it in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. |
| F# | If you allow Visual Studio to upgrade a project that was created in Visual Studio 2010 SP1, you can open it in Visual Studio 2013 and Visual Studio 2012. However, you can’t upgrade a Silverlight project that was created in an older version of Visual Studio to Visual Studio 2013. Instead, you must create a Silverlight project in Visual Studio 2013 and then copy your code into it. Silverlight projects that you create in Visual Studio 2013 target Silverlight 5. |
| LightSwitch | LightSwitch is no longer supported in Visual Studio 2017. Projects created with Visual Studio 2012 and earlier opened in Visual Studio 2013 or Visual Studio 2015 will be upgraded and can be opened only in Visual Studio 2013 or Visual Studio 2015 thereafter. |
| Microsoft Azure Tools for Visual Studio | To open these types of projects, first install the [Azure SDK for .NET](http://azure.microsoft.com/en-us/downloads/), then open the project. If necessary, your project will be updated. |
| Model-View-Controller framework (ASP.NET MVC) | Support for MVC versions and Visual Studio:<ul><li>Visual Studio 2010 SP1 supports MVC 2 and MVC 3; MVC 4 support is added through the [ASP.NET 4 MVC 4 for Visual Studio 2010 SP1 download](https://www.microsoft.com/en-us/download/details.aspx?id=30683)</li><li>Visual Studio 2012 supports only MVC 3 and MVC 4</li><li>Visual Studio 2013 supports only MVC 4 and MVC 5</li><li>Visual Studio 2017 and Visual Studio 2015 supports MVC 4 (you can open existing projects but not create new ones) and MVC 5</li></ul><br/><br/>Upgrading MVC versions:<ul><li>For information about how to automatically upgrade from MVC 2 to MCV 3, see [ASP.NET MVC 3 Application Upgrader](http://go.microsoft.com/fwlink/?LinkID=238178).</li><li>For information about how to manually upgrade from MVC 2 to MVC 3, see [Upgrading an ASP.NET MVC 2 Project to ASP.NET MVC 3 Tools Update](http://go.microsoft.com/fwlink/?linkid=238178).</li><li>For information about how to manually upgrade from MVC3 to MVC 4, see [Upgrading an ASP.NET MVC 3 Project to ASP.NET MVC 4](http://www.asp.net/whitepapers/mvc4-release-notes). If your project targets .NET Framework 3.5 SP1, you must retarget it to use .NET Framework 4.</li><li>For information about how to manually upgrade from MVC 4 to MVC 5, see [How to Upgrade an ASP.NET MVC 4 and Web API Project to ASP.NET MVC 5 and Web API 2](https://www.asp.net/mvc/overview/releases/how-to-upgrade-an-aspnet-mvc-4-and-web-api-project-to-aspnet-mvc-5-and-web-api-2)</li></ul> |
| Modeling | If you allow Visual Studio to update the project automatically, you can open it in Visual Studio 2015, Visual Studio 2013, or Visual Studio 2012.<br/><br/>The format of the modeling project has not changed between Visual Studio 2015 and Visual Studio 2017 and the project can be opened and modified in either version. However, there are differences in behavior in Visual Studio 2017:<ul><li>Modeling projects are now referred to as “Dependency Validation” projects in the menus and templates.</li><li>UML diagrams are no longer supported in Visual Studio 2017. UML files are listed in the Solution Explorer as before but will be opened as XML files. Use Visual Studio 2015 to view, create, or edit UML diagrams.</li><li>In Visual Studio 2017, validation of architectural dependencies is no longer performed when the modeling project is built. Instead, validation is carried out as each code project is built. This change does not affect the modeling project, but it does require changes to the code projects being validated. Visual Studio 2017 can automatically make the necessary changes to the code projects ([more information](http://go.microsoft.com/fwlink/?LinkId=827800)).</li></ul> |
| Office 2007 VSTO | If you upgrade the project to target Office 2013 and the .NET Framework 4, you can open this project in Visual Studio 2013, Visual Studio 2012, or Visual Studio 2010 SP1. |
| Office 2010 VSTO | If the project targets the .NET Framework 4, you can open it in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. All other projects require a one-way upgrade. |
| Portable Class Library | If you allow Visual Studio to update the project automatically, you can open it in Visual Studio 2013, Visual Studio 2012, or Visual Studio 2010 SP1.<ul><li>Projects that targeted Silverlight 4 will target Silverlight 5.</li><li>Projects that targeted Windows Phone 7.0 or Windows Phone 7.5 will target Windows Phone 8.</li><li>Projects that targeted Xbox 360 will no longer target Xbox 360.</li></ul> |
| SharePoint 2007 | This project can't be opened in Visual Studio 2013. However, if you manually upgrade the project to SharePoint 2010, you can open it in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. For more information about how to upgrade SharePoint 2007, see [Migrating from SharePoint 2007 to SharePoint 2010 for the IT Pro](http://go.microsoft.com/fwlink/?LinkId=238224), [Migrating a 2007 Workflow to Visual Studio & SharePoint 2010](http://go.microsoft.com/fwlink/?LinkId=238225), and [SharePoint Enterprise Search Migration Tool for SharePoint Server 2010](http://go.microsoft.com/fwlink/?LinkId=238226). |
| SharePoint 2010 | You can open the project in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. |
| Silverlight | Silverlight projects not supported in Visual Studio 2017. To maintain Silverlight applications, continue to use Visual Studio 2015. |
| SQL Server 2008 Express database | You can open the project in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. If you have a database file (.mdf) that was created in an earlier version of SQL Server, you must upgrade it to SQL Server 2012 before you can use it with SQL Server Express LocalDB, but the database is no longer compatible with earlier versions of SQL Server. If you don’t upgrade, you can continue to work with the database in Visual Studio 2013 by installing and using SQL Server 2008 Express on the same computer. For more information, see [Upgrade .mdf files](https://msdn.microsoft.com/en-us/library/hh873188.aspx). |
| SQL Server 2008 R2 Express | If SQL Server 2008 R2 Express is installed on the computers that are running Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1, you can open the project in all three versions. |
| SQL Server Report Project | You can open the project in Visual Studio 2012 and later. For local mode only (that is, when not connected to SQL Server), you won’t get the design-time experience for controls that are associated with the viewer in Visual Studio 2010, but the project will function correctly at runtime. **Caution:** If you add a feature that’s specific to Visual Studio 2013 or later, the report schema is upgraded automatically and you can no longer open the project in Visual Studio 2012. |
| Unit tests | You can use Microsoft Test Manager in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1 to open tests that were created in any of these versions. |
| Visual C++ | You can use Visual Studio 2017 to open solutions and projects that were created in Visual Studio 2015 as-is, but projects that were created in older versions of Visual Studio may require upgrading the project or retargeting to a more recent toolset to build with Visual Studio 2017. For more information, see [How to: Upgrade Visual C++ Projects to Visual Studio 2015](https://msdn.microsoft.com/en-us/library/hh690665.aspx) and [Visual C++ Porting and Upgrading Guide](https://msdn.microsoft.com/en-us/library/dn986839.aspx). |
| Visual Studio 2010 Database (.dbproj) | If you convert the project to a SQL Server Data Tools Database project, you can open it in Visual Studio 2013. However, Visual Studio 2013 doesn’t support the following artifacts:<ul><li>unit tests</li><li>data-generation plans</li><li>data-comparison files</li><li>custom rule extensions for static</li><li>code analysis</li><li>server.sqlsettings</li><li>.sqlcmd files</li><li>custom deployment extensions</li><li>and partial projects (.files)</li></ul><br/>If you install SQL Server Data Tools, you can open the project in Visual Studio 2010 SP1 after the conversion. For more information, see [Microsoft SQL Server Data Tools](https://msdn.microsoft.com/data/tools.aspx). |
| Database Unit Test Projects (.csproj, .vbproj)	| Older Data Unit test projects will be loaded in Visual Studio 2017 but will use the GAC’d version of dependencies. To upgrade the unit test project to use the latest dependencies right click on the project not in Solution Explorer and click Upgrade from context menu. |
| Visual Studio Lab Management | You can use Microsoft Test Manager or Visual Studio 2010 SP1 and later to open environments created in any of these versions. However, for Visual Studio 2010 SP1 the version of Microsoft Test Manager must match the version of Team Foundation Server before you can create environments. |
| Visual Studio Tools for Apache Cordova |This project can be opened in Visual Studio 2017, but it is not backwards compatible. Upon opening a project from Visual Studio 2015, you will be prompted to allow modifications to your project. This upgrades the project to use toolsets instead of a `taco.json` file to manage the versioning of the Cordova library, its platforms and plugins, as well as its node/npm dependencies. See the [migration guide](http://taco.visualstudio.com/docs/vs-taco-2017-migration/) for more information. |
| Visual Studio Macro | This project can't be opened in Visual Studio 2013 because it doesn't support the project type. |
| Visual Studio SDK/VSIX | After you upgrade a Visual Studio SDK project to Visual Studio 2013, it can't be opened in Visual Studio 2012. For more information, see [How to: Migrate Extensibility Projects to Visual Studio 2015](https://msdn.microsoft.com/en-us/library/cc512930.aspx). |
| Windows Communication Foundation, Windows Workflow Foundation | You can open this project in Visual Studio 2017, Visual Studio 2015, Visual Studio 2013, and Visual Studio 2012 |
| Windows Presentation Foundation | You can open this project in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. |
| Windows Store apps | Projects for Windows Store 8.1 and 8.0, and Windows Phone 8.1 and 8.0 are not supported in Visual Studio 2017. To maintain these apps, continue to use Visual Studio 2015. To maintain Windows Phone 7.x projects, use Visual Studio 2012. |
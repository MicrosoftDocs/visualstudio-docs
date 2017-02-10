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

Each new version of Visual Studio generally supports most previous types of projects, files, and other assets. You can work with them as you always have, and provided that you don't depend on newer features, Visual Studio preserves backwards compatibility with previous versions like Visual Studio 2015, Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. (See the [Release Notes](https://www.visualstudio.com/vs/release-notes/) for which features are specific to which versions.)

Support for some types change over time, however. A newer version of Visual Studio may no longer support certain types, or require that they be migrated and updated such that they're no longer backwards compatible. This topic provides details on each of the affected project, file, and asset types.


## Projects

The following list describes support in Visual Studio 2017, Visual Studio 2015, and Visual Studio 2013 for projects that were created in Visual Studio 2012 or Visual Studio 2010 SP1. 

| Type of Project | Compatibility |
| --- | --- |
| Universal Windows Platform apps | To install the tools Universal Windows apps, in Visual Studio setup, select **Custom** or **Modify**, and then select **Universal Windows App Development Tools**.<br/><br/>Universal Windows Platform (UWP) app development for Windows 10 is supported only in Visual Studio 2015 and later on Windows 10 or Windows 8.1. |
| Windows Store apps | Windows Store app development, including Universal apps that target both Windows 8.1 and Windows Phone 8.1, is supported on Windows 8.1 and Windows 10.<br/><br/>Existing Windows 8 projects can continue to be serviced, but new Windows 8 projects cannot be created. Windows 8.1 projects can depend only on certain types of references. For more information, see [Managing references in a project](https://msdn.microsoft.com/en-us/library/ez524kew.aspx).<br/><br/>**Note:**  Windows 8.1 projects that you create by using Visual Studio 2013 and 2015 cannot be opened in Visual Studio 2012 because the latter supports only Windows 8 projects that target Windows 8. |
| .NET Framework 4.5.1 | You can create and use these projects in Visual Studio 2013 and later after you install the appropriate multi-targeting pack. These projects are not supported in Visual Studio 2010 SP1. |
| .NET Framework 4.5 | You can create and open these projects in Visual Studio 2012 and later, but not in Visual Studio 2010 SP1. For more information, see [Migration Guide](https://msdn.microsoft.com/en-us/library/ff657133.aspx) |
| BizTalk | BizTalk server projects are not compatible with Visual Studio 2013 and later. |
| C#/Visual Basic Silverlight 4 Application or Class Library | If you allow Visual Studio to update the project automatically, you can open it in either Visual Studio 2013 or Visual Studio 2012. |
| C#/Visual Basic Webform or Windows Form | You can open the project in Visual Studio 2013 and Visual Studio 2012. |
| Visual Basic 6 and Visual C++ 6 | Visual Studio 2012 and Visual Studio 2013 do not support debugging applications built with Visual Basic 6 or Visual C++ 6; to debug these applications, use earlier versions of Visual Studio. |
| Coded UI test | If you allow Visual Studio to update the project automatically, you can open it in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. |
| F# | If you allow Visual Studio to upgrade a project that was created in Visual Studio 2010 SP1, you can open it in Visual Studio 2013 and Visual Studio 2012. However, you can’t upgrade a Silverlight project that was created in an older version of Visual Studio to Visual Studio 2013. Instead, you must create a Silverlight project in Visual Studio 2013 and then copy your code into it. Silverlight projects that you create in Visual Studio 2013 target Silverlight 5. |
| LightSwitch | If you allow Visual Studio to upgrade the project automatically, you can open it in Visual Studio 2013 only. |
| Local Database Cache | The Local Database Cache template and the **Configure Data Synchronization** dialog box are not included in Visual Studio 2013. You can use Visual Studio 2013 to open and run projects that were created in Visual Studio 2010 if Microsoft Synchronization Services v1.0 is installed, but if you want to update them in Visual Studio 2013, you must make all changes manually in code.<br/><br/>As an alternative, you can continue to use Visual Studio 2010 to maintain and update these projects. For new development, target the new synchronization model that's provided by the Microsoft Sync Framework. For information, see [Microsoft Sync Framework Developer Center](https://msdn.microsoft.com/sync/default) |
| Model-View-Controller framework | Visual Studio 2010 SP1 supports only MVC 2 and MVC 3, Visual Studio 2012 supports only MVC 3 and MVC 4, and Visual Studio 2013 supports only MVC 4.<ul><li>For information about how to automatically upgrade from MVC 2 to MCV 3, see [ASP.NET MVC 3 Application Upgrader](http://go.microsoft.com/fwlink/?LinkID=238178).</li><li>For information about how to manually upgrade from MVC 2 to MVC 3, see [Upgrading an ASP.NET MVC 2 Project to ASP.NET MVC 3 Tools Update](http://go.microsoft.com/fwlink/?linkid=238178).</li><li>For information about how to manually upgrade from MVC3 to MVC 4, see [Upgrading an ASP.NET MVC 3 Project to ASP.NET MVC 4](http://www.asp.net/whitepapers/mvc4-release-notes).</li><li>If your project targets the .NET Framework 3.5 SP1, you must retarget it to use the .NET Framework 4.</li></ul> |
| Modeling | If you allow Visual Studio to update the project automatically, you can open it in Visual Studio 2013, Visual Studio 2012, or Visual Studio 2010 SP1.<br/><br/>When Team Foundation builds a modeling project, it tries to validate the layers in the project. In Visual Studio 2013, Team Foundation Build can't validate the layers for a modeling project that was created in Visual Studio 2010 SP1. However, in Visual Studio 2010 SP1, Team Foundation Build can validate the layers in a modeling project that was created in Visual Studio 2013. |
| MPI/Cluster Debugging | If the same version of the runtime or tools is installed on the computers that are running Visual Studio 2013, Visual Studio 2012, or Visual Studio 2010 SP1, you can open this project in all three versions. |
| MSI setup (.vdproj) | This project can't be opened in Visual Studio 2013 because it doesn't support that project type. We recommend that you use InstallShield Limited Edition for Visual Studio (ISLE), a free deployment solution that directly supports most Windows platforms and application runtimes. You can also use ISLE to import data and settings from Visual Studio Installer projects. |
| Office 2007 VSTO | If you upgrade the project to target Office 2013 and the .NET Framework 4, you can open this project in Visual Studio 2013, Visual Studio 2012, or Visual Studio 2010 SP1. |
| Office 2010 VSTO | If the project targets the .NET Framework 4, you can open it in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. All other projects require a one-way upgrade. |
| Rich Internet Applications | If you upgrade the project, you can open it in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. |
| SharePoint 2007 | This project can't be opened in Visual Studio 2013. However, if you manually upgrade the project to SharePoint 2010, you can open it in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. For more information about how to upgrade SharePoint 2007, see [Migrating from SharePoint 2007 to SharePoint 2010 for the IT Pro](http://go.microsoft.com/fwlink/?LinkId=238224), [Migrating a 2007 Workflow to Visual Studio & SharePoint 2010](http://go.microsoft.com/fwlink/?LinkId=238225), and [SharePoint Enterprise Search Migration Tool for SharePoint Server 2010](http://go.microsoft.com/fwlink/?LinkId=238226). |
| SharePoint 2010 | You can open the project in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. |
| SketchFlow | If you allow Visual Studio to upgrade the project to WPF 4.5/Silverlight 5, you can open it in Visual Studio 2012 and Visual Studio 2013. |
| SQL Server 2008 Express database | You can open the project in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. If you have a database file (.mdf) that was created in an earlier version of SQL Server, you must upgrade it to SQL Server 2012 before you can use it with SQL Server Express LocalDB, but the database is no longer compatible with earlier versions of SQL Server. If you don’t upgrade, you can continue to work with the database in Visual Studio 2013 by installing and using SQL Server 2008 Express on the same computer. For more information, see [Upgrade .mdf files](https://msdn.microsoft.com/en-us/library/hh873188.aspx). |
| SQL Server 2008 R2 Express | If SQL Server 2008 R2 Express is installed on the computers that are running Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1, you can open the project in all three versions. |
| SQL Server Report Project | You can open the project in Visual Studio 2013 and Visual Studio 2012. For local mode only (that is, when not connected to SQL Server), you won’t get the design-time experience for controls that are associated with the viewer in Visual Studio 2010, but the project will function correctly at runtime. **Caution:** If you add a feature that’s specific to Visual Studio 2013, the report schema is upgraded automatically and you can no longer open the project in Visual Studio 2012. |
| Unit tests | You can use Microsoft Test Manager in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1 to open tests that were created in any of these versions. |
| Visual C++ | You can use Visual Studio 2013 to open a C++ project that was created in Visual Studio 2012 or Visual Studio 2010 SP1. If you want to use the Visual Studio 2013 build environment to build a project that was created in Visual Studio 2012, you must have both versions of Visual Studio installed on the same computer. For more information, see [How to: Upgrade Visual C++ Projects to Visual Studio 2015](https://msdn.microsoft.com/en-us/library/hh690665.aspx) and [Visual C++ Porting and Upgrading Guide](https://msdn.microsoft.com/en-us/library/dn986839.aspx). |
| Visual Studio 2010 web | If you allow Visual Studio to upgrade the project automatically, you can open it in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. |
| Visual Studio 2010 Database (.dbproj) | If you convert the project to a SQL Server Data Tools Database project, you can open it in Visual Studio 2013. However, Visual Studio 2013 doesn’t support the following artifacts:<ul><li>unit tests</li><li>data-generation plans</li><li>data-comparison files</li><li>custom rule extensions for static</li><li>code analysis</li><li>server.sqlsettings</li><li>.sqlcmd files</li><li>custom deployment extensions</li><li>and partial projects (.files)</li></ul><br/>If you install SQL Server Data Tools, you can open the project in Visual Studio 2010 SP1 after the conversion. For more information, see [Microsoft SQL Server Data Tools](https://msdn.microsoft.com/data/tools.aspx). |
| Visual Studio 2010 Visual Database Tools | You can open this project in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. |
| Visual Studio Lab Management | You can use Microsoft Test Manager, Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1 to open environments that were created in any of these versions. However, the version of Microsoft Test Manager must match the version of Team Foundation Server before you can create environments. |
| Visual Studio Macro | This project can't be opened in Visual Studio 2013 because it doesn't support the project type. |
| Visual Studio SDK/VSIX | After you upgrade a Visual Studio SDK project to Visual Studio 2013, it can't be opened in Visual Studio 2012. For more information, see [How to: Migrate Extensibility Projects to Visual Studio 2015](https://msdn.microsoft.com/en-us/library/cc512930.aspx). |
| Microsoft Azure Tools for Visual Studio | If you’re using Microsoft Azure Tools for Visual Studio version 2.1, you can open the project in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. For projects that target earlier versions, if you allow Visual Studio to upgrade the project to version 2.1, you can open it in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. |
| Windows Communication Foundation, Windows Presentation Foundation | You can open this project in Visual Studio 2013, Visual Studio 2012, and Visual Studio 2010 SP1. |
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
---
title: "Prerequisites Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "Microsoft.VisualStudio.Publish.BaseProvider.Dialog.Bootstrapper"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "Prerequisites dialog box"
ms.assetid: 53ac863c-77a0-409b-91e5-7a4bd8b8474e
caps.latest.revision: 79
author: jillre
ms.author: jillfra
manager: jillfra
---
# Prerequisites Dialog Box
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

This dialog box specifies which prerequisite components are installed, how they are installed, and which order the packages are installed.

 To access this dialog box, select a project node in **Solution Explorer**, and then, on the **Project** menu, click **Properties**. When the **Project Designer** appears, click the **Publish** tab. On the **Publish** page, click **Prerequisites**. For Setup projects, on the **Project** menu, click **Properties**. When the **Property Pages** dialog box appears, click **Prerequisites**.

## UIElement List

|Element|Description|
|-------------|-----------------|
|**Create setup program to install prerequisite components**|Includes the prerequisite components in your application's Setup program (Setup.exe) so that they will be installed before your application, in order of dependency. By default, this option is selected. If it is not selected, no Setup.exe is created.|
|**Choose which prerequisites to install**|Specifies whether to install components such as [!INCLUDE[dnprdnshort](../../includes/dnprdnshort-md.md)], Crystal Reports, and so on.<br /><br /> For example, by selecting the check box next to **SQL Server 2005 Express Edition SP2**, you specify that the Setup program verify whether this component is installed on the target computer and install it if it is not already installed.<br /><br /> For detailed information about each prerequisite package, see the Prerequisites Information table later in this topic.|
|**Check Microsoft Update for more redistributable components**|Clicking this link takes you to the [Bootstrapper Packages to Redistribute Components](https://go.microsoft.com/fwlink/?LinkId=208835) website to check for updates.|
|**Download prerequisites from the component vendor's web site**|Specifies that the prerequisite components be installed from the vendor's Web site. This is the default option.|
|**Download prerequisites from the same location as my application**|Specifies that the prerequisite components be installed from the same location as the application. This copies all the prerequisite packages to the publish location. For this option to work, the prerequisite packages must be on the development computer.|
|**Download prerequisites from the following location**|Specifies that the prerequisite components be installed from the location that you select. You can use the **Browse** button to select a location.|

## Prerequisites Information
 The prerequisite components that appear in the **Prerequisites** dialog box might differ from those in the following list. The prerequisite packages listed in the **Prerequisites Dialog Box** are set automatically the first time that you open the dialog box. If you subsequently change the project's target framework, you will have to select the prerequisites manually to match the new target framework.

|Element|Description|
|-------------|-----------------|
|**.NET Framework 3.5 SP1**|This package installs the following:<br /><br /> -   .NET Framework versions 2.0, 3.0, and 3.5.<br />-   Support for all .NET Framework versions on 32-bit (x86) and 64-bit (x64) operating systems.<br />-   Language packs for each .NET Framework version that is installed with the package.<br />-   Service packs for .NET Framework 2.0 and 3.0.<br /><br /> .NET Framework 3.0 is included with Windows Vista, and .NET Framework 3.5 is included with [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)]. .NET Framework 3.5 is required for all Visual Basic and Visual C# projects that are compiled for 32-bit operating systems and for which the target framework is set to **.NET Framework 3.5**, and for Visual Basic and Visual C# projects compiled for 64-bit operating systems. (IA64 is not supported.) Note that Visual Basic and Visual C# projects are compiled for any CPU architecture by default. For more information, see [Visual Studio Multi-Targeting Overview](../../ide/visual-studio-multi-targeting-overview.md), [Redistributing the .NET Framework](https://msdn.microsoft.com/a18d0456-fd89-493e-97f4-756505bfe287), and [Deploying Prerequisites for 64-bit Applications](../../deployment/deploying-prerequisites-for-64-bit-applications.md).<br /><br /> By default, this item is selected.|
|**.NET Framework 3.5 SP1 Client Profile**|The .NET Framework Client Profile is a subset of the full .NET Framework 3.5 SP1 that targets client applications. It provides a streamlined subset of Windows Presentation Foundation (WPF), Windows Forms, Windows Communication Foundation (WCF), and ClickOnce features. This enables rapid deployment scenarios for WPF, Windows Forms, WCF, and console applications that target the .NET Framework Client Profile. For more information, see [.NET Framework Client Profile](https://msdn.microsoft.com/library/f0219919-1f02-4588-8704-327a62fd91f1).|
|**Microsoft .NET Framework 4 (x86 and x64)**|This package installs the .NET Framework 4 for both the x86 and x64 platforms.<br /><br /> For more information, see [Visual Studio Multi-Targeting Overview](../../ide/visual-studio-multi-targeting-overview.md), [Redistributing the .NET Framework](https://msdn.microsoft.com/a18d0456-fd89-493e-97f4-756505bfe287), and [Deploying Prerequisites for 64-bit Applications](../../deployment/deploying-prerequisites-for-64-bit-applications.md).<br /><br /> By default, this item is selected.|
|**Microsoft .NET Framework 4 Client Profile (x86 and x64)**|The .NET Framework 4 Client Profile is a subset of the full .NET Framework 4 that targets client applications. It provides a streamlined subset of Windows Presentation Foundation (WPF), Windows Forms, Windows Communication Foundation (WCF), and ClickOnce features. This enables rapid deployment scenarios for WPF, Windows Forms, and console applications that target the .NET Framework 4 Client Profile. For more information, see [.NET Framework Client Profile](https://msdn.microsoft.com/library/f0219919-1f02-4588-8704-327a62fd91f1).|
|**Microsoft Office 2007 Primary Interop Assemblies**|This package installs the Primary Interop Assemblies for 2007 Microsoft Office products. The primary interop assembly enables managed code to interact with a Microsoft Office application's COM-based object model. For more information, see [Office Primary Interop Assemblies](https://msdn.microsoft.com/library/aa29d12c-185f-4558-a7cd-3d85f924203d).|
|**Microsoft Visual Basic PowerPacks version 10.0**|Power Packs are add-ins, controls, components, and tools to aid you in developing Visual Basic applications. This version contains the [PrintForm](/previous-versions/bb882742(v=vs.140)) component, which enables you to print the contents of a Windows Form, and the Printer Compatibility Library, which enables Visual Basic 6.0 Printer code to run unmodified.|
|**Microsoft Visual F# Runtime for .NET 2.0**|This package installs the Visual F# run-time libraries for the x86 and x64 operating systems, which provide support for functional programming as well as traditional object-oriented and imperative (procedural) programming. This package must be installed if the application or its components is authored in Visual F# and .NET Framework 2.0, .NET Framework 3.0, or .NET Framework 3.5.<br /><br /> For more information, see [F# Language Reference](https://msdn.microsoft.com/library/16b706f8-b5f2-4ff7-b2c1-64df33cd6adf).|
|**Microsoft Visual F# Runtime for .NET 4.0**|This package installs the Visual F# run-time libraries for the x86 and x64 operating systems, which provide support for functional programming as well as traditional object-oriented and imperative (procedural) programming. This package must be installed if the application or its components is authored in Visual F# and .NET Framework 4.<br /><br /> For more information, see [F# Language Reference](https://msdn.microsoft.com/library/16b706f8-b5f2-4ff7-b2c1-64df33cd6adf).|
|**Microsoft Visual Studio 2010 Report Viewer**|This package installs report viewer controls that you can use to add rich data reporting to Windows Forms and ASP.NET applications.|
|**Microsoft Visual Studio 2010 for Office Runtime (x86 and x64)**|The Office developer tools in Visual Studio offers easy-to-use, integrated tools for creating customized business solutions with Microsoft Office. You can create managed, smart client solutions that use Office applications as a user interface. The tools enable developers to create secure solutions that are easy to deploy and maintain.<br /><br /> For more information, see [How to: Publish an Office Solution by Using ClickOnce](https://msdn.microsoft.com/2b6c247e-bc04-4ce4-bb64-c4e79bb3d5b8).|
|**SQL Server 2005 Express Edition SP2 (x86)**|This package installs Microsoft SQL Server 2005 Express Edition SP2, a database application that is based on [!INCLUDE[sqprsqext](../../includes/sqprsqext-md.md)]. SQL Server Express is a replacement for Microsoft SQL Server Desktop Engine (MSDE). SQL Server Express is free and can be redistributed (subject to agreement), and it functions as both a client database and a basic server database. It is the same as SQL Server 2005, except for the following differences:<br /><br /> -   No enterprise features support.<br />-   Limited to one CPU.<br />-   1 gigabyte (GB) memory limit for the buffer pool.<br />-   4 GB maximum size for databases.|
|**SQL Server 2008 Express**|This package installs Microsoft SQL Server 2008 Express, a free edition of Microsoft SQL Server 2008, an ideal database for small web, server or desktop applications. It can be used for free for development and production. A free registration is required for distributing SQL Server 2008 Express with the application.<br /><br /> The behavior of the bootstrapper is the following:<br /><br /> -   If the computer already has SQL Server 2008 Express or later, the computer remains at SQL Server 2008 Express or later.<br />-   If the computer does not have any version of SQL Server 2008 Express or later, the package installs the latest version of SQL Server 2008 Express SP1.<br /><br /> To learn more about SQL Server 2008 Express, visit [http://go.microsoft.com/fwlink/?LinkId=183586](https://go.microsoft.com/fwlink/?LinkId=183586).|
|**Visual C++ 2010 Runtime Libraries (IA64)**|This package installs the Visual C++ run-time libraries for the Itanium architecture, which provide routines for programming for the Microsoft Windows operating system. These routines automate many common programming tasks that are not provided by the C and C++ languages.<br /><br /> For more information, see [C Run-Time Library Reference](https://msdn.microsoft.com/library/a503e11c-8dca-4846-84fb-025a826c32b8).|
|**Visual C++ 2010 Runtime Libraries (x64)**|This package installs the Visual C++ run-time libraries for the x64 operating systems, which provide routines for programming for the Microsoft Windows operating system. These routines automate many common programming tasks that are not provided by the C and C++ languages.<br /><br /> For more information, see [C Run-Time Library Reference](https://msdn.microsoft.com/library/a503e11c-8dca-4846-84fb-025a826c32b8).|
|**Visual C++ 2010 Runtime Libraries (x86)**|This package installs the Visual C++ run-time libraries for the x86 operating systems, which provide routines for programming for the Microsoft Windows operating system. These routines automate many common programming tasks that are not provided by the C and C++ languages.<br /><br /> For more information, see [C Run-Time Library Reference](https://msdn.microsoft.com/library/a503e11c-8dca-4846-84fb-025a826c32b8).|
|**Windows Installer 3.1**|This package installs the Microsoft Windows Installer redistributable, version 3.1, which allows the installation of Windows Installer Setup projects. It is preinstalled on Windows Server 2003 with SP1 and later.<br /><br /> By default, this item is selected.|
|**Windows Installer 4.5**|This package installs the Microsoft Windows Installer redistributable, version 4.5, which allows the installation of Windows Installer Setup projects.|

## See Also
 [Publish Page, Project Designer](../../ide/reference/publish-page-project-designer.md)
 [Application Deployment Prerequisites](../../deployment/application-deployment-prerequisites.md)
 [Redistributing the .NET Framework](https://msdn.microsoft.com/a18d0456-fd89-493e-97f4-756505bfe287)
 [Deploying Prerequisites for 64-bit Applications](../../deployment/deploying-prerequisites-for-64-bit-applications.md)
 [Visual Studio Multi-Targeting Overview](../../ide/visual-studio-multi-targeting-overview.md)

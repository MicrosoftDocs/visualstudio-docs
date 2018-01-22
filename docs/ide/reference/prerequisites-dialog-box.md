---
title: "Prerequisites Dialog Box | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2018"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "Microsoft.VisualStudio.Publish.BaseProvider.Dialog.Bootstrapper"
helpviewer_keywords: 
  - "Prerequisites dialog box"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Prerequisites Dialog Box

This dialog box specifies which prerequisite components are installed, how they are installed, and which order the packages are installed.

To access this dialog box, select a project node in **Solution Explorer**, and then, on the **Project** menu, click **Properties**. When the **Project Designer** appears, click the **Publish** tab. On the **Publish** page, click **Prerequisites**. For Setup projects, on the **Project** menu, click **Properties**. When the **Property Pages** dialog box appears, click **Prerequisites**.

## UIElement List

|Element|Description|
|-------------|-----------------|
|**Create setup program to install prerequisite components**|Includes the prerequisite components in your application's Setup program (Setup.exe) so that they will be installed before your application, in order of dependency. By default, this option is selected. If it is not selected, no Setup.exe is created.|
|**Choose which prerequisites to install**|Specifies whether to install components such as [!INCLUDE[dnprdnshort](../../code-quality/includes/dnprdnshort_md.md)], Crystal Reports, and so on.<br /><br /> For example, by selecting the check box next to **SQL Server 2005 Express Edition SP2**, you specify that the Setup program verify whether this component is installed on the target computer and install it if it is not already installed.<br /><br /> For detailed information about each prerequisite package, see the Prerequisites Information table later in this topic.|
|**Check Microsoft Update for more redistributable components**|Clicking this link takes you to the [Bootstrapper Packages to Redistribute Components](http://go.microsoft.com/fwlink/?LinkId=208835) website to check for updates.|
|**Download prerequisites from the component vendor's web site**|Specifies that the prerequisite components be installed from the vendor's Web site. This is the default option.|
|**Download prerequisites from the same location as my application**|Specifies that the prerequisite components be installed from the same location as the application. This copies all the prerequisite packages to the publish location. For this option to work, the prerequisite packages must be on the development computer.|
|**Download prerequisites from the following location**|Specifies that the prerequisite components be installed from the location that you select. You can use the **Browse** button to select a location.|

## Prerequisites Information

The prerequisite components that appear in the **Prerequisites** dialog box might differ from those in the following list. The prerequisite packages listed in the **Prerequisites Dialog Box** are set automatically the first time that you open the dialog box. If you subsequently change the project's target framework, you will have to select the prerequisites manually to match the new target framework.

|Element|Description|
|-------------|-----------------|
|**.NET Framework 3.5 SP1**|This package installs the following:<br /><br /> -   .NET Framework versions 2.0, 3.0, and 3.5.<br />-   Support for all .NET Framework versions on 32-bit (x86) and 64-bit (x64) operating systems.<br />-   Language packs for each .NET Framework version that is installed with the package.<br />-   Service packs for .NET Framework 2.0 and 3.0.<br /><br /> .NET Framework 3.0 is included with Windows Vista, and .NET Framework 3.5 is included with [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)]. .NET Framework 3.5 is required for all Visual Basic and Visual C# projects that are compiled for 32-bit operating systems and for which the target framework is set to **.NET Framework 3.5**, and for Visual Basic and Visual C# projects compiled for 64-bit operating systems. (IA64 is not supported.) Note that Visual Basic and Visual C# projects are compiled for any CPU architecture by default. For more information, see [Visual Studio Multi-Targeting Overview](../../ide/visual-studio-multi-targeting-overview.md), [Redistributing the .NET Framework](http://msdn.microsoft.com/en-us/a18d0456-fd89-493e-97f4-756505bfe287), and [Deploying Prerequisites for 64-bit Applications](../../deployment/deploying-prerequisites-for-64-bit-applications.md).<br /><br /> By default, this item is selected.|
|**Microsoft .NET Framework 4.x**|This package installs the .NET Framework 4.x for both the x86 and x64 platforms.|
|**Microsoft System CLR Types for SQL Server 2014 (x64 and x86)**|This package installs Microsoft System CLR Types for SQL Server 2014 for either x64 or x86.|
|**SQL Server 2008 R2 Express**|This package installs Microsoft SQL Server 2008 R2 Express, a free edition of Microsoft SQL Server 2008 R2, an ideal database for small web, server or desktop applications. It can be used for free for development and production. A free [registration](http://go.microsoft.com/fwlink/?LinkId=130380) is required for distributing SQL Server 2008 R2 Express with the application.|
|**SQL Server 2012 Express**|This package installs Microsoft SQL Server 2012 Express.|
|**SQL Server 2012 Express LocalDB**|This package installs Microsoft SQL Server 2012 Express LocalDB.|
|**Visual C++ "14" Runtime Libraries (ARM)**|This package installs the Visual C++ run-time libraries for the Itanium architecture, which provide routines for programming for the Microsoft Windows operating system. These routines automate many common programming tasks that are not provided by the C and C++ languages.<br /><br /> For more information, see [C Run-Time Library Reference](/cpp/c-runtime-library/c-run-time-library-reference).|
|**Visual C++ "14" Runtime Libraries (x64)**|This package installs the Visual C++ run-time libraries for the x64 operating systems, which provide routines for programming for the Microsoft Windows operating system. These routines automate many common programming tasks that are not provided by the C and C++ languages.<br /><br /> For more information, see [C Run-Time Library Reference](/cpp/c-runtime-library/c-run-time-library-reference).|
|**Visual C++ "14" Runtime Libraries (x86)**|This package installs the Visual C++ run-time libraries for the x86 operating systems, which provide routines for programming for the Microsoft Windows operating system. These routines automate many common programming tasks that are not provided by the C and C++ languages.<br /><br /> For more information, see [C Run-Time Library Reference](/cpp/c-runtime-library/c-run-time-library-reference).|

## See also

[Publish Page, Project Designer](../../ide/reference/publish-page-project-designer.md)  
[Application Deployment Prerequisites](../../deployment/application-deployment-prerequisites.md)  
[Redistributing the .NET Framework](http://msdn.microsoft.com/en-us/a18d0456-fd89-493e-97f4-756505bfe287)  
[Deploying Prerequisites for 64-bit Applications](../../deployment/deploying-prerequisites-for-64-bit-applications.md)  
[Visual Studio Multi-Targeting Overview](../../ide/visual-studio-multi-targeting-overview.md)

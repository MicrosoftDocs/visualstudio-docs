---
title: "Visual Studio Tools for Office Runtime Installation Scenarios | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Visual Studio Tools for Office runtime, installation scenarios"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Visual Studio Tools for Office Runtime Installation Scenarios
  You can install the Visual Studio 2010 Tools for Office Runtime in three ways:  
  
-   When you install Visual Studio.  
  
-   When you install Microsoft Office.  
  
-   When you install the Visual Studio 2010 Tools for Office Runtime redistributable.  
  
 The runtime components that are installed depend on the configuration of the computer and the installation scenario.  
  
## Runtime Components That Are Installed in Each Installation Scenario  
 The Visual Studio 2010 Tools for Office Runtime has three components: the Office solution loader, the Office extensions for the .NET Framework 3.5, and the Office extensions for the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later. When you install the runtime, the Office solution loader is always installed. The installation of the Office extensions for the .NET Framework depends on the configuration of the computer and the installation scenario. If one of the Office extensions cannot be installed when the runtime is first installed, the runtime will automatically install the missing Office extensions later, when certain requirements are met. This feature of the runtime is called *install on demand*.  
  
 The following table shows which runtime components are installed by default in each runtime installation scenario. More information about each scenario appears later.  
  
|Runtime installation scenario|Office solution loader|Office extensions for the .NET Framework 3.5|Office extensions for the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)]|Office extensions for the [!INCLUDE[net_v45](../vsto/includes/net-v45-md.md)]|  
|-----------------------------------|----------------------------|--------------------------------------------------|---------------------------------------------------------------------------------------|---------------------------------------------------------------------------|  
|With [!INCLUDE[vs_dev12](../vsto/includes/vs-dev12-md.md)] and later|Yes|Yes, if the .NET Framework 3.5 is already installed.|Yes|Yes|  
|With [!INCLUDE[office14_long](../vsto/includes/office14-long-md.md)]|Yes|Yes, if the .NET Framework 3.5 is already installed.|No|No|  
|With Office 2010 Service Pack 1 (SP1) or later|Yes|Yes, if the .NET Framework 3.5 is already installed.|Yes, if the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] is already installed.|No|  
|With the runtime redistributable|Yes|Yes, if the .NET Framework 3.5 is already installed|Yes, if the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] is already installed.|Yes, if the [!INCLUDE[net_v45](../vsto/includes/net-v45-md.md)] is already installed.|  
  
### Installing the Runtime with Visual Studio or the Microsoft Office Developer Tools for Visual Studio  
 When you install the Office developer tools in Visual Studio, the Office extensions for the [!INCLUDE[net_v45](../vsto/includes/net-v45-md.md)] and the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] are always installed on the development computer. The Office extensions for the .NET Framework 3.5 are installed only if the .NET Framework 3.5 is already present on the development computer. If you install the .NET Framework 3.5 after you install [!INCLUDE[vs_dev12](../vsto/includes/vs-dev12-md.md)], the runtime automatically installs the Office extensions for the .NET Framework 3.5 the first time you create an Office project that targets the .NET Framework 3.5.  
  
> [!WARNING]  
>  You cannot create an Office project that targets the .NET Framework 3.5 by using [!INCLUDE[vs_dev12](../vsto/includes/vs-dev12-md.md)] or later.  
  
 For more information about how to install the Office developer tools, see [How to: Configure a Computer to Develop Office Solutions](../vsto/how-to-configure-a-computer-to-develop-office-solutions.md).  
  
### Installing the Runtime with Office  
 When you install Office, the Office extensions for the .NET Framework 3.5 are installed if the .NET Framework 3.5 is already present on the computer. If you install the .NET Framework 3.5 after Office, the runtime automatically installs the Office extensions for the .NET Framework 3.5 the first time that an Office application tries to load a solution that targets the .NET Framework 3.5.  
  
 The Office extensions for the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later are not installed with Office, even if the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later is already present when you install Office.  
  
 The Office extensions for the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] are installed with Office. End users can obtain the Office extensions for the [!INCLUDE[net_v45](../vsto/includes/net-v45-md.md)] by installing a Windows update.  
  
 To ensure that your users have the necessary extensions to use your application, include the latest version of the Visual Studio 2010 Tools for Office Runtime redistributable as a prerequisite for your solution. For more information about prerequisites, see [Office Solution Prerequisites for Deployment](http://msdn.microsoft.com/en-us/9f672809-43a3-40a1-9057-397ce3b5126e).  
  
### Installing the Runtime by Using the Runtime Redistributable  
 You can install the runtime by running the Visual Studio 2010 Tools for Office Runtime redistributable manually or by including the redistributable as a prerequisite when you deploy an Office solution.  
  
 When you install the runtime by using the Visual Studio 2010 Tools for Office Runtime redistributable, the Office extensions for the .NET Framework 3.5 and the Office extensions for the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later are installed if the corresponding versions of the .NET Framework are already present on the computer. If the computer is missing one of these versions of the .NET Framework when the runtime is installed, the Office extensions for the missing version of the .NET Framework are not installed at that time. If you install the missing version of the .NET Framework later, the runtime automatically installs the corresponding Office extensions the next time a solution that requires the extensions is installed (if the runtime was installed with a solution that was deployed by using ClickOnce) or loaded (if the runtime was installed with a solution that was deployed by using Windows Installer).  
  
 For more information about including prerequisites in a ClickOnce solution, see [How to: Install Prerequisites on End User Computers to Run Office Solutions](http://msdn.microsoft.com/en-us/74dd2c52-838f-4abf-b2b4-4d7b0c2a0a98). For more information about how to install the runtime from the redistributable package manually, see [How to: Install the Visual Studio Tools for Office Runtime Redistributable](../vsto/how-to-install-the-visual-studio-tools-for-office-runtime-redistributable.md).  
  
## See Also  
 [Visual Studio Tools for Office Runtime Overview](../vsto/visual-studio-tools-for-office-runtime-overview.md)   
 [Assemblies in the Visual Studio Tools for Office Runtime](../vsto/assemblies-in-the-visual-studio-tools-for-office-runtime.md)  
  
  
---
title: "Migrating Office Solutions to the .NET Framework 4 or later | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VST.Project.TargetFrameworkWarning"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Office projects [Office development in Visual Studio], migrating to .NET Framework 4"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Migrating Office Solutions to the .NET Framework 4 or later
  If the target framework of an Office project is changed to the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later from an earlier version of the .NET Framework, some additional steps might be required to continue to run the solution on development and end user computers. For more information, see [Required Changes to Run Office Projects that You Migrate to the .NET Framework 4 or the .NET Framework 4.5](../vsto/required-changes-to-run-office-projects-that-you-migrate-to-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md).  
  
 In addition, the project might no longer compile. Some features of Office projects have different programming models for different versions of the .NET Framework. When the target framework of an Office project is changed to the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later from an earlier version of the .NET Framework, you must make the following code changes to the project:  
  
-   [Updating Excel and Word Projects that You Migrate to the .NET Framework 4 or the .NET Framework 4.5](../vsto/updating-excel-and-word-projects-that-you-migrate-to-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md)  
  
-   [Updating Ribbon Customizations in Office Projects that You Migrate to the .NET Framework 4 or the .NET Framework 4.5](../vsto/updating-ribbon-customizations-in-office-projects-that-you-migrate-to-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md)  
  
-   [Updating Form Regions in Outlook Projects that You Migrate to the .NET Framework 4 or the .NET Framework 4.5](../vsto/updating-form-regions-in-outlook-projects-that-you-migrate-to-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md)  
  
 The target framework of an Office project changes when you upgrade that project from an earlier version of Visual Studio. For more information, see [Upgrading and Migrating Office Solutions](../vsto/upgrading-and-migrating-office-solutions.md).  
  
 For more information about why some features in Office projects have a different programming model when you target the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, see [Changes to the Design of Office Projects that Target the .NET Framework 4 or the .NET Framework 4.5](../vsto/changes-to-the-design-of-office-projects-that-target-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md) and [Visual Studio Tools for Office Runtime Overview](../vsto/visual-studio-tools-for-office-runtime-overview.md).  
  
## See Also  
 [Designing and Creating Office Solutions](../vsto/designing-and-creating-office-solutions.md)   
 [How to: Target a Version of the .NET Framework](../ide/how-to-target-a-version-of-the-dotnet-framework.md)   
 [Troubleshooting Errors in Office Solutions](../vsto/troubleshooting-errors-in-office-solutions.md)   
 [Additional Support for Errors in Office Solutions](../vsto/additional-support-for-errors-in-office-solutions.md)  
  
  
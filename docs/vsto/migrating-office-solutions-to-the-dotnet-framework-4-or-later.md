---
title: "Migrate Office solutions to the .NET Framework 4 or later"
description: Learn how you can migrate Office solutions to the .NET Framework 4 or later so your project will continue to work.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: upgrade-and-migration-article
f1_keywords:
  - "VST.Project.TargetFrameworkWarning"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office projects [Office development in Visual Studio], migrating to .NET Framework 4"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Migrate Office solutions to the .NET Framework 4 or later

  If the target framework of an Office project is changed to the .NET Framework 4 or later from an earlier version of the .NET Framework, some additional steps might be required to continue to run the solution on development and end-user computers. For more information, see [Required changes to run Office projects that you migrate to the .NET Framework 4 or the .NET Framework 4.5](../vsto/required-changes-to-run-office-projects-that-you-migrate-to-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md).

 In addition, the project might no longer compile. Some features of Office projects have different programming models for different versions of the .NET Framework. When the target framework of an Office project is changed to the .NET Framework 4 or later from an earlier version of the .NET Framework, you must make the following code changes to the project:

- [Update Excel and Word projects that you migrate to the .NET Framework 4 or the .NET Framework 4.5](../vsto/updating-excel-and-word-projects-that-you-migrate-to-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md)

- [Update Ribbon customizations in Office projects that you migrate to the .NET Framework 4 or the .NET Framework 4.5](update-ribbon-customizations-in-office-projects-to-migrate-to-dotnet-framework-4-or-4-5.md)

- [Update form regions in Outlook projects that you migrate to the .NET Framework 4 or the .NET Framework 4.5](../vsto/updating-form-regions-in-outlook-projects-that-you-migrate-to-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md)

  The target framework of an Office project changes when you upgrade that project from an earlier version of Visual Studio. For more information, see [Upgrade and migrate Office solutions](../vsto/upgrading-and-migrating-office-solutions.md).

  For more information about why some features in Office projects have a different programming model when you target the .NET Framework 4 or later, see [Changes to the design of Office projects that target the .NET Framework 4 or the .NET Framework 4.5](../vsto/changes-to-the-design-of-office-projects-that-target-the-dotnet-framework-4-or-the-dotnet-framework-4-5.md) and [Visual Studio Tools for Office runtime overview](../vsto/visual-studio-tools-for-office-runtime-overview.md).

## Related content
- [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md)
- [How to: Target a version of the .NET Framework](../ide/visual-studio-multi-targeting-overview.md)
- [Troubleshoot errors in Office solutions](../vsto/troubleshooting-errors-in-office-solutions.md)
- [Additional support for errors in Office solutions](../vsto/additional-support-for-errors-in-office-solutions.md)

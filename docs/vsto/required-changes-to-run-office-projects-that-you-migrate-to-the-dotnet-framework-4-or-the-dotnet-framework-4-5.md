---
title: "Changes required for Office projects migrated to .NET 4.5"
description: Learn the changes you need to make to your project if the target framework changes to the .NET Framework 4 or later from an earlier version of the .NET Framework.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office projects [Office development in Visual Studio], migrating to .NET Framework 4"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# Changes required for Office projects migrated to .NET 4.5

  If the target framework of an Office project is changed to the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later from an earlier version of the .NET Framework, you must perform the following tasks to ensure that the solution can run on the development computer and on end-user computers:

- Remove the <xref:System.Security.SecurityTransparentAttribute> from the project if you upgraded it from Visual Studio 2008.

- Perform a **Clean** command in Visual Studio to be able to run or debug the project on the development computer.

- Update the .NET Framework prerequisite for the project.

- End users must also reinstall the solution if you previously deployed it by using ClickOnce before you changed the target framework.

  For more information about each of these tasks, see the corresponding sections below.

## Remove the SecurityTransparent attribute from projects that you upgrade from Visual Studio 2008
 If you upgrade an Office project from Visual Studio 2008 and the target framework of the project subsequently changes to the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, you must remove the <xref:System.Security.SecurityTransparentAttribute> from the project. Visual Studio does not automatically remove this attribute for you. If you do not remove this attribute, you receive an error message when you compile the project.

 For more information about the conditions in which Visual Studio can change the target framework of an upgraded project to the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or the [!INCLUDE[net_v45](../vsto/includes/net-v45-md.md)], see [Upgrade and migrate Office solutions](../vsto/upgrading-and-migrating-office-solutions.md).

#### To remove the SecurityTransparentAttribute

1. With the project open in Visual Studio, open **Solution Explorer**.

2. Under the **Properties** node (for C#) or the **My Project** node (for Visual Basic), double-click the AssemblyInfo code file to open it in the code editor.

    > [!NOTE]
    > In Visual Basic projects, you must click the **Show All Files** button in **Solution Explorer** to see the AssemblyInfo code file.

3. Locate the <xref:System.Security.SecurityTransparentAttribute> and either remove it from the file or comment it out.

    ```vb
    <Assembly: SecurityTransparent()>
    ```

    ```csharp
    [assembly: SecurityTransparent()]
    ```

## Perform the clean command to debug or run a project on the development computer
 If an Office project was built before the target framework of the project is changed to the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, you must perform a **Clean** command and then rebuild the project after the target framework is changed. If do not perform a **Clean** command, you will receive a <xref:System.Runtime.InteropServices.COMException> when you try to debug or run the retargeted project.

 For more information about the **Clean** command, see [Build Office solutions](../vsto/building-office-solutions.md).

## Update the prerequisites for deployment
 When you retarget an Office project to [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, you must also update the corresponding .NET Framework prerequisite in the **Prerequisites** dialog box. Otherwise, the ClickOnce deployment or InstallShield Limited Edition project checks for and installs a previous version of the .NET Framework.

 For more information about updating the prerequisites for deployment to end-user computers, see [How to: Install prerequisites on end user computers to run Office solutions](/previous-versions/bb608608(v=vs.110)).

## Reinstall solutions on end-user computers
 If you use ClickOnce to deploy an Office solution that targets the .NET Framework 3.5 and then you retarget the project to the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, end users must uninstall the solution and then reinstall the solution after you republish it. If you republish the retargeted solution and the solution is updated on end-user computers, end users will receive a <xref:System.Runtime.InteropServices.COMException> when they run the updated solution.

## See also
- [Migrate Office solutions to the .NET Framework 4 or later](../vsto/migrating-office-solutions-to-the-dotnet-framework-4-or-later.md)
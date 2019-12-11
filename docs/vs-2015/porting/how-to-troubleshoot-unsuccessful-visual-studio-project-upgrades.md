---
title: "How to: Troubleshoot Unsuccessful Project Upgrades | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: troubleshooting
f1_keywords:
  - "VisualStudio.SourceControl.CannotOpenFromSourceControlDSW"
  - "vs.UpgradeProjectSolution.8.0"
helpviewer_keywords:
  - "upgrading applications, Visual Studio"
  - "upgrading projects [Visual Studio]"
  - "projects [Visual Studio], upgrading"
  - "Visual Studio Conversion Wizard"
  - "Conversion wizard"
ms.assetid: 842fe448-c044-4343-8eae-d81711cf48ba
caps.latest.revision: 31
author: "kraigb"
ms.author: "kraigb"
manager: jillfra
---
# How to: Troubleshoot Unsuccessful Visual Studio Project Upgrades
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Sometimes Visual Studio cannot fully convert a project from an earlier version of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. If the tips in the following sections do not resolve your specific problem, you might be able to find more information on the TechNet [Wiki: Development Portal](https://go.microsoft.com/fwlink/?LinkId=254808).

## The Project Does Not Run Because Files Are Not Found
 A project file contains hard-coded file paths that [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] uses to run the project when you press F5. These paths may include the location of devenv.exe and other required files. In an upgraded version of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], the paths of these files may have been changed.

#### To resolve incorrect file paths

1. Open your project file in a text editor.

2. Scan for file paths that may be incorrect, especially those that contain a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] version number.

3. Modify incorrect file paths so that they point to the new targets.

## The Project Does Not Build Because References Are Not Valid
 When you upgrade [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], you might also be upgrading the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] version. If your project contains references that are discontinued in the newer [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] version, they may not resolve correctly. This is especially likely for references that include version numbers, for example, `Microsoft.VisualStudio.Shell.Interop.8.0`.

 If your code has many invalid references, the easiest solution may be to use the multi-targeting feature of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] to target an earlier version of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)].

#### To resolve incorrect references

1. Open your project file in a text editor.

2. Open the project properties.

3. Select the correct **Target Framework** value. Alternatively, you can modify the value of the `<TargetFrameworkVersion>` element directly in the project file.

   If you want your project to run in the upgraded [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] version, you must update the references for the project, and also update any `Imports` or `Using` statements that call the references. If your project loads in the IDE, you can update the references by using **Solution Explorer** or the **Reference Manager** dialog box.

## See Also
 [/Upgrade (devenv.exe)](../ide/reference/upgrade-devenv-exe.md)
 [Converting to ASP.NET 4](https://msdn.microsoft.com/library/790147c6-36c1-41b5-a52d-30b9ccd2bd10)

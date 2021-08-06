---
title: "Building and Debugging SharePoint Solutions | Microsoft Docs"
description: Learn to build and debug SharePoint solutions, and understand how it's different from building and debugging other types of projects in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: overview
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, building and debugging"
  - "SharePoint development in Visual Studio, debugging"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# Build and debug SharePoint solutions
  In general, building and debugging SharePoint solutions is the same as building and debugging other types of projects in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. The topics in this section explain the differences that do exist.

## Project output for SharePoint solutions
 Building SharePoint solutions creates assemblies and a solution package (*.wsp*) file. The following table shows the locations of these files during a build.

|Build item|Output folder|
|----------------|-------------------|
|Assembly, program database (*.pdb*), and *.wsp* files.|*\<ProjectName>\bin\debug* or *\<ProjectName>\bin\release*|
|SharePoint project item files.|*\<ProjectName>\pkg\debug* or *\<ProjectName>\pkg\release*|
|Build intermediate files.|*\<ProjectName>\obj\debug* or *\<ProjectName>\obj\release*|
|Package intermediate files.|*\<ProjectName>\pkgobj\debug* or *\<ProjectName>\pkgobj\release*|

## Build SharePoint solutions
 To build SharePoint solutions, the development computer must have the correct version of SharePoint server installed. Otherwise, building SharePoint solutions is the same as building other types of projects in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. For more information, see [How to: Build SharePoint solutions](../sharepoint/how-to-build-sharepoint-solutions.md).

## Debug and test SharePoint solutions
 Before debugging, [!include[vsprvs](../sharepoint/includes/vsprvs-md.md)] copies the *.wsp* package to the SharePoint server, activates the Site and Web-scoped Features, and in some cases, starts the project. In other cases, you may have to open the project manually. For more information, see [Troubleshoot SharePoint solutions](../sharepoint/troubleshooting-sharepoint-solutions.md) and [Debug SharePoint solutions](../sharepoint/debugging-sharepoint-solutions.md).

## Debug and verify SharePoint solutions by using Azure DevOps Services features
 Azure DevOps Services features such as unit testing and IntelliTrace enable you to more accurately pinpoint problems in your SharePoint solutions. Profiling enables you to locate and identify performance problem areas in your SharePoint solutions. For more information, see [Verifying and Debugging SharePoint Code](../sharepoint/verifying-and-debugging-sharepoint-code.md) and [Profiling the Performance of SharePoint Applications](../sharepoint/profiling-the-performance-of-sharepoint-applications.md).

## Security during the build process
 To package or deploy SharePoint solutions, [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] must have permission to copy files to the SharePoint server. You must run [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] as an elevated process, and your user account must be a Site Collections Administrator on the SharePoint server. In addition, you must specify whether your project is a sandboxed solution or a farm solution. For more information, see [Differences Between Sandboxed and Farm Solutions](../sharepoint/differences-between-sandboxed-and-farm-solutions.md).

## Using the Clean command
 When a SharePoint solution is installed on a SharePoint server for debugging, the **Clean** command does not uninstall the solution. Instead, you must deactivate the Features through the SharePoint configuration.

## See also
- [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md)
- [Browse SharePoint connections using Server Explorer](../sharepoint/browsing-sharepoint-connections-using-server-explorer.md)
- [Package and deploy SharePoint solutions](../sharepoint/packaging-and-deploying-sharepoint-solutions.md)

---
title: "Building and Debugging SharePoint Solutions | Microsoft Docs"
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
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, building and debugging"
  - "SharePoint development in Visual Studio, debugging"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Building and Debugging SharePoint Solutions
  In general, building and debugging SharePoint solutions is the same as building and debugging other types of projects in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. The topics in this section explain the differences that do exist.  
  
## Project Output for SharePoint Solutions  
 Building SharePoint solutions creates assemblies and a solution package (.wsp) file. The following table shows the locations of these files during a build.  
  
|Build item|Output folder|  
|----------------|-------------------|  
|Assembly, program database (PDB), and .wsp files.|*ProjectName*\bin\debug or *ProjectName*\bin\release|  
|SharePoint project item files.|*ProjectName*\pkg\debug or *ProjectName*\pkg\release|  
|Build intermediate files.|*ProjectName*\obj\debug or *ProjectName*\obj\release|  
|Package intermediate files.|*ProjectName*\pkgobj\debug or *ProjectName*\pkgobj\release|  
  
## Building SharePoint Solutions  
 To build SharePoint solutions, the development computer must have the correct version of SharePoint server installed. Otherwise, building SharePoint solutions is the same as building other types of projects in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. For more information, see [How to: Build SharePoint Solutions](../sharepoint/how-to-build-sharepoint-solutions.md).  
  
## Debugging and Testing SharePoint Solutions  
 Before debugging, [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] copies the .wsp package to the SharePoint server, activates the Site and Web-scoped Features, and in some cases, starts the project. In other cases, you may have to open the project manually. For more information, see [Troubleshooting SharePoint Solutions](../sharepoint/troubleshooting-sharepoint-solutions.md) and [Debugging SharePoint Solutions](../sharepoint/debugging-sharepoint-solutions.md).  
  
## Debugging and Verifying SharePoint Solutions by Using ALM Features  
 Visual Studio ALM features such as unit testing and IntelliTrace enable you to more accurately pinpoint problems in your SharePoint solutions. Profiling enables you to locate and identify performance problem areas in your SharePoint solutions. For more information, see [Verifying and Debugging SharePoint Code](../sharepoint/verifying-and-debugging-sharepoint-code.md) and [Profiling the Performance of SharePoint Applications](../sharepoint/profiling-the-performance-of-sharepoint-applications.md).  
  
## Security During the Build Process  
 To package or deploy SharePoint solutions, [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] must have permission to copy files to the SharePoint server. You must run [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] as an elevated process, and your user account must be a Site Collections Administrator on the SharePoint server. In addition, you must specify whether your project is a sandboxed solution or a farm solution. For more information, see [Differences Between Sandboxed and Farm Solutions](../sharepoint/differences-between-sandboxed-and-farm-solutions.md).  
  
## Using the Clean Command  
 When a SharePoint solution is installed on a SharePoint server for debugging, the **Clean** command does not uninstall the solution. Instead, you must deactivate the Features through the SharePoint configuration.  
  
## See Also  
 [Developing SharePoint Solutions](../sharepoint/developing-sharepoint-solutions.md)   
 [Browsing SharePoint Connections Using Server Explorer](../sharepoint/browsing-sharepoint-connections-using-server-explorer.md)   
 [Packaging and Deploying SharePoint Solutions](../sharepoint/packaging-and-deploying-sharepoint-solutions.md)  
  
  
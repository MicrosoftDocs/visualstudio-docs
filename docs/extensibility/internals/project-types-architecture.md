---
title: "Project Types Architecture | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "projects [Visual Studio SDK], architecture"
ms.assetid: 9c1d940f-8a54-41f7-a8aa-c870e324371c
caps.latest.revision: 6
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Project Types Architecture
This section contains detailed information about the architecture of project types in [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)].  
  
## In This Section  
 [Elements of a Project Model](../../extensibility/internals/elements-of-a-project-model.md)  
 Lists the services a project type can consume and the interfaces it must implement.  
  
 [Project Model Core Components](../../extensibility/internals/project-model-core-components.md)  
 Describes the interfaces project types both must implement and optionally can implement to provide additional functionality.  
  
 [When to Create Project Types](../../extensibility/internals/when-to-create-project-types.md)  
 Helps you decide when you must create a project type and when you can use another [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] extensibility feature such as VSPackages and editors to achieve the same goal.  
  
 [Hierarchies and Selection](../../extensibility/internals/hierarchies-and-selection.md)  
 Describes how [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] uses hierarchies and selection context to provide a consistent and simplified user experience.  
  
## Related Sections  
 [Project Subtypes](../../extensibility/internals/project-subtypes.md)  
 Explains how project subtypes let you customize the behavior of the project systems of [!INCLUDE[vbprvb](../../code-quality/includes/vbprvb_md.md)] and [!INCLUDE[vcprvc](../../code-quality/includes/vcprvc_md.md)].  
  
 [Project Types](../../extensibility/internals/project-types.md)  
 Provides an overview of projects as the basic building blocks of the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] integrated development environment (IDE). Links are provided to additional topics that explain how projects control building and compiling code.
---
title: "Getting Started with Source Control Plug-ins | Microsoft Docs"
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
  - "source control plug-ins, getting started"
  - "getting started, source control plug-ins"
ms.assetid: 46ac1f9f-4ecc-4a72-88d3-4c7e1647e1cb
caps.latest.revision: 21
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
# Getting Started with Source Control Plug-ins
To create a source control plug-in, you must create a DLL that implements the functions defined in the Source Control Plug-in API, and then to register the DLL with [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] to make it available for use in source code version control.  
  
 Three versions of the Source Control Plug-in API (versions 1.1, 1.2, and 1.3) are available for source control plug-ins. The Source Control Plug-in API documented here is version 1.3. It was designed to be fully compatible with source control plug-ins supporting versions 1.1 and 1.2. The [What's New in the Source Control Plug-in API Version 1.3](../../extensibility/internals/what-s-new-in-the-source-control-plug-in-api-version-1-3.md) section details the new features supported in the latest version of the Source Control Plug-in API.  
  
## In This Section  
 [How to: Install a Source Control Plug-in](../../extensibility/internals/how-to-install-a-source-control-plug-in.md)  
 Describes how to make the registry entries that are required to plug in a source control DLL.  
  
 [What's New in the Source Control Plug-in API Version 1.3](../../extensibility/internals/what-s-new-in-the-source-control-plug-in-api-version-1-3.md)  
 Provides a brief overview of the changes that were made to the Source Control Plug-in API in version 1.3.  
  
 [What's New in the Source Control Plug-in API Version 1.2](../../extensibility/internals/what-s-new-in-the-source-control-plug-in-api-version-1-2.md)  
 Provides a brief overview of the changes that were made to the Source Control Plug-in API in version 1.2.  
  
## Related Sections  
 [Source Control Plug-ins](../../extensibility/source-control-plug-ins.md)  
 Provides a complete listing of all the elements in the Source Control Plug-in API.  
  
 [Creating a Source Control Plug-in](../../extensibility/internals/creating-a-source-control-plug-in.md)  
 Defines the Source Control Plug-in SDK and describes the included resources.
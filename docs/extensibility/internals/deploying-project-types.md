---
title: "Deploying Project Types | Microsoft Docs"
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
  - "projects [Visual Studio SDK], managed-code"
  - "projects [Visual Studio SDK], aggregator"
ms.assetid: 7f132f67-8589-464c-90dc-0d57ae02aa8f
caps.latest.revision: 12
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
# Deploying Project Types
[!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)] installs a new project-type aggregator (ProjectAggregator2.dll) and also a Windows Installer package for redistribution (ProjectAggregator2.msi). You must use the new aggregator for managed-code project types. ProjectAggregator2 works arounds limitations in the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] project aggregator that prevent managed-code project types from working correctly. The following steps describe how to change your VSPackage to use the new aggregator.  
  
1.  Remove the NativeHierarchyWrapper project from your solution.  
  
2.  Remove any NativeHierarchyWrapper binaries from your setup.  
  
3.  Add ProjectAggregator2.msi to your setup.
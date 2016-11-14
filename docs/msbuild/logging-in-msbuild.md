---
title: "Logging in MSBuild | Microsoft Docs"
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
  - "msbuild, logging"
ms.assetid: 9aea2e76-8f60-4234-913d-598e7bbad808
caps.latest.revision: 11
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Logging in MSBuild
Logging provides a way for you to monitor the progress of a build. Logging captures build events, messages, warnings, and errors in a log file.  
  
## In This Section  
 [Obtaining Build Logs](../msbuild/obtaining-build-logs-with-msbuild.md)  
 Describes the various aspects of logging in [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)].  
  
 [Build Loggers](../msbuild/build-loggers.md)  
 Outlines the steps required to create a single-processor logger.  
  
 [Logging in a Multi-Processor Environment](../msbuild/logging-in-a-multi-processor-environment.md)  
 Describes how logging works in a multi-processor environment and the two multi-processor logging models.  
  
 [Writing Multi-Processor-Aware Loggers](../msbuild/writing-multi-processor-aware-loggers.md)  
 Outlines how to create multi-processor-aware loggers and how to use the ConfigurableForwardingLogger.  
  
 [Creating Forwarding Loggers](../msbuild/creating-forwarding-loggers.md)  
 Outlines how to create custom forwarding loggers.  
  
## Related Sections  
 [Building Multiple Projects in Parallel](../msbuild/building-multiple-projects-in-parallel-with-msbuild.md)  
 Describes how to build multiple projects faster by running them in parallel.